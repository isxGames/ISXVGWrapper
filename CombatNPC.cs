using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class CombatNPC : LavishScriptObject
    {
        public CombatNPC(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public CombatNPC()
            : base(LavishScript.Objects.GetObject("CombatNPC"))
        {
        }


        public string Name
        {
            get
            {
                return GetMember<string>("Name");
            }
        }

        public float PctHealth
        {
            get
            {
                return GetMember<float>("PctHealth");
            }
        }
        /// <summary>
        /// alias for PctHealth
        /// </summary>
        public float Health
        {
            get
            {
                return GetMember<float>("Health");
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

        public string Target
        {
            get
            {
                return GetMember<string>("Target");
            }
        }
        public Int64 ID
        {
            get
            {
                return GetMember<Int64>("ID");
            }
        }
    }
}
