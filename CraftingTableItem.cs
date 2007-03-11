using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class CraftingTableItem : LavishScriptObject
    {
        public CraftingTableItem(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public CraftingTableItem()
            : base(LavishScript.Objects.GetObject("CraftingTableItem"))
        {
        }
        public string Name
        {
            get
            {
                return GetMember<string>("Name");
            }
        }
        public int Quantity
        {
            get
            {
                return GetMember<int>("Quantity");
            }
        }
        public int IconID
        {
            get
            {
                return GetMember<int>("IconID");
            }
        }
        public int Handle
        {
            get
            {
                return GetMember<int>("Handle");
            }
        }
        public bool RemoveFromTable()
        {
            return ExecuteMethod("RemoveFromTable");
        }
    }
}
