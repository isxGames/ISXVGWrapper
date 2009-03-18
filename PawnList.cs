using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using LavishVMAPI;

namespace Vanguard.ISXVG
{
    /// <summary>
    /// This exception is only thrown if there is an error in syntax during a PawnList search.
    /// </summary>
    [Serializable]
    public class PawnListSyntaxException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PawnListSyntaxException"/> class.
        /// </summary>
        internal PawnListSyntaxException() {}

        /// <summary>
        /// Initializes a new instance of the <see cref="PawnListSyntaxException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        internal PawnListSyntaxException(string message) : base(message) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="PawnListSyntaxException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="argument">The argument.</param>
        internal PawnListSyntaxException(string message, string argument)
            : base(message)
        {
            Argument = argument;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PawnListSyntaxException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="inner">The inner.</param>
        internal PawnListSyntaxException(string message, Exception inner) : base(message, inner) {}

        protected PawnListSyntaxException(
            SerializationInfo info,
            StreamingContext context) : base(info, context) {}

        /// <summary>
        /// The argument that caused the syntax exception.
        /// </summary>
        /// <value>The argument.</value>
        public string Argument { get; private set; }
    }

    /// <summary>
    /// An enumerable list of Pawns. This is created to give you the ability to create a collection of Pawns, from
    /// a set of search strings. See the remarks for valid search strings.
    /// </summary>
    public sealed class PawnList : IEnumerable<Pawn>
    {
        private readonly List<Pawn> _lst;

        /// <summary>
        /// Initializes a new instance of the <see cref="PawnList"/> class.
        /// </summary>
        /// <param name="search">The search params.</param>
        public PawnList(params string[] search) : this(false, search) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="PawnList"/> class.
        /// </summary>
        /// <param name="throwSyntaxErrors">if set to <c>true</c> [throw syntax errors].</param>
        /// <param name="search">The search.</param>
        public PawnList(bool throwSyntaxErrors, params string[] search)
        {
            // We want it all done in a single frame. This may hurt FPS.
            // Make sure the user is aware!
            using (new FrameLock(true))
            {
                // Set our search args. And parse everything.
                SearchArguments = new PawnSearchArgs(throwSyntaxErrors, search);
                _lst = new List<Pawn>();
                // This is our main 'search' function.
                RefreshList();
            }
        }

        /// <summary>
        /// Gets the search arguments of this <see cref="PawnList"/>.
        /// </summary>
        /// <value>The search arguments.</value>
        public PawnSearchArgs SearchArguments { get; private set; }

        /// <summary>
        /// Gets the count of this <see cref="PawnList"/>.
        /// </summary>
        /// <value>The count.</value>
        public int Count { get { return _lst.Count; } }

        /// <summary>
        /// Gets the <see cref="Vanguard.ISXVG.Pawn"/> at the specified index.
        /// </summary>
        /// <value></value>
        public Pawn this[int index] { get { return _lst[index]; } }

