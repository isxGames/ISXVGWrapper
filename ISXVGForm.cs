using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class ISXVGForm
    {
        public ISXVGForm()
        {
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

        public void ChangeTo(string changeform)
        {
            LavishScript.ExecuteCommand("Form:ChangeTo[" + changeform + "]");
        }

        protected void GetData<T>(ref T obj, string param)
        {
            LavishScript.DataParse<T>("${VG." + param + "}", ref obj);
        }

    }
}
