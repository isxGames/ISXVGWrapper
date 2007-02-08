using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class Correction : LavishScriptObject
    {
        public Correction(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public Correction()
            : base(LavishScript.Objects.GetObject("Correction"))
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

        public int AvailableActionsCount
        {
            get { return GetMember<int>("AvailableActionsCount"); }
        }

        public CraftingAction AvailAction(int Arg)
        {
            LavishScriptObject Obj = GetMember("AvailAction", Arg.ToString());
            return new CraftingAction(Obj);
        }
    }
}