using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    /// <summary>
    /// Retrieves an market object from the game world. Use this TLO to interact with Exchange Brokers. 
    /// This DataType includes all of the data available to ISXVG that is related to browsing a given market (exchange broker). 
    /// </summary>
    public class Market : LavishScriptObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Market"/> class.
        /// </summary>
        /// <param name="Obj">The obj.</param>
        public Market(LavishScriptObject Obj) : base(Obj) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="Market"/> class.
        /// </summary>
        /// <param name="Args">The args.</param>
        public Market(params string[] Args) : base(LavishScript.Objects.GetObject("Market", Args)) {}

        /// <summary>
        /// Name of the market you're in
        /// </summary>
        public string Name { get { return GetMember<string>("Name"); } }

        /// <summary>
        /// Number of search items listed
        /// </summary>
        public int SearchItem()
        {
            return GetMember<int>("SearchItem");
        }

        /// <summary>
        /// Searches the item.
        /// </summary>
        /// <param name="Index">Between 1 and number of search items listed</param>
        /// <returns></returns>
        public MarketItem SearchItem(int Index)
        {
            LavishScriptObject Obj = GetMember("SearchItem", Index.ToString());
            return new MarketItem(Obj);
        }

        /// <summary>
        /// Searches the item.
        /// </summary>
        /// <param name="Name">The name.</param>
        /// <returns></returns>
        public MarketItem SearchItem(string Name)
        {
            LavishScriptObject Obj = GetMember("SearchItem", Name);
            return new MarketItem(Obj);
        }

        /// <summary>
        /// Number of items you are selling
        /// </summary>
        public int Consignment()
        {
            return GetMember<int>("Consignment");
        }

        /// <summary>
        /// Consignments the specified index.
        /// </summary>
        /// <param name="Index">Between 1 and number of items you are selling</param>
        /// <returns></returns>
        public MarketItem Consignment(int Index)
        {
            LavishScriptObject Obj = GetMember("Consignment", Index.ToString());
            return new MarketItem(Obj);
        }

        /// <summary>
        /// Consignments the specified name.
        /// </summary>
        /// <param name="Name">The name.</param>
        /// <returns></returns>
        public MarketItem Consignment(string Name)
        {
            LavishScriptObject Obj = GetMember("Consignment", Name);
            return new MarketItem(Obj);
        }

        /// <summary>
        /// Begins this <see cref="Market"/>.
        /// </summary>
        /// <returns></returns>
        public bool Begin()
        {
            return ExecuteMethod("Begin");
        }

        /// <summary>
        /// Ends this <see cref="Market"/>.
        /// </summary>
        /// <returns></returns>
        public bool End()
        {
            return ExecuteMethod("End");
        }

        /// <summary>
        /// Buys this <see cref="Market"/>.
        /// </summary>
        /// <returns></returns>
        public bool Buy()
        {
            return ExecuteMethod("Buy");
        }

        /// <summary>
        /// Defaults for this method are exactly as they are in-game.  In other words, for any parameters you do not specify,
        /// it will act similarly as it does in game when fields are left empty.
        /// EXAMPLE:  Search(MinLevel,15,MaxLevel,30,Class,Warrior,EquipSlot,Head)
        /// </summary>
        /// <param name="Parameters">See http://vg.isxgames.com/wiki/index.php?title=Market.Search_Parameters for the list of possible parameters.</param>
        /// <returns></returns>
        public bool Search(params string[] Parameters)
        {
            return ExecuteMethod("Search", Parameters);
        }

        /// <summary>
        /// place item up for sale [ie, add to consignment]
        /// </summary>
        public bool PlaceItem()
        {
            return ExecuteMethod("PlaceItem");
        }

        /// <summary>
        /// remove an item from consignment  (Note: Select the item to be removed using the "Select" method of the 'marketitem' datatype)
        /// </summary>
        public bool CancelItemSale()
        {
            return ExecuteMethod("CancelItemSale");
        }
    }
}