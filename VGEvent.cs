using System;
using System.Text;

using LavishVMAPI;
using InnerSpaceAPI;
using LavishScriptAPI;


namespace Vanguard.ISXVG
{
    public class VGEvent
    {
        #region .Net Events
        public event System.EventHandler<LSEventArgs> ParlayBegin;
        public event System.EventHandler<LSEventArgs> ParlayDialog;
        public event System.EventHandler<LSEventArgs> ParlayUpdate;
        public event System.EventHandler<LSEventArgs> ParlayOppTurnBegin;
        public event System.EventHandler<LSEventArgs> ParlayOppTurnEnd;
        public event System.EventHandler<LSEventArgs> ParlayOppPlayedCard;
        public event System.EventHandler<LSEventArgs> ParlaySuccess;
        public event System.EventHandler<LSEventArgs> ParlayLoss;
        public event System.EventHandler<LSEventArgs> ParlayEnd;
        public event System.EventHandler<LSEventArgs> GroupBooted;
        public event System.EventHandler<LSEventArgs> GroupDisbanded;
        public event System.EventHandler<LSEventArgs> GroupFormed;
        public event System.EventHandler<LSEventArgs> GroupJoined;
        public event System.EventHandler<LSEventArgs> GroupLootNotify;
        public event System.EventHandler<LSEventArgs> GroupLootRandomStarted;
        public event System.EventHandler<LSEventArgs> GroupLootRandomEnded;
        public event System.EventHandler<LSEventArgs> GroupMemberAdded;
        public event System.EventHandler<LSEventArgs> GroupMemberBooted;
        public event System.EventHandler<LSEventArgs> GroupMemberDeath;
        public event System.EventHandler<LSEventArgs> GroupMemberCountChange;
        public event System.EventHandler<LSEventArgs> CraftingStepComplete;
        public event System.EventHandler<LSEventArgs> CraftingAlert;
        public event System.EventHandler<LSEventArgs> ChangeChunk;
        public event System.EventHandler<LSEventArgs> StartSwimming;
        public event System.EventHandler<LSEventArgs> StopSwimming;
        public event System.EventHandler<LSEventArgs> ConnectionStateChange;
        public event System.EventHandler<LSEventArgs> PawnSpawned;
        public event System.EventHandler<LSEventArgs> PawnDespawned;
        public event System.EventHandler<LSEventArgs> IncomingText;
        public event System.EventHandler<LSEventArgs> WeightUpdate;
        public event System.EventHandler<LSEventArgs> AddInventoryItem;
        public event System.EventHandler<LSEventArgs> CoinUpdate;
        public event System.EventHandler<LSEventArgs> ItemStackCountChange;
        public event System.EventHandler<LSEventArgs> ItemCanUseUpdated;
        public event System.EventHandler<LSEventArgs> IncomingCombatText;
        public event System.EventHandler<LSEventArgs> HitObstacle;
        public event System.EventHandler<LSEventArgs> TouchPawn;
        #endregion

