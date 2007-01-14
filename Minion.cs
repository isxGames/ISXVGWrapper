using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class Minion : Wrapper
    {
        public Minion()
        {
        }

        public Minion(string tlo)
        {
            TLO = tlo;
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
    }
}
