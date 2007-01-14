using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class Effect : Wrapper
    {
        public Effect()
        {
        }

        public Effect(string args)
        {
            Args = args;
        }

        public Effect(int args)
        {
            Args = args.ToString();
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

        private string _duration;
        public string Duration
        {
            get
            {
                GetData<string>(ref _duration, "Duration");
                return _duration;
            }
        }

        private string _timeRemaining;
        public string TimeRemaining
        {
            get
            {
                GetData<string>(ref _timeRemaining, "TimeRemaining");
                return _timeRemaining;
            }
        }
    }
}
