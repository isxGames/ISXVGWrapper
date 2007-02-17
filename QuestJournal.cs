using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class QuestJournal : LavishScriptObject
    {
        public QuestJournal(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public QuestJournal()
            : base(LavishScript.Objects.GetObject("QuestJournal"))
        {
        }

        public int EntryCount
        {
            get
            {
                return GetMember<int>("EntryCount");
            }
        }

        public CurrentDisplayedQuest CurrentDisplayed
        {
            get
            {
                LavishScriptObject Obj = GetMember("CurrentDisplayed");
                return new CurrentDisplayedQuest(Obj);
            }
        }

    }

}
