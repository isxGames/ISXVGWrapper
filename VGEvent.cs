using System;
using LavishScriptAPI;
using Vanguard.ISXVG.Events;

namespace Vanguard.ISXVG
{
    /// <summary>
    /// A class containing all available Vanguard events you may hook.
    /// </summary>
    public class VGEvent
    {
        #region .Net Events

        public event EventHandler<LSEventArgs> ParlayBegin;
        public event EventHandler<ParlayDialogEventArgs> ParlayDialog;
        public event EventHandler<LSEventArgs> ParlayUpdate;
        public event EventHandler<LSEventArgs> ParlayOppTurnBegin;
        public event EventHandler<LSEventArgs> ParlayOppTurnEnd;
        public event EventHandler<LSEventArgs> ParlayOppPlayedCard;
        public event EventHandler<LSEventArgs> ParlaySuccess;
        public event EventHandler<LSEventArgs> ParlayLoss;
        public event EventHandler<LSEventArgs> ParlayEnd;
        public event EventHandler<LSEventArgs> GroupBooted;
        public event EventHandler<LSEventArgs> GroupDisbanded;
        public event EventHandler<LSEventArgs> GroupFormed;
        public event EventHandler<LSEventArgs> GroupJoined;
        public event EventHandler<LSEventArgs> GroupLootNotify;
        public event EventHandler<LSEventArgs> GroupLootRandomStarted;
        public event EventHandler<LSEventArgs> GroupLootRandomEnded;
        public event EventHandler<GroupMemberAddedEventArgs> GroupMemberAdded;
        public event EventHandler<GroupMemberBootedEventArgs> GroupMemberBooted;
        public event EventHandler<GroupMemberDeathEventArgs> GroupMemberDeath;
        public event EventHandler<LSEventArgs> GroupMemberCountChange;
        public event EventHandler<CraftingStepCompleteEventArgs> CraftingStepComplete;
        public event EventHandler<CraftingAlertEventArgs> CraftingAlert;
        public event EventHandler<ChangeChunkEventArgs> ChangeChunk;
        public event EventHandler<LSEventArgs> StartSwimming;
        public event EventHandler<LSEventArgs> StopSwimming;
        public event EventHandler<LSEventArgs> ConnectionStateChange;
        public event EventHandler<PawnSpawnedEventArgs> PawnSpawned;
        public event EventHandler<PawnDespawnedEventArgs> PawnDespawned;
        public event EventHandler<IncomingTextEventArgs> IncomingText;
        public event EventHandler<WeightUpdateEventArgs> WeightUpdate;
        public event EventHandler<AddInventoryItemEventArgs> AddInventoryItem;
        public event EventHandler<CoinUpdateEventArgs> CoinUpdate;
        public event EventHandler<StackCountChangeEventArgs> ItemStackCountChange;
        public event EventHandler<CanUseUpdatedEventArgs> ItemCanUseUpdated;
        public event EventHandler<IncomingCombatTextEventArgs> IncomingCombatText;
        public event EventHandler<HitObstactleEventArgs> HitObstacle;
        public event EventHandler<TouchPawnEventArgs> TouchPawn;
        public event EventHandler<PawnStatusChangedEventArgs> PawnStatusChange;
        public event EventHandler<PawnIDChangedEventArgs> PawnIDChange;
        public event EventHandler<LSEventArgs> TradeFinished;
        public event EventHandler<LSEventArgs> TradeAcceptanceCanceled;
        public event EventHandler<LSEventArgs> TradeOtherAcceptance;
        public event EventHandler<LSEventArgs> TradeCanceled;
        public event EventHandler<LSEventArgs> TradeOtherCoinSet;
        public event EventHandler<LSEventArgs> TradeOtherItemRemoved;
        public event EventHandler<LSEventArgs> TradeOtherItemAdded;
        public event EventHandler<LSEventArgs> SentTradeInvitationDeclined;
        public event EventHandler<SentTradeInvitationEventArgs> SentTradeInvitationAccepted;
        public event EventHandler<ReceivedTradeInvitationEventArgs> RecievedTradeInvintation;
        public event EventHandler<LSEventArgs> ClickItemLink;
        public event EventHandler<LSEventArgs> MarketWindowOpen;
        public event EventHandler<LSEventArgs> MarketWindowClose;
        public event EventHandler<LSEventArgs> MarketSearchComplete;
        public event EventHandler<LSEventArgs> MarketPlaceItemSuccess;
        public event EventHandler<LSEventArgs> MarketRemoveItem;
        public event EventHandler<AlertTextEventArgs> AlertText;

