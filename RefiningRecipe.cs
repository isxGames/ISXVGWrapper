using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class RefiningRecipe : LavishScriptObject
    {
        public RefiningRecipe(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public RefiningRecipe()
            : base(LavishScript.Objects.GetObject("RefiningRecipie"))
        {
        }

        public int ID
        {
            get { return GetMember<int>("ID"); }
        }

        public string Name
        {
            get { return GetMember<string>("Name"); }
        }

        public string Description
        {
            get { return GetMember<string>("Description"); }
        }

        public string Stage1Name
        {
            get { return GetMember<string>("Stage1Name"); }
        }

        public string Stage2Name
        {
            get { return GetMember<string>("Stage2Name"); }
        }

        public string Stage3Name
        {
            get { return GetMember<string>("Stage3Name"); }
        }

        public string Stage4Name
        {
            get { return GetMember<string>("Stage4Name"); }
        }

        public int ActionPointsTotal
        {
            get { return GetMember<int>("ActionPointsTotal"); }
        }

        public float ProgressBarPct
        {
            get { return GetMember<float>("ProgressBarPct"); }
        }

        public int NumUses
        {
            get { return GetMember<int>("NumUses"); }
        }

        public bool IsWorkOrder
        {
            get { return GetMember<bool>("IsWorkOrder"); }
        }

        public bool IsRefining
        {
            get { return GetMember<bool>("IsRefining"); }
        }

        public bool IsFinishing
        {
            get { return GetMember<bool>("IsFinishing"); }
        }

        public int StepCount
        {
            get { return GetMember<int>("StepCount"); }
        }

        public CraftingStep Step(int Arg)
        {
            LavishScriptObject Obj = GetMember("Step", Arg.ToString());
            return new CraftingStep(Obj);
        }

    }
}
