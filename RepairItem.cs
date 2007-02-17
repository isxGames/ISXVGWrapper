using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class RepairItem : LavishScriptObject
    {
        public RepairItem(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public RepairItem()
            : base(LavishScript.Objects.GetObject("RepairItem"))
        {
        }
        /// <summary>
        /// cost in copper
        /// </summary>
        public int RepairCost
        {
            get
            {
                return GetMember<int>("RepairCost");
            }
        }
        public bool Repair()
        {
            return ExecuteMethod("Repair");
        }

    }
}
