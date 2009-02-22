using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    /// <summary>
    /// This DataType includes all of the data available to ISXVG that is related to crafting actions. 
    /// </summary>
    public class CraftingAction : LavishScriptObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CraftingAction"/> class.
        /// </summary>
        /// <param name="Obj">The obj.</param>
        public CraftingAction(LavishScriptObject Obj) : base(Obj) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="CraftingAction"/> class.
        /// </summary>
        public CraftingAction() : base(LavishScript.Objects.GetObject("CraftingAction")) {}

        /// <summary>
        /// Gets the name of this <see cref="CraftingAction"/>.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get { return GetMember<string>("Name"); } }

        /// <summary>
        /// Gets the description of this <see cref="CraftingAction"/>.
        /// </summary>
        /// <value>The description.</value>
        public string Description { get { return GetMember<string>("Description"); } }

        /// <summary>
        /// Gets the action point cost of this <see cref="CraftingAction"/>.
        /// </summary>
        /// <value>The action point cost.</value>
        public int ActionPointCost { get { return GetMember<int>("ActionPointCost"); } }

        /// <summary>
        /// Uses this <see cref="CraftingAction"/>.
        /// </summary>
        /// <returns></returns>
        public bool Use()
        {
            return ExecuteMethod("Use");
        }
    }
}