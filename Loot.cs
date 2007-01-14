using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class Loot
    {
        public Loot()
        {
        }

        private int _numItems;
        public int NumItems
        {
            get
            {
                GetData<int>(ref _numItems, "NumItems");
                return _numItems;
            }
        }

        private Pawn _lootingFrom;
        public Pawn LootingFrom
        {
            get
            {
                _lootingFrom = new Pawn("Loot.LootingFrom",1);
                return _lootingFrom;
            }
        }

        public Item Item(int item)
        {
            return new Item("Loot.Item[" + item + "]");
        }

        public Item Item(string item)
        {
            return new Item("Loot.Item[" + item + "]");
        }

        public void LootAll()
        {
            LavishScript.ExecuteCommand("Loot:LootAll");
        }

        public void EndLooting()
        {
            LavishScript.ExecuteCommand("Loot:EndLooting");
        }

        protected void GetData<T>(ref T obj, string param)
        {
            try
            {
                LavishScript.DataParse<T>("${Loot." + param + "}", ref obj);
            }
            catch
            {

            }
        }
    }
}
