using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class Complication : LavishScriptObject
    {
        public Complication(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public Complication()
            : base(LavishScript.Objects.GetObject("Complication"))
        {
        }

        public string Name
        {
            get { return GetMember<string>("Name"); }
        }

        public string Description
        {
            get { return GetMember<string>("Description"); }
        }
    }
}