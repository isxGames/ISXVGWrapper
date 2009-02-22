using System;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    /// <summary>
    /// This DataType includes all of the data available to ISXVG that is related to an item on the market (exchange broker). 
    /// </summary>
    public class MarketItem : LavishScriptObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarketItem"/> class.
        /// </summary>
        /// <param name="Obj">The obj.</param>
        public MarketItem(LavishScriptObject Obj)
            : base(Obj) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="MarketItem"/> class.
        /// </summary>
        /// <param name="Args">The args.</param>
        public MarketItem(params string[] Args)
            : base(LavishScript.Objects.GetObject("MarketItem", Args)) {}

        /// <summary>
        /// in copper
        /// </summary>
        public Int64 BaseCost { get { return GetMember<Int64>("BaseCost"); } }

        /// <summary>
        /// in copper
        /// </summary>
        public Int64 Commission { get { return GetMember<Int64>("Commission"); } }

        /// <summary>
        /// in copper
        /// </summary>
        public Int64 TotalCost { get { return GetMember<Int64>("TotalCost"); } }

        /// <summary>
        /// Gets the seller of this <see cref="MarketItem"/>.
        /// </summary>
        /// <value>The seller.</value>
        public string Seller { get { return GetMember<string>("Seller"); } }

        /// <summary>
        /// Gets the handle of this <see cref="MarketItem"/>.
        /// </summary>
        /// <value>The handle.</value>
        public int Handle { get { return GetMember<int>("Handle"); } }

        /// <summary>
        /// Gets to item of this <see cref="MarketItem"/>.
        /// </summary>
        /// <value>To item.</value>
        public Item ToItem { get { return GetMember<Item>("ToItem"); } }

        /// <summary>
        /// Select the item for either buying or cancelling -- ISXVG will automatically detect which based on the marketitem
        /// </summary>
        public bool Select()
        {
            return ExecuteMethod("Select");
        }
    }
}