using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    /// <summary>
    /// 
    /// </summary>
    public class Refining : LavishScriptObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Refining"/> class.
        /// </summary>
        /// <param name="Obj">The obj.</param>
        public Refining(LavishScriptObject Obj)
            : base(Obj) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="Refining"/> class.
        /// </summary>
        public Refining()
            : base(LavishScript.Objects.GetObject("Refining")) {}

        /// <summary>
        /// Gets a value indicating whether [in recovery].
        /// </summary>
        /// <value><c>true</c> if [in recovery]; otherwise, <c>false</c>.</value>
        public bool InRecovery { get { return GetMember<bool>("InRecovery"); } }

        /// <summary>
        /// Gets the recovery of this <see cref="Refining"/>.
        /// </summary>
        /// <value>The recovery.</value>
        public float Recovery { get { return GetMember<float>("Recovery"); } }

        /// <summary>
        /// Gets the recipe count of this <see cref="Refining"/>.
        /// </summary>
        /// <value>The recipe count.</value>
        public int RecipeCount { get { return GetMember<int>("RecipeCount"); } }

        /// <summary>
        /// Gets the state of this <see cref="Refining"/>.
        /// </summary>
        /// <value>The state.</value>
        public int State { get { return GetMember<int>("State"); } }

        /// <summary>
        /// Gets the orig action points avail of this <see cref="Refining"/>.
        /// </summary>
        /// <value>The orig action points avail.</value>
        public int OrigActionPointsAvail { get { return GetMember<int>("OrigActionPointsAvail"); } }

        /// <summary>
        /// Gets the action points used of this <see cref="Refining"/>.
        /// </summary>
        /// <value>The action points used.</value>
        public int ActionPointsUsed { get { return GetMember<int>("ActionPointsUsed"); } }

        /// <summary>
        /// Gets the useable item count of this <see cref="Refining"/>.
        /// </summary>
        /// <value>The useable item count.</value>
        public int UseableItemCount { get { return GetMember<int>("UseableItemCount"); } }

        /// <summary>
        /// Gets the total table space of this <see cref="Refining"/>.
        /// </summary>
        /// <value>The total table space.</value>
        public int TotalTableSpace { get { return GetMember<int>("TotalTableSpace"); } }

        /// <summary>
        /// Gets the quality of this <see cref="Refining"/>.
        /// </summary>
        /// <value>The quality.</value>
        public int Quality { get { return GetMember<int>("Quality"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="Refining"/> is setup complete.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="Refining"/> is setup complete; otherwise, <c>false</c>.
        /// </value>
        public bool IsSetupComplete { get { return GetMember<bool>("IsSetupComplete"); } }

        /// <summary>
        /// Gets the complication count of this <see cref="Refining"/>.
        /// </summary>
        /// <value>The complication count.</value>
        public int ComplicationCount { get { return GetMember<int>("ComplicationCount"); } }

        /// <summary>
        /// Gets the correction count of this <see cref="Refining"/>.
        /// </summary>
        /// <value>The correction count.</value>
        public int CorrectionCount { get { return GetMember<int>("CorrectionCount"); } }

        /// <summary>
        /// Stages the specified arg.
        /// </summary>
        /// <param name="Arg">The arg.</param>
        /// <returns></returns>
        public CraftingStage Stage(int Arg)
        {
            LavishScriptObject Obj = GetMember("Stage", Arg.ToString());
            return new CraftingStage(Obj);
        }

        /// <summary>
        /// Stages this <see cref="Refining"/>.
        /// </summary>
        /// <returns></returns>
        public CraftingStage Stage()
        {
            LavishScriptObject Obj = GetMember("Stage");
            return new CraftingStage(Obj);
        }

        /// <summary>
        /// Currents the recipe.
        /// </summary>
        /// <returns></returns>
        public RefiningRecipe CurrentRecipe()
        {
            LavishScriptObject Obj = GetMember("CurrentRecipe");
            return new RefiningRecipe(Obj);
        }

        /// <summary>
        /// Recipes the specified name.
        /// </summary>
        /// <param name="Name">The name.</param>
        /// <returns></returns>
        public RefiningRecipe Recipe(string Name)
        {
            LavishScriptObject Obj = GetMember("CurrentRecipe", Name);
            return new RefiningRecipe(Obj);
        }

        /// <summary>
        /// Recipes the specified index.
        /// </summary>
        /// <param name="Index">The index.</param>
        /// <returns></returns>
        public RefiningRecipe Recipe(int Index)
        {
            LavishScriptObject Obj = GetMember("CurrentRecipe", Index.ToString());
            return new RefiningRecipe(Obj);
        }

        /// <summary>
        /// Useables the item.
        /// </summary>
        /// <param name="Arg">The arg.</param>
        /// <returns></returns>
        public Item UseableItem(int Arg)
        {
            LavishScriptObject Obj = GetMember("UseableItem", Arg.ToString());
            return new Item(Obj);
        }

        /// <summary>
        /// Useables the item.
        /// </summary>
        /// <param name="Arg">The arg.</param>
        /// <returns></returns>
        public Item UseableItem(string Arg)
        {
            LavishScriptObject Obj = GetMember("UseableItem", Arg);
            return new Item(Obj);
        }

        /// <summary>
        /// Number of item stacks currently on the table
        /// </summary>
        public int Table()
        {
            return GetMember<int>("Table");
        }

        /// <summary>
        /// Tables the specified arg.
        /// </summary>
        /// <param name="Arg">The arg.</param>
        /// <returns></returns>
        public CraftingTableItem Table(int Arg)
        {
            LavishScriptObject Obj = GetMember("Table", Arg.ToString());
            return new CraftingTableItem(Obj);
        }

        /// <summary>
        /// Tables the specified arg.
        /// </summary>
        /// <param name="Arg">The arg.</param>
        /// <returns></returns>
        public CraftingTableItem Table(string Arg)
        {
            LavishScriptObject Obj = GetMember("Table", Arg);
            return new CraftingTableItem(Obj);
        }

        /// <summary>
        /// Complications the specified arg.
        /// </summary>
        /// <param name="Arg">The arg.</param>
        /// <returns></returns>
        public Complication Complication(int Arg)
        {
            LavishScriptObject Obj = GetMember("Complication", Arg.ToString());
            return new Complication(Obj);
        }

        /// <summary>
        /// Corrections the specified arg.
        /// </summary>
        /// <param name="Arg">The arg.</param>
        /// <returns></returns>
        public Correction Correction(int Arg)
        {
            LavishScriptObject Obj = GetMember("Correction", Arg.ToString());
            return new Correction(Obj);
        }

        /// <summary>
        /// Begins this <see cref="Refining"/>.
        /// </summary>
        /// <returns></returns>
        public bool Begin()
        {
            return ExecuteMethod("Begin");
        }

        /// <summary>
        /// Changes the toolbelt.
        /// </summary>
        /// <param name="ToolbeltID">The toolbelt ID.</param>
        /// <returns></returns>
        public bool ChangeToolbelt(int ToolbeltID)
        {
            return ExecuteMethod("ChangeToolbelt", ToolbeltID.ToString());
        }

        /// <summary>
        /// Adds the item to table.
        /// </summary>
        /// <param name="ItemID">The item ID.</param>
        /// <returns></returns>
        public bool AddItemToTable(int ItemID)
        {
            return ExecuteMethod("AddItemToTable", ItemID.ToString());
        }

        /// <summary>
        /// Does the setup.
        /// </summary>
        /// <returns></returns>
        public bool DoSetup()
        {
            return ExecuteMethod("DoSetup");
        }

        /// <summary>
        /// Starts this <see cref="Refining"/>.
        /// </summary>
        /// <returns></returns>
        public bool Start()
        {
            return ExecuteMethod("Start");
        }

        /// <summary>
        /// Cancels this <see cref="Refining"/>.
        /// </summary>
        /// <returns></returns>
        public bool Cancel()
        {
            return ExecuteMethod("Cancel");
        }

        /// <summary>
        /// Selects this <see cref="Refining"/>.
        /// </summary>
        /// <returns></returns>
        public bool Select()
        {
            return ExecuteMethod("Select");
        }

        /// <summary>
        /// Ends this <see cref="Refining"/>.
        /// </summary>
        /// <returns></returns>
        public bool End()
        {
            return ExecuteMethod("End");
        }
    }
}