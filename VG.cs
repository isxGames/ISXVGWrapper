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
        public int LanguageID
        {
            get { return GetMember<int>("LanguageID"); }
        }

        public int LanguageSubtypeID
        {
            get { return GetMember<int>("LanguageSubtypeID"); }
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

        public string Language
        {
            get { return GetMember<string>("Language"); }
        }
        /// <summary>
        /// Vanguards current build
        /// </summary>
        public string Version
        {
            get { return GetMember<string>("Version"); }
        }
        public int ServerID
        {
            get { return GetMember<int>("ServerID"); }
        }

        public bool IsInParlay
        {
            get { return GetMember<bool>("IsInParlay"); }
        }
        public bool IsMinimized
        {
            get { return GetMember<bool>("IsMinimized"); }
        }
        public bool IsMaximized
        {
            get { return GetMember<bool>("IsMaximized"); }
        }
        public bool InFullScreenMode
        {
            get { return GetMember<bool>("InFullScreenMode"); }
        }
        public Actor CheckCollision(float FromX, float FromY, float FromZ, float ToX, float ToY, float ToZ)
        {
            LavishScriptObject Obj = GetMember("CheckCollision", FromX.ToString(), FromY.ToString(), FromZ.ToString(), ToX.ToString(), ToY.ToString(),ToZ.ToString());
            return new Actor(Obj);
        }
        public Actor CheckCollision(float ToX, float ToY, float ToZ)
        {
            LavishScriptObject Obj = GetMember("CheckCollision", ToX.ToString(), ToY.ToString(), ToZ.ToString());
            return new Actor(Obj);
        }
        public string InstallDirectory
        {
            get
            {
                return GetMember<string>("InstallDirectory");
            }
        }

        public bool IsConverting
        {
            get
            {
                return GetMember<bool>("IsConverting");
            }
        }


        public bool ToggleFullScreenMode()
        {
            return ExecuteMethod("ToggleFullScreenMode");
        }
        public bool MaximizeWindow()
        {
            return ExecuteMethod("MaximizeWindow");
        }
        public bool MinimizeWindow()
        {
            return ExecuteMethod("MinimizeWindow");
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

        public bool ConvertItem(int Option)
        {
            return ExecuteMethod("ConvertItem", Option.ToString());
        }

        public bool ConvertItem()
        {
            return ExecuteMethod("ConvertItem");
        }
    }
}