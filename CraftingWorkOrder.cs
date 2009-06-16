using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    /// <summary>
    /// This DataType includes all of the data available to ISXVG that is related to a crafting work order. 
    /// </summary>
    public class CraftingWorkOrder : LavishScriptObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CraftingWorkOrder"/> class.
        /// </summary>
        /// <param name="Obj">The obj.</param>
        public CraftingWorkOrder(LavishScriptObject Obj) : base(Obj) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="CraftingWorkOrder"/> class.
        /// </summary>
        public CraftingWorkOrder() : base(LavishScript.Objects.GetObject("CraftingWorkOrder")) {}

        /// <summary>
        /// Gets the name of this <see cref="CraftingWorkOrder"/>.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get { return GetMember<string>("Name"); } }

        /// <summary>
        /// Gets the description of this <see cref="CraftingWorkOrder"/>.
        /// </summary>
        /// <value>The description.</value>
        public string Description { get { return GetMember<string>("Description"); } }

        /// <summary>
        /// Gets who issued this <see cref="CraftingWorkOrder"/>.
        /// Note: This is only set AFTER you have accepted the work order.
        /// </summary>
        /// <value>The issued by.</value>
        public string IssuedBy { get { return GetMember<string>("IssuedBy"); } }

        /// <summary>
        /// Gets the requested items of this <see cref="CraftingWorkOrder"/>.
        /// </summary>
        /// <value>The requested items.</value>
        public string RequestedItems { get { return GetMember<string>("RequestedItems"); } }

        /// <summary>
        /// Gets the icon ID of this <see cref="CraftingWorkOrder"/>.
        /// </summary>
        /// <value>The icon ID.</value>
        public int IconID { get { return GetMember<int>("IconID"); } }

        /// <summary>
        /// Gets the ID of this <see cref="CraftingWorkOrder"/>.
        /// </summary>
        /// <value>The ID.</value>
        public int ID { get { return GetMember<int>("ID"); } }

        /// <summary>
        /// Gets the difficulty of this <see cref="CraftingWorkOrder"/>.
        /// </summary>
        /// <value>The difficulty.</value>
        public string Difficulty { get { return GetMember<string>("Difficulty"); } }

        /// <summary>
        /// Gets the required skill of this <see cref="CraftingWorkOrder"/>.
        /// </summary>
        /// <value>The required skill.</value>
        public string RequiredSkill { get { return GetMember<string>("RequiredSkill"); } }

        /// <summary>
        /// Selects this <see cref="CraftingWorkOrder"/>.
        /// Note: This can only be used in <see cref="CraftingTaskMaster.InTransaction"/> is TRUE
        /// </summary>
        /// <returns></returns>
        public bool Select()
        {
            return ExecuteMethod("Select");
        }

        /// <summary>
        /// Abandons this <see cref="CraftingWorkOrder"/>.
        /// Note: This can only be used in <see cref="CraftingTaskMaster.InTransaction"/> is TRUE
        /// </summary>
        /// <returns></returns>
        public bool Abandon()
        {
            return ExecuteMethod("Abandon");
        }

        /// <summary>
        /// Completes this <see cref="CraftingWorkOrder"/>.
        /// Note: This can only be used in <see cref="CraftingTaskMaster.InTransaction"/> is TRUE
        /// </summary>
        /// <returns></returns>
        public bool Complete()
        {
            return ExecuteMethod("Complete");
        }

        public bool GetRequestedItems()
        {
            return ExecuteMethod("GetRequestedItems");
        }
    }
}