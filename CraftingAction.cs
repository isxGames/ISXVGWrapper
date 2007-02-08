using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class CraftingAction : LavishScriptObject
    {
        public CraftingAction(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public CraftingAction()
            : base(LavishScript.Objects.GetObject("CraftingAction"))
        {
        }

        public string Name
        {
            get { return GetMember<string>("Name"); }
        }

        public string Description
        {
            get { return GetMember<string>("Description"); }
        }

        public int ActionPointCost
        {
            get { return GetMember<int>("ActionPointCost"); }
        }

        public bool Use()
        {
            return ExecuteMethod("Use");
        }

    }
}