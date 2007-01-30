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

        public Encounter(string EncounterName)
            : base(LavishScript.Objects.GetObject("Encounter", EncounterName))
        {
        }
        public Encounter(int EncounterNumber)
            : base(LavishScript.Objects.GetObject("Encounter", EncounterNumber.ToString()))
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

        public Pawn TargetOfTarget
        {
            get
            {
                return GetMember<Pawn>("TargetOfTarget");
            }
        }
    }
}