        #endregion

        #region .Net Event Raisers

        protected virtual void OnParlayBegin(object Sender, LSEventArgs e)
        {
            EventHandler<LSEventArgs> temp = ParlayBegin;
            if (temp != null)
            {
                temp(Sender, e);
            }
        }

        protected virtual void OnParlayDialog(object Sender, LSEventArgs e)
        {
            EventHandler<ParlayDialogEventArgs> temp = ParlayDialog;
            if (temp != null)
            {
                temp(Sender, new ParlayDialogEventArgs());
            }
        }

        protected virtual void OnParlayUpdate(object Sender, LSEventArgs e)
        {
            EventHandler<LSEventArgs> temp = ParlayUpdate;
            if (temp != null)
            {
                temp(Sender, e);
            }
        }

        protected virtual void OnParlayOppTurnBegin(object Sender, LSEventArgs e)
        {
            EventHandler<LSEventArgs> temp = ParlayOppTurnBegin;
            if (temp != null)
            {
                temp(Sender, e);
            }
        }

        protected virtual void OnParlayOppTurnEnd(object Sender, LSEventArgs e)
        {
            EventHandler<LSEventArgs> temp = ParlayOppTurnEnd;
            if (temp != null)
            {
                temp(Sender, e);
            }
        }

        protected virtual void OnParlayOppPlayedCard(object Sender, LSEventArgs e)
        {
            EventHandler<LSEventArgs> temp = ParlayOppPlayedCard;
            if (temp != null)
            {
                temp(Sender, e);
            }
        }

        protected virtual void OnParlaySuccess(object Sender, LSEventArgs e)
        {
            EventHandler<LSEventArgs> temp = ParlaySuccess;
            if (temp != null)
            {
                temp(Sender, e);
            }
        }

        protected virtual void OnParlayLoss(object Sender, LSEventArgs e)
        {
            EventHandler<LSEventArgs> temp = ParlayLoss;
            if (temp != null)
            {
                temp(Sender, e);
            }
        }

        protected virtual void OnParlayEnd(object Sender, LSEventArgs e)
        {
            EventHandler<LSEventArgs> temp = ParlayEnd;
            if (temp != null)
            {
                temp(Sender, e);
            }
        }

        protected virtual void OnGroupBooted(object Sender, LSEventArgs e)
        {
            EventHandler<LSEventArgs> temp = GroupBooted;
            if (temp != null)
            {
                temp(Sender, e);
            }
        }

        protected virtual void OnGroupDisbanded(object Sender, LSEventArgs e)
        {
            EventHandler<LSEventArgs> temp = GroupDisbanded;
            if (temp != null)
            {
                temp(Sender, e);
            }
        }

        protected virtual void OnGroupFormed(object Sender, LSEventArgs e)
        {
            EventHandler<LSEventArgs> temp = GroupFormed;
            if (temp != null)
            {
                temp(Sender, e);
            }
        }

        protected virtual void OnGroupJoined(object Sender, LSEventArgs e)
        {
            EventHandler<LSEventArgs> temp = GroupJoined;
            if (temp != null)
            {
                temp(Sender, e);
            }
        }

        protected virtual void OnGroupLootNotify(object Sender, LSEventArgs e)
        {
            EventHandler<LSEventArgs> temp = GroupLootNotify;
            if (temp != null)
            {
                temp(Sender, e);
            }
        }

        protected virtual void OnGroupLootRandomStarted(object Sender, LSEventArgs e)
        {
            EventHandler<LSEventArgs> temp = GroupLootRandomStarted;
            if (temp != null)
            {
                temp(Sender, e);
            }
        }

