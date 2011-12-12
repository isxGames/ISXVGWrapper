using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class Loot : LavishScriptObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Loot"/> class.
        /// </summary>
        public Loot() : base(LavishScript.Objects.GetObject("Loot")) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="Loot"/> class.
        /// </summary>
        /// <param name="Copy">The copy.</param>
        public Loot(LavishScriptObject Copy) : base(Copy) {}

        public bool IsLooting { get { return IsValid; } }

        /// <summary>
        /// Gets the number of items in the loot window.
        /// </summary>
        /// <value>The num items.</value>
        public int NumItems { get { return GetMember<int>("NumItems"); } }

        /// <summary>
        /// Gets the looting from of this <see cref="Loot"/>.
        /// </summary>
        /// <value>The looting from.</value>
        public Pawn LootingFrom
        {
            get
            {
                LavishScriptObject Obj = GetMember("LootingFrom");
                return new Pawn(Obj);
            }
        }

        /// <summary>
        /// Gets an <see cref="Vanguard.ISXVG.Item"/> at the specified index.
        /// </summary>
        /// <param name="item">The index to get the item at. (1 - <see cref="NumItems"/>)</param>
        /// <returns></returns>
        public Item Item(int item)
        {
            LavishScriptObject Obj = GetMember("Item", item.ToString());
            return new Item(Obj);
        }

        /// <summary>
        /// Gets an <see cref="Vanguard.ISXVG.Item"/> with the specified index from the loot window.
        /// </summary>
        /// <param name="item">The item name to use.</param>
        /// <returns></returns>
        public Item Item(string item)
        {
            LavishScriptObject Obj = GetMember("Item", item);
            return new Item(Obj);
        }

        /// <summary>
        /// Loots all.
        /// </summary>
        /// <returns></returns>
        public bool LootAll()
        {
            return ExecuteMethod("LootAll");
        }

        /// <summary>
        /// Begins the looting.
        /// </summary>
        /// <returns></returns>
        public bool BeginLooting()
        {
            return ExecuteMethod("BeginLooting");
        }

        /// <summary>
        /// Ends the looting.
        /// </summary>
        /// <returns></returns>
        public bool EndLooting()
        {
            return ExecuteMethod("EndLooting");
        }
    }
}