        #region IEnumerable<Pawn> Members

        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Collections.Generic.IEnumerator`1" /> that can be used to iterate through the collection.
        /// </returns>
        /// <filterpriority>1</filterpriority>
        public IEnumerator<Pawn> GetEnumerator()
        {
            return _lst.GetEnumerator();
        }

        /// <summary>
        /// Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>
        /// An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate through the collection.
        /// </returns>
        /// <filterpriority>2</filterpriority>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion

        /// <summary>
        /// Creates a new PawnList based on the search parameters.
        /// </summary>
        /// <param name="search">The search params.</param>
        /// <returns></returns>
        public static PawnList Search(params string[] search)
        {
            return Search(false, search);
        }

        /// <summary>
        /// Creates a new PawnList based on the search parameters.
        /// </summary>
        /// <param name="throwSyntaxExceptions">if set to <c>true</c> [throw syntax exceptions].</param>
        /// <param name="search">The search.</param>
        /// <returns></returns>
        public static PawnList Search(bool throwSyntaxExceptions, params string[] search)
        {
            return new PawnList(throwSyntaxExceptions, search);
        }

        /// <summary>
        /// Refreshes this <see cref="PawnList"/> based on the <see cref="SearchArguments"/> provided when creating this class.
        /// </summary>
        public void RefreshList()
        {
            // Make sure we run _RefreshList in a framelock. I prefer to split it here, since it makes my life a bit easier
            // in case I want to add more functionality.
            using (new FrameLock(true))
            {
                _RefreshList();
            }
        }

        /// <summary>
        /// Refreshes this <see cref="PawnList"/> based on the <see cref="SearchArguments"/> provided when creating this class.
        /// </summary>
        private void _RefreshList()
        {
            _lst.Clear();

            // Really sad that we need to do this... but oh well...
            int pawnCount = new VG().PawnCount;
            int limit = int.MaxValue; // Laziness.
            // Just to shorten stuff a bit.
            PawnSearchArgs a = SearchArguments;
            // Set our limit ONCE. If limit has no value, it defaults to int.MaxValue.
            // Which pretty much removes the limit :P
            if (a.Limit.HasValue)
            {
                limit = a.Limit.Value;
            }

            float meZ = new Character().Z;

            for (int i = 0; i < pawnCount; i++)
            {
                // We hit the 'limit'. So just stop even going through stuff!
                if (_lst.Count >= limit)
                {
                    break;
                }
                // Store our pawn so we don't need to get a new one 50-60 times per iteration.
                Pawn p = new Pawn(i);
                PawnType ptype = p.PawnType;

                // And now...... the long.... long... search method. Oh boy!

                if (a.AggroNpc.HasValue)
                {
                    // If we only wnat NPCs that are aggroed, and the current is not. Skip it.
                    if (a.AggroNpc.Value && !p.IsAggro)
                    {
                        continue;
                    }
                    // Opposite of the above.
                    if (!a.AggroNpc.Value && p.IsAggro)
                    {
                        continue;
                    }
                }

                if (a.Attackable.HasValue)
                {
                    if (a.Attackable.Value && !p.IsAttackable)
                    {
                        continue;
                    }
                    if (!a.Attackable.Value && p.IsAttackable)
                    {
                        continue;
                    }
                }

                if (a.Clickable.HasValue)
                {
                    if (a.Clickable.Value && !p.IsClickable)
                    {
                        continue;
                    }
                    if (!a.Clickable.Value && p.IsClickable)
                    {
                        continue;
                    }
                }

                if (a.Corpse.HasValue)
                {
                    if (a.Corpse.Value && ptype != PawnType.Corpse)
                    {
                        continue;
                    }
                    if (!a.Corpse.Value && ptype == PawnType.Corpse)
                    {
                        continue;
                    }
                }

                if (a.CraftingStation.HasValue)
                {
                    if (a.CraftingStation.Value && ptype != PawnType.CraftingStation)
                    {
                        continue;
                    }
                    if (!a.CraftingStation.Value && ptype == PawnType.CraftingStation)
                    {
                        continue;
                    }
                }

                if (a.Distance.HasValue)
                {
                    if (a.Distance.Value > p.Distance)
                    {
                        continue;
                    }
                }

                if (!string.IsNullOrEmpty(a.Name))
                {
                    // If the Name property is set, a simple contains should suffice.
                    // Also, if the Name and ExactName are BOTH set. If this fails,
                    // the exact name check would fail also. So just do the check now.

                    // Note: We're doing this via .ToLower() strings. It's just a contains, so casing should have no input on the matter.
                    if (!p.Name.ToLower().Contains(a.Name.ToLower()))
                    {
                        continue;
                    }
                }

                if (!string.IsNullOrEmpty(a.ExactName))
                {
                    // Literal match.
                    if (a.ExactName != p.Name)
                    {
                        continue;
                    }
                }

                if (a.GroupMember.HasValue)
                {
                    if (a.GroupMember.Value && ptype != PawnType.GroupMember)
                    {
                        continue;
                    }
                    if (!a.GroupMember.Value && ptype == PawnType.GroupMember)
                    {
                        continue;
                    }
                }

                // NotID takes precedence over ID.
                if (a.NotID.HasValue)
                {
                    if (a.NotID.Value == p.ID)
                    {
                        continue;
                    }
                }
                if (a.ID.HasValue)
                {
                    if (a.ID.Value != p.ID)
                    {
                        continue;
                    }
                }

                // If OuterRadius has a value. InnerRadius will have one too.
                // But since only InnerRadius differing from OutRadius changes
                // the search, we'll use that within the a.OuterRadius.HasValue check.
                if (a.OuterRadius.HasValue)
                {
                    float distance = p.Distance;
                    if (a.InnerRadius.Value != a.OuterRadius.Value)
                    {
                        // Means we need to check for a distance 'within'.
                        if (a.InnerRadius.Value <= distance || a.OuterRadius.Value >= distance)
                        {
                            continue;
                        }
                    }
                    else
                    {
                        if (a.OuterRadius.Value > distance)
                        {
                            continue;
                        }
                    }
                }

                // Do both checks.
                if (a.MaxLevel.HasValue || a.MinLevel.HasValue)
                {
                    int lvl = p.Level;
                    if (a.MaxLevel.HasValue)
                    {
                        if (a.MaxLevel <= lvl)
                        {
                            continue;
                        }
                    }
                    if (a.MinLevel.HasValue)
                    {
                        if (a.MinLevel >= lvl)
                        {
                            continue;
                        }
                    }
                }
                if (a.Merchant.HasValue)
                {
                    if (a.Merchant.Value && ptype != PawnType.Merchant)
                    {
                        continue;
                    }
                    if (!a.Merchant.Value && ptype == PawnType.Merchant)
                    {
                        continue;
                    }
                }
                if (a.MyPet.HasValue)
                {
                    if (a.MyPet.Value && ptype != PawnType.MyPet)
                    {
                        continue;
                    }
                    if (!a.MyPet.Value && ptype == PawnType.MyPet)
                    {
                        continue;
                    }
                }
                if (a.NoOwner.HasValue)
                {
                    if (a.NoOwner.HasValue && p.Owner.IsValid)
                    {
                        continue;
                    }
                }
                if (a.Npc.HasValue)
                {
                    if (a.Npc.Value && ptype != PawnType.NPC)
                    {
                        continue;
                    }
                    if (!a.Npc.Value && ptype == PawnType.NPC)
                    {
                        continue;
                    }
                }
                if (a.Pc.HasValue)
                {
                    if (a.Pc.Value && ptype != PawnType.PC)
                    {
                        continue;
                    }
                    if (!a.Pc.Value && ptype == PawnType.PC)
                    {
                        continue;
                    }
                }
                if (a.Pet.HasValue)
                {
                    if (a.Pet.Value && ptype != PawnType.Pet)
                    {
                        continue;
                    }
                    if (!a.Pet.Value && ptype == PawnType.Pet)
                    {
                        continue;
                    }
                }
                if (a.QuestNpc.HasValue)
                {
                    if (a.QuestNpc.Value && !p.HasQuestFlag)
                    {
                        continue;
                    }
                    if (!a.QuestNpc.Value && p.HasQuestFlag)
                    {
                        continue;
                    }
                }
                if (!string.IsNullOrEmpty(a.Race))
                {
                    if (p.Race.ToLower() != a.Race.ToLower())
                    {
                        continue;
                    }
                }
                if (a.Resource.HasValue)
                {
                    if (a.Resource.Value && ptype != PawnType.Resource)
                    {
                        continue;
                    }
                    if (!a.Resource.Value && ptype == PawnType.Resource)
                    {
                        continue;
                    }
                }
                if (a.Trainer.HasValue)
                {
                    if (a.Trainer.Value && ptype != PawnType.Trainer)
                    {
                        continue;
                    }
                    if (!a.Trainer.Value && ptype == PawnType.Trainer)
                    {
                        continue;
                    }
                }
                if (!string.IsNullOrEmpty(a.Type))
                {
                    if (a.Type.ToLower() != p.Type.ToLower())
                    {
                        continue;
                    }
                }
                if (a.ZRange.HasValue)
                {
                    // Should be right.... right?
                    float zdist = Math.Abs(meZ - p.Z);
                    if (zdist >= a.ZRange.Value)
                    {
                        continue;
                    }
                }

                // FINALLY! THE END! All our checks passed. So we can FINALLY add the pawn to the list.
                // Holy christ that took forever!
                _lst.Add(p);
            }
        }

        #region Nested type: PawnSearchArgs

        /// <summary>
        /// <para>A (small.. kinda) struct to hold information about the passed search arguments.
        /// All of the types in this struct are nullable for a reason. (Things can get screwy if you define
        /// bools that shouldn't be defined.)</para>
        /// 
        /// <para>Use #field#.HasValue and #field#.Value to get values for things (not valid for strings. Just use them normally). 
        /// You shouldn't need to read from this struct. It is mainly used internally, however, 
        /// I have left it public (with readonly fields) in case you want to add some sort of functionality.</para>
        /// </summary>
        public struct PawnSearchArgs
        {
            // So... do YOU know about nullable types? :)
            public readonly bool? AggroNpc;
            public readonly bool? Attackable;
            public readonly bool? Clickable;
            public readonly bool? Corpse;
            public readonly bool? CraftingStation;
            public readonly float? Distance;
            public readonly string ExactName;
            public readonly bool? GroupMember;
            public readonly int? ID;
            public readonly float? InnerRadius;
            public readonly int? Limit;
            public readonly int? MaxLevel;
            public readonly bool? Merchant;
            public readonly int? MinLevel;
            public readonly bool? MyPet;
            public readonly string Name;
            public readonly bool? NoOwner;
            public readonly int? NotID;
            public readonly bool? Npc;
            public readonly float? OuterRadius;
            public readonly bool? Pc;
            public readonly bool? Pet;
            public readonly bool? QuestNpc;
            public readonly string Race;
            public readonly bool? Resource;
            public readonly bool? Trainer;
            public readonly string Type;
            public readonly float? ZRange;

            /// <summary>
            /// Initializes a new instance of the <see cref="PawnSearchArgs"/> struct.
            /// </summary>
            /// <param name="throwSyntaxErrors">if set to <c>true</c> syntax exceptions will be thrown.</param>
            /// <param name="args">The args.</param>
            /// <exception cref="PawnListSyntaxException">
            /// Thrown when syntax is wrong. 
            /// Sytnax expectation, and use are returned, as well as the invalid argument.
            /// </exception>
            // I forget if using the structs default ctor will set all the fields to null, or their normal default (0, false, etc)
            // I don't have time to test it at the moment. But if needed, the fields may need to be set to null manually.
            public PawnSearchArgs(bool throwSyntaxErrors, params string[] args) : this()
            {
                #region Prelim splitting in case people use ',' to split args

                List<string> realArgs = new List<string>();
                foreach (string s in args)
                {
                    // Just split by , Since some args require spaces!
                    string[] insert = s.Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string ins in insert)
                    {
                        // Trim any extra whitespace
                        realArgs.Add(ins.Trim());
                    }
                }

                #endregion

                foreach (string arg in realArgs)
                {
                    // This isn't incredibly glamorous. But oh well. Eventually I'll write a (very) long regex
                    // to handle this much quicker. Until then, this will have to do.
                    bool not = arg.StartsWith("not");
                    // We're only checking the 'actual' argument. This shouldn't include the 'not' delimiter.
                    string toCheck = not
                                         ? arg.Substring(3)
                                         : arg;
                    string[] spaceSplit = toCheck.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                    #region 'level' switch

                    if (toCheck.StartsWith("level"))
                    {
                        if (spaceSplit.Length == 2)
                        {
                            // We should be 2 items in the main array. (level #, or level #-# still comes out to 2 items when split by ' ')
                            string[] levels = spaceSplit[1].Split(new[] {'-'}, StringSplitOptions.RemoveEmptyEntries);
                            MinLevel = levels.Length == 2
                                           ? Convert.ToInt32(levels[0])
                                           : Convert.ToInt32(spaceSplit[1]);
                            MaxLevel = levels.Length == 2
                                           ? Convert.ToInt32(levels[1])
                                           : Convert.ToInt32(spaceSplit[1]);
                        }
                        else if (throwSyntaxErrors)
                        {
                            throw new PawnListSyntaxException(
                                "Invalid level syntax. Supported forms are: level #, or level #-#.", arg);
                        }
                    }

                        #endregion

                        #region 'distance' switch

                    else if (toCheck.StartsWith("distance"))
                    {
                        if (spaceSplit.Length == 2)
                        {
                            Distance = Convert.ToSingle(spaceSplit[1]);
                        }
                        else if (throwSyntaxErrors)
                        {
                            throw new PawnListSyntaxException(
                                "Invalid distance syntax. Supported form is: distance #. # may be of type float.", arg);
                        }
                    }

                        #endregion
                        
                        #region 'clickable'

                    else if (toCheck.StartsWith("clickable"))
                    {
                        // Simplicity!
                        Clickable = !not;
                    }
                        #endregion
                        #region 'aggronpc'

                    else if (toCheck.StartsWith("aggronpc"))
                    {
                        AggroNpc = !not;
                    }
                        #endregion
                        #region 'attackable'

                    else if (toCheck.StartsWith("attackable"))
                    {
                        Attackable = !not;
                    }
                        #endregion
                        #region 'corpse'

                    else if (toCheck.StartsWith("corpse"))
                    {
                        Corpse = !not;
                    }
                        #endregion
                        #region 'craftingstation'

                    else if (toCheck.StartsWith("craftingstation"))
                    {
                        CraftingStation = !not;
                    }
                        #endregion
                        #region 'groupmember'

                    else if (toCheck.StartsWith("groupmember"))
                    {
                        GroupMember = !not;
                    }
                        #endregion
                        #region 'npc'

                    else if (toCheck.StartsWith("npc"))
                    {
                        Npc = !not;
                    }
                        #endregion
                        #region 'pc'

                    else if (toCheck.StartsWith("pc"))
                    {
                        Pc = !not;
                    }
                        #endregion
                        #region 'pet'

                    else if (toCheck.StartsWith("pet"))
                    {
                        Pet = !not;
                    }
                        #endregion
                        #region 'questnpc'

                    else if (toCheck.StartsWith("questnpc"))
                    {
                        QuestNpc = !not;
                    }
                        #endregion
                        #region 'resource'

                    else if (toCheck.StartsWith("resource"))
                    {
                        Resource = !not;
                    }
                        #endregion
                        #region 'trainer'

                    else if (toCheck.StartsWith("trainer"))
                    {
                        Trainer = !not;
                    }
                        #endregion
                        #region 'mypet'

                    else if (toCheck.StartsWith("mypet"))
                    {
                        Trainer = !not;
                    }
                        #endregion
                        #region 'noowner'
                        // No 'not' clause for this.
                    else if (toCheck.StartsWith("noowner"))
                    {
                        if (!not)
                        {
                            NoOwner = true;
                        }
                        else if (throwSyntaxErrors)
                        {
                            throw new PawnListSyntaxException("There is no 'not' clause for the noowner switch.", arg);
                        }
                    }

                        #endregion
                        #region 'merchant'

                    else if (toCheck.StartsWith("merchant"))
                    {
                        Merchant = !not;
                    }
                        #endregion
                        #region 'mypet'

                    else if (toCheck.StartsWith("mypet"))
                    {
                        MyPet = !not;
                    }
                        #endregion
                        #region Radius checks

                    else if (toCheck.StartsWith("radius"))
                    {
                        if (spaceSplit.Length == 2)
                        {
                            string[] radii = spaceSplit[1].Split(new[] {'-'}, StringSplitOptions.RemoveEmptyEntries);
                            InnerRadius = radii.Length == 2
                                              ? Convert.ToSingle(radii[0])
                                              : Convert.ToSingle(spaceSplit[1]);
                            OuterRadius = radii.Length == 2
                                              ? Convert.ToSingle(radii[1])
                                              : Convert.ToSingle(spaceSplit[1]);
                        }
                        else if (throwSyntaxErrors)
                        {
                            throw new PawnListSyntaxException(
                                "Invalid radius syntax. Possible values are: radius #, or radius #-#.", arg);
                        }
                    }
                        #endregion
                        #region 'zrange'

                    else if (toCheck.StartsWith("zrange"))
                    {
                        if (spaceSplit.Length == 2)
                        {
                            ZRange = Convert.ToSingle(spaceSplit[1]);
                        }
                        else if (throwSyntaxErrors)
                        {
                            throw new PawnListSyntaxException(
                                "Invalid zrange syntax. Valid syntax is: zrange #. # may be a float.");
                        }
                    }
                        #endregion
                        #region 'id' and 'notid'

                    else if (toCheck.StartsWith("id"))
                    {
                        if (not)
                        {
                            if (spaceSplit.Length == 2)
                            {
                                NotID = Convert.ToInt32(spaceSplit[1]);
                            }
                            else if (throwSyntaxErrors)
                            {
                                throw new PawnListSyntaxException("Invalid syntax for notid. Valid syntax is: notid #",
                                                                  arg);
                            }
                        }
                        else
                        {
                            if (spaceSplit.Length == 2)
                            {
                                ID = Convert.ToInt32(spaceSplit[1]);
                            }
                            else if (throwSyntaxErrors)
                            {
                                throw new PawnListSyntaxException("Invalid syntax for id. Valid syntax is: id #", arg);
                            }
                        }
                    }
                        #endregion
                        #region 'race'

                    else if (toCheck.StartsWith("race"))
                    {
                        if (spaceSplit.Length == 2)
                        {
                            Race = spaceSplit[1];
                        }
                        else if (throwSyntaxErrors)
                        {
                            throw new PawnListSyntaxException("Invalid syntax for race. Valid syntax is: race Dwarf",
                                                              arg);
                        }
                    }
                        #endregion
                        #region 'type'

                    else if (toCheck.StartsWith("type"))
                    {
                        if (spaceSplit.Length == 2)
                        {
                            Type = spaceSplit[1];
                        }
                        else if (throwSyntaxErrors)
                        {
                            throw new PawnListSyntaxException(
                                "Invalid syntax for type. Valid syntax is: type typeString", arg);
                        }
                    }
                        #endregion
                        #region 'name'

                    else if (toCheck.StartsWith("name"))
                    {
                        if (spaceSplit.Length == 2)
                        {
                            Name = spaceSplit[1];
                        }
                        else if (throwSyntaxErrors)
                        {
                            throw new PawnListSyntaxException(
                                "Invalid syntax for name. Valid syntax is: name nameToCheck", arg);
                        }
                    }
                        #endregion
                        #region 'exactname'

                    else if (toCheck.StartsWith("exactname"))
                    {
                        if (spaceSplit.Length == 2)
                        {
                            ExactName = spaceSplit[1];
                        }
                        else if (throwSyntaxErrors)
                        {
                            throw new PawnListSyntaxException(
                                "Invalid syntax for exactname. Valid syntax is: exactname NameToCheck", arg);
                        }
                    }
                        #endregion
                        #region 'limit'

                    else if (toCheck.StartsWith("limit"))
                    {
                        if (spaceSplit.Length == 2)
                        {
                            Limit = Convert.ToInt32(spaceSplit[1]);
                        }
                        else if (throwSyntaxErrors)
                        {
                            throw new PawnListSyntaxException("Invalid limit syntax. Valid syntax is: limit #");
                        }
                    }
                        #endregion
                        #region Catch all

                    else
                    {
                        if (throwSyntaxErrors)
                        {
                            throw new PawnListSyntaxException("Invalid switch parameter provided.", arg);
                        }
                    }

                    #endregion
                }
            }
        }

        #endregion
    }
}