using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class Market : LavishScriptObject
    {
        public Market(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public Market(params string[] Args)
            : base(LavishScript.Objects.GetObject("Market", Args))
        {
        }

        /// <summary>
        /// Number of search items listed
        /// </summary>
        public int SearchItem()
        {
            return GetMember<int>("SearchItem");
        }
        /// <param name="Index">Between 1 and number of search items listed</param>
        public MarketItem SearchItem(int Index)
        {
            LavishScriptObject Obj = GetMember("SearchItem", Index.ToString());
            return new MarketItem(Obj);
        }
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
        /// <param name="Index">Between 1 and number of items you are selling</param>
        public MarketItem Consignment(int Index)
        {
            LavishScriptObject Obj = GetMember("Consignment", Index.ToString());
            return new MarketItem(Obj);
        }
        public MarketItem Consignment(string Name)
        {
            LavishScriptObject Obj = GetMember("Consignment", Name);
            return new MarketItem(Obj);
        }
        /// <summary>
        /// Name of the market you're in
        /// </summary>
        public string Name
        {
            get
            {
                return GetMember<string>("Name");
            }
        }

        
        public bool Begin()
        {
            return ExecuteMethod("Begin");
        }
        public bool End()
        {
            return ExecuteMethod("End");
        }
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