        #region .Net Event Raisers
        protected virtual void OnParlayBegin(object Sender,LSEventArgs e)
        {
            System.EventHandler<LSEventArgs> temp = ParlayBegin; 
            if (temp != null)
                temp(Sender, e);
        }
        protected virtual void OnParlayDialog(object Sender,LSEventArgs e)
        {
            System.EventHandler<LSEventArgs> temp = ParlayDialog;
            if (temp != null)
                temp(Sender, e);
        }
        protected virtual void OnParlayUpdate(object Sender,LSEventArgs e)
        {
            System.EventHandler<LSEventArgs> temp = ParlayUpdate;
            if (temp != null)
                temp(Sender, e);
        }
        protected virtual void OnParlayOppTurnBegin(object Sender,LSEventArgs e)
        {
            System.EventHandler<LSEventArgs> temp = ParlayOppTurnBegin;
            if (temp != null)
                temp(Sender, e);
        }
        protected virtual void OnParlayOppTurnEnd(object Sender,LSEventArgs e)
        {
            System.EventHandler<LSEventArgs> temp = ParlayOppTurnEnd;
            if (temp != null)
                temp(Sender, e);
        }
        protected virtual void OnParlayOppPlayedCard(object Sender,LSEventArgs e)
        {
            System.EventHandler<LSEventArgs> temp = ParlayOppPlayedCard;
            if (temp != null)
                temp(Sender, e);
        }
        protected virtual void OnParlaySuccess(object Sender,LSEventArgs e)
        {
            System.EventHandler<LSEventArgs> temp = ParlaySuccess;
            if (temp != null)
                temp(Sender, e);
        }
        protected virtual void OnParlayLoss(object Sender,LSEventArgs e)
        {
            System.EventHandler<LSEventArgs> temp = ParlayLoss;
            if (temp != null)
                temp(Sender, e);
        }
        protected virtual void OnParlayEnd(object Sender,LSEventArgs e)
        {
            System.EventHandler<LSEventArgs> temp = ParlayEnd;
            if (temp != null)
                temp(Sender, e);
        }
        protected virtual void OnGroupBooted(object Sender,LSEventArgs e)
        {
            System.EventHandler<LSEventArgs> temp = GroupBooted;
            if (temp != null)
                temp(Sender, e);
        }
        protected virtual void OnGroupDisbanded(object Sender,LSEventArgs e)
        {
            System.EventHandler<LSEventArgs> temp = GroupDisbanded;
            if (temp != null)
                temp(Sender, e);
        }
        protected virtual void OnGroupFormed(object Sender,LSEventArgs e)
        {
            System.EventHandler<LSEventArgs> temp = GroupFormed;
            if (temp != null)
                temp(Sender, e);
        }
        protected virtual void OnGroupJoined(object Sender,LSEventArgs e)
        {
            System.EventHandler<LSEventArgs> temp = GroupJoined;
            if (temp != null)
                temp(Sender, e);
        }
        protected virtual void OnGroupLootNotify(object Sender,LSEventArgs e)
        {
            System.EventHandler<LSEventArgs> temp = GroupLootNotify;
            if (temp != null)
                temp(Sender, e);
        }
        protected virtual void OnGroupLootRandomStarted(object Sender,LSEventArgs e)
        {
            System.EventHandler<LSEventArgs> temp = GroupLootRandomStarted;
            if (temp != null)
                temp(Sender, e);
        }
        protected virtual void OnGroupLootRandomEnded(object Sender,LSEventArgs e)
        {
            System.EventHandler<LSEventArgs> temp = GroupLootRandomEnded;
            if (temp != null)
                temp(Sender, e);
        }
        protected virtual void OnGroupMemberAdded(object Sender,LSEventArgs e)
        {
            System.EventHandler<LSEventArgs> temp = GroupMemberAdded;
            if (temp != null)
                temp(Sender, e);
        }
        protected virtual void OnGroupMemberBooted(object Sender,LSEventArgs e)
        {
            System.EventHandler<LSEventArgs> temp = GroupMemberBooted;
            if (temp != null)
                temp(Sender, e);
        }
        protected virtual void OnGroupMemberDeath(object Sender,LSEventArgs e)
        {
            System.EventHandler<LSEventArgs> temp = GroupMemberDeath;
            if (temp != null)
                temp(Sender, e);
        }
        protected virtual void OnGroupMemberCountChange(object Sender,LSEventArgs e)
        {
            System.EventHandler<LSEventArgs> temp = GroupMemberCountChange;
            if (temp != null)
                temp(Sender, e);
        }
        protected virtual void OnCraftingStepComplete(object Sender,LSEventArgs e)
        {
            System.EventHandler<LSEventArgs> temp = CraftingStepComplete;
            if (temp != null)
                temp(Sender, e);
        }
        protected virtual void OnCraftingAlert(object Sender,LSEventArgs e)
        {
            System.EventHandler<LSEventArgs> temp = CraftingAlert;
            if (temp != null)
                temp(Sender, e);
        }
        protected virtual void OnChangeChunk(object Sender,LSEventArgs e)
        {
            System.EventHandler<LSEventArgs> temp = ChangeChunk;
            if (temp != null)
                temp(Sender, e);
        }
        protected virtual void OnStartSwimming(object Sender,LSEventArgs e)
        {
            System.EventHandler<LSEventArgs> temp = StartSwimming;
            if (temp != null)
                temp(Sender, e);
        }
        protected virtual void OnStopSwimming(object Sender,LSEventArgs e)
        {
            System.EventHandler<LSEventArgs> temp = StopSwimming;
            if (temp != null)
                temp(Sender, e);
        }
        protected virtual void OnConnectionStateChange(object Sender,LSEventArgs e)
        {
            System.EventHandler<LSEventArgs> temp = ConnectionStateChange;
            if (temp != null)
                temp(Sender, e);
        }
        protected virtual void OnPawnSpawned(object Sender,LSEventArgs e)
        {
            System.EventHandler<LSEventArgs> temp = PawnSpawned;
            if (temp != null)
                temp(Sender, e);
        }
        protected virtual void OnPawnDespawned(object Sender,LSEventArgs e)
        {
            System.EventHandler<LSEventArgs> temp = PawnDespawned;
            if (temp != null)
                temp(Sender, e);
        }
        protected virtual void OnIncomingText(object Sender,LSEventArgs e)
        {
            System.EventHandler<LSEventArgs> temp = IncomingText;
            if (temp != null)
                temp(Sender, e);
        }
        protected virtual void OnWeightUpdate(object Sender,LSEventArgs e)
        {
            System.EventHandler<LSEventArgs> temp = WeightUpdate;
            if (temp != null)
                temp(Sender, e);
        }
        protected virtual void OnAddInventoryItem(object Sender,LSEventArgs e)
        {
            System.EventHandler<LSEventArgs> temp = AddInventoryItem;
            if (temp != null)
                temp(Sender, e);
        }
        protected virtual void OnCoinUpdate(object Sender,LSEventArgs e)
        {
            System.EventHandler<LSEventArgs> temp = CoinUpdate;
            if (temp != null)
                temp(Sender, e);
        }
        protected virtual void OnItemStackCountChange(object Sender,LSEventArgs e)
        {
            System.EventHandler<LSEventArgs> temp = ItemStackCountChange;
            if (temp != null)
                temp(Sender, e);
        }
        protected virtual void OnItemCanUseUpdated(object Sender,LSEventArgs e)
        {
            System.EventHandler<LSEventArgs> temp = ItemCanUseUpdated;
            if (temp != null)
                temp(Sender, e);
        }
        protected virtual void OnIncomingCombatText(object Sender,LSEventArgs e)
        {
            System.EventHandler<LSEventArgs> temp = IncomingCombatText;
            if (temp != null)
                temp(Sender, e);
        }
        protected virtual void OnHitObstacle(object Sender,LSEventArgs e)
        {
            System.EventHandler<LSEventArgs> temp = HitObstacle;
            if (temp != null)
                temp(Sender, e); ;
        }
        protected virtual void OnTouchPawn(object Sender,LSEventArgs e)
        {
            System.EventHandler<LSEventArgs> temp = TouchPawn;
            if (temp != null)
                temp(Sender, e);
        }
        #endregion

