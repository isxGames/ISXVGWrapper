using System;
using System.Collections.Generic;
using System.Text;
using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class Group : LavishScriptObject
    {
        public Group()
            :
            base(LavishScript.Objects.GetObject("Group"))
        {
        }

        public Group(LavishScriptObject Copy)
            :
            base(Copy)
        {
        }

        public Pawn GroupLeader
        {
            get
            {
                LavishScriptObject Obj = GetMember("GroupLeader");
                return new Pawn(Obj);
            }
        }

        public Int64 ID
        {
            get { return GetMember<Int64>("ID"); }
        }

        public int Count
        {
            get { return GetMember<int>("Count"); }
        }

        public bool Disband()
        {
            return ExecuteMethod("Disband");
        }

        public bool InviteCancel()
        {
            return ExecuteMethod("InviteCancel");
        }

        public bool InviteDecline()
        {
            return ExecuteMethod("InviteDecline");
        }

        public bool Leave()
        {
            return ExecuteMethod("Leave");
        }

        public bool PassOnRewardBeingRandomed()
        {
            return ExecuteMethod("PassOnRewardBeingRandomed");
        }

        public bool CloseRandomLootInvitation()
        {
            return ExecuteMethod("CloseRandomLootInvitation");
        }

        public bool EnterGreedOnLootBeingRandomed()
        {
            return ExecuteMethod("EnterGreedOnLootBeingRandomed");
        }

        public bool EnterNeedOnLootBeingRandomed()
        {
            return ExecuteMethod("EnterNeedOnLootBeingRandomed");
        }

        public bool YellForHelp()
        {
            return ExecuteMethod("YellForHelp");
        }
    }

}
