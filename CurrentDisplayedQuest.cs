using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class CurrentDisplayedQuest : LavishScriptObject
    {
        public CurrentDisplayedQuest(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public CurrentDisplayedQuest()
            : base(LavishScript.Objects.GetObject("CurrentDisplayedQuest"))
        {
        }

        public QuestJournalEntry ToQuestJournalEntry()
        {
            LavishScriptObject Obj = GetMember("ToQuestJournalEntry");
            return new QuestJournalEntry(Obj);
        }
        public bool Abandon()
        {
            return ExecuteMethod("Abandon");
        }
        public bool Accept()
        {
            return ExecuteMethod("Accept");
        }
        public bool AcceptReward()
        {
            return ExecuteMethod("AcceptReward");
        }
        public bool Complete()
        {
            return ExecuteMethod("Complete");
        }
        public bool Decline()
        {
            return ExecuteMethod("Decline");
        }
        public bool Share()
        {
            return ExecuteMethod("Share");
        }
        public bool Track()
        {
            return ExecuteMethod("Track");
        }

    }
}