        protected virtual void OnGroupLootRandomEnded(object Sender, LSEventArgs e)
        {
            EventHandler<LSEventArgs> temp = GroupLootRandomEnded;
            if (temp != null)
            {
                temp(Sender, e);
            }
        }

        protected virtual void OnGroupMemberAdded(object Sender, LSEventArgs e)
        {
            EventHandler<GroupMemberAddedEventArgs> temp = GroupMemberAdded;
            if (temp != null)
            {
                temp(Sender, (GroupMemberAddedEventArgs) e);
            }
        }

        protected virtual void OnGroupMemberBooted(object Sender, LSEventArgs e)
        {
            EventHandler<GroupMemberBootedEventArgs> temp = GroupMemberBooted;
            if (temp != null)
            {
                temp(Sender, (GroupMemberBootedEventArgs) e);
            }
        }

        protected virtual void OnGroupMemberDeath(object Sender, LSEventArgs e)
        {
            EventHandler<GroupMemberDeathEventArgs> temp = GroupMemberDeath;
            if (temp != null)
            {
                temp(Sender, (GroupMemberDeathEventArgs) e);
            }
        }

        protected virtual void OnGroupMemberCountChange(object Sender, LSEventArgs e)
        {
            EventHandler<LSEventArgs> temp = GroupMemberCountChange;
            if (temp != null)
            {
                temp(Sender, e);
            }
        }

        protected virtual void OnCraftingStepComplete(object Sender, LSEventArgs e)
        {
            EventHandler<CraftingStepCompleteEventArgs> temp = CraftingStepComplete;
            if (temp != null)
            {
                temp(Sender, (CraftingStepCompleteEventArgs) e);
            }
        }

        protected virtual void OnCraftingAlert(object Sender, LSEventArgs e)
        {
            EventHandler<CraftingAlertEventArgs> temp = CraftingAlert;
            if (temp != null)
            {
                temp(Sender, (CraftingAlertEventArgs) e);
            }
        }

        protected virtual void OnChangeChunk(object Sender, LSEventArgs e)
        {
            EventHandler<ChangeChunkEventArgs> temp = ChangeChunk;
            if (temp != null)
            {
                temp(Sender, (ChangeChunkEventArgs) e);
            }
        }

        protected virtual void OnStartSwimming(object Sender, LSEventArgs e)
        {
            EventHandler<LSEventArgs> temp = StartSwimming;
            if (temp != null)
            {
                temp(Sender, e);
            }
        }

        protected virtual void OnStopSwimming(object Sender, LSEventArgs e)
        {
            EventHandler<LSEventArgs> temp = StopSwimming;
            if (temp != null)
            {
                temp(Sender, e);
            }
        }

        protected virtual void OnConnectionStateChange(object Sender, LSEventArgs e)
        {
            EventHandler<LSEventArgs> temp = ConnectionStateChange;
            if (temp != null)
            {
                temp(Sender, e);
            }
        }

        protected virtual void OnPawnSpawned(object Sender, LSEventArgs e)
        {
            EventHandler<PawnSpawnedEventArgs> temp = PawnSpawned;
            if (temp != null)
            {
                temp(Sender, (PawnSpawnedEventArgs) e);
            }
        }

        protected virtual void OnPawnDespawned(object Sender, LSEventArgs e)
        {
            EventHandler<PawnDespawnedEventArgs> temp = PawnDespawned;
            if (temp != null)
            {
                temp(Sender, (PawnDespawnedEventArgs) e);
            }
        }

        protected virtual void OnIncomingText(object Sender, LSEventArgs e)
        {
            EventHandler<IncomingTextEventArgs> temp = IncomingText;
            if (temp != null)
            {
                temp(Sender, (IncomingTextEventArgs) e);
            }
        }

        protected virtual void OnWeightUpdate(object Sender, LSEventArgs e)
        {
            EventHandler<WeightUpdateEventArgs> temp = WeightUpdate;
            if (temp != null)
            {
                temp(Sender, (WeightUpdateEventArgs) e);
            }
        }

