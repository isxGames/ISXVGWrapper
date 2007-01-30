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

        public ItemModifier(string ItemModifierName)
            : base(LavishScript.Objects.GetObject("ItemModifier", ItemModifierName))
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
