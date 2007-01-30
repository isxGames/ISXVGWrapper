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

    public class Extension : Wrapper
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

        public Extension(string args)
        {
            Args = args;
        }

        public Character Me()
        {
            return new Character();
        }

        /*
        public Pawn Pawn(string args)
        {
            return new Pawn("Pawn[" + args + "]", 1);
        }
        */

        public Radar Radar()
        {
            return new Radar();
        }

        public Radar Radar(string args)
        {
            return new Radar("Radar[" + args + "]", 1);
        }

        public ISXVG ISXVG()
        {
            return new ISXVG();
        }

        public Loot Loot()
        {
            return new Loot();
        }

        public VG VG()
        {
            return new VG();
        }

        public Map Map()
        {
            return new Map();
        }

        public VGLocation VGLoc(string args)
        {
            return new VGLocation("VGLoc[" + args + "]", 1);
        }

        public void VGExecute(string Command)
        {
            LavishScript.ExecuteCommand("VGExecute " + Command);
        }

        public void VGEcho(string args)
        {
            LavishScript.ExecuteCommand("VGEcho " + args);
        }

        public void Target()
        {
            LavishScript.ExecuteCommand("Target");
        }

        public void Target(string args)
        {
            LavishScript.ExecuteCommand("Target " + args);
        }

        public void Face()
        {
            LavishScript.ExecuteCommand("Face");
        }

        public void Face(string args)
        {
            LavishScript.ExecuteCommand("Face " + args);
        }

        public void Where()
        {
            LavishScript.ExecuteCommand("Where");
        }

        public void Where(string args)
        {
            LavishScript.ExecuteCommand("Where " + args);
        }
    }
}