        protected virtual void OnAddInventoryItem(object Sender, LSEventArgs e)
        {
            EventHandler<AddInventoryItemEventArgs> temp = AddInventoryItem;
            if (temp != null)
            {
                temp(Sender, (AddInventoryItemEventArgs) e);
            }
        }

        protected virtual void OnCoinUpdate(object Sender, LSEventArgs e)
        {
            EventHandler<CoinUpdateEventArgs> temp = CoinUpdate;
            if (temp != null)
            {
                temp(Sender, (CoinUpdateEventArgs) e);
            }
        }

        protected virtual void OnItemStackCountChange(object Sender, LSEventArgs e)
        {
            EventHandler<StackCountChangeEventArgs> temp = ItemStackCountChange;
            if (temp != null)
            {
                temp(Sender, (StackCountChangeEventArgs) e);
            }
        }

        protected virtual void OnItemCanUseUpdated(object Sender, LSEventArgs e)
        {
            EventHandler<CanUseUpdatedEventArgs> temp = ItemCanUseUpdated;
            if (temp != null)
            {
                temp(Sender, (CanUseUpdatedEventArgs) e);
            }
        }

        protected virtual void OnIncomingCombatText(object Sender, LSEventArgs e)
        {
            EventHandler<IncomingCombatTextEventArgs> temp = IncomingCombatText;
            if (temp != null)
            {
                temp(Sender, (IncomingCombatTextEventArgs) e);
            }
        }

        protected virtual void OnHitObstacle(object Sender, LSEventArgs e)
        {
            EventHandler<HitObstactleEventArgs> temp = HitObstacle;
            if (temp != null)
            {
                temp(Sender, (HitObstactleEventArgs) e);
            }
        }

        protected virtual void OnTouchPawn(object Sender, LSEventArgs e)
        {
            EventHandler<TouchPawnEventArgs> temp = TouchPawn;
            if (temp != null)
            {
                temp(Sender, (TouchPawnEventArgs) e);
            }
        }

        protected virtual void OnPawnStatusChange(object Sender, LSEventArgs e)
        {
            EventHandler<PawnStatusChangedEventArgs> temp = PawnStatusChange;
            if (temp != null)
            {
                temp(Sender, (PawnStatusChangedEventArgs) e);
            }
        }

        protected virtual void OnPawnIDChange(object Sender, LSEventArgs e)
        {
            EventHandler<PawnIDChangedEventArgs> temp = PawnIDChange;
            if (temp != null)
            {
                temp(Sender, (PawnIDChangedEventArgs) e);
            }
        }

        protected virtual void OnTradeFinished(object Sender, LSEventArgs e)
        {
            EventHandler<LSEventArgs> temp = TradeFinished;
            if (temp != null)
            {
                temp(Sender, e);
            }
        }

        protected virtual void OnTradeAcceptanceCanceled(object Sender, LSEventArgs e)
        {
            EventHandler<LSEventArgs> temp = TradeAcceptanceCanceled;
            if (temp != null)
            {
                temp(Sender, e);
            }
        }

        protected virtual void OnTradeOtherAcceptance(object Sender, LSEventArgs e)
        {
            EventHandler<LSEventArgs> temp = TradeOtherAcceptance;
            if (temp != null)
            {
                temp(Sender, e);
            }
        }

        protected virtual void OnTradeCanceled(object Sender, LSEventArgs e)
        {
            EventHandler<LSEventArgs> temp = TradeCanceled;
            if (temp != null)
            {
                temp(Sender, e);
            }
        }

        protected virtual void OnTradeOtherCoinSet(object Sender, LSEventArgs e)
        {
            EventHandler<LSEventArgs> temp = TradeOtherCoinSet;
            if (temp != null)
            {
                temp(Sender, e);
            }
        }

        protected virtual void OnTradeOtherItemRemoved(object Sender, LSEventArgs e)
        {
            EventHandler<LSEventArgs> temp = TradeOtherItemRemoved;
            if (temp != null)
            {
                temp(Sender, e);
            }
        }

