using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class Assembly : LavishScriptObject
    {
        public Assembly(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public Assembly()
            : base(LavishScript.Objects.GetObject("Assembly"))
        {
        }

    }
}