        ~VGEvent()
        {
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayBegin"), OnParlayBegin);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayDialog"), OnParlayDialog);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayUpdate"), OnParlayUpdate);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayOppTurnBegin"), OnParlayOppTurnBegin);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayOppTurnEnd"), OnParlayOppTurnEnd);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayOppPlayedCard"), OnParlayOppPlayedCard);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlaySuccess"), OnParlaySuccess);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayLost"), OnParlayLoss);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayEnd"), OnParlayEnd);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupBooted"), OnGroupBooted);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupDisbanded"), OnGroupDisbanded);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupFormed"), OnGroupFormed);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupJoined"), OnGroupJoined);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupLootNotify"), OnGroupLootNotify);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupLootRandomStarted"), OnGroupLootRandomStarted);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupLootRandomEnded"), OnGroupLootRandomEnded);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupMemberAdded"), OnGroupMemberAdded);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupMemberBooted"), OnGroupMemberBooted);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupMemberDeath"), OnGroupMemberDeath);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupMemberCountChange"), OnGroupMemberCountChange);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onCraftingStepComplete"), OnCraftingStepComplete);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onCraftingAlert"), OnCraftingAlert);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onChangeChunk"), OnChangeChunk);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onStartSwimming"), OnStartSwimming);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onStopSwimming"), OnStopSwimming);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onConnectionStateChange"), OnConnectionStateChange);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_OnPawnSpawned"), OnPawnSpawned);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_OnPawnDespawned"), OnPawnDespawned);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_OnIncomingText"), OnIncomingText);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onWeightUpdate"), OnWeightUpdate);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onAddInventoryItem"), OnAddInventoryItem);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onCoinUpdate"), OnCoinUpdate);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onItemStackCountChange"), OnItemStackCountChange);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onItemCanUseUpdated"), OnItemCanUseUpdated);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_OnIncomingCombatText"), OnIncomingCombatText);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onHitObstacle"), OnHitObstacle);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onTouchPawn"), OnTouchPawn);
        }

        public VGEvent()
        {
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayBegin"), OnParlayBegin);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayDialog"), OnParlayDialog);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayUpdate"), OnParlayUpdate);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayOppTurnBegin"), OnParlayOppTurnBegin);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayOppTurnEnd"), OnParlayOppTurnEnd);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayOppPlayedCard"), OnParlayOppPlayedCard);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlaySuccess"), OnParlaySuccess);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayLost"), OnParlayLoss);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayEnd"), OnParlayEnd);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupBooted"), OnGroupBooted);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupDisbanded"), OnGroupDisbanded);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupFormed"), OnGroupFormed);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupJoined"), OnGroupJoined);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupLootNotify"), OnGroupLootNotify);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupLootRandomStarted"), OnGroupLootRandomStarted);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupLootRandomEnded"), OnGroupLootRandomEnded);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupMemberAdded"), OnGroupMemberAdded);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupMemberBooted"), OnGroupMemberBooted);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupMemberDeath"), OnGroupMemberDeath);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupMemberCountChange"), OnGroupMemberCountChange);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onCraftingStepComplete"), OnCraftingStepComplete);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onCraftingAlert"), OnCraftingAlert);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onChangeChunk"), OnChangeChunk);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onStartSwimming"), OnStartSwimming);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onStopSwimming"), OnStopSwimming);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onConnectionStateChange"), OnConnectionStateChange);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_OnPawnSpawned"), OnPawnSpawned);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_OnPawnDespawned"), OnPawnDespawned);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_OnIncomingText"), OnIncomingText);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onWeightUpdate"), OnWeightUpdate);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onAddInventoryItem"), OnAddInventoryItem);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onCoinUpdate"), OnCoinUpdate);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onItemStackCountChange"), OnItemStackCountChange);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onItemCanUseUpdated"), OnItemCanUseUpdated);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_OnIncomingCombatText"), OnIncomingCombatText);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onHitObstacle"), OnHitObstacle);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onTouchPawn"), OnTouchPawn);
        }


    }
}