        protected virtual void OnTradeOtherItemAdded(object Sender, LSEventArgs e)
        {
            EventHandler<LSEventArgs> temp = TradeOtherItemAdded;
            if (temp != null)
            {
                temp(Sender, e);
            }
        }

        protected virtual void OnSentTradeInvintationDeclined(object Sender, LSEventArgs e)
        {
            EventHandler<LSEventArgs> temp = SentTradeInvitationDeclined;
            if (temp != null)
            {
                temp(Sender, e);
            }
        }

        protected virtual void OnSentTradeInvintationAccepted(object Sender, LSEventArgs e)
        {
            EventHandler<SentTradeInvitationEventArgs> temp = SentTradeInvitationAccepted;
            if (temp != null)
            {
                temp(Sender, (SentTradeInvitationEventArgs) e);
            }
        }

        protected virtual void OnRecievedTradeInvintation(object Sender, LSEventArgs e)
        {
            EventHandler<ReceivedTradeInvitationEventArgs> temp = RecievedTradeInvintation;
            if (temp != null)
            {
                temp(Sender, (ReceivedTradeInvitationEventArgs) e);
            }
        }

        protected virtual void OnClickItemLink(Object Sender, LSEventArgs e)
        {
            EventHandler<LSEventArgs> temp = ClickItemLink;
            if (temp != null)
            {
                temp(Sender, e);
            }
        }

        protected virtual void onMarketWindowOpen(Object Sender, LSEventArgs e)
        {
            EventHandler<LSEventArgs> temp = MarketWindowOpen;
            if (temp != null)
            {
                temp(Sender, e);
            }
        }

        protected virtual void onMarketWindowClose(Object Sender, LSEventArgs e)
        {
            EventHandler<LSEventArgs> temp = MarketWindowClose;
            if (temp != null)
            {
                temp(Sender, e);
            }
        }

        protected virtual void onMarketSearchComplete(Object Sender, LSEventArgs e)
        {
            EventHandler<LSEventArgs> temp = MarketSearchComplete;
            if (temp != null)
            {
                temp(Sender, e);
            }
        }

        protected virtual void onMarketPlaceItemSuccess(Object Sender, LSEventArgs e)
        {
            EventHandler<LSEventArgs> temp = MarketPlaceItemSuccess;
            if (temp != null)
            {
                temp(Sender, e);
            }
        }

        protected virtual void onMarketRemoveItem(Object Sender, LSEventArgs e)
        {
            EventHandler<LSEventArgs> temp = MarketRemoveItem;
            if (temp != null)
            {
                temp(Sender, e);
            }
        }

