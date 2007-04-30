using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class Mail : LavishScriptObject
    {
        public Mail(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public Mail(string Arg)
            : base(LavishScript.Objects.GetObject("Mail", Arg))
        {
        }

        public int Message()
        {
            return GetMember<int>("NumMessages");
        }

        public MailMessage Message(int Index)
        {
            LavishScriptObject Obj = GetMember("Message",Index.ToString());
            return new MailMessage(Obj);
        }
        public int NumMessages
        {
            get
            {
                return GetMember<int>("NumMessages");
            }
        }
        public bool HaveUnreadMail
        {
            get
            {
                return GetMember<bool>("HaveUnreadMail");
            }
        }
        public bool SetCOD()
        {
            return ExecuteMethod("SetCOD");
        }
        public bool UnsetCOD()
        {
            return ExecuteMethod("UnsetCOD");
        }
        public bool Send()
        {
            return ExecuteMethod("Send");
        }
        public bool Cancel()
        {
            return ExecuteMethod("Cancel");
        }
    }
}
