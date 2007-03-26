using System;
using System.Text;

using LavishVMAPI;
using InnerSpaceAPI;
using LavishScriptAPI;


namespace Vanguard.ISXVG
{
    public class VGEvent
    {
        #region .Net Event Handlers
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

        ~VGEvent()
        {
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayBegin"), ParlayBegin);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayDialog"), ParlayDialog);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayUpdate"), ParlayUpdate);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayOppTurnBegin"), ParlayOppTurnBegin);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayOppTurnEnd"), ParlayOppTurnEnd);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayOppPlayedCard"), ParlayOppPlayedCard);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlaySuccess"), ParlaySuccess);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayLost"), ParlayLoss);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayEnd"), ParlayEnd);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupBooted"), GroupBooted);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupDisbanded"), GroupDisbanded);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupFormed"), GroupFormed);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupJoined"), GroupJoined);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupLootNotify"), GroupLootNotify);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupLootRandomStarted"), GroupLootRandomStarted);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupLootRandomEnded"), GroupLootRandomEnded);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupMemberAdded"), GroupMemberAdded);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupMemberBooted"), GroupMemberBooted);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupMemberDeath"), GroupMemberDeath);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupMemberCountChange"), GroupMemberCountChange);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onCraftingStepComplete"), CraftingStepComplete);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onCraftingAlert"), CraftingAlert);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onChangeChunk"), ChangeChunk);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onStartSwimming"), StartSwimming);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onStopSwimming"), StopSwimming);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onConnectionStateChange"), ConnectionStateChange);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_OnPawnSpawned"), PawnSpawned);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_OnPawnDespawned"), PawnDespawned);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_OnIncomingText"), IncomingText);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onWeightUpdate"), WeightUpdate);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onAddInventoryItem"), AddInventoryItem);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onCoinUpdate"), CoinUpdate);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onItemStackCountChange"), ItemStackCountChange);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onItemCanUseUpdated"), ItemCanUseUpdated);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_OnIncomingCombatText"), IncomingCombatText);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onHitObstacle"), HitObstacle);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("VG_onTouchPawn"), TouchPawn);
        }

        public VGEvent()
        {
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayBegin"), ParlayBegin);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayDialog"), ParlayDialog);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayUpdate"), ParlayUpdate);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayOppTurnBegin"), ParlayOppTurnBegin);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayOppTurnEnd"), ParlayOppTurnEnd);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayOppPlayedCard"), ParlayOppPlayedCard);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlaySuccess"), ParlaySuccess);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayLost"), ParlayLoss);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onParlayEnd"), ParlayEnd);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupBooted"), GroupBooted);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupDisbanded"), GroupDisbanded);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupFormed"), GroupFormed);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupJoined"), GroupJoined);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupLootNotify"), GroupLootNotify);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupLootRandomStarted"), GroupLootRandomStarted);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupLootRandomEnded"), GroupLootRandomEnded);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupMemberAdded"), GroupMemberAdded);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupMemberBooted"), GroupMemberBooted);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupMemberDeath"), GroupMemberDeath);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onGroupMemberCountChange"), GroupMemberCountChange);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onCraftingStepComplete"), CraftingStepComplete);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onCraftingAlert"), CraftingAlert);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onChangeChunk"), ChangeChunk);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onStartSwimming"), StartSwimming);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onStopSwimming"), StopSwimming);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onConnectionStateChange"), ConnectionStateChange);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_OnPawnSpawned"), PawnSpawned);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_OnPawnDespawned"), PawnDespawned);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_OnIncomingText"), IncomingText);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onWeightUpdate"), WeightUpdate);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onAddInventoryItem"), AddInventoryItem);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onCoinUpdate"), CoinUpdate);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onItemStackCountChange"), ItemStackCountChange);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onItemCanUseUpdated"), ItemCanUseUpdated);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_OnIncomingCombatText"), IncomingCombatText);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onHitObstacle"), HitObstacle);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("VG_onTouchPawn"), TouchPawn);
        }


    }
}
