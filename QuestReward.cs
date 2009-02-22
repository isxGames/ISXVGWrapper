using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    /// <summary>
    /// 
    /// </summary>
    public class QuestReward : LavishScriptObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuestReward"/> class.
        /// </summary>
        /// <param name="Obj">The obj.</param>
        public QuestReward(LavishScriptObject Obj)
            : base(Obj) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="QuestReward"/> class.
        /// </summary>
        public QuestReward()
            : base(LavishScript.Objects.GetObject("QuestReward")) {}

        /// <summary>
        /// Toes the item.
        /// </summary>
        /// <returns></returns>
        public Item ToItem()
        {
            LavishScriptObject Obj = GetMember("ToItem");
            return new Item(Obj);
        }

        /// <summary>
        /// Selects this <see cref="QuestReward"/>.
        /// </summary>
        /// <returns></returns>
        public bool Select()
        {
            return ExecuteMethod("Select");
        }
    }
}