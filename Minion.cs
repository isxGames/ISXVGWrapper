using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    /// <summary>
    /// This DataType includes all of the data available to ISXVG that is related to character minions. 
    /// </summary>
    public class Minion : LavishScriptObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Minion"/> class.
        /// </summary>
        /// <param name="Obj">The obj.</param>
        public Minion(LavishScriptObject Obj) : base(Obj) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="Minion"/> class.
        /// </summary>
        public Minion() : base(LavishScript.Objects.GetObject("Minion")) {}

        /// <summary>
        /// Gets the name of this <see cref="Minion"/>.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get { return GetMember<string>("Name"); } }

        /// <summary>
        /// Gets the health percentage of this <see cref="Minion"/>.
        /// </summary>
        /// <value>The health.</value>
        public float Health { get { return GetMember<float>("Health"); } }

        /// <summary>
        /// Gets the total time of this <see cref="Minion"/> in seconds.
        /// </summary>
        /// <value>The total time.</value>
        public float TotalTime { get { return GetMember<float>("TotalTime"); } }

        /// <summary>
        /// Gets the time remaining of this <see cref="Minion"/> in seconds.
        /// </summary>
        /// <value>The time remaining.</value>
        public float TimeRemaining { get { return GetMember<float>("TimeRemaining"); } }
    }
}