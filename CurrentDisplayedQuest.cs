using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    /// <summary>
    /// This DataType includes all of the data available to ISXVG that is related to the currently displayed quest in an NPC dialog. 
    /// </summary>
    public class CurrentDisplayedQuest : LavishScriptObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentDisplayedQuest"/> class.
        /// </summary>
        /// <param name="Obj">The obj.</param>
        public CurrentDisplayedQuest(LavishScriptObject Obj) : base(Obj) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentDisplayedQuest"/> class.
        /// </summary>
        public CurrentDisplayedQuest() : base(LavishScript.Objects.GetObject("CurrentDisplayedQuest")) {}

        /// <summary>
        /// Gets this <see cref="CurrentDisplayedQuest"/> as a <see cref="QuestJournalEntry"/>.
        /// </summary>
        /// <returns></returns>
        public QuestJournalEntry ToQuestJournalEntry()
        {
            LavishScriptObject Obj = GetMember("ToQuestJournalEntry");
            return new QuestJournalEntry(Obj);
        }

        /// <summary>
        /// Performs an explicit conversion from <see cref="Vanguard.ISXVG.CurrentDisplayedQuest"/> to <see cref="Vanguard.ISXVG.QuestJournalEntry"/>.
        /// </summary>
        /// <param name="q">The quest to convet from.</param>
        /// <returns>The result of the conversion.</returns>
        public static explicit operator QuestJournalEntry(CurrentDisplayedQuest q)
        {
            return q.ToQuestJournalEntry();
        }

        /// <summary>
        /// Abandons this <see cref="CurrentDisplayedQuest"/>.
        /// </summary>
        /// <returns></returns>
        public bool Abandon()
        {
            return ExecuteMethod("Abandon");
        }

        /// <summary>
        /// Accepts this <see cref="CurrentDisplayedQuest"/>.
        /// </summary>
        /// <returns></returns>
        public bool Accept()
        {
            return ExecuteMethod("Accept");
        }

        /// <summary>
        /// Accepts the reward.
        /// </summary>
        /// <returns></returns>
        public bool AcceptReward()
        {
            return ExecuteMethod("AcceptReward");
        }

        /// <summary>
        /// Completes this <see cref="CurrentDisplayedQuest"/>.
        /// </summary>
        /// <returns></returns>
        public bool Complete()
        {
            return ExecuteMethod("Complete");
        }

        /// <summary>
        /// Declines this <see cref="CurrentDisplayedQuest"/>.
        /// </summary>
        /// <returns></returns>
        public bool Decline()
        {
            return ExecuteMethod("Decline");
        }

        /// <summary>
        /// Shares this <see cref="CurrentDisplayedQuest"/>.
        /// </summary>
        /// <returns></returns>
        public bool Share()
        {
            return ExecuteMethod("Share");
        }

        /// <summary>
        /// Tracks this <see cref="CurrentDisplayedQuest"/>.
        /// </summary>
        /// <returns></returns>
        public bool Track()
        {
            return ExecuteMethod("Track");
        }
    }
}