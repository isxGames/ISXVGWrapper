using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    /// <summary>
    /// <para>Retrieves objects related to dealing with NPC Merchants. 
    /// This TLO is used for both buy/sell merchants as well as repair merchants. 
    /// You must be in a merchant transaction for the merchant data type to return anything but NULL's. </para> 
    /// <para>Use <see cref="InTransaction"/> to check for the validity of this object.</para>
    /// <para>This DataType includes all of the data available to ISXVG that is related to a merchant transaction. All 'merchant' datatype members will return NULL if you're currently not in a merchant transaction.</para>
    /// </summary>
    public class Merchant : LavishScriptObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Merchant"/> class.
        /// </summary>
        /// <param name="Obj">The obj.</param>
        public Merchant(LavishScriptObject Obj) : base(Obj) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="Merchant"/> class.
        /// </summary>
        public Merchant() : base(LavishScript.Objects.GetObject("Merchant")) {}

        /// <summary>
        /// Gets a value indicating whether we are current in a transaction with this merchant.
        /// </summary>
        /// <value><c>true</c> if we are current in a transaction with this merchant; otherwise, <c>false</c>.</value>
        public bool InTransaction { get { return IsValid; } }

        /// <summary>
        /// Gets the num items for sale of this <see cref="Merchant"/>.
        /// </summary>
        /// <value>The num items for sale.</value>
        public int NumItemsForSale { get { return GetMember<int>("NumItemsForSale"); } }

        /// <summary>
        /// Gets the num items for repair of this <see cref="Merchant"/>.
        /// </summary>
        /// <value>The num items for repair.</value>
        public int NumItemsForRepair { get { return GetMember<int>("NumItemsForRepair"); } }

        /// <summary>
        /// Gets an item for sale by name.
        /// </summary>
        /// <param name="Name">The name.</param>
        /// <returns></returns>
        public Item ForSaleItem(string Name)
        {
            LavishScriptObject Obj = GetMember("ForSaleItem", Name);
            return new Item(Obj);
        }

        /// <summary>
        /// Gets an item for sale by index.
        /// </summary>
        /// <param name="Index">The index.</param>
        /// <returns></returns>
        public Item ForSaleItem(int Index)
        {
            return ForSaleItem(Index.ToString());
        }

        /// <summary>
        /// Repairs the item.
        /// </summary>
        /// <param name="Name">The name.</param>
        /// <returns></returns>
        public RepairItem RepairItem(string Name)
        {
            LavishScriptObject Obj = GetMember("RepairItem", Name);
            return new RepairItem(Obj);
        }

        /// <summary>
        /// Repairs the item.
        /// </summary>
        /// <param name="Index">The index. (1 - <see cref="NumItemsForRepair"/>)</param>
        /// <returns></returns>
        public RepairItem RepairItem(int Index)
        {
            LavishScriptObject Obj = GetMember("RepairItem", Index.ToString());
            return new RepairItem(Obj);
        }

        /// <summary>
        /// Begins a transaction with a Merchant
        /// </summary>
        /// <param name="Type">BuySell or Repair</param>
        /// <returns></returns>
        public bool Begin(string Type)
        {
            return ExecuteMethod("Begin", Type);
        }

        /// <summary>
        /// Ends this <see cref="Merchant"/>.
        /// </summary>
        /// <returns></returns>
        public bool End()
        {
            return ExecuteMethod("End");
        }
    }
}