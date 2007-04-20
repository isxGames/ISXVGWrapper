using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class MailMessage : LavishScriptObject
    {
        public MailMessage(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public MailMessage(string Arg)
            : base(LavishScript.Objects.GetObject("MailMessage", Arg))
        {
        }

        public string From
        {
            get
            {
                return GetMember<string>("From");
            }
        }
        public string Subject
        {
            get
            {
                return GetMember<string>("Subject");
            }
        }
        public string Body
        {
            get
            {
                return GetMember<string>("Body");
            }
        }
        public Item AttachedItem
        {
            get
            {
                return GetMember<Item>("AttachedItem");
            }
        }
        public int AttachedCoin
        {
            get
            {
                return GetMember<int>("AttachedCoin");
            }
        }
        public int ShippingFee
        {
            get
            {
                return GetMember<int>("ShippingFee");
            }
        }
        public bool IsUnread
        {
            get
            {
                return GetMember<bool>("IsUnread");
            }
        }
        public bool Read()
        {
            return ExecuteMethod("Read");
        }
        public bool Reply()
        {
            return ExecuteMethod("Reply");
        }
        public bool Return()
        {
            return ExecuteMethod("Return");
        }
        public bool Delete()
        {
            return ExecuteMethod("Delete");
        }
        public bool TakeItem()
        {
            return ExecuteMethod("TakeItem");
        }
        public bool TakeCoin()
        {
            return ExecuteMethod("TakeCoin");
        }
    }
}
