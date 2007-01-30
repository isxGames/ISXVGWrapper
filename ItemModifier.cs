using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class ItemModifier : LavishScriptObject
    {
        public ItemModifier(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public ItemModifier()
            : base(LavishScript.Objects.GetObject("ItemModifier"))
        {
        }

        public string Name
        {
            get
            {
                return GetMember<string>("Name");
            }
        }

        public int CurrentMod
        {
            get
            {
                return GetMember<int>("CurrentMod");
            }
        }

        public int MaxMod
        {
            get
            {
                return GetMember<int>("MaxMod");
            }
        }
    }
}
