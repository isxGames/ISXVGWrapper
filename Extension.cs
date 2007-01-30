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

        public Character Me()
        {
            return new Character();
        }

        public Pawn Pawn(params string[] Args)
        {
            return new Pawn(Args);
        }

        public Pawn Pawn(string Arg)
        {
            return new Pawn(Arg);
        }

        public Pawn Pawn(int Arg)
        {
            return new Pawn(Arg.ToString());
        }

        public Radar Radar(int Index)
        {
            return new Radar(Index.ToString());
        }

        public Radar Radar(string Name)
        {
            return new Radar(Name);
        }

        public Radar Radar()
        {
            return new Radar();
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

        public VGLocation VGLoc(string Arg)
        {
            return new VGLocation(Arg);
        }

        public VGLocation VGLoc(int Arg)
        {
            return new VGLocation(Arg.ToString());
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