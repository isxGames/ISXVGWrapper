using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class CraftingStep : LavishScriptObject
    {
        public CraftingStep(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public CraftingStep()
            : base(LavishScript.Objects.GetObject("CraftingStep"))
        {
        }

        public int TypeID
        {
            get
            {
                return GetMember<int>("TypeID");
            }
        }
        public string Name
        {
            get { return GetMember<string>("Name"); }
        }

        public string Description
        {
            get { return GetMember<string>("Description"); }
        }

        public int AvailActionsCount
        {
            get { return GetMember<int>("AvailActionsCount"); }
        }

        public CraftingAction AvailAction(int Arg)
        {
            LavishScriptObject Obj = GetMember("AvailAction", Arg.ToString());
            return new CraftingAction(Obj);
        }
        public CraftingStage InStage()
        {
            LavishScriptObject Obj = GetMember("InStage");
            return new CraftingStage(Obj);
        }

    }

}
