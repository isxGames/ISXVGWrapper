using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class MarketItem : LavishScriptObject
    {
        public MarketItem(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public MarketItem(params string[] Args)
            : base(LavishScript.Objects.GetObject("MarketItem", Args))
        {
        }

        /// <summary>
        /// in copper
        /// </summary>
        public Int64 BaseCost
        {
            get
            {
                return GetMember<Int64>("BaseCost");
            }
        }
        /// <summary>
        /// in copper
        /// </summary>
        public Int64 Commission
        {
            get
            {
                return GetMember<Int64>("Commission");
            }
        }
        /// <summary>
        /// in copper
        /// </summary>
        public Int64 TotalCost
        {
            get
            {
                return GetMember<Int64>("TotalCost");
            }
        }
        public string Seller
        {
            get
            {
                return GetMember<string>("Seller");
            }
        }
        public int Handle
        {
            get
            {
                return GetMember<int>("Handle");
            }
        }
        public Item ToItem
        {
            get
            {
                return GetMember<Item>("ToItem");
            }
        }

        /// <summary>
        /// Select the item for either buying or cancelling -- ISXVG will automatically detect which based on the marketitem
        /// </summary>
        public bool Select()
        {
            return ExecuteMethod("Select");
        }

    }
}