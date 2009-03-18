using System;
using System.Collections.Generic;
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
        public event EventHandler<LSEventArgs> ParlayDialog;
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
        public event EventHandler<LSEventArgs> GroupMemberAdded;
        public event EventHandler<LSEventArgs> GroupMemberBooted;
        public event EventHandler<LSEventArgs> GroupMemberDeath;
        public event EventHandler<LSEventArgs> GroupMemberCountChange;
        public event EventHandler<LSEventArgs> CraftingAlert;
        public event EventHandler<LSEventArgs> ChangeChunk;
        public event EventHandler<LSEventArgs> StartSwimming;
        public event EventHandler<LSEventArgs> StopSwimming;
        public event EventHandler<LSEventArgs> ConnectionStateChange;
        public event EventHandler<LSEventArgs> PawnSpawned;
        public event EventHandler<LSEventArgs> PawnDespawned;
        public event EventHandler<LSEventArgs> IncomingText;
        public event EventHandler<LSEventArgs> WeightUpdate;
        public event EventHandler<LSEventArgs> AddInventoryItem;
        public event EventHandler<LSEventArgs> CoinUpdate;
        public event EventHandler<LSEventArgs> ItemStackCountChange;
        public event EventHandler<LSEventArgs> ItemCanUseUpdated;
        public event EventHandler<LSEventArgs> IncomingCombatText;
        public event EventHandler<LSEventArgs> HitObstacle;
        public event EventHandler<LSEventArgs> TouchPawn;
        public event EventHandler<LSEventArgs> PawnStatusChange;
        public event EventHandler<LSEventArgs> PawnIDChange;
        public event EventHandler<LSEventArgs> TradeFinished;
        public event EventHandler<LSEventArgs> TradeAcceptanceCanceled;
        public event EventHandler<LSEventArgs> TradeOtherAcceptance;
        public event EventHandler<LSEventArgs> TradeCanceled;
        public event EventHandler<LSEventArgs> TradeOtherCoinSet;
        public event EventHandler<LSEventArgs> TradeOtherItemRemoved;
        public event EventHandler<LSEventArgs> TradeOtherItemAdded;
        public event EventHandler<LSEventArgs> SentTradeInvitationDeclined;
        public event EventHandler<LSEventArgs> SentTradeInvitationAccepted;
        public event EventHandler<LSEventArgs> RecievedTradeInvintation;
        public event EventHandler<LSEventArgs> ClickItemLink;
        public event EventHandler<LSEventArgs> MarketWindowOpen;
        public event EventHandler<LSEventArgs> MarketWindowClose;
        public event EventHandler<LSEventArgs> MarketSearchComplete;
        public event EventHandler<LSEventArgs> MarketPlaceItemSuccess;
        public event EventHandler<LSEventArgs> MarketRemoveItem;
        public event EventHandler<LSEventArgs> AlertText;
        public event EventHandler<LSEventArgs> CraftingStepComplete;

        public event EventHandler<AlertTextEventArgs> AlertTextNew;
        public event EventHandler<GroupMemberAddedEventArgs> GroupMemberAddedNew;
        public event EventHandler<GroupMemberBootedEventArgs> GroupMemberBootedNew;
        public event EventHandler<GroupMemberDeathEventArgs> GroupMemberDeathNew;
        public event EventHandler<CraftingStepCompleteEventArgs> CraftingStepCompleteNew;
        public event EventHandler<CraftingAlertEventArgs> CraftingAlertNew;
        public event EventHandler<ChangeChunkEventArgs> ChangeChunkNew;
        public event EventHandler<PawnSpawnedEventArgs> PawnSpawnedNew;
        public event EventHandler<PawnDespawnedEventArgs> PawnDespawnedNew;
        public event EventHandler<ParlayDialogEventArgs> ParlayDialogNew;
        public event EventHandler<IncomingTextEventArgs> IncomingTextNew;
        public event EventHandler<WeightUpdateEventArgs> WeightUpdateNew;
        public event EventHandler<AddInventoryItemEventArgs> AddInventoryItemNew;
        public event EventHandler<CoinUpdateEventArgs> CoinUpdateNew;
        public event EventHandler<StackCountChangeEventArgs> ItemStackCountChangeNew;
        public event EventHandler<CanUseUpdatedEventArgs> ItemCanUseUpdatedNew;
        public event EventHandler<IncomingCombatTextEventArgs> IncomingCombatTextNew;
        public event EventHandler<HitObstactleEventArgs> HitObstacleNew;
        public event EventHandler<TouchPawnEventArgs> TouchPawnNew;
        public event EventHandler<PawnStatusChangedEventArgs> PawnStatusChangeNew;
        public event EventHandler<PawnIDChangedEventArgs> PawnIDChangeNew;
        public event EventHandler<SentTradeInvitationEventArgs> SentTradeInvitationAcceptedNew;
        public event EventHandler<ReceivedTradeInvitationEventArgs> RecievedTradeInvintationNew;

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
            EventHandler<LSEventArgs> temp = ParlayDialog;
            if (temp != null)
            {
                temp(Sender, e);
            }
        }
        protected virtual void OnParlayDialogNew(object Sender, LSEventArgs e)
        {
            EventHandler<ParlayDialogEventArgs> temp = ParlayDialogNew;
            if (temp != null)
            {
                temp(Sender, new ParlayDialogEventArgs(e.Args));
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
            EventHandler<LSEventArgs> temp = GroupMemberAdded;
            if (temp != null)
            {
                temp(Sender, e);
            }
        }

        protected virtual void OnGroupMemberAddedNew(object Sender, LSEventArgs e)
        {
            EventHandler<GroupMemberAddedEventArgs> temp = GroupMemberAddedNew;
            if (temp != null)
            {
                temp(Sender, new GroupMemberAddedEventArgs(e.Args));
            }
        }

        protected virtual void OnGroupMemberBooted(object Sender, LSEventArgs e)
        {
            EventHandler<LSEventArgs> temp = GroupMemberBooted;
            if (temp != null)
            {
                temp(Sender, e);
            }
        }

        protected virtual void OnGroupMemberBootedNew(object Sender, LSEventArgs e)
        {
            EventHandler<GroupMemberBootedEventArgs> temp = GroupMemberBootedNew;
            if (temp != null)
            {
                temp(Sender, new GroupMemberBootedEventArgs(e.Args));
            }
        }

        protected virtual void OnGroupMemberDeath(object Sender, LSEventArgs e)
        {
            EventHandler<LSEventArgs> temp = GroupMemberDeath;
            if (temp != null)
            {
                temp(Sender, e);
            }
        }

        protected virtual void OnGroupMemberDeathNew(object Sender, LSEventArgs e)
        {
            EventHandler<GroupMemberDeathEventArgs> temp = GroupMemberDeathNew;
            if (temp != null)
            {
                temp(Sender, new GroupMemberDeathEventArgs(e.Args));
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
            EventHandler<LSEventArgs> temp = CraftingStepComplete;
            if (temp != null)
            {
                temp(Sender,e);
            }
        }
        protected virtual void OnCraftingStepCompleteNew(object Sender, LSEventArgs e)
        {
            EventHandler<CraftingStepCompleteEventArgs> temp = CraftingStepCompleteNew;
            if (temp != null)
            {
                temp(Sender, new CraftingStepCompleteEventArgs(e.Args));
            }
        }

        protected virtual void OnCraftingAlert(object Sender, LSEventArgs e)
        {
            EventHandler<LSEventArgs> temp = CraftingAlert;
            if (temp != null)
            {
                temp(Sender, e);
            }
        }
        protected virtual void OnCraftingAlertNew(object Sender, LSEventArgs e)
        {
            EventHandler<CraftingAlertEventArgs> temp = CraftingAlertNew;
            if (temp != null)
            {
                temp(Sender, new CraftingAlertEventArgs(e.Args));
            }
        }

        protected virtual void OnChangeChunk(object Sender, LSEventArgs e)
        {
            EventHandler<LSEventArgs> temp = ChangeChunk;
            if (temp != null)
            {
                temp(Sender, e);
            }
        }
        protected virtual void OnChangeChunkNew(object Sender, LSEventArgs e)
        {
            EventHandler<ChangeChunkEventArgs> temp = ChangeChunkNew;
            if (temp != null)
            {
                temp(Sender, new ChangeChunkEventArgs(e.Args));
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
            EventHandler<LSEventArgs> temp = PawnSpawned;
            if (temp != null)
            {
                temp(Sender, e);
            }
        }

        protected virtual void OnPawnDespawned(object Sender, LSEventArgs e)
        {
            EventHandler<LSEventArgs> temp = PawnDespawned;
            if (temp != null)
            {
                temp(Sender, e);
            }
        }

        protected virtual void OnIncomingText(object Sender, LSEventArgs e)
        {
            EventHandler<LSEventArgs> temp = IncomingText;
            if (temp != null)
            {
                temp(Sender, e);
            }
        }

        protected virtual void OnWeightUpdate(object Sender, LSEventArgs e)
        {
            EventHandler<LSEventArgs> temp = WeightUpdate;
            if (temp != null)
            {
                temp(Sender, e);
            }
        }

        protected virtual void OnAddInventoryItem(object Sender, LSEventArgs e)
        {
            EventHandler<LSEventArgs> temp = AddInventoryItem;
            if (temp != null)
            {
                temp(Sender, e);
            }
        }

        protected virtual void OnCoinUpdate(object Sender, LSEventArgs e)
        {
            EventHandler<LSEventArgs> temp = CoinUpdate;
            if (temp != null)
            {
                temp(Sender, e);
            }
        }

        protected virtual void OnItemStackCountChange(object Sender, LSEventArgs e)
        {
            EventHandler<LSEventArgs> temp = ItemStackCountChange;
            if (temp != null)
            {
                temp(Sender, e);
            }
        }

        protected virtual void OnItemCanUseUpdated(object Sender, LSEventArgs e)
        {
            EventHandler<LSEventArgs> temp = ItemCanUseUpdated;
            if (temp != null)
            {
                temp(Sender, e);
            }
        }

        protected virtual void OnIncomingCombatText(object Sender, LSEventArgs e)
        {
            EventHandler<LSEventArgs> temp = IncomingCombatText;
            if (temp != null)
            {
                temp(Sender, e);
            }
        }

        protected virtual void OnHitObstacle(object Sender, LSEventArgs e)
        {
            EventHandler<LSEventArgs> temp = HitObstacle;
            if (temp != null)
            {
                temp(Sender, e);
            }
        }

        protected virtual void OnTouchPawn(object Sender, LSEventArgs e)
        {
            EventHandler<LSEventArgs> temp = TouchPawn;
            if (temp != null)
            {
                temp(Sender, e);
            }
        }

        protected virtual void OnPawnStatusChange(object Sender, LSEventArgs e)
        {
            EventHandler<LSEventArgs> temp = PawnStatusChange;
            if (temp != null)
            {
                temp(Sender, e);
            }
        }

        protected virtual void OnPawnIDChange(object Sender, LSEventArgs e)
        {
            EventHandler<LSEventArgs> temp = PawnIDChange;
            if (temp != null)
            {
                temp(Sender, e);
            }
        }

        protected virtual void OnPawnSpawnedNew(object Sender, LSEventArgs e)
        {
            EventHandler<PawnSpawnedEventArgs> temp = PawnSpawnedNew;
            if (temp != null)
            {
                temp(Sender, new PawnSpawnedEventArgs(e.Args));
            }
        }

        protected virtual void OnPawnDespawnedNew(object Sender, LSEventArgs e)
        {
            EventHandler<PawnDespawnedEventArgs> temp = PawnDespawnedNew;
            if (temp != null)
            {
                temp(Sender, new PawnDespawnedEventArgs(e.Args));
            }
        }

        protected virtual void OnIncomingTextNew(object Sender, LSEventArgs e)
        {
            EventHandler<IncomingTextEventArgs> temp = IncomingTextNew;
            if (temp != null)
            {
                temp(Sender, new IncomingTextEventArgs(e.Args));
            }
        }

        protected virtual void OnWeightUpdateNew(object Sender, LSEventArgs e)
        {
            EventHandler<WeightUpdateEventArgs> temp = WeightUpdateNew;
            if (temp != null)
            {
                temp(Sender, new WeightUpdateEventArgs(e.Args));
            }
        }

        protected virtual void OnAddInventoryItemNew(object Sender, LSEventArgs e)
        {
            EventHandler<AddInventoryItemEventArgs> temp = AddInventoryItemNew;
            if (temp != null)
            {
                temp(Sender, new AddInventoryItemEventArgs(e.Args));
            }
        }

        protected virtual void OnCoinUpdateNew(object Sender, LSEventArgs e)
        {
            EventHandler<CoinUpdateEventArgs> temp = CoinUpdateNew;
            if (temp != null)
            {
                temp(Sender, new CoinUpdateEventArgs(e.Args));
            }
        }

        protected virtual void OnItemStackCountChangeNew(object Sender, LSEventArgs e)
        {
            EventHandler<StackCountChangeEventArgs> temp = ItemStackCountChangeNew;
            if (temp != null)
            {
                temp(Sender, new StackCountChangeEventArgs(e.Args));
            }
        }

        protected virtual void OnItemCanUseUpdatedNew(object Sender, LSEventArgs e)
        {
            EventHandler<CanUseUpdatedEventArgs> temp = ItemCanUseUpdatedNew;
            if (temp != null)
            {
                temp(Sender, new CanUseUpdatedEventArgs(e.Args));
            }
        }

        protected virtual void OnIncomingCombatTextNew(object Sender, LSEventArgs e)
        {
            EventHandler<IncomingCombatTextEventArgs> temp = IncomingCombatTextNew;
            if (temp != null)
            {
                temp(Sender, new IncomingCombatTextEventArgs(e.Args));
            }
        }

        protected virtual void OnHitObstacleNew(object Sender, LSEventArgs e)
        {
            EventHandler<HitObstactleEventArgs> temp = HitObstacleNew;
            if (temp != null)
            {
                temp(Sender, new HitObstactleEventArgs(e.Args));
            }
        }

        protected virtual void OnTouchPawnNew(object Sender, LSEventArgs e)
        {
            EventHandler<TouchPawnEventArgs> temp = TouchPawnNew;
            if (temp != null)
            {
                temp(Sender, new TouchPawnEventArgs(e.Args));
            }
        }

        protected virtual void OnPawnStatusChangeNew(object Sender, LSEventArgs e)
        {
            EventHandler<PawnStatusChangedEventArgs> temp = PawnStatusChangeNew;
            if (temp != null)
            {
                temp(Sender, new PawnStatusChangedEventArgs(e.Args));
            }
        }

        protected virtual void OnPawnIDChangeNew(object Sender, LSEventArgs e)
        {
            EventHandler<PawnIDChangedEventArgs> temp = PawnIDChangeNew;
            if (temp != null)
            {
                temp(Sender, new PawnIDChangedEventArgs(e.Args));
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
            EventHandler<LSEventArgs> temp = SentTradeInvitationAccepted;
            if (temp != null)
            {
                temp(Sender, e);
            }
        }

        protected virtual void OnRecievedTradeInvintation(object Sender, LSEventArgs e)
        {
            EventHandler<LSEventArgs> temp = RecievedTradeInvintation;
            if (temp != null)
            {
                temp(Sender, e);
            }
        }

        protected virtual void OnSentTradeInvintationAcceptedNew(object Sender, LSEventArgs e)
        {
            EventHandler<SentTradeInvitationEventArgs> temp = SentTradeInvitationAcceptedNew;
            if (temp != null)
            {
                temp(Sender, new SentTradeInvitationEventArgs(e.Args));
            }
        }

        protected virtual void OnRecievedTradeInvintationNew(object Sender, LSEventArgs e)
        {
            EventHandler<ReceivedTradeInvitationEventArgs> temp = RecievedTradeInvintationNew;
            if (temp != null)
            {
                temp(Sender, new ReceivedTradeInvitationEventArgs(e.Args));
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

        protected virtual void onAlertTextNew(Object Sender, LSEventArgs e)
        {
            EventHandler<AlertTextEventArgs> temp = AlertTextNew;
            if (temp != null)
            {
                temp(Sender, new AlertTextEventArgs(e.Args));
            }
        }

        protected virtual void onAlertText(Object Sender, LSEventArgs e)
        {
            EventHandler<LSEventArgs> temp = AlertText;
            if (temp != null)
            {
                temp(Sender, e);
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
            Attach("VG_onPawnStatusChange", OnPawnStatusChange);



            Attach("VG_onAlertText", onAlertTextNew);
            Attach("VG_onParlayDialog", OnParlayDialogNew);
            Attach("VG_onGroupMemberAdded", OnGroupMemberAddedNew);
            Attach("VG_onGroupMemberBooted", OnGroupMemberBootedNew);
            Attach("VG_onGroupMemberDeath", OnGroupMemberDeathNew);
            Attach("VG_onCraftingStepComplete", OnCraftingStepCompleteNew);
            Attach("VG_onCraftingAlert", OnCraftingAlertNew);
            Attach("VG_onChangeChunk", OnChangeChunkNew);
            Attach("VG_OnPawnSpawned", OnPawnSpawnedNew);
            Attach("VG_OnPawnDespawned", OnPawnDespawnedNew);
            Attach("VG_OnIncomingText", OnIncomingTextNew);
            Attach("VG_onWeightUpdate", OnWeightUpdateNew);
            Attach("VG_onAddInventoryItem", OnAddInventoryItemNew);
            Attach("VG_onCoinUpdate", OnCoinUpdateNew);
            Attach("VG_onItemStackCountChange", OnItemStackCountChangeNew);
            Attach("VG_onItemCanUseUpdated", OnItemCanUseUpdatedNew);
            Attach("VG_OnIncomingCombatText", OnIncomingCombatTextNew);
            Attach("VG_onHitObstacle", OnHitObstacleNew);
            Attach("VG_onTouchPawn", OnTouchPawnNew);
            Attach("VG_onPawnIDChange", OnPawnIDChangeNew);
            Attach("VG_onSentTradeInvintationAccepted", OnSentTradeInvintationAcceptedNew);
            Attach("VG_onRecievedTradeInvintation", OnRecievedTradeInvintationNew);
            Attach("VG_onPawnStatusChange", OnPawnStatusChangeNew);
        }

        ~VGEvent()
        {
            #region Old Detach nuisance.
            Detach("VG_onParlayDialog", OnParlayDialogNew);
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

            Detach("VG_onAlertText", onAlertTextNew);
            Detach("VG_onParlayDialog", OnParlayDialogNew);
            Detach("VG_onGroupMemberAdded", OnGroupMemberAddedNew);
            Detach("VG_onGroupMemberBooted", OnGroupMemberBootedNew);
            Detach("VG_onGroupMemberDeath", OnGroupMemberDeathNew);
            Detach("VG_onCraftingStepComplete", OnCraftingStepCompleteNew);
            Detach("VG_onCraftingAlert", OnCraftingAlertNew);
            Detach("VG_onChangeChunk", OnChangeChunkNew);
            Detach("VG_OnPawnSpawned", OnPawnSpawnedNew);
            Detach("VG_OnPawnDespawned", OnPawnDespawnedNew);
            Detach("VG_OnIncomingText", OnIncomingTextNew);
            Detach("VG_onWeightUpdate", OnWeightUpdateNew);
            Detach("VG_onAddInventoryItem", OnAddInventoryItemNew);
            Detach("VG_onCoinUpdate", OnCoinUpdateNew);
            Detach("VG_onItemStackCountChange", OnItemStackCountChangeNew);
            Detach("VG_onItemCanUseUpdated", OnItemCanUseUpdatedNew);
            Detach("VG_OnIncomingCombatText", OnIncomingCombatTextNew);
            Detach("VG_onHitObstacle", OnHitObstacleNew);
            Detach("VG_onTouchPawn", OnTouchPawnNew);
            Detach("VG_onPawnIDChange", OnPawnIDChangeNew);
            Detach("VG_onSentTradeInvintationAccepted", OnSentTradeInvintationAcceptedNew);
            Detach("VG_onRecievedTradeInvintation", OnRecievedTradeInvintationNew);
            Detach("VG_onPawnStatusChange", OnPawnStatusChangeNew);
            #endregion
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