        protected virtual void onAlertText(Object Sender, LSEventArgs e)
        {
            EventHandler<AlertTextEventArgs> temp = AlertText;
            if (temp != null)
            {
                temp(Sender, (AlertTextEventArgs) e);
            }
        }

        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="VGEvent"/> class.
        /// </summary>
        public VGEvent()
        {
            Attach("VG_onParlayBegin", OnParlayBegin);
            Attach("VG_onParlayDialog", OnParlayDialog);
            Attach("VG_onParlayUpdate", OnParlayUpdate);
            Attach("VG_onParlayOppTurnBegin", OnParlayOppTurnBegin);
            Attach("VG_onParlayOppTurnEnd", OnParlayOppTurnEnd);
            Attach("VG_onParlayOppPlayedCard", OnParlayOppPlayedCard);
            Attach("VG_onParlaySuccess", OnParlaySuccess);
            Attach("VG_onParlayLost", OnParlayLoss);
            Attach("VG_onParlayEnd", OnParlayEnd);
            Attach("VG_onGroupBooted", OnGroupBooted);
            Attach("VG_onGroupDisbanded", OnGroupDisbanded);
            Attach("VG_onGroupFormed", OnGroupFormed);
            Attach("VG_onGroupJoined", OnGroupJoined);
            Attach("VG_onGroupLootNotify", OnGroupLootNotify);
            Attach("VG_onGroupLootRandomStarted", OnGroupLootRandomStarted);
            Attach("VG_onGroupLootRandomEnded", OnGroupLootRandomEnded);
            Attach("VG_onGroupMemberAdded", OnGroupMemberAdded);
            Attach("VG_onGroupMemberBooted", OnGroupMemberBooted);
            Attach("VG_onGroupMemberDeath", OnGroupMemberDeath);
            Attach("VG_onGroupMemberCountChange", OnGroupMemberCountChange);
            Attach("VG_onCraftingStepComplete", OnCraftingStepComplete);
            Attach("VG_onCraftingAlert", OnCraftingAlert);
            Attach("VG_onChangeChunk", OnChangeChunk);
            Attach("VG_onStartSwimming", OnStartSwimming);
            Attach("VG_onStopSwimming", OnStopSwimming);
            Attach("VG_onConnectionStateChange", OnConnectionStateChange);
            Attach("VG_OnPawnSpawned", OnPawnSpawned);
            Attach("VG_OnPawnDespawned", OnPawnDespawned);
            Attach("VG_OnIncomingText", OnIncomingText);
            Attach("VG_onWeightUpdate", OnWeightUpdate);
            Attach("VG_onAddInventoryItem", OnAddInventoryItem);
            Attach("VG_onCoinUpdate", OnCoinUpdate);
            Attach("VG_onItemStackCountChange", OnItemStackCountChange);
            Attach("VG_onItemCanUseUpdated", OnItemCanUseUpdated);
            Attach("VG_OnIncomingCombatText", OnIncomingCombatText);
            Attach("VG_onHitObstacle", OnHitObstacle);
            Attach("VG_onTouchPawn", OnTouchPawn);
            Attach("VG_onPawnIDChange", OnPawnIDChange);
            Attach("VG_onTradeFinished", OnTradeFinished);
            Attach("VG_onTradeAcceptanceCanceled", OnTradeAcceptanceCanceled);
            Attach("VG_onTradeOtherAcceptnace", OnTradeOtherAcceptance);
            Attach("VG_onTradeCanceled", OnTradeCanceled);
            Attach("VG_onTradeOtherCoinSet", OnTradeOtherCoinSet);
            Attach("VG_onTradeOtherItemRemoved", OnTradeOtherItemRemoved);
            Attach("VG_onTradeOtherItemAdded", OnTradeOtherItemAdded);
            Attach("VG_onSentTradeInvintationDeclined", OnSentTradeInvintationDeclined);
            Attach("VG_onSentTradeInvintationAccepted", OnSentTradeInvintationAccepted);
            Attach("VG_onRecievedTradeInvintation", OnRecievedTradeInvintation);
            Attach("VG_onClickItemLink", OnClickItemLink);
            Attach("VG_onMarketWindowOpen", onMarketWindowOpen);
            Attach("VG_onMarketWindowClose", onMarketWindowClose);
            Attach("VG_onMarketSearchComplete", onMarketSearchComplete);
            Attach("VG_onMarketPlaceItemSuccess", onMarketPlaceItemSuccess);
            Attach("VG_onMarketRemoveItem", onMarketRemoveItem);
            Attach("VG_onAlertText", onAlertText);
        }

