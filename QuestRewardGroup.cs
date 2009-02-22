using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    /// <summary>
    /// 
    /// </summary>
    public class QuestRewardGroup : LavishScriptObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuestRewardGroup"/> class.
        /// </summary>
        /// <param name="Obj">The obj.</param>
        public QuestRewardGroup(LavishScriptObject Obj)
            : base(Obj) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="QuestRewardGroup"/> class.
        /// </summary>
        public QuestRewardGroup()
            : base(LavishScript.Objects.GetObject("QuestRewardGroup")) {}

        /// <summary>
        /// Gets the reward count of this <see cref="QuestRewardGroup"/>.
        /// </summary>
        /// <value>The reward count.</value>
        public int RewardCount { get { return GetMember<int>("RewardCount"); } }

        /// <summary>
        /// Rewards the specified index.
        /// </summary>
        /// <param name="Index">The index.</param>
        /// <returns></returns>
        public QuestReward Reward(int Index)
        {
            LavishScriptObject Obj = GetMember("Reward", Index.ToString());
            return new QuestReward(Obj);
        }
    }
}