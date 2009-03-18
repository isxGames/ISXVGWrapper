using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using LavishScriptAPI;
using LavishVMAPI;
using Vanguard.ISXVG.Delegates;

namespace Vanguard.ISXVG
{
    namespace Delegates
    {
        public delegate bool IsFullScreen();
    }

    /// <summary>
    /// This is a basic .NET wrapper around things available in ISXVG.
    /// You can use this wrapper to access most (if not all) objects available.
    /// </summary>
    public class Extension
    {
        public static IsFullScreen IsFullScreen = Stubs.IsFullScreen;

        /// <summary>
        /// Gets the number of cards in the ParlayCard deck.
        /// </summary>
        /// <value>The parlay card count.</value>
        public int ParlayCardCount { get { return LavishScript.Objects.GetObject<int>("ParlayCard"); } }

        /// <summary>
        /// Gets the actor count of this <see cref="Extension"/>.
        /// </summary>
        /// <value>The actor count.</value>
        public int ActorCount { get { return LavishScript.Objects.GetObject("Actor").GetValue<int>(); } }

        /// <summary>
        /// Returns the "Me" object.
        /// </summary>
        /// <returns></returns>
        public Character Me()
        {
            LavishScriptPersistentObject Obj = LavishScript.Objects.GetPersistentObject("Me");
            return new Character(Obj);
        }

        /// <summary>
        /// Gets a pawn using the specified arguments.
        /// </summary>
        /// <param name="Args">The args.</param>
        /// <returns></returns>
        public Pawn Pawn(params string[] Args)
        {
            LavishScriptPersistentObject Obj = LavishScript.Objects.GetPersistentObject("Pawn", Args);
            return new Pawn(Obj);
        }

        /// <summary>
        /// Gets a pawn using the specified argument.
        /// </summary>
        /// <param name="Arg">The arg.</param>
        /// <returns></returns>
        public Pawn Pawn(string Arg)
        {
            // The line below was causing the crash.
            // return Pawn(Arg);

            // Ok, so using the params string[] Args method causes shit to crash.
            // No idea why.
            LavishScriptPersistentObject Obj = LavishScript.Objects.GetPersistentObject("Pawn", Arg);
            return new Pawn(Obj);
        }

        /// <summary>
        /// Gets a pawn using the specified arguments.
        /// </summary>
        /// <param name="Arg">The arg.</param>
        /// <returns></returns>
        public Pawn Pawn(int Arg)
        {
            return Pawn(Arg.ToString());
        }

        /// <summary>
        /// Returns the number of actors in the array.
        /// </summary>
        /// <returns>number of actors in the array</returns>
        [Obsolete("Use ActorCount instead.")]
        public int Actor()
        {
            return LavishScript.Objects.GetObject("Actor").GetValue<int>();
        }

        /// <summary>
        /// Gets an <see cref="Actor"/> at the specified index.
        /// </summary>
        /// <param name="Arg">between 1 and the <see cref="ActorCount"/></param>
        /// <returns></returns>
        public Actor Actor(int Arg)
        {
            // This has the same effect. With being easier to maintain.
            return Actor(Arg.ToString());
        }

        /// <summary>
        /// Gets an actor by it's search params.
        /// See http://vg.isxgames.com/wiki/index.php?title=Actor_Search_Parameters for possible parameters.
        /// </summary>
        /// <param name="Args">The search parameters to use.</param>
        /// <returns></returns>
        public Actor Actor(params string[] Args)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Actor", Args);
            return new Actor(Obj);
        }

        /// <summary>
        /// Gets a radar object at the specified index.
        /// </summary>
        /// <param name="Index">The index to get the radar from. (1-${ISXVG.NumRadars})</param>
        /// <returns></returns>
        public Radar Radar(int Index)
        {
            LavishScriptPersistentObject Obj = LavishScript.Objects.GetPersistentObject("Radar", Index.ToString());
            return new Radar(Obj);
        }

        /// <summary>
        /// Gets a radar object by its name.
        /// </summary>
        /// <param name="Name">The name of the radar to get.</param>
        /// <returns></returns>
        public Radar Radar(string Name)
        {
            LavishScriptPersistentObject Obj = LavishScript.Objects.GetPersistentObject("Radar", Name);
            return new Radar(Obj);
        }

        /// <summary>
        /// Returns the first/only radar in the array.
        /// </summary>
        /// <returns></returns>
        public Radar Radar()
        {
            LavishScriptPersistentObject Obj = LavishScript.Objects.GetPersistentObject("Radar");
            return new Radar(Obj);
        }

