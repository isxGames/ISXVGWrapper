using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class QuestReward : LavishScriptObject
    {
        public QuestReward(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public QuestReward()
            : base(LavishScript.Objects.GetObject("QuestReward"))
        {
        }

        public Item ToItem()
        {
            LavishScriptObject Obj = GetMember("ToItem");
            return new Item(Obj);
        }
        public bool Select()
        {
            return ExecuteMethod("Select");
        }

    }
}
