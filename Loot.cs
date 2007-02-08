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
            get
            {
                LavishScriptPersistentObject Obj = GetPersistentMember("LootingFrom");
                return new Pawn(Obj);
            }
        }

        public Item Item(int item)
        {
            LavishScriptObject Obj = GetMember("Item", item.ToString());
            return new Item(Obj);
        }

        public Item Item(string item)
        {
            LavishScriptObject Obj = GetMember("Item", item);
            return new Item(Obj);
        }

        public bool LootAll()
        {
            return ExecuteMethod("LootAll");
        }

        public bool EndLooting
        {
            get { return ExecuteMethod("EndLooting"); }
        }
    }
}
