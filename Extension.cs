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
        public delegate bool IsFullScreen();
    }

    public class Extension
    {
        public static Vanguard.ISXVG.Delegates.IsFullScreen IsFullScreen = Stubs.IsFullScreen;

        internal class Stubs
        {
            static public bool IsFullScreen()
            {
                IntPtr Address = LavishVM.GetAPI("VGWindowsAPI", "IsFullScreen", 1);
                if (Address.ToInt32() == 0)
                    return false;
                Extension.IsFullScreen = (Vanguard.ISXVG.Delegates.IsFullScreen)Marshal.GetDelegateForFunctionPointer(Address, typeof(Vanguard.ISXVG.Delegates.IsFullScreen));
                return Extension.IsFullScreen();
            }
        }

        public Extension()
        {
        }

        public Character Me
        {
            get
            {
                LavishScriptObject Obj = LavishScript.Objects.GetObject("Me");
                return new Character(Obj);
            }
        }

        public Pawn Pawn(params string[] Args)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Pawn", Args);
            return new Pawn(Obj);
        }

        public Pawn Pawn(string Arg)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Pawn", Arg);
            return new Pawn(Obj);
        }

        public Pawn Pawn(int Arg)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Pawn", Arg.ToString());
            return new Pawn(Obj);
        }

        public Radar Radar(int Index)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Radar", Index.ToString());
            return new Radar(Obj);
        }

        public Radar Radar(string Name)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Radar",Name);
            return new Radar(Obj);
        }

        public Radar Radar()
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Radar");
            return new Radar(Obj);
        }

        public ISXVG ISXVG()
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("ISXVG");
            return new ISXVG(Obj);
        }

        public Loot Loot()
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Loot");
            return new Loot(Obj);
        }

        public VG VG()
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("VG");
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

        /// <summary>
        /// number of cards in strategy deck
        /// </summary>
        /// <returns>number of cards in strategy deck</returns>
        public int Strategy()
        {
            return LavishScript.Objects.GetObject<int>("Strategy");
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

        /// <summary>
        /// number of cards in ParlayCard deck
        /// </summary>
        /// <returns>number of cards in ParlayCard deck</returns>
        public int ParlayCard()
        {
            return LavishScript.Objects.GetObject<int>("ParlayCard");
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

        public Dialog Dialog(string Arg)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Dialog", Arg);
            return new Dialog(Obj);
        }

        public DialogResponse Dialog(params string[] Args)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Dialog", Args);
            return new DialogResponse(Obj);
        }

        public QuestJournal QuestJournal()
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Journal", "Quest");
            return new QuestJournal(Obj);
        }

        public QuestJournal QuestJournal(string Arg)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Journal", "Quest", Arg);
            return new QuestJournal(Obj);
        }

        public QuestJournal QuestJournal(int Arg)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Journal", "Quest", Arg.ToString());
            return new QuestJournal(Obj);
        }

        public TravelJournal TravelJournal()
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Journal", "Travel");
            return new TravelJournal(Obj);
        }

        public TravelJournal TravelJournal(string Arg)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Journal", "Travel", Arg);
            return new TravelJournal(Obj);
        }

        public TravelJournal TravelJournal(int Arg)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Journal", "Travel", Arg.ToString());
            return new TravelJournal(Obj);
        }

        public Merchant Merchant()
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Merchant");
            return new Merchant(Obj);
        }

        public CraftingTaskMaster CraftingTaskMaster()
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("TaskMaster", "Crafting");
            return new CraftingTaskMaster(Obj);
        }

        public void VGExecute(string Args)
        {
            LavishScript.ExecuteCommand("VGExecute " + Args);
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
            LavishScript.ExecuteCommand("Where" + Args);
        }
    }
}