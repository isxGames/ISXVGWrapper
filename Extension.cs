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
        public delegate int GetVGEventID(string EventName);
    }

    public class Extension
    {
        public static Vanguard.ISXVG.Delegates.GetVGEventID GetVGEventID = Stubs.GetVGEventID;

        internal class Stubs
        {
            static public int GetVGEventID(string EventName)
            {
                IntPtr Address = LavishVM.GetAPI("ISXVGAPI", "GetVGEventID", 1);
                if (Address.ToInt32() == 0)
                    return 0;
                Extension.GetVGEventID = (Vanguard.ISXVG.Delegates.GetVGEventID)Marshal.GetDelegateForFunctionPointer(Address, typeof(Vanguard.ISXVG.Delegates.GetVGEventID));
                return Extension.GetVGEventID(EventName);
            }
        }

        public Pawn Pawn(string pawn)
        {
            return new Pawn("Pawn[" + pawn + "]",1);
        }
    }

}