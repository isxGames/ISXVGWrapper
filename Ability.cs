using System;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    /// <summary>
    /// 
    /// </summary>
    public enum AbilityType
    {
        /// <summary>
        /// 
        /// </summary>
        NULL = -1,
        /// <summary>
        /// 
        /// </summary>
        Informational,
        /// <summary>
        /// 
        /// </summary>
        CombatArt,
        /// <summary>
        /// 
        /// </summary>
        Spell,
        /// <summary>
        /// 
        /// </summary>
        RangedAttack,
        /// <summary>
        /// 
        /// </summary>
        BattleCry,
        /// <summary>
        /// 
        /// </summary>
        DefensiveManeuver,
        /// <summary>
        /// 
        /// </summary>
        Song
    }

    //public enum TargetType
    //{
    //    NULL = -1,
    //    None,
    //    Self,
    //    Offensive,
    //    Defensive,
    //    Group,
    //    Ally
    //}

    //public enum SongType
    //{
    //    NULL = -1,
    //    Shout,
    //    Melody,
    //    Embellishment,
    //    Lyric,
    //    Chorus,
    //    Rest
    //}

    /// <summary>
    /// 
    /// </summary>
    public class Ability : LavishScriptObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ability"/> class.
        /// </summary>
        /// <param name="Obj">The object ot use as a copy.</param>
        public Ability(LavishScriptObject Obj)
            : base(Obj) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="Ability"/> class.
        /// </summary>
        public Ability()
            : base(LavishScript.Objects.GetObject("Ability")) {}

        /// <summary>
        /// Returns the name of this <see cref="Ability"/>.
        /// </summary>
        public string Name { get { return GetMember<string>("Name"); } }

        /// <summary>
        /// Gets the ID of this <see cref="Ability"/>.
        /// </summary>
        /// <value>The ID.</value>
        public uint ID { get { return GetMember<uint>("ID"); } }

        /// <summary>
        /// Returns the description for this <see cref="Ability"/>.
        /// </summary>
        public string Description { get { return GetMember<string>("Description"); } }

        /// <summary>
        /// Returns the cast time for this <see cref="Ability"/>
        /// </summary>
        public float CastTime { get { return GetMember<float>("CastTime"); } }

        /// <summary>
        /// Returns the recovery time for this <see cref="Ability"/> in seconds.
        /// </summary>
        public float RecoveryTime { get { return GetMember<float>("RecoveryTime"); } }

        /// <summary>
        /// Returns this <see cref="Ability"/>'s range.
        /// </summary>
        public int Range { get { return GetMember<int>("Range"); } }

        /// <summary>
        /// Returns a <see cref="AbilityType"/> corresponding to this <see cref="Ability"/>s type.
        /// </summary>
        public AbilityType AbilityType
        {
            get
            {
                switch (GetMember<string>("Type"))
                {
                    case "Informational":
                        return AbilityType.Informational;
                    case "Combat Art":
                        return AbilityType.CombatArt;
                    case "Spell":
                        return AbilityType.Spell;
                    case "Ranged Attack":
                        return AbilityType.RangedAttack;
                    case "Battle Cry":
                        return AbilityType.BattleCry;
                    case "Defensive Maneuver":
                        return AbilityType.DefensiveManeuver;
                    case "Song":
                        return AbilityType.Song;
                    default:
                        return AbilityType.NULL;
                }
            }
        }

        /// <summary>
        /// Returns the type of this ability in string format.
        /// </summary>
        [Obsolete("Use AbilityType instead.")]
        public string Type { get { return GetMember<string>("Type"); } }

        /// <summary>
        /// Gets the type of the song.
        /// </summary>
        /// <value>The type of the song.</value>
        public string SongType { get { return GetMember<string>("SongType"); } }

        /// <summary>
        /// Gets the type of the target.
        /// </summary>
        /// <value>The type of the target.</value>
        public string TargetType { get { return GetMember<string>("TargetType"); } }

        /// <summary>
        /// Gets a value indicating whether this instance is a chain.
        /// </summary>
        /// <value><c>true</c> if this instance is a chain; otherwise, <c>false</c>.</value>
        public bool IsChain { get { return GetMember<bool>("IsChain"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="Ability"/> is counter.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance is counter; otherwise, <c>false</c>.
        /// </value>
        public bool IsCounter { get { return GetMember<bool>("IsCounter"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="Ability"/> is rescue.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="Ability"/> is rescue; otherwise, <c>false</c>.
        /// </value>
        public bool IsRescue { get { return GetMember<bool>("IsRescue"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="Ability"/> is offensive.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="Ability"/> is offensive; otherwise, <c>false</c>.
        /// </value>
        public bool IsOffensive { get { return GetMember<bool>("IsOffensive"); } }

        /// <summary>
        /// Gets the triggered countdown.
        /// </summary>
        /// <value>The triggered countdown.</value>
        public float TriggeredCountdown { get { return GetMember<float>("TriggeredCountdown"); } }

        /// <summary>
        /// Gets the level granted.
        /// </summary>
        /// <value>The level granted.</value>
        public int LevelGranted { get { return GetMember<int>("LevelGranted"); } }

        /// <summary>
        /// Gets the health cost.
        /// </summary>
        /// <value>The health cost.</value>
        public int HealthCost { get { return GetMember<int>("HealthCost"); } }

        /// <summary>
        /// Gets the health cost per second.
        /// </summary>
        /// <value>The health cost per second.</value>
        public int HealthCostPerSecond { get { return GetMember<int>("HealthCostPerSecond"); } }

        /// <summary>
        /// Gets the energy cost.
        /// </summary>
        /// <value>The energy cost.</value>
        public int EnergyCost { get { return GetMember<int>("EnergyCost"); } }

        /// <summary>
        /// Gets the energy cost per second.
        /// </summary>
        /// <value>The energy cost per second.</value>
        public int EnergyCostPerSecond { get { return GetMember<int>("EnergyCostPerSecond"); } }

        /// <summary>
        /// Gets the endurance cost.
        /// </summary>
        /// <value>The endurance cost.</value>
        public int EnduranceCost { get { return GetMember<int>("EnduranceCost"); } }

        /// <summary>
        /// Gets the endurance cost per second.
        /// </summary>
        /// <value>The endurance cost per second.</value>
        public int EnduranceCostPerSecond { get { return GetMember<int>("EnduranceCostPerSecond"); } }

        /// <summary>
        /// Gets the time remaining.
        /// </summary>
        /// <value>The time remaining.</value>
        public float TimeRemaining { get { return GetMember<float>("TimeRemaining"); } }

        /// <summary>
        /// Gets a value indicating whether this <see cref="Ability"/> is toggled.
        /// </summary>
        /// <value><c>true</c> if toggled; otherwise, <c>false</c>.</value>
        public bool Toggled { get { return GetMember<bool>("Toggled"); } }

        /// <summary>
        /// Gets a value indicating whether [target in range].
        /// </summary>
        /// <value><c>true</c> if [target in range]; otherwise, <c>false</c>.</value>
        public bool TargetInRange { get { return GetMember<bool>("TargetInRange"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="Ability"/> is ready.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="Ability"/> is ready; otherwise, <c>false</c>.
        /// </value>
        public bool IsReady { get { return GetMember<bool>("IsReady"); } }

        /// <summary>
        /// Gets the special points cost.
        /// </summary>
        /// <value>The special points cost.</value>
        public int SpecialPointsCost { get { return GetMember<int>("SpecialPointsCost"); } }

        /// <summary>
        /// Gets the special points cost per second.
        /// </summary>
        /// <value>The special points cost per second.</value>
        public int SpecialPointsCostPerSecond { get { return GetMember<int>("SpecialPointsCostPerSecond"); } }

        /// <summary>
        /// Gets the phenomena points cost.
        /// </summary>
        /// <value>The phenomena points cost.</value>
        public int PhenomenaPointsCost { get { return GetMember<int>("PhenomenaPointsCost"); } }

        /// <summary>
        /// Gets the phenomena points cost per second.
        /// </summary>
        /// <value>The phenomena points cost per second.</value>
        public int PhenomenaPointsCostPerSecond { get { return GetMember<int>("PhenomenaPointsCostPerSecond"); } }

        /// <summary>
        /// Gets the virtue points cost.
        /// </summary>
        /// <value>The virtue points cost.</value>
        public int VirtuePointsCost { get { return GetMember<int>("VirtuePointsCost"); } }

        /// <summary>
        /// Gets the virtue points cost per second.
        /// </summary>
        /// <value>The virtue points cost per second.</value>
        public int VirtuePointsCostPerSecond { get { return GetMember<int>("VirtuePointsCostPerSecond"); } }

        /// <summary>
        /// Gets the jin cost.
        /// </summary>
        /// <value>The jin cost.</value>
        public int JinCost { get { return GetMember<int>("JinCost"); } }

        /// <summary>
        /// Gets the jin cost per second.
        /// </summary>
        /// <value>The jin cost per second.</value>
        public int JinCostPerSecond { get { return GetMember<int>("JinCostPerSecond"); } }

        /// <summary>
        /// Gets the school.
        /// </summary>
        /// <value>The school.</value>
        public string School { get { return GetMember<string>("School"); } }

        /// <summary>
        /// Gets the blood union required.
        /// </summary>
        /// <value>The blood union required.</value>
        public int BloodUnionRequired { get { return GetMember<int>("BloodUnionRequired"); } }

        /// <summary>
        /// Gets the requirements.
        /// </summary>
        /// <value>The requirements.</value>
        public string Requirements { get { return GetMember<string>("Requirements"); } }

        /// <summary>
        /// Gets the restrictions.
        /// </summary>
        /// <value>The restrictions.</value>
        public string Restrictions { get { return GetMember<string>("Restrictions"); } }

        /// <summary>
        /// Uses this <see cref="Ability"/>.
        /// </summary>
        /// <returns></returns>
        public bool Use()
        {
            return ExecuteMethod("Use");
        }
    }
}