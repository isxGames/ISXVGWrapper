using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class Trade : LavishScriptObject
    {
        public Trade(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public Trade()
            : base(LavishScript.Objects.GetObject("Trade"))
        {
        }
        public string State
        {
            get
            {
                return GetMember<string>("State");
            }
        }
        public string Trader
        {
            get
            {
                return GetMember<string>("Trader");
            }
        }
        public Int64 MyCoinOffer
        {
            get
            {
                return GetMember<Int64>("MyCoinOffer");
            }
        }
        public Int64 OtherCoinOffer
        {
            get
            {
                return GetMember<Int64>("OtherCoinOffer");
            }
        }
        public int MyOfferCount
        {
            get
            {
                return GetMember<int>("MyOffer");
            }
        }
        public Item MyOffer(int Qty)
        {
            LavishScriptObject Obj = GetMember("MyOffer", Qty.ToString());
            return new Item(Obj);
        }
        public Item MyOffer(string Name)
        {
            LavishScriptObject Obj = GetMember("MyOffer", Name);
            return new Item(Obj);
        }
        public int OtherOfferCount
        {
            get
            {
                return GetMember<int>("OtherOffer");
            }
        }
        public Item OtherOffer(int Qty)
        {
            LavishScriptObject Obj = GetMember("OtherOffer", Qty.ToString());
            return new Item(Obj);
        }
        public Item OtherOffer(string Name)
        {
            LavishScriptObject Obj = GetMember("OtherOffer", Name);
            return new Item(Obj);
        }
        public bool IAcceptedOffer
        {
            get
            {
                return GetMember<bool>("IAcceptedOffer");
            }
        }
        public bool OtherAcceptedOffer
        {
            get
            {
                return GetMember<bool>("OtherAcceptedOffer");
            }
        }

        public bool AcceptInvite()
        {
            return ExecuteMethod("AcceptInvite");
        }
        public bool AcceptOffer()
        {
            return ExecuteMethod("AcceptOffer");
        }
        public bool DeclineInvite()
        {
            return ExecuteMethod("DeclineInvite");
        }
        public bool Cancel()
        {
            return ExecuteMethod("Cancel");
        }
        public bool RemoveItem(int Handle)
        {
            return ExecuteMethod("RemoveItem", Handle.ToString());
        }
        public bool RemoveItem(int Handle, int Qty)
        {
            return ExecuteMethod("RemoveItem", Handle.ToString(), Qty.ToString());
        }
    }
}
