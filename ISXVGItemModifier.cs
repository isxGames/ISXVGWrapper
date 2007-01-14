using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class ISXVGItemModifier
    {
        public ISXVGItemModifier()
        {
        }

        public ISXVGItemModifier(string tlo)
        {
            TLO = tlo;
        }

        public ISXVGItemModifier(int tlo)
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

        protected void GetData<T>(ref T obj, string param)
        {
            try
            {
                LavishScript.DataParse<T>("${" + TLO + "." + param + "}", ref obj);
            }
            catch
            {
                InnerSpace.Echo("Exception Raised");
            }
        }
    }
}
