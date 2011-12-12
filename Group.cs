using System;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    /// <summary>
    /// This DataType includes all of the data available to ISXVG that is related to groups. 
    /// </summary>
    public class Group : LavishScriptObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Group"/> class.
        /// </summary>
        public Group() : base(LavishScript.Objects.GetObject("Group")) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="Group"/> class.
        /// </summary>
        /// <param name="Copy">The copy.</param>
        public Group(LavishScriptObject Copy) : base(Copy) {}

        /// <summary>
        /// Gets the group leader of this <see cref="Group"/>.
        /// </summary>
        /// <value>The group leader.</value>
        public Pawn GroupLeader
        {
            get
            {
                LavishScriptObject Obj = GetMember("GroupLeader");
                return new Pawn(Obj);
            }
        }

        /// <summary>
        /// Gets the ID of this <see cref="Group"/>.
        /// </summary>
        /// <value>The ID.</value>
        public Int64 ID { get { return GetMember<Int64>("ID"); } }

        /// <summary>
        /// Gets the count of this <see cref="Group"/>.
        /// </summary>
        /// <value>The count.</value>
        public int Count { get { return GetMember<int>("Count"); } }

        /// <summary>
        /// Disbands this <see cref="Group"/>.
        /// </summary>
        /// <returns></returns>
        public bool Disband()
        {
            return ExecuteMethod("Disband");
        }

        /// <summary>
        /// Invites the cancel.
        /// </summary>
        /// <returns></returns>
        public bool InviteCancel()
        {
            return ExecuteMethod("InviteCancel");
        }

        /// <summary>
        /// Invites the decline.
        /// </summary>
        /// <returns></returns>
        public bool InviteDecline()
        {
            return ExecuteMethod("InviteDecline");
        }

        /// <summary>
        /// Leaves this <see cref="Group"/>.
        /// </summary>
        /// <returns></returns>
        public bool Leave()
        {
            return ExecuteMethod("Leave");
        }

        /// <summary>
        /// Passes the on reward being randomed.
        /// </summary>
        /// <returns></returns>
        public bool PassOnRewardBeingRandomed()
        {
            return ExecuteMethod("PassOnRewardBeingRandomed");
        }

        /// <summary>
        /// Closes the random loot invitation.
        /// </summary>
        /// <returns></returns>
        public bool CloseRandomLootInvitation()
        {
            return ExecuteMethod("CloseRandomLootInvitation");
        }

        /// <summary>
        /// Enters the greed on loot being randomed.
        /// </summary>
        /// <returns></returns>
        public bool EnterGreedOnLootBeingRandomed()
        {
            return ExecuteMethod("EnterGreedOnLootBeingRandomed");
        }

        /// <summary>
        /// Enters the need on loot being randomed.
        /// </summary>
        /// <returns></returns>
        public bool EnterNeedOnLootBeingRandomed()
        {
            return ExecuteMethod("EnterNeedOnLootBeingRandomed");
        }

        /// <summary>
        /// Yells for help.
        /// </summary>
        /// <returns></returns>
        public bool YellForHelp()
        {
            return ExecuteMethod("YellForHelp");
        }
    }
}