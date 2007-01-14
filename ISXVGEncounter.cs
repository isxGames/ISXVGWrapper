using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class ISXVGEncounter
    {
        public ISXVGEncounter()
        {
        }

        public ISXVGEncounter(string tlo)
        {
            TLO = tlo;
        }

        public ISXVGEncounter(int tlo)
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

        private int _pctHealth;
        public int PctHealth
        {
            get
            {
                GetData<int>(ref _pctHealth, "PctHealth");
                return _pctHealth;
            }
        }

        protected void GetData<T>(ref T obj, string param)
        {
            try
            {
                LavishScript.DataParse<T>("${" + param + ".}", ref obj);
            }
            catch
            {
                InnerSpace.Echo("Exception Raised/n");
            }
        }
    }
}
