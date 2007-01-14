using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class VGLoc : Wrapper
    {
        public VGLoc()
        {
        }

        public VGLoc(string args)
        {
            Args = "VGLoc[" + args + "]";
        }

        public VGLoc(string args, int unused)
        {
            Args = args;
        }
    }
}
