using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    /// <summary>
    /// This DataType includes all of the data available to ISXVG that is related to a crafting 'step'. 
    /// </summary>
    public class CraftingStep : LavishScriptObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CraftingStep"/> class.
        /// </summary>
        /// <param name="Obj">The obj.</param>
        public CraftingStep(LavishScriptObject Obj) : base(Obj) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="CraftingStep"/> class.
        /// </summary>
        public CraftingStep() : base(LavishScript.Objects.GetObject("CraftingStep")) {}

        /// <summary>
        /// Gets the type ID of this <see cref="CraftingStep"/>.
        /// </summary>
        /// <value>The type ID.</value>
        public int TypeID { get { return GetMember<int>("TypeID"); } }

        /// <summary>
        /// Gets the name of this <see cref="CraftingStep"/>.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get { return GetMember<string>("Name"); } }

        /// <summary>
        /// Gets the description of this <see cref="CraftingStep"/>.
        /// </summary>
        /// <value>The description.</value>
        public string Description { get { return GetMember<string>("Description"); } }

        /// <summary>
        /// Gets the available actions count of this <see cref="CraftingStep"/>.
        /// </summary>
        /// <value>The avail actions count.</value>
        public int AvailActionsCount { get { return GetMember<int>("AvailActionsCount"); } }

        /// <summary>
        /// Gets the <see cref="CraftingAction"/> available at the specified index.
        /// </summary>
        /// <param name="Arg">The index to use. (1 based index)</param>
        /// <returns></returns>
        public CraftingAction AvailAction(int Arg)
        {
            LavishScriptObject Obj = GetMember("AvailAction", Arg.ToString());
            return new CraftingAction(Obj);
        }

        /// <summary>
        /// Gets the <see cref="CraftingStage"/> of this <see cref="CraftingStep"/>.
        /// </summary>
        /// <returns></returns>
        public CraftingStage InStage()
        {
            LavishScriptObject Obj = GetMember("InStage");
            return new CraftingStage(Obj);
        }
    }
}