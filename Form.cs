using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class Form : LavishScriptObject
    {
        public Form(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public Form(string FormName)
            : base(LavishScript.Objects.GetObject("Form", FormName))
        {
        }

        public string Name
        {
            get
            {
                return GetMember<string>("Name");
            }
        }
        public string Description
        {
            get
            {
                return GetMember<string>("Description");
            }
        }

        public void ChangeTo(string FormName)
        {
            LavishScript.ExecuteCommand("Me.Form[" + FormName + "]:ChangeTo");
        }
    }
}
