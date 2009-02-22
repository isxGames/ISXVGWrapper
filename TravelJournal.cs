using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    /// <summary>
    /// 
    /// </summary>
    public class TravelJournal : LavishScriptObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TravelJournal"/> class.
        /// </summary>
        /// <param name="Obj">The obj.</param>
        public TravelJournal(LavishScriptObject Obj)
            : base(Obj) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="TravelJournal"/> class.
        /// </summary>
        public TravelJournal()
            : base(LavishScript.Objects.GetObject("TravelJournal")) {}

        /// <summary>
        /// Gets the entry count of this <see cref="TravelJournal"/>.
        /// </summary>
        /// <value>The entry count.</value>
        public int EntryCount { get { return GetMember<int>("EntryCount"); } }

        /// <summary>
        /// Currentlies the tracking.
        /// </summary>
        /// <returns></returns>
        public TravelJournalEntry CurrentlyTracking()
        {
            LavishScriptObject Obj = GetMember("CurrentlyTracking");
            return new TravelJournalEntry(Obj);
        }

        /// <summary>
        /// Stops the tracking.
        /// </summary>
        /// <returns></returns>
        public bool StopTracking()
        {
            return ExecuteMethod("StopTracking");
        }
    }
}