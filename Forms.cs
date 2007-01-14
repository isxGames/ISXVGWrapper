using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class Forms : Wrapper
    {
        public Forms()
        {
        }

        public Forms(string tlo)
        {
            TLO = tlo;
        }

        public Forms(int tlo)
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

        private string _description;
        public string Description
        {
            get
            {
                GetData<string>(ref _description, "Description");
                return _description;
            }
        }

        public void ChangeTo()
        {
            LavishScript.ExecuteCommand(TLO + ":ChangeTo");
        }

        public void ChangeTo(string changeform)
        {
            LavishScript.ExecuteCommand("Form:ChangeTo[" + changeform + "]");
        }
    }
}
