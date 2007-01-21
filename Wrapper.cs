using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class Wrapper
    {
        public Wrapper()
        {
        }

        private string _args;
        protected string Args
        {
            get
            {
                return _args;
            }
            set
            {
                _args = value;
            }
        }

        protected void GetData<T>(ref T obj, string param)
        {
            try
            {
                LavishScript.DataParse<T>("${" + Args + "." + param + "}", ref obj);
            }
            catch
            {
                InnerSpace.Echo("[DEBUG]Object does not Exist or returned NULL for: ${" + Args + "." + param + "}");
            }
        }
    }
}
