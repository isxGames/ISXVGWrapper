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
        private LavishScriptAPI.Delegates.EventTarget Event_OnGroupBooted;
        private LavishScriptAPI.Delegates.EventTarget Event_OnGroupDisbanded;
        private LavishScriptAPI.Delegates.EventTarget Event_OnGroupFormed;
        private LavishScriptAPI.Delegates.EventTarget Event_OnGroupJoined;
        private LavishScriptAPI.Delegates.EventTarget Event_OnGroupLootNotify;
        private LavishScriptAPI.Delegates.EventTarget Event_OnGroupLootRandomStarted;
        private LavishScriptAPI.Delegates.EventTarget Event_OnGroupLootRandomEnded;
        private LavishScriptAPI.Delegates.EventTarget Event_OnGroupMemberAdded;
        private LavishScriptAPI.Delegates.EventTarget Event_OnGroupMemberBooted;
        private LavishScriptAPI.Delegates.EventTarget Event_OnGroupMemberDeath;
        private LavishScriptAPI.Delegates.EventTarget Event_OnGroupMemberCountChange;
        private LavishScriptAPI.Delegates.EventTarget Event_OnCraftingStepComplete;
        private LavishScriptAPI.Delegates.EventTarget Event_OnCraftingAlert;
        private LavishScriptAPI.Delegates.EventTarget Event_OnChangeChunk;
        private LavishScriptAPI.Delegates.EventTarget Event_OnStartSwimming;
        private LavishScriptAPI.Delegates.EventTarget Event_OnStopSwimming;
        private LavishScriptAPI.Delegates.EventTarget Event_OnConnectionStateChange;
        private LavishScriptAPI.Delegates.EventTarget Event_OnPawnDespawned;
        private LavishScriptAPI.Delegates.EventTarget Event_OnPawnSpawned;
        private LavishScriptAPI.Delegates.EventTarget Event_OnIncomingText;
        private LavishScriptAPI.Delegates.EventTarget Event_OnWeightUpdate;
        private LavishScriptAPI.Delegates.EventTarget Event_OnAddInventoryItem;
        private LavishScriptAPI.Delegates.EventTarget Event_OnCoinUpdate;
        private LavishScriptAPI.Delegates.EventTarget Event_OnItemStackCountChange;
        private LavishScriptAPI.Delegates.EventTarget Event_OnItemCanUseUpdated;
        private LavishScriptAPI.Delegates.EventTarget Event_OnIncomingCombatText;
        private LavishScriptAPI.Delegates.EventTarget Event_onHitObstacle;
        private LavishScriptAPI.Delegates.EventTarget Event_onTouchPawn;
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
        public event LavishScriptEventHandler GroupBooted;
        public event LavishScriptEventHandler GroupDisbanded;
        public event LavishScriptEventHandler GroupFormed;
        public event LavishScriptEventHandler GroupJoined;
        public event LavishScriptEventHandler GroupLootNotify;
        public event LavishScriptEventHandler GroupLootRandomStarted;
        public event LavishScriptEventHandler GroupLootRandomEnded;
        public event LavishScriptEventHandler GroupMemberAdded;
        public event LavishScriptEventHandler GroupMemberBooted;
        public event LavishScriptEventHandler GroupMemberDeath;
        public event LavishScriptEventHandler GroupMemberCountChange;
        public event LavishScriptEventHandler CraftingStepComplete;
        public event LavishScriptEventHandler CraftingAlert;
        public event LavishScriptEventHandler ChangeChunk;
        public event LavishScriptEventHandler StartSwimming;
        public event LavishScriptEventHandler StopSwimming;
        public event LavishScriptEventHandler ConnectionStateChange;
        public event LavishScriptEventHandler PawnSpawned;
        public event LavishScriptEventHandler PawnDespawned;
        public event LavishScriptEventHandler IncomingText;
        public event LavishScriptEventHandler WeightUpdate;
        public event LavishScriptEventHandler AddInventoryItem;
        public event LavishScriptEventHandler CoinUpdate;
        public event LavishScriptEventHandler ItemStackCountChange;
        public event LavishScriptEventHandler ItemCanUseUpdated;
        public event LavishScriptEventHandler IncomingCombatText;
        public event LavishScriptEventHandler HitObstacle;
        public event LavishScriptEventHandler TouchPawn;
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
        protected virtual void OnGroupBooted(LavishScriptEventArgs e)
        {
            if (GroupBooted != null)
                GroupBooted(this, e);
        }
        protected virtual void OnGroupDisbanded(LavishScriptEventArgs e)
        {
            if (GroupDisbanded != null)
                GroupDisbanded(this, e);
        }
        protected virtual void OnGroupFormed(LavishScriptEventArgs e)
        {
            if (GroupFormed != null)
                GroupFormed(this, e);
        }
        protected virtual void OnGroupJoined(LavishScriptEventArgs e)
        {
            if (GroupJoined != null)
                GroupJoined(this, e);
        }
        protected virtual void OnGroupLootNotify(LavishScriptEventArgs e)
        {
            if (GroupLootNotify != null)
                GroupLootNotify(this, e);
        }
        protected virtual void OnGroupLootRandomStarted(LavishScriptEventArgs e)
        {
            if (GroupLootRandomStarted != null)
                GroupLootRandomStarted(this, e);
        }
        protected virtual void OnGroupLootRandomEnded(LavishScriptEventArgs e)
        {
            if (GroupLootRandomEnded != null)
                GroupLootRandomEnded(this, e);
        }
        protected virtual void OnGroupMemberAdded(LavishScriptEventArgs e)
        {
            if (GroupMemberAdded != null)
                GroupMemberAdded(this, e);
        }
        protected virtual void OnGroupMemberBooted(LavishScriptEventArgs e)
        {
            if (GroupMemberBooted != null)
                GroupMemberBooted(this, e);
        }
        protected virtual void OnGroupMemberDeath(LavishScriptEventArgs e)
        {
            if (GroupMemberDeath != null)
                GroupMemberDeath(this, e);
        }
        protected virtual void OnGroupMemberCountChange(LavishScriptEventArgs e)
        {
            if (GroupMemberCountChange != null)
                GroupMemberCountChange(this, e);
        }
        protected virtual void OnCraftingStepComplete(LavishScriptEventArgs e)
        {
            if (CraftingStepComplete != null)
                CraftingStepComplete(this, e);
        }
        protected virtual void OnCraftingAlert(LavishScriptEventArgs e)
        {
            if (CraftingAlert != null)
                CraftingAlert(this, e);
        }
        protected virtual void OnChangeChunk(LavishScriptEventArgs e)
        {
            if (ChangeChunk != null)
                ChangeChunk(this, e);
        }
        protected virtual void OnStartSwimming(LavishScriptEventArgs e)
        {
            if (StartSwimming != null)
                StartSwimming(this, e);
        }
        protected virtual void OnStopSwimming(LavishScriptEventArgs e)
        {
            if (StopSwimming != null)
                StopSwimming(this, e);
        }
        protected virtual void OnConnectionStateChange(LavishScriptEventArgs e)
        {
            if (ConnectionStateChange != null)
                ConnectionStateChange(this, e);
        }
        protected virtual void OnPawnSpawned(LavishScriptEventArgs e)
        {
            if (PawnSpawned != null)
                PawnSpawned(this, e);
        }
        protected virtual void OnPawnDespawned(LavishScriptEventArgs e)
        {
            if (PawnDespawned != null)
                PawnDespawned(this, e);
        }
        protected virtual void OnIncomingText(LavishScriptEventArgs e)
        {
            if (IncomingText != null)
                IncomingText(this, e);
        }
        protected virtual void OnWeightUpdate(LavishScriptEventArgs e)
        {
            if (WeightUpdate != null)
                WeightUpdate(this, e);
        }
        protected virtual void OnAddInventoryItem(LavishScriptEventArgs e)
        {
            if (AddInventoryItem != null)
                AddInventoryItem(this, e);
        }
        protected virtual void OnCoinUpdate(LavishScriptEventArgs e)
        {
            if (CoinUpdate != null)
                CoinUpdate(this, e);
        }
        protected virtual void OnItemStackCountChange(LavishScriptEventArgs e)
        {
            if (ItemStackCountChange != null)
                ItemStackCountChange(this, e);
        }
        protected virtual void OnItemCanUseUpdated(LavishScriptEventArgs e)
        {
            if (ItemCanUseUpdated != null)
                ItemCanUseUpdated(this, e);
        }
        protected virtual void OnIncomingCombatText(LavishScriptEventArgs e)
        {
            if (IncomingCombatText != null)
                IncomingCombatText(this, e);
        }
        protected virtual void OnHitObstacle(LavishScriptEventArgs e)
        {
            if (HitObstacle != null)
                HitObstacle(this, e);
        }
        protected virtual void onTouchPawn(LavishScriptEventArgs e)
        {
            if (TouchPawn != null)
                TouchPawn(this, e);
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
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupBooted"), Event_OnGroupBooted);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupDisbanded"), Event_OnGroupDisbanded);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupFormed"), Event_OnGroupFormed);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupJoined"), Event_OnGroupJoined);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupLootNotify"), Event_OnGroupLootNotify);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupLootRandomStarted"), Event_OnGroupLootRandomStarted);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupLootRandomEnded"), Event_OnGroupLootRandomEnded);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupMemberAdded"), Event_OnGroupMemberAdded);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupMemberBooted"), Event_OnGroupMemberBooted);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupMemberDeath"), Event_OnGroupMemberDeath);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupMemberCountChange"), Event_OnGroupMemberCountChange);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onCraftingStepComplete"), Event_OnCraftingStepComplete);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onCraftingAlert"), Event_OnCraftingAlert);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onChangeChunk"), Event_OnChangeChunk);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onStartSwimming"), Event_OnStartSwimming);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onStopSwimming"), Event_OnStopSwimming);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onConnectionStateChange"), Event_OnConnectionStateChange);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_OnPawnSpawned"), Event_OnPawnSpawned);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_OnPawnDespawned"), Event_OnPawnDespawned);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_OnIncomingText"), Event_OnIncomingText);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onWeightUpdate"), Event_OnWeightUpdate);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onAddInventoryItem"), Event_OnAddInventoryItem);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onCoinUpdate"), Event_OnCoinUpdate);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onItemStackCountChange"), Event_OnItemStackCountChange);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onItemCanUseUpdated"), Event_OnItemCanUseUpdated);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_OnIncomingCombatText"), Event_OnIncomingCombatText);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onHitObstacle"), Event_onHitObstacle);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onTouchPawn"), Event_onTouchPawn);
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
            Event_OnGroupBooted = new LavishScriptAPI.Delegates.EventTarget(Event_GroupBooted);
            Event_OnGroupDisbanded = new LavishScriptAPI.Delegates.EventTarget(Event_GroupDisbanded);
            Event_OnGroupFormed = new LavishScriptAPI.Delegates.EventTarget(Event_GroupFormed);
            Event_OnGroupJoined = new LavishScriptAPI.Delegates.EventTarget(Event_GroupJoined);
            Event_OnGroupLootNotify = new LavishScriptAPI.Delegates.EventTarget(Event_GroupLootNotify);
            Event_OnGroupLootRandomStarted = new LavishScriptAPI.Delegates.EventTarget(Event_GroupLootRandomStarted);
            Event_OnGroupLootRandomEnded = new LavishScriptAPI.Delegates.EventTarget(Event_GroupLootRandomEnded);
            Event_OnGroupMemberAdded = new LavishScriptAPI.Delegates.EventTarget(Event_GroupMemberAdded);
            Event_OnGroupMemberBooted = new LavishScriptAPI.Delegates.EventTarget(Event_GroupMemberBooted);
            Event_OnGroupMemberDeath = new LavishScriptAPI.Delegates.EventTarget(Event_GroupMemberDeath);
            Event_OnGroupMemberCountChange = new LavishScriptAPI.Delegates.EventTarget(Event_GroupMemberCountChange);
            Event_OnCraftingStepComplete = new LavishScriptAPI.Delegates.EventTarget(Event_CraftingStepComplete);
            Event_OnCraftingAlert = new LavishScriptAPI.Delegates.EventTarget(Event_CraftingAlert);
            Event_OnChangeChunk = new LavishScriptAPI.Delegates.EventTarget(Event_ChangeChunk);
            Event_OnStartSwimming = new LavishScriptAPI.Delegates.EventTarget(Event_StartSwimming);
            Event_OnStopSwimming = new LavishScriptAPI.Delegates.EventTarget(Event_StopSwimming);
            Event_OnConnectionStateChange = new LavishScriptAPI.Delegates.EventTarget(Event_ConnectionStateChange);
            Event_OnPawnSpawned = new LavishScriptAPI.Delegates.EventTarget(Event_PawnSpawned);
            Event_OnPawnDespawned = new LavishScriptAPI.Delegates.EventTarget(Event_PawnDespawned);
            Event_OnIncomingText = new LavishScriptAPI.Delegates.EventTarget(Event_IncomingText);
            Event_OnWeightUpdate = new LavishScriptAPI.Delegates.EventTarget(Event_WeightUpdate);
            Event_OnAddInventoryItem = new LavishScriptAPI.Delegates.EventTarget(Event_AddInventoryItem);
            Event_OnCoinUpdate = new LavishScriptAPI.Delegates.EventTarget(Event_CoinUpdate);
            Event_OnItemStackCountChange = new LavishScriptAPI.Delegates.EventTarget(Event_ItemStackCountChange);
            Event_OnItemCanUseUpdated = new LavishScriptAPI.Delegates.EventTarget(Event_ItemCanUseUpdated);
            Event_OnIncomingCombatText = new LavishScriptAPI.Delegates.EventTarget(Event_IncomingCombatText);
            Event_onHitObstacle = new LavishScriptAPI.Delegates.EventTarget(Event_HitObstacle);
            Event_onTouchPawn = new LavishScriptAPI.Delegates.EventTarget(Event_TouchPawn);

            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayBegin"), Event_OnParlayBegin);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayDialog"), Event_OnParlayDialog);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayUpdate"), Event_OnParlayUpdate);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayOppTurnBegin"), Event_OnParlayOppTurnBegin);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayOppTurnEnd"), Event_OnParlayOppTurnEnd);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayOppPlayedCard"), Event_OnParlayOppPlayedCard);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlaySuccess"), Event_OnParlaySuccess);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayLost"), Event_OnParlayLoss);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayEnd"), Event_OnParlayEnd);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupBooted"), Event_OnGroupBooted);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupDisbanded"), Event_OnGroupDisbanded);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupFormed"), Event_OnGroupFormed);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupJoined"), Event_OnGroupJoined);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupLootNotify"), Event_OnGroupLootNotify);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupLootRandomStarted"), Event_OnGroupLootRandomStarted);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupLootRandomEnded"), Event_OnGroupLootRandomEnded);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupMemberAdded"), Event_OnGroupMemberAdded);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupMemberBooted"), Event_OnGroupMemberBooted);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupMemberDeath"), Event_OnGroupMemberDeath);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupMemberCountChange"), Event_OnGroupMemberCountChange);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onCraftingStepComplete"), Event_OnCraftingStepComplete);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onCraftingAlert"), Event_OnCraftingAlert);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onChangeChunk"), Event_OnChangeChunk);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onStartSwimming"), Event_OnStartSwimming);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onStopSwimming"), Event_OnStopSwimming);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onConnectionStateChange"), Event_OnConnectionStateChange);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_OnPawnSpawned"), Event_OnPawnSpawned);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_OnPawnDespawned"), Event_OnPawnDespawned);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_OnIncomingText"), Event_OnIncomingText);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onWeightUpdate"), Event_OnWeightUpdate);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onAddInventoryItem"), Event_OnAddInventoryItem);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onCoinUpdate"), Event_OnCoinUpdate);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onItemStackCountChange"), Event_OnItemStackCountChange);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onItemCanUseUpdated"), Event_OnItemCanUseUpdated);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_OnIncomingCombatText"), Event_OnIncomingCombatText);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onHitObstacle"), Event_onHitObstacle);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onTouchPawn"), Event_onTouchPawn);
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
        private void Event_GroupBooted(int argc, uint argv, Object ThisObject)
        {
            OnGroupBooted(new LavishScriptEventArgs(argc, argv, ThisObject));
        }
        private void Event_GroupDisbanded(int argc, uint argv, Object ThisObject)
        {
            OnGroupDisbanded(new LavishScriptEventArgs(argc, argv, ThisObject));
        }
        private void Event_GroupFormed(int argc, uint argv, Object ThisObject)
        {
            OnGroupFormed(new LavishScriptEventArgs(argc, argv, ThisObject));
        }
        private void Event_GroupJoined(int argc, uint argv, Object ThisObject)
        {
            OnGroupJoined(new LavishScriptEventArgs(argc, argv, ThisObject));
        }
        private void Event_GroupLootNotify(int argc, uint argv, Object ThisObject)
        {
            OnGroupLootNotify(new LavishScriptEventArgs(argc, argv, ThisObject));
        }
        private void Event_GroupLootRandomStarted(int argc, uint argv, Object ThisObject)
        {
            OnGroupLootRandomStarted(new LavishScriptEventArgs(argc, argv, ThisObject));
        }
        private void Event_GroupLootRandomEnded(int argc, uint argv, Object ThisObject)
        {
            OnGroupLootRandomEnded(new LavishScriptEventArgs(argc, argv, ThisObject));
        }
        private void Event_GroupMemberAdded(int argc, uint argv, Object ThisObject)
        {
            OnGroupMemberAdded(new LavishScriptEventArgs(argc, argv, ThisObject));
        }
        private void Event_GroupMemberBooted(int argc, uint argv, Object ThisObject)
        {
            OnGroupMemberBooted(new LavishScriptEventArgs(argc, argv, ThisObject));
        }
        private void Event_GroupMemberDeath(int argc, uint argv, Object ThisObject)
        {
            OnGroupMemberDeath(new LavishScriptEventArgs(argc, argv, ThisObject));
        }
        private void Event_GroupMemberCountChange(int argc, uint argv, Object ThisObject)
        {
            OnGroupMemberCountChange(new LavishScriptEventArgs(argc, argv, ThisObject));
        }
        private void Event_CraftingStepComplete(int argc, uint argv, Object ThisObject)
        {
            OnCraftingStepComplete(new LavishScriptEventArgs(argc, argv, ThisObject));
        }
        private void Event_CraftingAlert(int argc, uint argv, Object ThisObject)
        {
            OnCraftingAlert(new LavishScriptEventArgs(argc, argv, ThisObject));
        }
        private void Event_ChangeChunk(int argc, uint argv, Object ThisObject)
        {
            OnChangeChunk(new LavishScriptEventArgs(argc, argv, ThisObject));
        }
        private void Event_StartSwimming(int argc, uint argv, Object ThisObject)
        {
            OnStartSwimming(new LavishScriptEventArgs(argc, argv, ThisObject));
        }
        private void Event_StopSwimming(int argc, uint argv, Object ThisObject)
        {
            OnStopSwimming(new LavishScriptEventArgs(argc, argv, ThisObject));
        }
        private void Event_ConnectionStateChange(int argc, uint argv, Object ThisObject)
        {
            OnConnectionStateChange(new LavishScriptEventArgs(argc, argv, ThisObject));
        }
        private void Event_PawnSpawned(int argc, uint argv, Object ThisObject)
        {
            OnPawnSpawned(new LavishScriptEventArgs(argc, argv, ThisObject));
        }
        private void Event_PawnDespawned(int argc, uint argv, Object ThisObject)
        {
            OnPawnDespawned(new LavishScriptEventArgs(argc, argv, ThisObject));
        }
        private void Event_IncomingText(int argc, uint argv, Object ThisObject)
        {
            OnIncomingText(new LavishScriptEventArgs(argc, argv, ThisObject));
        }
        private void Event_WeightUpdate(int argc, uint argv, Object ThisObject)
        {
            OnWeightUpdate(new LavishScriptEventArgs(argc, argv, ThisObject));
        }
        private void Event_AddInventoryItem(int argc, uint argv, Object ThisObject)
        {
            OnAddInventoryItem(new LavishScriptEventArgs(argc, argv, ThisObject));
        }
        private void Event_CoinUpdate(int argc, uint argv, Object ThisObject)
        {
            OnCoinUpdate(new LavishScriptEventArgs(argc, argv, ThisObject));
        }
        private void Event_ItemStackCountChange(int argc, uint argv, Object ThisObject)
        {
            OnItemStackCountChange(new LavishScriptEventArgs(argc, argv, ThisObject));
        }
        private void Event_ItemCanUseUpdated(int argc, uint argv, Object ThisObject)
        {
            OnItemCanUseUpdated(new LavishScriptEventArgs(argc, argv, ThisObject));
        }
        private void Event_IncomingCombatText(int argc, uint argv, Object ThisObject)
        {
            OnIncomingCombatText(new LavishScriptEventArgs(argc, argv, ThisObject));
        }
        private void Event_HitObstacle(int argc, uint argv, Object ThisObject)
        {
            OnHitObstacle(new LavishScriptEventArgs(argc, argv, ThisObject));
        }
        private void Event_TouchPawn(int argc, uint argv, Object ThisObject)
        {
            onTouchPawn(new LavishScriptEventArgs(argc, argv, ThisObject));
        }
        #endregion
    }
}
