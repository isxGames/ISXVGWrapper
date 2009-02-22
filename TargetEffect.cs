using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    /// <summary>
    /// 
    /// </summary>
    public class TargetEffect : LavishScriptObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TargetEffect"/> class.
        /// </summary>
        /// <param name="Obj">The obj.</param>
        public TargetEffect(LavishScriptObject Obj)
            : base(Obj) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="TargetEffect"/> class.
        /// </summary>
        public TargetEffect()
            : base(LavishScript.Objects.GetObject("TargetEffect")) {}

        /// <summary>
        /// Gets the name of this <see cref="TargetEffect"/>.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get { return GetMember<string>("Name"); } }

        /// <summary>
        /// Gets the description of this <see cref="TargetEffect"/>.
        /// </summary>
        /// <value>The description.</value>
        public string Description { get { return GetMember<string>("Description"); } }

        /// <summary>
        /// Gets the time remaining of this <see cref="TargetEffect"/>.
        /// </summary>
        /// <value>The time remaining.</value>
        public string TimeRemaining { get { return GetMember<string>("TimeRemaining"); } }
    }
}