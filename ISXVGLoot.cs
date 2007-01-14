using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class ISXVGLoot
    {
        public ISXVGLoot()
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

        private ISXVGPawn _lootingFrom;
        public ISXVGPawn LootingFrom
        {
            get
            {
                _lootingFrom = new ISXVGPawn("Loot.LootingFrom");
                return _lootingFrom;
            }
        }

        public ISXVGItem Item(int item)
        {
            return new ISXVGItem("Loot.Item[" + item + "]");
        }

        public ISXVGItem Item(string item)
        {
            return new ISXVGItem("Loot.Item[" + item + "]");
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
