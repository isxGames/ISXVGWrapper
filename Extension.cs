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

        public Character Me()
        {
                
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Me");
            return new Character(Obj);
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

        /// </summary>
        /// <returns>number of actors in the array</returns>
        public int Actor()
        {
            return LavishScript.Objects.GetObject("Actor").GetValue<int>();
        }
        /// <param name="Arg">between 1 and the number of actors in the array</param>
        public Actor Actor(int Arg)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Actor", Arg.ToString());
            return new Actor(Obj);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Args">See http://vg.isxgames.com/wiki/index.php?title=Actor_Search_Parameters for possible parameters</param>
        /// <returns></returns>
        public Actor Actor(params string[] Args)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Actor", Args);
            return new Actor(Obj);
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

        /// <summary>
        /// This TLO only works when the "Your Remains" window is open and populated.
        /// </summary>
        /// <param name="Argument">At this point (4.18.2007) the only parameter accepted is "Corpse"</param>
        /// <returns>Number of corpses available for summoning</returns> 
        public int Altar(string Argument)
        {
            if (Argument.Contains("Corpse") || Argument.Contains("corpse"))
            {
                return LavishScript.Objects.GetObject("Altar").GetValue<int>();
            }
            else
                return 0;
        }

        /// <summary>
        /// This TLO only works when the "Your Remains" window is open and populated.
        /// </summary>
        /// <param name="Argument">At this point (4.18.2007) the only parameter accepted is "Corpse"</param>
        /// <param name="Index">between 1 and the number of corpses available for summoning</param>
        public SCorpse Altar(string Argument, int Index)
        {
            if (Argument.Contains("Corpse") || Argument.Contains("corpse"))
            {
                LavishScriptObject Obj = LavishScript.Objects.GetObject("Altar","Corpse",Index.ToString());
                return new SCorpse(Obj);
            }
            else
                return null;
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

        public Mail Mail()
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Mail");
            return new Mail(Obj);
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

        /// <param name="SearchKey">'searchkeys' are found within the windows xml files in /vanguard/VGUIAssets/Shells/Default/Windows.</param>
        /// <returns></returns>
        public VGUIElement VGUI(string SearchKey)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("VGUI", SearchKey);
            return new VGUIElement(Obj);
        }

        public Market Market()
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Market");
            return new Market(Obj);
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
        public GV GV(params string[] Args)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("GV", Args);
            return new GV(Obj);
        }
        public Trade Trade()
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Trade");
            return new Trade(Obj);
        }
        public Songbook Songs()
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Songbook");
            return new Songbook(Obj);
        }

        public Song Songs(string Name)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Songs", Name);
            return new Song(Obj);
        }

        public Song Songs(int Index)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Song", Index.ToString());
            return new Song(Obj);
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