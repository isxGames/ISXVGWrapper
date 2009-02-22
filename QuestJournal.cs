using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    /// <summary>
    /// 
    /// </summary>
    public class QuestJournal : LavishScriptObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuestJournal"/> class.
        /// </summary>
        /// <param name="Obj">The obj.</param>
        public QuestJournal(LavishScriptObject Obj)
            : base(Obj) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="QuestJournal"/> class.
        /// </summary>
        public QuestJournal()
            : base(LavishScript.Objects.GetObject("QuestJournal")) {}

        /// <summary>
        /// Gets the entry count of this <see cref="QuestJournal"/>.
        /// </summary>
        /// <value>The entry count.</value>
        public int EntryCount { get { return GetMember<int>("EntryCount"); } }

        /// <summary>
        /// Gets the current displayed of this <see cref="QuestJournal"/>.
        /// </summary>
        /// <value>The current displayed.</value>
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