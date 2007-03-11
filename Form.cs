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

        public Form()
            : base(LavishScript.Objects.GetObject("Form"))
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
        public bool IsReady
        {
            get
            {
                return GetMember<bool>("IsReady");
            }
        }
        public bool ChangeTo(params string[] Args)
        {
            return ExecuteMethod("ChangeTo",Args);
        }
    }
}
