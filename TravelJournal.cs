using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class TravelJournal : LavishScriptObject
    {
        public TravelJournal(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public TravelJournal()
            : base(LavishScript.Objects.GetObject("TravelJournal"))
        {
        }

        public int EntryCount
        {
            get
            {
                return GetMember<int>("EntryCount");
            }
        }

        public TravelJournalEntry CurrentlyTracking()
        {
            LavishScriptObject Obj = GetMember("CurrentlyTracking");
            return new TravelJournalEntry(Obj);
        }
        public bool StopTracking()
        {
            return ExecuteMethod("StopTracking");
        }

    }
}
