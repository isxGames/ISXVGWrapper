using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class Effect : LavishScriptObject
    {
        public Effect(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public Effect()
            : base(LavishScript.Objects.GetObject("Effect"))
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

        public string Duration
        {
            get
            {
                return GetMember<string>("Duration");
            }
        }

        public string TimeRemaining
        {
            get
            {
                return GetMember<string>("TimeRemaining");
            }
        }

        public bool IsVisibleOnUI
        {
            get
            {
                return GetMember<bool>("IsVisibleOnUI");
            }
        }

        public bool IsBeneficial
        {
            get
            {
                return GetMember<bool>("IsBeneficial");
            }
        }

        public bool IsDetrimental
        {
            get
            {
                return GetMember<bool>("IsDetrimental");
            }
        }

        public bool Cancel()
        {
            return ExecuteMethod("Cancel");
        }

        public bool Remove()
        {
            return ExecuteMethod("Remove");
        }
    }
}
