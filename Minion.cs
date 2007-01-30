using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class Minion : LavishScriptObject
    {
        public Minion(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public Minion(string MinionName)
            : base(LavishScript.Objects.GetObject("Minion", MinionName))
        {
        }

        public string Name
        {
            get
            {
                return GetMember<string>("Name");
            }
        }

        public float Health
        {
            get
            {
                return GetMember<float>("Health");
            }
        }

        public float TotalTime
        {
            get
            {
                return GetMember<float>("TotalTime");
            }
        }

        public float TimeRemaining
        {
            get
            {
                return GetMember<float>("TimeRemaining");
            }
        }
    }
}
