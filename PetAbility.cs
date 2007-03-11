using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class PetAbility : LavishScriptObject
    {
        public PetAbility(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public PetAbility()
            : base(LavishScript.Objects.GetObject("PetAbility"))
        {
        }
        public string Name
        {
            get
            {
                return GetMember<string>("Name");
            }
        }
        public string Description
        {
            get
            {
                return GetMember<string>("Description");
            }
        }
        public bool IsReady
        {
            get
            {
                return GetMember<bool>("IsReady");
            }
        }
        public float RecoveryTime
        {
            get
            {
                return GetMember<float>("RecoveryTime");
            }
        }
        public int IconID
        {
            get
            {
                return GetMember<int>("IconID");
            }
        }
        public int Type
        {
            get
            {
                return GetMember<int>("Type");
            }
        }
        public bool Use()
        {
            return ExecuteMethod("Use");
        }
        public bool MakeDefault()
        {
            return ExecuteMethod("MakeDefault");
        }

    }
}
