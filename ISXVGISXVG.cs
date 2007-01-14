using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class ISXVGISXVG
    {
        public ISXVGISXVG()
        {
        }

        private int _numRadars;
        public int NumRadars
        {
            get
            {
                GetData<int>(ref _numRadars, "NumRadars");
                return _numRadars;
            }
        }

        private string _version;
        public string Version
        {
            get
            {
                GetData<string>(ref _version, "Version");
                return _version;
            }
        }

        protected void GetData<T>(ref T obj, string param)
        {
            try
            {
                LavishScript.DataParse<T>("${ISXVG." + param + "}", ref obj);
            }
            catch
            {
                InnerSpace.Echo("Exception Raised");
            }
        }
    }
}