        ~VGEvent()
        {
            Detach("VG_onParlayBegin", OnParlayBegin);
            Detach("VG_onParlayDialog", OnParlayDialog);
            Detach("VG_onParlayUpdate", OnParlayUpdate);
            Detach("VG_onParlayOppTurnBegin", OnParlayOppTurnBegin);
            Detach("VG_onParlayOppTurnEnd", OnParlayOppTurnEnd);
            Detach("VG_onParlayOppPlayedCard", OnParlayOppPlayedCard);
            Detach("VG_onParlaySuccess", OnParlaySuccess);
            Detach("VG_onParlayLost", OnParlayLoss);
            Detach("VG_onParlayEnd", OnParlayEnd);
            Detach("VG_onGroupBooted", OnGroupBooted);
            Detach("VG_onGroupDisbanded", OnGroupDisbanded);
            Detach("VG_onGroupFormed", OnGroupFormed);
            Detach("VG_onGroupJoined", OnGroupJoined);
            Detach("VG_onGroupLootNotify", OnGroupLootNotify);
            Detach("VG_onGroupLootRandomStarted", OnGroupLootRandomStarted);
            Detach("VG_onGroupLootRandomEnded", OnGroupLootRandomEnded);
            Detach("VG_onGroupMemberAdded", OnGroupMemberAdded);
            Detach("VG_onGroupMemberBooted", OnGroupMemberBooted);
            Detach("VG_onGroupMemberDeath", OnGroupMemberDeath);
            Detach("VG_onGroupMemberCountChange", OnGroupMemberCountChange);
            Detach("VG_onCraftingStepComplete", OnCraftingStepComplete);
            Detach("VG_onCraftingAlert", OnCraftingAlert);
            Detach("VG_onChangeChunk", OnChangeChunk);
            Detach("VG_onStartSwimming", OnStartSwimming);
            Detach("VG_onStopSwimming", OnStopSwimming);
            Detach("VG_onConnectionStateChange", OnConnectionStateChange);
            Detach("VG_OnPawnSpawned", OnPawnSpawned);
            Detach("VG_OnPawnDespawned", OnPawnDespawned);
            Detach("VG_OnIncomingText", OnIncomingText);
            Detach("VG_onWeightUpdate", OnWeightUpdate);
            Detach("VG_onAddInventoryItem", OnAddInventoryItem);
            Detach("VG_onCoinUpdate", OnCoinUpdate);
            Detach("VG_onItemStackCountChange", OnItemStackCountChange);
            Detach("VG_onItemCanUseUpdated", OnItemCanUseUpdated);
            Detach("VG_OnIncomingCombatText", OnIncomingCombatText);
            Detach("VG_onHitObstacle", OnHitObstacle);
            Detach("VG_onTouchPawn", OnTouchPawn);
            Detach("VG_onPawnStatusChange", OnPawnStatusChange);
            Detach("VG_onPawnIDChange", OnPawnIDChange);
            Detach("VG_onTradeFinished", OnTradeFinished);
            Detach("VG_onTradeAcceptanceCanceled", OnTradeAcceptanceCanceled);
            Detach("VG_onTradeOtherAcceptance", OnTradeOtherAcceptance);
            Detach("VG_onTradeCanceled", OnTradeCanceled);
            Detach("VG_onTradeOtherCoinSet", OnTradeOtherCoinSet);
            Detach("VG_onTradeOtherItemRemoved", OnTradeOtherItemRemoved);
            Detach("VG_onTradeOtherItemAdded", OnTradeOtherItemAdded);
            Detach("VG_onSentTradeInvintationDeclined", OnSentTradeInvintationDeclined);
            Detach("VG_onSentTradeInvintationAccepted", OnSentTradeInvintationAccepted);
            Detach("VG_onRecievedTradeInvintation", OnRecievedTradeInvintation);
            Detach("VG_onClickItemLink", OnClickItemLink);
            Detach("VG_onMarketWindowOpen", onMarketWindowOpen);
            Detach("VG_onMarketWindowClose", onMarketWindowClose);
            Detach("VG_onMarketSearchComplete", onMarketSearchComplete);
            Detach("VG_onMarketPlaceItemSuccess", onMarketPlaceItemSuccess);
            Detach("VG_onMarketRemoveItem", onMarketRemoveItem);
            Detach("VG_onAlertText", onAlertText);
        }

        #region Smaller footprint attach/detach methods

        /// <summary>
        /// Attaches the specified event to the specified handler.
        /// </summary>
        /// <param name="eventToAttach">The event to attach.</param>
        /// <param name="handler">The handler.</param>
        public void Attach(string eventToAttach, EventHandler<LSEventArgs> handler)
        {
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent(eventToAttach), handler);
        }

        /// <summary>
        /// Detaches the specified event from the specified handler.
        /// </summary>
        /// <param name="eventToDetach">The event to detach.</param>
        /// <param name="handler">The handler.</param>
        public void Detach(string eventToDetach, EventHandler<LSEventArgs> handler)
        {
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent(eventToDetach), handler);
        }

        #endregion
    }
}