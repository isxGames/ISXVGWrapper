using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    /// <summary>
    /// This DataType includes all of the data available to ISXVG that is related to an npc you are in combat with. 
    /// </summary>
    public class CombatNPC : LavishScriptObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CombatNPC"/> class.
        /// </summary>
        /// <param name="Obj">The obj.</param>
        public CombatNPC(LavishScriptObject Obj) : base(Obj) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="CombatNPC"/> class.
        /// </summary>
        public CombatNPC() : base(LavishScript.Objects.GetObject("CombatNPC")) {}

        /// <summary>
        /// Gets the name of this <see cref="CombatNPC"/>.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get { return GetMember<string>("Name"); } }

        /// <summary>
        /// Gets the PCT health of this <see cref="CombatNPC"/>.
        /// </summary>
        /// <value>The PCT health.</value>
        public float PctHealth { get { return GetMember<float>("PctHealth"); } }

        /// <summary>
        /// alias for PctHealth
        /// </summary>
        public int Health { get { return GetMember<int>("Health"); } }

        /// <summary>
        /// Gets the distance of this <see cref="CombatNPC"/>.
        /// </summary>
        /// <value>The distance.</value>
        public float Distance { get { return GetMember<float>("Distance"); } }

        /// <summary>
        /// Gets the level of this <see cref="CombatNPC"/>.
        /// </summary>
        /// <value>The level.</value>
        public int Level { get { return GetMember<int>("Level"); } }

        /// <summary>
        /// Gets the difficulty of this <see cref="CombatNPC"/>.
        /// </summary>
        /// <value>The difficulty.</value>
        public int Difficulty { get { return GetMember<int>("Difficulty"); } }

        /// <summary>
        /// Gets the <see cref="Pawn"/> object representing this <see cref="CombatNPC"/>
        /// </summary>
        /// <value>To pawn.</value>
        public Pawn ToPawn { get { return new Pawn(GetMember("ToPawn")); } }

        /// <summary>
        /// Gets the target of this <see cref="CombatNPC"/>.
        /// </summary>
        /// <value>The target.</value>
        public string Target { get { return GetMember<string>("Target"); } }

        /// <summary>
        /// Gets the ID of this <see cref="CombatNPC"/>.
        /// </summary>
        /// <value>The ID.</value>
        public long ID { get { return GetMember<long>("ID"); } }

        /// <summary>
        /// Performs an explicit conversion from <see cref="Vanguard.ISXVG.CombatNPC"/> to <see cref="Vanguard.ISXVG.Pawn"/>.
        /// </summary>
        /// <param name="a">A.</param>
        /// <returns>The result of the conversion.</returns>
        public static explicit operator Pawn(CombatNPC a)
        {
            return a.ToPawn;
        }
    }
}