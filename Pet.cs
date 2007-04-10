using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class Pet : LavishScriptObject
    {
        public Pet(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public Pet()
            : base(LavishScript.Objects.GetObject("Pet"))
        {
        }

        public string Name
        {
            get
            {
                return GetMember<string>("Name");
            }
        }
        public Int64 ID
        {
            get
            {
                return GetMember<Int64>("ID");
            }
        }
        public float Health
        {
            get
            {
                return GetMember<float>("Health");
            }
        }
        public PetAbility DefaultAbility()
        {
            LavishScriptObject Obj = GetMember("DefaultAbility");
            return new PetAbility(Obj);
        }
        public Pawn ToPawn()
        {
            LavishScriptPersistentObject Obj = GetPersistentMember("ToPawn");
            return new Pawn(Obj);
        }
        public int AbilityCount
        {
            get
            {
                return GetMember<int>("AbilityCount");
            }
        }
        public int Ability()
        {
            return GetMember<int>("Ability");
        }
        public PetAbility Ability(int Arg)
        {
            LavishScriptObject Obj = GetMember("Ability", Arg.ToString());
            return new PetAbility(Obj);
        }
        public PetAbility Ability(string Arg)
        {
            LavishScriptObject Obj = GetMember("Ability", Arg);
            return new PetAbility(Obj);
        }
    }
}
