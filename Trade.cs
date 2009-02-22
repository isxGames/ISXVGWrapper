using System;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    /// <summary>
    /// 
    /// </summary>
    public class Trade : LavishScriptObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Trade"/> class.
        /// </summary>
        /// <param name="Obj">The obj.</param>
        public Trade(LavishScriptObject Obj)
            : base(Obj) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="Trade"/> class.
        /// </summary>
        public Trade()
            : base(LavishScript.Objects.GetObject("Trade")) {}

        /// <summary>
        /// Gets the state of this <see cref="Trade"/>.
        /// </summary>
        /// <value>The state.</value>
        public string State { get { return GetMember<string>("State"); } }

        /// <summary>
        /// Gets the trader of this <see cref="Trade"/>.
        /// </summary>
        /// <value>The trader.</value>
        public string Trader { get { return GetMember<string>("Trader"); } }

        /// <summary>
        /// Gets my coin offer of this <see cref="Trade"/>.
        /// </summary>
        /// <value>My coin offer.</value>
        public Int64 MyCoinOffer { get { return GetMember<Int64>("MyCoinOffer"); } }

        /// <summary>
        /// Gets the other coin offer of this <see cref="Trade"/>.
        /// </summary>
        /// <value>The other coin offer.</value>
        public Int64 OtherCoinOffer { get { return GetMember<Int64>("OtherCoinOffer"); } }

        /// <summary>
        /// Gets my offer count of this <see cref="Trade"/>.
        /// </summary>
        /// <value>My offer count.</value>
        public int MyOfferCount { get { return GetMember<int>("MyOffer"); } }

        /// <summary>
        /// Gets the other offer count of this <see cref="Trade"/>.
        /// </summary>
        /// <value>The other offer count.</value>
        public int OtherOfferCount { get { return GetMember<int>("OtherOffer"); } }

        /// <summary>
        /// Gets a value indicating whether [I accepted offer].
        /// </summary>
        /// <value><c>true</c> if [I accepted offer]; otherwise, <c>false</c>.</value>
        public bool IAcceptedOffer { get { return GetMember<bool>("IAcceptedOffer"); } }

        /// <summary>
        /// Gets a value indicating whether [other accepted offer].
        /// </summary>
        /// <value><c>true</c> if [other accepted offer]; otherwise, <c>false</c>.</value>
        public bool OtherAcceptedOffer { get { return GetMember<bool>("OtherAcceptedOffer"); } }

        /// <summary>
        /// Mies the offer.
        /// </summary>
        /// <param name="Qty">The qty.</param>
        /// <returns></returns>
        public Item MyOffer(int Qty)
        {
            LavishScriptObject Obj = GetMember("MyOffer", Qty.ToString());
            return new Item(Obj);
        }

        /// <summary>
        /// Mies the offer.
        /// </summary>
        /// <param name="Name">The name.</param>
        /// <returns></returns>
        public Item MyOffer(string Name)
        {
            LavishScriptObject Obj = GetMember("MyOffer", Name);
            return new Item(Obj);
        }

        /// <summary>
        /// Others the offer.
        /// </summary>
        /// <param name="Qty">The qty.</param>
        /// <returns></returns>
        public Item OtherOffer(int Qty)
        {
            LavishScriptObject Obj = GetMember("OtherOffer", Qty.ToString());
            return new Item(Obj);
        }

        /// <summary>
        /// Others the offer.
        /// </summary>
        /// <param name="Name">The name.</param>
        /// <returns></returns>
        public Item OtherOffer(string Name)
        {
            LavishScriptObject Obj = GetMember("OtherOffer", Name);
            return new Item(Obj);
        }

        /// <summary>
        /// Accepts the invite.
        /// </summary>
        /// <returns></returns>
        public bool AcceptInvite()
        {
            return ExecuteMethod("AcceptInvite");
        }

        /// <summary>
        /// Accepts the offer.
        /// </summary>
        /// <returns></returns>
        public bool AcceptOffer()
        {
            return ExecuteMethod("AcceptOffer");
        }

        /// <summary>
        /// Declines the invite.
        /// </summary>
        /// <returns></returns>
        public bool DeclineInvite()
        {
            return ExecuteMethod("DeclineInvite");
        }

        /// <summary>
        /// Cancels this <see cref="Trade"/>.
        /// </summary>
        /// <returns></returns>
        public bool Cancel()
        {
            return ExecuteMethod("Cancel");
        }

        /// <summary>
        /// Removes the item.
        /// </summary>
        /// <param name="Handle">The handle.</param>
        /// <returns></returns>
        public bool RemoveItem(int Handle)
        {
            return ExecuteMethod("RemoveItem", Handle.ToString());
        }

        /// <summary>
        /// Removes the item.
        /// </summary>
        /// <param name="Handle">The handle.</param>
        /// <param name="Qty">The qty.</param>
        /// <returns></returns>
        public bool RemoveItem(int Handle, int Qty)
        {
            return ExecuteMethod("RemoveItem", Handle.ToString(), Qty.ToString());
        }
    }
}