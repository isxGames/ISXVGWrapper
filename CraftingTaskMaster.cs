using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    /// <summary>
    /// This DataType includes all of the data available to ISXVG that is related to a Crafting TaskMaster. 
    /// </summary>
    public class CraftingTaskMaster : LavishScriptObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CraftingTaskMaster"/> class.
        /// </summary>
        /// <param name="Obj">The obj.</param>
        public CraftingTaskMaster(LavishScriptObject Obj) : base(Obj) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="CraftingTaskMaster"/> class.
        /// </summary>
        public CraftingTaskMaster() : base(LavishScript.Objects.GetObject("CraftingTaskMaster")) {}

        /// <summary>
        /// Gets the available work order count of this <see cref="CraftingTaskMaster"/>.
        /// </summary>
        /// <value>The avail work order count.</value>
        public int AvailWorkOrderCount { get { return GetMember<int>("AvailWorkOrderCount"); } }

        /// <summary>
        /// Gets the current work order count of this <see cref="CraftingTaskMaster"/>.
        /// </summary>
        /// <value>The current work order count.</value>
        public int CurrentWorkOrderCount { get { return GetMember<int>("CurrentWorkOrderCount"); } }

        /// <summary>
        /// Gets a value indicating whether [in transaction].
        /// </summary>
        /// <value><c>true</c> if [in transaction]; otherwise, <c>false</c>.</value>
        public bool InTransaction { get { return GetMember<bool>("InTransaction"); } }

        /// <summary>
        /// Gets an available work order by name.
        /// NOTE: Available Work Orders are only accessible if ${TaskMaster[Crafting].InTransaction} is TRUE
        /// </summary>
        /// <param name="Name">The name.</param>
        /// <returns></returns>
        public CraftingWorkOrder AvailWorkOrder(string Name)
        {
            LavishScriptObject Obj = GetMember("AvailWorkOrder", Name);
            return new CraftingWorkOrder(Obj);
        }

        /// <summary>
        /// Gets an available work order by index.
        /// NOTE: Available Work Orders are only accessible if <see cref="InTransaction"/> is TRUE
        /// </summary>
        /// <param name="Index">The index.</param>
        /// <returns></returns>
        public CraftingWorkOrder AvailWorkOrder(int Index)
        {
            return AvailWorkOrder(Index.ToString());
        }

        /// <summary>
        /// Gets the current <see cref="CraftingWorkOrder"/> for this <see cref="CraftingTaskMaster"/>.
        /// </summary>
        /// <returns></returns>
        public CraftingWorkOrder CurrentWorkOrder()
        {
            LavishScriptObject Obj = GetMember("CurrentWorkOrder");
            return new CraftingWorkOrder(Obj);
        }

        /// <summary>
        /// Gets the current <see cref="CraftingWorkOrder"/> for this <see cref="CraftingTaskMaster"/> by name.
        /// </summary>
        /// <param name="Name">The name.</param>
        /// <returns></returns>
        public CraftingWorkOrder CurrentWorkOrder(string Name)
        {
            LavishScriptObject Obj = GetMember("CurrentWorkOrder", Name);
            return new CraftingWorkOrder(Obj);
        }

        /// <summary>
        /// Gets the current <see cref="CraftingWorkOrder"/> for this <see cref="CraftingTaskMaster"/> by index.
        /// </summary>
        /// <param name="Index">The index.</param>
        /// <returns></returns>
        public CraftingWorkOrder CurrentWorkOrder(int Index)
        {
            return CurrentWorkOrder(Index.ToString());
        }

        /// <summary>
        /// Begins this <see cref="CraftingTaskMaster"/>.
        /// </summary>
        /// <returns></returns>
        public bool Begin()
        {
            return ExecuteMethod("Begin");
        }

        /// <summary>
        /// Ends this <see cref="CraftingTaskMaster"/>.
        /// </summary>
        /// <returns></returns>
        public bool End()
        {
            return ExecuteMethod("End");
        }
    }
}