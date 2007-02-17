using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class CraftingWorkOrder : LavishScriptObject
    {
        public CraftingWorkOrder(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public CraftingWorkOrder()
            : base(LavishScript.Objects.GetObject("CraftingWorkOrder"))
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
        /// <summary>
        /// This is only set after you accept
        /// </summary>
        public string IssuedBy
        {
            get
            {
                return GetMember<string>("IssuedBy");
            }
        }
        public string RequestedItems
        {
            get
            {
                return GetMember<string>("RequestedItems");
            }
        }
        public int IconID
        {
            get
            {
                return GetMember<int>("IconID");
            }
        }
        public int ID
        {
            get
            {
                return GetMember<int>("ID");
            }
        }
        public string Difficulty
        {
            get
            {
                return GetMember<string>("Difficulty");
            }
        }
        public string RequiredSkill
        {
            get
            {
                return GetMember<string>("RequiredSkill");
            }
        }

        public bool Select()
        {
            return ExecuteMethod("Select");
        }
        public bool Abandon()
        {
            return ExecuteMethod("Abandon");
        }
        public bool Complete()
        {
            return ExecuteMethod("Complete");
        }

    }
}
