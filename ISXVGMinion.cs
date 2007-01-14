using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class ISXVGMinion
    {
        public ISXVGMinion()
        {
        }

        public ISXVGMinion(string tlo)
        {
            TLO = tlo;
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

        private float _health;
        public float Health
        {
            get
            {
                GetData<float>(ref _health, "Health");
                return _health;
            }
        }

        private float _totalTime;
        public float TotalTime
        {
            get
            {
                GetData<float>(ref _totalTime, "TotalTime");
                return _totalTime;
            }
        }

        private float _timeRemaining;
        public float TimeRemaining
        {
            get
            {
                GetData<float>(ref _timeRemaining, "TimeRemaining");
                return _timeRemaining;
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
