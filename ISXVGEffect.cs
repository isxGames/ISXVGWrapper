using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class ISXVGEffect
    {
        public ISXVGEffect()
        {
        }

        public ISXVGEffect(string tlo)
        {
            TLO = tlo;
        }

        public ISXVGEffect(int tlo)
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

        private string _description;
        public string Description
        {
            get
            {
                GetData<string>(ref _description, "Description");
                return _description;
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
