using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class GV : LavishScriptObject
    {
        public GV(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public GV(params string[] Args)
            : base(LavishScript.Objects.GetObject("GV", Args))
        {
        }

    }
}