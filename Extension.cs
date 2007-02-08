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

        public Character Me
        {
            get
            {
                LavishScriptPersistentObject Obj = LavishScript.Objects.GetPersistentObject("Me");
                return new Character(Obj);
            }
        }

        public Pawn Pawn(params string[] Args)
        {
            LavishScriptPersistentObject Obj = LavishScript.Objects.GetPersistentObject("Pawn", Args);
            return new Pawn(Obj);
        }

        public Pawn Pawn(string Arg)
        {
            LavishScriptPersistentObject Obj = LavishScript.Objects.GetPersistentObject("Pawn", Arg);
            return new Pawn(Obj);
        }

        public Pawn Pawn(int Arg)
        {
            LavishScriptPersistentObject Obj = LavishScript.Objects.GetPersistentObject("Pawn", Arg.ToString());
            return new Pawn(Obj);
        }

        public Radar Radar(int Index)
        {
            LavishScriptPersistentObject Obj = LavishScript.Objects.GetPersistentObject("Radar", Index.ToString());
            return new Radar(Obj);
        }

        public Radar Radar(string Name)
        {
            LavishScriptPersistentObject Obj = LavishScript.Objects.GetPersistentObject("Radar",Name);
            return new Radar(Obj);
        }

        public Radar Radar()
        {
            LavishScriptPersistentObject Obj = LavishScript.Objects.GetPersistentObject("Radar");
            return new Radar(Obj);
        }

        public ISXVG ISXVG()
        {
            LavishScriptPersistentObject Obj = LavishScript.Objects.GetPersistentObject("ISXVG");
            return new ISXVG(Obj);
        }

        public Loot Loot()
        {
            LavishScriptPersistentObject Obj = LavishScript.Objects.GetPersistentObject("Loot");
            return new Loot(Obj);
        }

        public VG VG()
        {
            LavishScriptPersistentObject Obj = LavishScript.Objects.GetPersistentObject("VG");
            return new VG(Obj);
        }

        public Map Map()
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Map");
            return new Map(Obj);
        }

        public VGLocation VGLoc(params string[] Args)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("VGLoc", Args);
            return new VGLocation(Obj);
        }

        public VGLocation VGLoc(string Arg)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("VGLoc", Arg);
            return new VGLocation(Obj);
        }

        public VGLocation VGLoc(int Arg)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("VGLoc", Arg.ToString());
            return new VGLocation(Obj);
        }

        public ParlayCard Strategy(int Arg)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Strategy", Arg.ToString());
            return new ParlayCard(Obj);
        }

        public ParlayCard Strategy(string Name)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Strategy", Name);
            return new ParlayCard(Obj);
        }

        public ParlayCard ParlayCard(int Arg)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("ParlayCard", Arg.ToString());
            return new ParlayCard(Obj);
        }

        public ParlayCard ParlayCard(string Name)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("ParlayCard", Name);
            return new ParlayCard(Obj);
        }

        public Parlay Parlay()
        {
                LavishScriptObject Obj = LavishScript.Objects.GetObject("Parlay");
                return new Parlay(Obj);
        }

        public GroupMember Group(int Arg)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Group", Arg.ToString());
            return new GroupMember(Obj);
        }

        public GroupMember Group(string Name)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Group", Name);
            return new GroupMember(Obj);
        }

        public Group Group()
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Group");
            return new Group(Obj);
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