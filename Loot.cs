using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class Loot : LavishScriptObject
    {
        public Loot()
            :
            base(LavishScript.Objects.GetObject("Loot"))
        {
        }

        public Loot(LavishScriptPersistentObject Copy)
            :
            base(Copy)
        {
        }

        public int NumItems
        {
            get { return GetMember<int>("NumItems"); }
        }

        public Pawn LootingFrom
        {
            get { return GetMember<Pawn>("LootingFrom"); }
        }

        public Item Item(int item)
        {
            return GetMember<Item>("Item",item.ToString());
        }

        public Item Item(string item)
        {
            return GetMember<Item>("Item",item);
        }

        public bool LootAll
        {
            get { return ExecuteMethod("LootAll"); }
        }

        public bool EndLooting
        {
            get { return ExecuteMethod("EndLooting"); }
        }
    }
}
