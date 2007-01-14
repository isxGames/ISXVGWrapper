using System;
using System.Text;
using System.Runtime.InteropServices;

using InnerSpaceAPI;
using LavishScriptAPI;
using LavishVMAPI;

namespace Vanguard.ISXVG
{
    namespace Delegates
    {
        public delegate uint GetVGEventID(string EventName);
    }

    public class Extension
    {
        public static Vanguard.ISXVG.Delegates.GetVGEventID GetVGEventID = Stubs.GetVGEventID;

        internal class Stubs
        {
            static public uint GetVGEventID(string EventName)
            {
                IntPtr Address = LavishVM.GetAPI("ISXVGAPI", "GetVGEventID", 1);
                if (Address.ToInt32() == 0)
                    return 0;
                Extension.GetVGEventID = (Vanguard.ISXVG.Delegates.GetVGEventID)Marshal.GetDelegateForFunctionPointer(Address, typeof(Vanguard.ISXVG.Delegates.GetVGEventID));
                return Extension.GetVGEventID(EventName);
            }
        }

        public Extension()
        {
        }

        public Extension(string tlo)
        {
            TLO = tlo;
        }

        public Pawn Pawn(string pawn)
        {
            return new Pawn("Pawn[" + pawn + "]",1);
        }

        public Radar Radar()
        {
            return new Radar();
        }

        public Radar Radar(string radar)
        {
            return new Radar("Radar[" + radar + "]");
        }

        public void VGExecute(string Command)
        {
            LavishScript.ExecuteCommand("VGExecute " + Command);
        }

        public void VGEcho(string Args)
        {
            LavishScript.ExecuteCommand("VGEcho " + Args);
        }

        public void Target()
        {
            LavishScript.ExecuteCommand("Target");
        }

        public void Target(string Args)
        {
            LavishScript.ExecuteCommand("Target " + Args);
        }

        public void Face()
        {
            LavishScript.ExecuteCommand("Face");
        }

        public void Face(string Args)
        {
            LavishScript.ExecuteCommand("Face " + Args);
        }

        public void Where()
        {
            LavishScript.ExecuteCommand("Where");
        }

        public void Where(string Args)
        {
            LavishScript.ExecuteCommand("Where " + Args);
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

        protected void GetData<T>(ref T obj, string param)
        {
            try
            {
                LavishScript.DataParse<T>("${" + TLO + "." + param + "}", ref obj);
            }
            catch
            {
                InnerSpace.Echo("Exception Raised or Object does not Exist or NULL");
            }
        }
    }

}