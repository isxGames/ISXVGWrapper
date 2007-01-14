using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class ISXVGItem
    {
        public ISXVGItem()
        {
        }

        public ISXVGItem(string tlo)
        {
            TLO = tlo;
        }

        public ISXVGItem(int tlo)
        {
            TLO = tlo.ToString();
        }

        private string _tlo;
        protected string TLO
        {
            get
            {
                return _tlo;
            }
            set
            {
                _tlo = value;
            }
        }

        private int _expertiseCost;
        public int ExpertiseCost
        {
            get
            {
                GetData<int>(ref _expertiseCost, "ExpertiseCost");
                return _expertiseCost;
            }
        }

        public void Loot()
        {
            LavishScript.ExecuteCommand(TLO + ":Loot");
        }

        public void LootNDC()
        {
            LavishScript.ExecuteCommand(TLO + ":Loot[NDC]");
        }

        protected void GetData<T>(ref T obj, string param)
        {
            LavishScript.DataParse<T>("${VG." + param + "}", ref obj);
        }
    }
}
