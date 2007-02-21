using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class Encounter : LavishScriptObject
    {
        public Encounter(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public Encounter()
            : base(LavishScript.Objects.GetObject("Encounter"))
        {
        }


        public string Name
        {
            get
            {
                return GetMember<string>("Name");
            }
        }

        public int PctHealth
        {
            get
            {
                return GetMember<int>("PctHealth");
            }
        }

        public int Distance
        {
            get
            {
                return GetMember<int>("Distance");
            }
        }

        public int Level
        {
            get
            {
                return GetMember<int>("Level");
            }
        }

        public int Difficulty
        {
            get
            {
                return GetMember<int>("Difficulty");
            }
        }

        public Pawn ToPawn
        {
            get
            {
                LavishScriptObject Obj = GetMember("ToPawn");
                return new Pawn(Obj);
            }
        }

        public Pawn TargetOfTarget
        {
            get
            {
                LavishScriptObject Obj = GetMember("TargetOfTarget");
                return new Pawn(Obj);
            }
        }
    }
}
