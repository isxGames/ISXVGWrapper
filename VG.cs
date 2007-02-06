using System;
using System.Collections.Generic;
using InnerSpaceAPI;

using LavishVMAPI; // allows using LavishVMAPI.LavishVM.GetAPI without explicitly specifying LavishVMAPI
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class VG : LavishScriptPersistentObject
    {
        public VG()
            :
            base(LavishScript.Objects.GetPersistentObject("VG"))
        {
        }

        public VG(LavishScriptPersistentObject Copy)
            :
            base(Copy)
        {
        }

        public int PawnCount
        {
            get { return GetMember<int>("PawnCount"); }
        }

        public bool IsSwimming
        {
            get { return GetMember<bool>("IsSwimming"); }
        }

        public bool InGlobalRecovery
        {
            get { return GetMember<bool>("InGlobalRecovery"); }
        }
        
        public float GlobalRecovery
        {
            get { return GetMember<float>("GlobalRecovery"); }
        }

        public string GroupInviteSender
        {
            get { return GetMember<string>("GroupInviteSender"); }
        }

        public int ServerID
        {
            get { return GetMember<int>("ServerID"); }
        }

        public bool IsInParlay
        {
            get { return GetMember<bool>("IsInParlay"); }
        }

        public bool ExecBinding(string Action)
        {
            return ExecuteMethod("ExecBinding", Action);
        }

        public bool ExecBinding(string Action, bool Release)
        {
            if (Release)
            {
                return ExecuteMethod("ExecBinding", Action , "Release");
                
            }
            else
                return ExecuteMethod("ExecBinding", Action);
        }

    }
}