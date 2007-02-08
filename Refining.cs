using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class Refining : LavishScriptObject
    {
        public Refining(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public Refining()
            : base(LavishScript.Objects.GetObject("Refining"))
        {
        }

        public bool InRecovery
        {
            get
            {
                return GetMember<bool>("InRecovery");
            }
        }

        public float Recovery
        {
            get
            {
                return GetMember<float>("Recovery");
            }
        }

        public int State
        {
            get
            {
                return GetMember<int>("State");
            }
        }

        public CraftingStage Stage()
        {
            LavishScriptObject Obj = GetMember("Stage");
            return new CraftingStage(Obj);
        }

        public int OrigActionPointsAvail
        {
            get
            {
                return GetMember<int>("OrigActionPointsAvail");
            }
        }

        public RefiningRecipe CurrentRecipe()
        {
            LavishScriptObject Obj = GetMember("CurrentRecipe");
            return new RefiningRecipe(Obj);
        }

        public int ActionPointsUsed
        {
            get
            {
                return GetMember<int>("ActionPointsUsed");
            }
        }

        public int UseableItemCount
        {
            get
            {
                return GetMember<int>("UseableItemCount");
            }
        }

        public Item UseableItem(int Arg)
        {
            LavishScriptObject Obj = GetMember("UseableItem", Arg.ToString());
            return new Item(Obj);
        }

        public int Quality
        {
            get
            {
                return GetMember<int>("Quality");
            }
        }

        public bool IsSetupComplete
        {
            get
            {
                return GetMember<bool>("IsSetupComplete");
            }
        }

        public int ComplicationCount
        {
            get
            {
                return GetMember<int>("ComplicationCount");
            }
        }

        public Complication Complication(int Arg)
        {
            LavishScriptObject Obj = GetMember("Complication", Arg.ToString());
            return new Complication(Obj);
        }

        public int CorrectionCount
        {
            get
            {
                return GetMember<int>("CorrectionCount");
            }
        }

        public Correction Correction(int Arg)
        {
            LavishScriptObject Obj = GetMember("Correction", Arg.ToString());
            return new Correction(Obj);
        }

        public bool Begin()
        {
            return ExecuteMethod("Begin");
        }

        public bool SetRecipe(int Arg)
        {
            return ExecuteMethod("SetRecipe", Arg.ToString());
        }

        public bool DoSetup()
        {
            return ExecuteMethod("DoSetup");
        }

        public bool Start()
        {
            return ExecuteMethod("Start");
        }

        public bool Cancel()
        {
            return ExecuteMethod("Cancel");
        }

        public bool End()
        {
            return ExecuteMethod("End");
        }

    }

}