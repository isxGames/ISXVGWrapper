using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class DialogResponse : LavishScriptObject
    {
        public DialogResponse(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public DialogResponse()
            : base(LavishScript.Objects.GetObject("DialogResponse"))
        {
        }

        public string Text
        {
            get
            {
                return GetMember<string>("Text");
            }
        }

        public int Type
        {
            get
            {
                return GetMember<int>("Type");
            }
        }

        public int PresenceRequired
        {
            get
            {
                return GetMember<int>("PresenceRequired");
            }
        }

        public string PresenceRequiredType
        {
            get
            {
                return GetMember<string>("PresenceRequiredType");
            }
        }

        public bool IsCivicDiplomacyResponse 
        {
            get
            {
                return GetMember<bool>("IsCivicDiplomacyResponse");
            }
        }

        public bool Select()
        {
            return ExecuteMethod("Select");
        }
    }
}
