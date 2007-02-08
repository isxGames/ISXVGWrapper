using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class AssemblyRecipe : LavishScriptObject
    {
        public AssemblyRecipe(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public AssemblyRecipe()
            : base(LavishScript.Objects.GetObject("AssemblyRecipe"))
        {
        }

    }
}