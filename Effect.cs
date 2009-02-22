using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    /// <summary>
    /// This DataType includes all of the data available to ISXVG that is related to effects (both beneficial and detrimental.) 
    /// </summary>
    public class Effect : LavishScriptObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Effect"/> class.
        /// </summary>
        /// <param name="Obj">The obj.</param>
        public Effect(LavishScriptObject Obj) : base(Obj) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="Effect"/> class.
        /// </summary>
        public Effect() : base(LavishScript.Objects.GetObject("Effect")) {}

        /// <summary>
        /// Gets the name of this <see cref="Effect"/>.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get { return GetMember<string>("Name"); } }

        /// <summary>
        /// Gets the description of this <see cref="Effect"/>.
        /// </summary>
        /// <value>The description.</value>
        public string Description { get { return GetMember<string>("Description"); } }

        /// <summary>
        /// Gets the duration of this <see cref="Effect"/>.
        /// </summary>
        /// <value>The duration.</value>
        public string Duration { get { return GetMember<string>("Duration"); } }

        /// <summary>
        /// Gets the time remaining of this <see cref="Effect"/>.
        /// </summary>
        /// <value>The time remaining.</value>
        public string TimeRemaining { get { return GetMember<string>("TimeRemaining"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="Effect"/> is visible on UI.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="Effect"/> is visible on UI; otherwise, <c>false</c>.
        /// </value>
        public bool IsVisibleOnUI { get { return GetMember<bool>("IsVisibleOnUI"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="Effect"/> is beneficial.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="Effect"/> is beneficial; otherwise, <c>false</c>.
        /// </value>
        public bool IsBeneficial { get { return GetMember<bool>("IsBeneficial"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="Effect"/> is detrimental.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="Effect"/> is detrimental; otherwise, <c>false</c>.
        /// </value>
        public bool IsDetrimental { get { return GetMember<bool>("IsDetrimental"); } }

        /// <summary>
        /// Cancels this <see cref="Effect"/>.
        /// Note: You cannot cancel detrimental effects.
        /// </summary>
        /// <returns></returns>
        public bool Cancel()
        {
            return ExecuteMethod("Cancel");
        }

        /// <summary>
        /// Removes this <see cref="Effect"/>.
        /// </summary>
        /// <returns></returns>
        public bool Remove()
        {
            return ExecuteMethod("Remove");
        }
    }
}