using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class TargetEffect : LavishScriptObject
    {
        public TargetEffect(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public TargetEffect()
            : base(LavishScript.Objects.GetObject("TargetEffect"))
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

        public string TimeRemaining
        {
            get
            {
                return GetMember<string>("TimeRemaining");
            }
        }
    }
}
