using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    /// <summary>
    /// 
    /// </summary>
    public class QuestJournalEntry : LavishScriptObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuestJournalEntry"/> class.
        /// </summary>
        /// <param name="Obj">The obj.</param>
        public QuestJournalEntry(LavishScriptObject Obj)
            : base(Obj) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="QuestJournalEntry"/> class.
        /// </summary>
        public QuestJournalEntry()
            : base(LavishScript.Objects.GetObject("QuestJournalEntry")) {}

        /// <summary>
        /// Gets the name of this <see cref="QuestJournalEntry"/>.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get { return GetMember<string>("Name"); } }

        /// <summary>
        /// Gets the desription of this <see cref="QuestJournalEntry"/>.
        /// </summary>
        /// <value>The desription.</value>
        public string Desription { get { return GetMember<string>("Description"); } }

        /// <summary>
        /// Gets the objectives of this <see cref="QuestJournalEntry"/>.
        /// </summary>
        /// <value>The objectives.</value>
        public string Objectives { get { return GetMember<string>("Objectives"); } }

        /// <summary>
        /// Gets the objectives short of this <see cref="QuestJournalEntry"/>.
        /// </summary>
        /// <value>The objectives short.</value>
        public string ObjectivesShort { get { return GetMember<string>("ObjectivesShort"); } }

        /// <summary>
        /// Gets the coin reward of this <see cref="QuestJournalEntry"/>.
        /// </summary>
        /// <value>The coin reward.</value>
        public int CoinReward { get { return GetMember<int>("CoinReward"); } }

        /// <summary>
        /// Gets the status of this <see cref="QuestJournalEntry"/>.
        /// </summary>
        /// <value>The status.</value>
        public int Status { get { return GetMember<int>("Status"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="QuestJournalEntry"/> is tracking.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="QuestJournalEntry"/> is tracking; otherwise, <c>false</c>.
        /// </value>
        public bool IsTracking { get { return GetMember<bool>("IsTracking"); } }

        /// <summary>
        /// Gets the end location of this <see cref="QuestJournalEntry"/>.
        /// </summary>
        /// <value>The end location.</value>
        public TravelJournalEntry EndLocation
        {
            get
            {
                LavishScriptObject Obj = GetMember("EndLocation");
                return new TravelJournalEntry(Obj);
            }
        }

        /// <summary>
        /// Gets the waypoint count of this <see cref="QuestJournalEntry"/>.
        /// </summary>
        /// <value>The waypoint count.</value>
        public int WaypointCount { get { return GetMember<int>("WaypointCount"); } }

        /// <summary>
        /// Gets the reward group count of this <see cref="QuestJournalEntry"/>.
        /// </summary>
        /// <value>The reward group count.</value>
        public int RewardGroupCount { get { return GetMember<int>("RewardGroupCount"); } }

        /// <summary>
        /// Waypoints the specified name.
        /// </summary>
        /// <param name="Name">The name.</param>
        /// <returns></returns>
        public TravelJournalEntry Waypoint(string Name)
        {
            LavishScriptObject Obj = GetMember("Waypoint", Name);
            return new TravelJournalEntry(Obj);
        }

        /// <summary>
        /// Waypoints the specified index.
        /// </summary>
        /// <param name="Index">The index.</param>
        /// <returns></returns>
        public TravelJournalEntry Waypoint(int Index)
        {
            LavishScriptObject Obj = GetMember("Waypoint", Index.ToString());
            return new TravelJournalEntry(Obj);
        }

        /// <summary>
        /// Rewards the group.
        /// </summary>
        /// <param name="Index">The index.</param>
        /// <returns></returns>
        public QuestRewardGroup RewardGroup(int Index)
        {
            LavishScriptObject Obj = GetMember("RewardGroup", Index.ToString());
            return new QuestRewardGroup(Obj);
        }

        /// <summary>
        /// Tracks this <see cref="QuestJournalEntry"/>.
        /// </summary>
        /// <returns></returns>
        public bool Track()
        {
            return ExecuteMethod("Track");
        }

        /// <summary>
        /// Selects this <see cref="QuestJournalEntry"/>.
        /// </summary>
        /// <returns></returns>
        public bool Select()
        {
            return ExecuteMethod("Select");
        }
    }
}