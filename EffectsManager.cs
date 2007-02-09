using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class EffectsManager : LavishScriptObject
    {
        public EffectsManager(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public EffectsManager()
            : base(LavishScript.Objects.GetObject("EffectsManager"))
        {
        }

        public int Count
        {
            get { return GetMember<int>("Count"); }
        }
    }
}
