using System;
using System.Text;

using LavishVMAPI;
using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class VGEvent
    {
        //.Net Delegate
        public delegate void LavishScriptEventHandler(object sender, LavishScriptEventArgs e);

        #region LavishScript Delegates
        //private LavishScriptAPI.Delegates.EventTarget Eventdel_VGEvent;
        private LavishScriptAPI.Delegates.EventTarget Event_OnParlayBegin;
        private LavishScriptAPI.Delegates.EventTarget Event_OnParlayDialog;
        private LavishScriptAPI.Delegates.EventTarget Event_OnParlayUpdate;
        private LavishScriptAPI.Delegates.EventTarget Event_OnParlayOppTurnBegin;
        private LavishScriptAPI.Delegates.EventTarget Event_OnParlayOppTurnEnd;
        private LavishScriptAPI.Delegates.EventTarget Event_OnParlayOppPlayedCard;
        private LavishScriptAPI.Delegates.EventTarget Event_OnParlaySuccess;
        private LavishScriptAPI.Delegates.EventTarget Event_OnParlayLoss;
        private LavishScriptAPI.Delegates.EventTarget Event_OnParlayEnd; 
        #endregion

        #region .Net Event Handlers
        public event LavishScriptEventHandler ParlayBegin;
        public event LavishScriptEventHandler ParlayDialog;
        public event LavishScriptEventHandler ParlayUpdate;
        public event LavishScriptEventHandler ParlayOppTurnBegin;
        public event LavishScriptEventHandler ParlayOppTurnEnd;
        public event LavishScriptEventHandler ParlayOppPlayedCard;
        public event LavishScriptEventHandler ParlaySuccess;
        public event LavishScriptEventHandler ParlayLoss;
        public event LavishScriptEventHandler ParlayEnd; 
        #endregion

        #region .Net Event Raisers
        protected virtual void OnParlayBegin(LavishScriptEventArgs e)
        {
            if (ParlayBegin != null)
                ParlayBegin(this, e);
        }
        protected virtual void OnParlayDialog(LavishScriptEventArgs e)
        {
            if (ParlayDialog != null)
                ParlayDialog(this, e);
        }
        protected virtual void OnParlayUpdate(LavishScriptEventArgs e)
        {
            if (ParlayUpdate != null)
                ParlayUpdate(this, e);
        }
        protected virtual void OnParlayOppTurnBegin(LavishScriptEventArgs e)
        {
            if (ParlayOppTurnBegin != null)
                ParlayOppTurnBegin(this, e);
        }
        protected virtual void OnParlayOppTurnEnd(LavishScriptEventArgs e)
        {
            if (ParlayOppTurnEnd != null)
                ParlayOppTurnEnd(this, e);
        }
        protected virtual void OnParlayOppPlayedCard(LavishScriptEventArgs e)
        {
            if (ParlayOppPlayedCard != null)
                ParlayOppPlayedCard(this, e);
        }
        protected virtual void OnParlaySuccess(LavishScriptEventArgs e)
        {
            if (ParlaySuccess != null)
                ParlaySuccess(this, e);
        }
        protected virtual void OnParlayLoss(LavishScriptEventArgs e)
        {
            if (ParlayLoss != null)
                ParlayLoss(this, e);
        }
        protected virtual void OnParlayEnd(LavishScriptEventArgs e)
        {
            if (ParlayEnd != null)
                ParlayEnd(this, e);
        } 
        #endregion

        ~VGEvent()
        {
            //LavishScript.Events.DetachEventTarget(Extension.GetVGEventID("VG_onStartSwimming"), Eventdel_VGEvent);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayBegin"), Event_OnParlayBegin);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayDialog"), Event_OnParlayDialog);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayUpdate"), Event_OnParlayUpdate);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayOppTurnBegin"), Event_OnParlayOppTurnBegin);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayOppTurnEnd"), Event_OnParlayOppTurnEnd);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayOppPlayedCard"), Event_OnParlayOppPlayedCard);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlaySuccess"), Event_OnParlaySuccess);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayLost"), Event_OnParlayLoss);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayEnd"), Event_OnParlayEnd);
        }

        public VGEvent()
        {
            //InnerSpace.Echo("Attaching Event: " + Extension.GetVGEventID("VG_onStartSwimming").ToString());//sample
            //Eventdel_VGEvent = new LavishScriptAPI.Delegates.EventTarget(Event_VGEvent);//sample
            //LavishScript.Events.AttachEventTarget(Extension.GetVGEventID("VG_onStartSwimming"), Eventdel_VGEvent);//sample
            
            Event_OnParlayBegin = new LavishScriptAPI.Delegates.EventTarget(Event_ParlayBegin);
            Event_OnParlayDialog = new LavishScriptAPI.Delegates.EventTarget(Event_ParlayDialog);
            Event_OnParlayUpdate = new LavishScriptAPI.Delegates.EventTarget(Event_ParlayUpdate);
            Event_OnParlayOppTurnBegin = new LavishScriptAPI.Delegates.EventTarget(Event_ParlayOppTurnBegin);
            Event_OnParlayOppTurnEnd = new LavishScriptAPI.Delegates.EventTarget(Event_ParlayOppTurnEnd);
            Event_OnParlayOppPlayedCard = new LavishScriptAPI.Delegates.EventTarget(Event_ParlayOppPlayedCard);
            Event_OnParlaySuccess = new LavishScriptAPI.Delegates.EventTarget(Event_ParlaySuccess);
            Event_OnParlayLoss = new LavishScriptAPI.Delegates.EventTarget(Event_ParlayLoss);
            Event_OnParlayEnd = new LavishScriptAPI.Delegates.EventTarget(Event_ParlayEnd);

            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayBegin"), Event_OnParlayBegin);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayDialog"), Event_OnParlayDialog);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayUpdate"), Event_OnParlayUpdate);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayOppTurnBegin"), Event_OnParlayOppTurnBegin);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayOppTurnEnd"), Event_OnParlayOppTurnEnd);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayOppPlayedCard"), Event_OnParlayOppPlayedCard);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlaySuccess"), Event_OnParlaySuccess);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayLost"), Event_OnParlayLoss);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayEnd"), Event_OnParlayEnd);
        }

        #region LavishScript to .Net Event Triggers
        /*
        private void Event_VGEvent(int argc, uint argv, Object ThisObject)//sample
        {
            // The event has been fired. argc is now the count of arguments, and argv is the token for GetArg

            // Let's echo the event name and the parameter count
            InnerSpace.Echo("Event Fired: " + argc.ToString());
            // Now let's echo each parameter individually
            for (uint i = 0; i < argc; i++)
            {
               // Echo the arg number, then the value
                InnerSpace.Echo(i.ToString() + " = " + InnerSpace.GetArg<string>(i, argv));
            }
           // all done! 
            InnerSpace.Echo("------------------");
        }
        */
        private void Event_ParlayBegin(int argc, uint argv, Object ThisObject)
        {
            OnParlayBegin(new LavishScriptEventArgs(argc, argv, ThisObject));
        }
        private void Event_ParlayDialog(int argc, uint argv, Object ThisObject)
        {
            OnParlayDialog(new LavishScriptEventArgs(argc, argv, ThisObject));
        }
        private void Event_ParlayUpdate(int argc, uint argv, Object ThisObject)
        {
            OnParlayUpdate(new LavishScriptEventArgs(argc, argv, ThisObject));
        }
        private void Event_ParlayOppTurnBegin(int argc, uint argv, Object ThisObject)
        {
            OnParlayOppTurnBegin(new LavishScriptEventArgs(argc, argv, ThisObject));
        }
        private void Event_ParlayOppTurnEnd(int argc, uint argv, Object ThisObject)
        {
            OnParlayOppTurnEnd(new LavishScriptEventArgs(argc, argv, ThisObject));
        }
        private void Event_ParlayOppPlayedCard(int argc, uint argv, Object ThisObject)
        {
            OnParlayOppPlayedCard(new LavishScriptEventArgs(argc, argv, ThisObject));
        }
        private void Event_ParlaySuccess(int argc, uint argv, Object ThisObject)
        {
            OnParlaySuccess(new LavishScriptEventArgs(argc, argv, ThisObject));
        }
        private void Event_ParlayLoss(int argc, uint argv, Object ThisObject)
        {
            OnParlayLoss(new LavishScriptEventArgs(argc, argv, ThisObject));
        }
        private void Event_ParlayEnd(int argc, uint argv, Object ThisObject)
        {
            OnParlayEnd(new LavishScriptEventArgs(argc, argv, ThisObject));
        } 
        #endregion
    }
}
