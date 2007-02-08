using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class PoI : LavishScriptObject
    {
       
        public PoI(params string[] Args)
            :
            base(LavishScript.Objects.GetObject("PoI",Args))
        {
        }

        public PoI(LavishScriptObject Copy)
            :
            base(Copy)
        {
        }
        public string Name
        {
            get
            {
                return GetMember<string>("Name");
            }
        }

        public int X
        {
            get
            {
                return GetMember<int>("X");
            }
        }

        public int Y
        {
            get
            {
                return GetMember<int>("Y");
            }
        }

        public bool Visible
        {
            get
            {
                return GetMember<bool>("Visible");
            }
        }
        public bool Hide()
        {
            return ExecuteMethod("Hide");
        }

    }

}
