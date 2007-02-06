using System;
using System.Text;

using LavishVMAPI;
using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class VGEvent
    {
        public static VGEvent Instance = new VGEvent();

        ~VGEvent()
        {
            LavishScript.Events.DetachEventTarget(Extension.GetVGEventID("VG_onStartSwimming"), Eventdel_VGEvent);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayBegin"), Event_OnParlayBegin);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayDialog"), Event_OnParlayDialog);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayUpdate"), Event_OnParlayUpdate);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayOppTurnBegin"), Event_OnParlayOppTurnBegin);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayOppTurnEnd"), Event_OnParlayOppTurnEnd);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayOppPlayedCard"), Event_OnParlayOppPlayedCard);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlaySuccess"), Event_OnParlaySuccess);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayLost"), Event_OnParlayLoss);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayEnd"), Event_OnParalyEnd);
        }

        public VGEvent()
        {
            InnerSpace.Echo("Attaching Event: " + Extension.GetVGEventID("VG_onStartSwimming").ToString());
            LavishScript.Events.AttachEventTarget(Extension.GetVGEventID("VG_onStartSwimming"), Eventdel_VGEvent);
            InnerSpace.Echo("Attaching Event: " + LavishScript.Events.RegisterEvent("VG_onParlayBegin").ToString());
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayBegin"), Event_OnParlayBegin);
            InnerSpace.Echo("Attaching Event: " + LavishScript.Events.RegisterEvent("VG_onParlayDialog").ToString());
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayDialog"), Event_OnParlayDialog);
            InnerSpace.Echo("Attaching Event: " + LavishScript.Events.RegisterEvent("VG_onParlayUpdate").ToString());
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayUpdate"), Event_OnParlayUpdate);
            InnerSpace.Echo("Attaching Event: " + LavishScript.Events.RegisterEvent("VG_onParlayOppTurnBegin").ToString());
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayOppTurnBegin"), Event_OnParlayOppTurnBegin);
            InnerSpace.Echo("Attaching Event: " + LavishScript.Events.RegisterEvent("VG_onParlayOppTurnEnd").ToString());
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayOppTurnEnd"), Event_OnParlayOppTurnEnd);
            InnerSpace.Echo("Attaching Event: " + LavishScript.Events.RegisterEvent("VG_onParlayOppPlayedCard").ToString());
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayOppPlayedCard"), Event_OnParlayOppPlayedCard);
            InnerSpace.Echo("Attaching Event: " + LavishScript.Events.RegisterEvent("VG_onParlaySuccess").ToString());
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlaySuccess"), Event_OnParlaySuccess);
            InnerSpace.Echo("Attaching Event: " + LavishScript.Events.RegisterEvent("VG_onParlayLost").ToString());
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayLost"), Event_OnParlayLoss);
            InnerSpace.Echo("Attaching Event: " + LavishScript.Events.RegisterEvent("VG_onParlayEnd").ToString());
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayEnd"), Event_OnParalyEnd);
        }

        internal static LavishScriptAPI.Delegates.EventTarget Eventdel_VGEvent = Event_VGEvent;
        internal static LavishScriptAPI.Delegates.EventTarget Event_OnParlayBegin = Event_ParlayBegin;
        internal static LavishScriptAPI.Delegates.EventTarget Event_OnParlayDialog = Event_ParlayDialog;
        internal static LavishScriptAPI.Delegates.EventTarget Event_OnParlayUpdate = Event_ParlayUpdate;
        internal static LavishScriptAPI.Delegates.EventTarget Event_OnParlayOppTurnBegin = Event_ParlayOppTurnBegin;
        internal static LavishScriptAPI.Delegates.EventTarget Event_OnParlayOppTurnEnd = Event_ParlayOppTurnEnd;
        internal static LavishScriptAPI.Delegates.EventTarget Event_OnParlayOppPlayedCard = Event_ParlayOppPlayedCard;
        internal static LavishScriptAPI.Delegates.EventTarget Event_OnParlaySuccess = Event_ParlaySuccess;
        internal static LavishScriptAPI.Delegates.EventTarget Event_OnParlayLoss = Event_ParlayLoss;
        internal static LavishScriptAPI.Delegates.EventTarget Event_OnParalyEnd = Event_ParlayEnd;

        public static void Event_VGEvent(int argc, uint argv, Object ThisObject)
        {
            /* The event has been fired. argc is now the count of arguments, and argv is the token for GetArg */

            /* Let's echo the event name and the parameter count */
            InnerSpace.Echo("Event Fired: " + argc.ToString());
            /* Now let's echo each parameter individually */
            for (uint i = 0; i < argc; i++)
            {
                /* Echo the arg number, then the value */
                InnerSpace.Echo(i.ToString() + " = " + InnerSpace.GetArg<string>(i, argv));
            }
            /* all done! */
            InnerSpace.Echo("------------------");
        }
        public static void Event_ParlayBegin(int argc, uint argv, Object ThisObject)
        {

        }

        public static void Event_ParlayDialog(int argc, uint argv, Object ThisObject)
        {

        }

        public static void Event_ParlayUpdate(int argc, uint argv, Object ThisObject)
        {

        }

        public static void Event_ParlayOppTurnBegin(int argc, uint argv, Object ThisObject)
        {

        }

        public static void Event_ParlayOppTurnEnd(int argc, uint argv, Object ThisObject)
        {

        }

        public static void Event_ParlayOppPlayedCard(int argc, uint argv, Object ThisObject)
        {

        }

        public static void Event_ParlaySuccess(int argc, uint argv, Object ThisObject)
        {

        }

        public static void Event_ParlayLoss(int argc, uint argv, Object ThisObject)
        {

        }

        public static void Event_ParlayEnd(int argc, uint argv, Object ThisObject)
        {

        }
    }
}