        /// <summary>
        /// This TLO only works when the "Your Remains" window is open and populated.
        /// </summary>
        /// <param name="Argument">At this point (4.18.2007) the only parameter accepted is "Corpse"</param>
        /// <returns>Number of corpses available for summoning</returns> 
        public int Altar(string Argument)
        {
            if (Argument.Contains("Corpse") || Argument.Contains("corpse"))
            {
                return LavishScript.Objects.GetObject("Altar").GetValue<int>();
            }
            return 0;
        }

        /// <summary>
        /// This TLO only works when the "Your Remains" window is open and populated.
        /// </summary>
        /// <param name="Argument">At this point (4.18.2007) the only parameter accepted is "Corpse"</param>
        /// <param name="Index">between 1 and the number of corpses available for summoning</param>
        public SCorpse Altar(string Argument, int Index)
        {
            if (Argument.Contains("Corpse") || Argument.Contains("corpse"))
            {
                LavishScriptObject Obj = LavishScript.Objects.GetObject("Altar", "Corpse", Index.ToString());
                return new SCorpse(Obj);
            }
            return null;
        }

        /// <summary>
        /// Returns the <see cref="ISXVG"/> TLO.
        /// </summary>
        /// <returns></returns>
        public ISXVG ISXVG()
        {
            LavishScriptPersistentObject Obj = LavishScript.Objects.GetPersistentObject("ISXVG");
            return new ISXVG(Obj);
        }

