using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class CraftingTaskMaster : LavishScriptObject
    {
        public CraftingTaskMaster(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public CraftingTaskMaster()
            : base(LavishScript.Objects.GetObject("CraftingTaskMaster"))
        {
        }
        public int AvailWorkOrderCount
        {
            get
            {
                return GetMember<int>("AvailWorkOrderCount");
            }
        }

        public CraftingWorkOrder AvailWorkOrder(string Name)
        {
            LavishScriptObject Obj = GetMember("AvailWorkOrder", Name);
            return new CraftingWorkOrder(Obj);
        }

        public CraftingWorkOrder AvailWorkOrder(int Index)
        {
            LavishScriptObject Obj = GetMember("AvailWorkOrder", Index.ToString());
            return new CraftingWorkOrder(Obj);
        }

        public int CurrentWorkOrderCount
        {
            get
            {
                return GetMember<int>("CurrentWorkOrderCount");
            }
        }

        public CraftingWorkOrder CurrentWorkOrder()
        {
            LavishScriptObject Obj = GetMember("CurrentWorkOrder");
            return new CraftingWorkOrder(Obj);
        }

        public CraftingWorkOrder CurrentWorkOrder(string Name)
        {
            LavishScriptObject Obj = GetMember("CurrentWorkOrder", Name);
            return new CraftingWorkOrder(Obj);
        }

        public CraftingWorkOrder CurrentWorkOrder(int Index)
        {
            LavishScriptObject Obj = GetMember("CurrentWorkOrder", Index.ToString());
            return new CraftingWorkOrder(Obj);
        }
        public bool InTransaction
        {
            get
            {
                return GetMember<bool>("InTransaction");
            }
        }
        public bool Begin()
        {
            return ExecuteMethod("Begin");
        }

        public bool End()
        {
            return ExecuteMethod("End");
        }

    }
}
