using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class QuestRewardGroup : LavishScriptObject
    {
        public QuestRewardGroup(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public QuestRewardGroup()
            : base(LavishScript.Objects.GetObject("QuestRewardGroup"))
        {
        }

        public int RewardCount
        {
            get
            {
                return GetMember<int>("RewardCount");
            }
        }
        public QuestReward Reward(int Index)
        {
            LavishScriptObject Obj = GetMember("Reward", Index.ToString());
            return new QuestReward(Obj);
        }
    }
}