        /// <summary>
        /// Returns the <see cref="Loot"/> TLO.
        /// </summary>
        /// <returns></returns>
        public Loot Loot()
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Loot");
            return new Loot(Obj);
        }

        /// <summary>
        /// Returns the <see cref="VG"/> TLO.
        /// </summary>
        /// <returns></returns>
        public VG VG()
        {
            LavishScriptPersistentObject Obj = LavishScript.Objects.GetPersistentObject("VG");
            return new VG(Obj);
        }

        /// <summary>
        /// Returns the <see cref="Mail"/> TLO.
        /// </summary>
        /// <returns></returns>
        public Mail Mail()
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Mail");
            return new Mail(Obj);
        }

        /// <summary>
        /// Returns the <see cref="Map"/> TLO.
        /// </summary>
        /// <returns></returns>
        public Map Map()
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Map");
            return new Map(Obj);
        }

        /// <summary>
        /// Gets a <see cref="VGLocation"/> based on the passed arguments.
        /// </summary>
        /// <param name="Args">The arguments to use.</param>
        /// <returns></returns>
        public VGLocation VGLoc(params string[] Args)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("VGLoc", Args);
            return new VGLocation(Obj);
        }

        /// <summary>
        /// Gets a <see cref="VGLocation"/> based on the passed argument.
        /// </summary>
        /// <param name="Arg">The argument.</param>
        /// <returns></returns>
        public VGLocation VGLoc(string Arg)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("VGLoc", Arg);
            return new VGLocation(Obj);
        }

        /// <summary>
        /// Gets a <see cref="VGLocation"/> based on its index. (1-<see cref="Vanguard.ISXVG.ISXVG.VGLocsCount"/>)
        /// </summary>
        /// <param name="Arg"></param>
        /// <returns></returns>
        public VGLocation VGLoc(int Arg)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("VGLoc", Arg.ToString());
            return new VGLocation(Obj);
        }

        /// <summary>
        /// Gets a <see cref="VGUIElement"/> by the specified search key.
        /// </summary>
        /// <param name="SearchKey">'searchkeys' are found within the windows xml files in /vanguard/VGUIAssets/Shells/Default/Windows.</param>
        /// <returns></returns>
        public VGUIElement VGUI(string SearchKey)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("VGUI", SearchKey);
            return new VGUIElement(Obj);
        }

        /// <summary>
        /// Gets the <see cref="Vanguard.ISXVG.Market"/> TLO.
        /// </summary>
        /// <returns></returns>
        public Market Market()
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Market");
            return new Market(Obj);
        }

        /// <summary>
        /// number of cards in strategy deck
        /// </summary>
        /// <returns>number of cards in strategy deck</returns>
        public int Strategy()
        {
            return LavishScript.Objects.GetObject<int>("Strategy");
        }

        /// <summary>
        /// Strategies the specified arg.
        /// </summary>
        /// <param name="Arg">The arg.</param>
        /// <returns></returns>
        public ParlayCard Strategy(int Arg)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Strategy", Arg.ToString());
            return new ParlayCard(Obj);
        }

        /// <summary>
        /// Strategies the specified name.
        /// </summary>
        /// <param name="Name">The name.</param>
        /// <returns></returns>
        public ParlayCard Strategy(string Name)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Strategy", Name);
            return new ParlayCard(Obj);
        }

        /// <summary>
        /// number of cards in ParlayCard deck
        /// </summary>
        /// <returns>number of cards in ParlayCard deck</returns>
        [Obsolete("Use ParlayCardCount property instead.")]
        public int ParlayCard()
        {
            return LavishScript.Objects.GetObject<int>("ParlayCard");
        }

        /// <summary>
        /// Parlays the card.
        /// </summary>
        /// <param name="Arg">The arg.</param>
        /// <returns></returns>
        public ParlayCard ParlayCard(int Arg)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("ParlayCard", Arg.ToString());
            return new ParlayCard(Obj);
        }

        /// <summary>
        /// Parlays the card.
        /// </summary>
        /// <param name="Name">The name.</param>
        /// <returns></returns>
        public ParlayCard ParlayCard(string Name)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("ParlayCard", Name);
            return new ParlayCard(Obj);
        }

        /// <summary>
        /// Parlays this <see cref="Extension"/>.
        /// </summary>
        /// <returns></returns>
        public Parlay Parlay()
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Parlay");
            return new Parlay(Obj);
        }

        /// <summary>
        /// Groups the specified arg.
        /// </summary>
        /// <param name="Arg">The arg.</param>
        /// <returns></returns>
        public GroupMember Group(int Arg)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Group", Arg.ToString());
            return new GroupMember(Obj);
        }

        /// <summary>
        /// Groups the specified name.
        /// </summary>
        /// <param name="Name">The name.</param>
        /// <returns></returns>
        public GroupMember Group(string Name)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Group", Name);
            return new GroupMember(Obj);
        }

        public Group Group()
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Group");
            return new Group(Obj);
        }

        public Dialog Dialog(string Arg)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Dialog", Arg);
            return new Dialog(Obj);
        }

        public DialogResponse Dialog(params string[] Args)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Dialog", Args);
            return new DialogResponse(Obj);
        }

        public QuestJournal QuestJournal()
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Journal", "Quest");
            return new QuestJournal(Obj);
        }

        public QuestJournal QuestJournal(string Arg)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Journal", "Quest", Arg);
            return new QuestJournal(Obj);
        }

        public QuestJournal QuestJournal(int Arg)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Journal", "Quest", Arg.ToString());
            return new QuestJournal(Obj);
        }

        public TravelJournal TravelJournal()
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Journal", "Travel");
            return new TravelJournal(Obj);
        }

        public TravelJournal TravelJournal(string Arg)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Journal", "Travel", Arg);
            return new TravelJournal(Obj);
        }

        public TravelJournal TravelJournal(int Arg)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Journal", "Travel", Arg.ToString());
            return new TravelJournal(Obj);
        }

        public Merchant Merchant()
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Merchant");
            return new Merchant(Obj);
        }

        public CraftingTaskMaster CraftingTaskMaster()
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("TaskMaster", "Crafting");
            return new CraftingTaskMaster(Obj);
        }

        public GV GV(params string[] Args)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("GV", Args);
            return new GV(Obj);
        }

        public Trade Trade()
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Trade");
            return new Trade(Obj);
        }

        public Songbook Songs()
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Songbook");
            return new Songbook(Obj);
        }

        public Song Songs(string Name)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Songs", Name);
            return new Song(Obj);
        }

        public Song Songs(int Index)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Song", Index.ToString());
            return new Song(Obj);
        }

        public void VGExecute(string Args)
        {
            LavishScript.ExecuteCommand("VGExecute " + Args);
        }

        public void VGEcho(string Args)
        {
            LavishScript.ExecuteCommand("VGEcho " + Args);
        }

        public void Target()
        {
            LavishScript.ExecuteCommand("Target");
        }

        public void Target(string Args)
        {
            LavishScript.ExecuteCommand("Target " + Args);
        }

        public void Face()
        {
            LavishScript.ExecuteCommand("Face");
        }

        public void Face(string Args)
        {
            LavishScript.ExecuteCommand("Face " + Args);
        }

        public void Where()
        {
            LavishScript.ExecuteCommand("Where");
        }

        public void Where(string Args)
        {
            LavishScript.ExecuteCommand("Where" + Args);
        }

        #region Nested type: Stubs

        internal class Stubs
        {
            public static bool IsFullScreen()
            {
                IntPtr Address = LavishVM.GetAPI("VGWindowsAPI", "IsFullScreen", 1);
                if (Address.ToInt32() == 0)
                {
                    return false;
                }
                Extension.IsFullScreen =
                    (IsFullScreen) Marshal.GetDelegateForFunctionPointer(Address, typeof(IsFullScreen));
                return Extension.IsFullScreen();
            }
        }

        #endregion

    }
}