using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class ItemModifier : Wrapper
    {
        public ItemModifier()
        {
        }

        public ItemModifier(string tlo)
        {
            TLO = tlo;
        }

        public ItemModifier(int tlo)
        {
            TLO = tlo.ToString();
        }

        private string _name;
        public string Name
        {
            get
            {
                GetData<string>(ref _name, "Name");
                return _name;
            }
        }

        private int _currentMod;
        public int CurrentMod
        {
            get
            {
                GetData<int>(ref _currentMod, "CurrentMod");
                return _currentMod;
            }
        }

        private int _maxMod;
        public int MaxMod
        {
            get
            {
                GetData<int>(ref _maxMod, "MaxMod");
                return _maxMod;
            }
        }
    }
}
