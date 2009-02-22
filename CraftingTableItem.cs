using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    /// <summary>
    /// This DataType includes data available that is related to the crafting table items. 
    /// </summary>
    public class CraftingTableItem : LavishScriptObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CraftingTableItem"/> class.
        /// </summary>
        /// <param name="Obj">The obj.</param>
        public CraftingTableItem(LavishScriptObject Obj) : base(Obj) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="CraftingTableItem"/> class.
        /// </summary>
        public CraftingTableItem() : base(LavishScript.Objects.GetObject("CraftingTableItem")) {}

        /// <summary>
        /// Gets the name of this <see cref="CraftingTableItem"/>.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get { return GetMember<string>("Name"); } }

        /// <summary>
        /// Gets the quantity of this <see cref="CraftingTableItem"/>.
        /// </summary>
        /// <value>The quantity.</value>
        public int Quantity { get { return GetMember<int>("Quantity"); } }

        /// <summary>
        /// Gets the icon ID of this <see cref="CraftingTableItem"/>.
        /// </summary>
        /// <value>The icon ID.</value>
        public int IconID { get { return GetMember<int>("IconID"); } }

        /// <summary>
        /// Gets the handle of this <see cref="CraftingTableItem"/>.
        /// </summary>
        /// <value>The handle.</value>
        public int Handle { get { return GetMember<int>("Handle"); } }

        /// <summary>
        /// Removes this <see cref="CraftingTableItem"/> from the table.
        /// </summary>
        /// <returns></returns>
        public bool RemoveFromTable()
        {
            return ExecuteMethod("RemoveFromTable");
        }
    }
}