using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class CraftingStage : LavishScriptObject
    {
        public CraftingStage(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public CraftingStage()
            : base(LavishScript.Objects.GetObject("CraftingStep"))
        {
        }

        public string Name
        {
            get
            {
                return GetMember<string>("Name");
            }
        }

        public int Index
        {
            get
            {
                return GetMember<int>("Index");
            }
        }

        public int StepCount
        {
            get
            {
                return GetMember<int>("StepCount");
            }
        }

        public CraftingStep Step(int Index)
        {
            LavishScriptObject Obj = GetMember("Step", Index.ToString());
            return new CraftingStep(Obj);
        }
    }
}
