using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    /// <summary>
    /// 
    /// </summary>
    public class PetAbility : LavishScriptObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PetAbility"/> class.
        /// </summary>
        /// <param name="Obj">The obj.</param>
        public PetAbility(LavishScriptObject Obj)
            : base(Obj) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="PetAbility"/> class.
        /// </summary>
        public PetAbility()
            : base(LavishScript.Objects.GetObject("PetAbility")) {}

        /// <summary>
        /// Gets the name of this <see cref="PetAbility"/>.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get { return GetMember<string>("Name"); } }

        /// <summary>
        /// Gets the description of this <see cref="PetAbility"/>.
        /// </summary>
        /// <value>The description.</value>
        public string Description { get { return GetMember<string>("Description"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="PetAbility"/> is ready.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="PetAbility"/> is ready; otherwise, <c>false</c>.
        /// </value>
        public bool IsReady { get { return GetMember<bool>("IsReady"); } }

        /// <summary>
        /// Gets the recovery time of this <see cref="PetAbility"/>.
        /// </summary>
        /// <value>The recovery time.</value>
        public float RecoveryTime { get { return GetMember<float>("RecoveryTime"); } }

        /// <summary>
        /// Gets the icon ID of this <see cref="PetAbility"/>.
        /// </summary>
        /// <value>The icon ID.</value>
        public int IconID { get { return GetMember<int>("IconID"); } }

        /// <summary>
        /// Gets the type of this <see cref="PetAbility"/>.
        /// </summary>
        /// <value>The type.</value>
        public int Type { get { return GetMember<int>("Type"); } }

        /// <summary>
        /// Uses this <see cref="PetAbility"/>.
        /// </summary>
        /// <returns></returns>
        public bool Use()
        {
            return ExecuteMethod("Use");
        }

        /// <summary>
        /// Makes the default.
        /// </summary>
        /// <returns></returns>
        public bool MakeDefault()
        {
            return ExecuteMethod("MakeDefault");
        }
    }
}