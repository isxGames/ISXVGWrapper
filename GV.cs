using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    /// <summary>
    /// Retrieves Vanguard game variables 
    /// </summary>
    public class GV : LavishScriptObject
    {
        #region GameVariableBool enum

        /// <summary>
        /// 
        /// </summary>
        public enum GameVariableBool
        {
            /// <summary>
            /// 
            /// </summary>
            ActiveGroupLootAutoSplitCoin,
            /// <summary>
            /// 
            /// </summary>
            ActiveGroupLootPassOutCashLoot,
            /// <summary>
            /// 
            /// </summary>
            AdvBlockVisible,
            /// <summary>
            /// 
            /// </summary>
            AdvDefComma0,
            /// <summary>
            /// 
            /// </summary>
            AdvDefComma1,
            /// <summary>
            /// 
            /// </summary>
            AdvDodgeVisible,
            /// <summary>
            /// 
            /// </summary>
            AdvParryVisible,
            /// <summary>
            /// 
            /// </summary>
            AsmRecipeIngredientFulfilled0,
            /// <summary>
            /// 
            /// </summary>
            AsmRecipeIngredientFulfilled1,
            /// <summary>
            /// 
            /// </summary>
            AsmRecipeIngredientFulfilled2,
            /// <summary>
            /// 
            /// </summary>
            AsmRecipeIngredientFulfilled3,
            /// <summary>
            /// 
            /// </summary>
            AsmRecipeIngredientFulfilled4,
            /// <summary>
            /// 
            /// </summary>
            AssemblyTraining,
            /// <summary>
            /// 
            /// </summary>
            Banking,
            /// <summary>
            /// 
            /// </summary>
            bAsmRecipeSelected,
            /// <summary>
            /// 
            /// </summary>
            bAssembling,
            /// <summary>
            /// 
            /// </summary>
            bAvailableWorkOrderSelected,
            /// <summary>
            /// 
            /// </summary>
            bBuildingGuildUsable,
            /// <summary>
            /// 
            /// </summary>
            bBuildingViewFixtureList,
            /// <summary>
            /// 
            /// </summary>
            bCanAssemble,
            /// <summary>
            /// 
            /// </summary>
            bCanBeAggrodOnSelf,
            /// <summary>
            /// 
            /// </summary>
            bCanChangeGuildUsable,
            /// <summary>
            /// 
            /// </summary>
            bCanSpendAdvAllocPoints,
            /// <summary>
            /// 
            /// </summary>
            bCanSpendAdvRefundPoints,
            /// <summary>
            /// 
            /// </summary>
            bCanSpendCraAllocPoints,
            /// <summary>
            /// 
            /// </summary>
            bCanSpendCraRefundPoints,
            /// <summary>
            /// 
            /// </summary>
            bCasting,
            /// <summary>
            /// 
            /// </summary>
            bCharacterCreate,
            /// <summary>
            /// 
            /// </summary>
            bCharacterCreateClassAvailableBard,
            /// <summary>
            /// 
            /// </summary>
            bCharacterCreateClassAvailableBloodMage,
            /// <summary>
            /// 
            /// </summary>
            bCharacterCreateClassAvailableCleric,
            /// <summary>
            /// 
            /// </summary>
            bCharacterCreateClassAvailableDisciple,
            /// <summary>
            /// 
            /// </summary>
            bCharacterCreateClassAvailableDreadKnight,
            /// <summary>
            /// 
            /// </summary>
            bCharacterCreateClassAvailableDruid,
            /// <summary>
            /// 
            /// </summary>
            bCharacterCreateClassAvailableInquisitor,
            /// <summary>
            /// 
            /// </summary>
            bCharacterCreateClassAvailableMonk,
            /// <summary>
            /// 
            /// </summary>
            bCharacterCreateClassAvailableNecromancer,
            /// <summary>
            /// 
            /// </summary>
            bCharacterCreateClassAvailablePaladin,
            /// <summary>
            /// 
            /// </summary>
            bCharacterCreateClassAvailablePsionicist,
            /// <summary>
            /// 
            /// </summary>
            bCharacterCreateClassAvailableRanger,
            /// <summary>
            /// 
            /// </summary>
            bCharacterCreateClassAvailableRogue,
            /// <summary>
            /// 
            /// </summary>
            bCharacterCreateClassAvailableShaman,
            /// <summary>
            /// 
            /// </summary>
            bCharacterCreateClassAvailableSorcerer,
            /// <summary>
            /// 
            /// </summary>
            bCharacterCreateClassAvailableWarrior,
            /// <summary>
            /// 
            /// </summary>
            bCharacterCreateError,
            /// <summary>
            /// 
            /// </summary>
            bCharacterCreateLoadTemplate,
            /// <summary>
            /// 
            /// </summary>
            bCharacterCreateName,
            /// <summary>
            /// 
            /// </summary>
            bCharacterCreateNavigation,
            /// <summary>
            /// 
            /// </summary>
            bCharacterCreateRaceAvailableDarkElf,
            /// <summary>
            /// 
            /// </summary>
            bCharacterCreateRaceAvailableDwarf,
            /// <summary>
            /// 
            /// </summary>
            bCharacterCreateRaceAvailableGnome,
            /// <summary>
            /// 
            /// </summary>
            bCharacterCreateRaceAvailableGoblin,
            /// <summary>
            /// 
            /// </summary>
            bCharacterCreateRaceAvailableHalfElf,
            /// <summary>
            /// 
            /// </summary>
            bCharacterCreateRaceAvailableHalfling,
            /// <summary>
            /// 
            /// </summary>
            bCharacterCreateRaceAvailableHighElf,
            /// <summary>
            /// 
            /// </summary>
            bCharacterCreateRaceAvailableKojani,
            /// <summary>
            /// 
            /// </summary>
            bCharacterCreateRaceAvailableKurashasa,
            /// <summary>
            /// 
            /// </summary>
            bCharacterCreateRaceAvailableLesserGiant,
            /// <summary>
            /// 
            /// </summary>
            bCharacterCreateRaceAvailableMordebi,
            /// <summary>
            /// 
            /// </summary>
            bCharacterCreateRaceAvailableOrc,
            /// <summary>
            /// 
            /// </summary>
            bCharacterCreateRaceAvailableQaliathari,
            /// <summary>
            /// 
            /// </summary>
            bCharacterCreateRaceAvailableRaki,
            /// <summary>
            /// 
            /// </summary>
            bCharacterCreateRaceAvailableThestran,
            /// <summary>
            /// 
            /// </summary>
            bCharacterCreateRaceAvailableVaranjar,
            /// <summary>
            /// 
            /// </summary>
            bCharacterCreateRaceAvailableVaranthari,
            /// <summary>
            /// 
            /// </summary>
            bCharacterCreateRaceAvailableVulmane,
            /// <summary>
            /// 
            /// </summary>
            bCharacterCreateRaceAvailableWoodElf,
            /// <summary>
            /// 
            /// </summary>
            bCharacterCreateSaveTemplate,
            /// <summary>
            /// 
            /// </summary>
            bCharacterCustomize,
            /// <summary>
            /// 
            /// </summary>
            bCharacterSelectDeleteConfirm,
            /// <summary>
            /// 
            /// </summary>
            bCharacterSelectHasAChar,
            /// <summary>
            /// 
            /// </summary>
            bConversion,
            /// <summary>
            /// 
            /// </summary>
            bCurrentWorkOrderSelected,
            /// <summary>
            /// 
            /// </summary>
            bDisplayCivicStats,
            /// <summary>
            /// 
            /// </summary>
            bDualWielding,
            /// <summary>
            /// 
            /// </summary>
            bFindShowComments,
            /// <summary>
            /// 
            /// </summary>
            bFindShowGuild,
            /// <summary>
            /// 
            /// </summary>
            bFindShowLocation,
            /// <summary>
            /// 
            /// </summary>
            bFinRecipeHasLimitedUses,
            /// <summary>
            /// 
            /// </summary>
            bFinRecipeSelected,
            /// <summary>
            /// 
            /// </summary>
            bGroupInvitePendingSelf,
            /// <summary>
            /// 
            /// </summary>
            bGuildCanEditGuildRanks,
            /// <summary>
            /// 
            /// </summary>
            bGuildCanSetGuildNotes,
            /// <summary>
            /// 
            /// </summary>
            bGuildNotifyOnline,
            /// <summary>
            /// 
            /// </summary>
            bGuildShowGuildNote,
            /// <summary>
            /// 
            /// </summary>
            bGuildShowGuildStatus,
            /// <summary>
            /// 
            /// </summary>
            bGuildShowOfficerNote,
            /// <summary>
            /// 
            /// </summary>
            bGuildShowOfflineMembers,
            /// <summary>
            /// 
            /// </summary>
            bGuildShowPersonalNote,
            /// <summary>
            /// 
            /// </summary>
            bHarvesting,
            /// <summary>
            /// 
            /// </summary>
            bHasAllAbilitiesSelf,
            /// <summary>
            /// 
            /// </summary>
            bHasCombatForms,
            /// <summary>
            /// 
            /// </summary>
            bHasCounter,
            /// <summary>
            /// 
            /// </summary>
            bHasFinisher,
            /// <summary>
            /// 
            /// </summary>
            bHasFullPerm,
            /// <summary>
            /// 
            /// </summary>
            bHasPetition,
            /// <summary>
            /// 
            /// </summary>
            bHasPrimaryAbilityList,
            /// <summary>
            /// 
            /// </summary>
            bHasPrimSubsetAbilityList,
            /// <summary>
            /// 
            /// </summary>
            bHasProgressiveFormStatus,
            /// <summary>
            /// 
            /// </summary>
            bHasRescue,
            /// <summary>
            /// 
            /// </summary>
            bHasResearchAdv,
            /// <summary>
            /// 
            /// </summary>
            bHasResearchDip,
            /// <summary>
            /// 
            /// </summary>
            bHasSecondaryAbilityList,
            /// <summary>
            /// 
            /// </summary>
            bHasSympathetic,
            /// <summary>
            /// 
            /// </summary>
            bHasVirtue,
            /// <summary>
            /// 
            /// </summary>
            bHaveAutomaticPet,
            /// <summary>
            /// 
            /// </summary>
            bHaveControllablePet,
            /// <summary>
            /// 
            /// </summary>
            bHaveDefensiveTarget,
            /// <summary>
            /// 
            /// </summary>
            bHavePet,
            /// <summary>
            /// 
            /// </summary>
            bHaveUnreadMail,
            /// <summary>
            /// 
            /// </summary>
            bHouseInformation,
            /// <summary>
            /// 
            /// </summary>
            bHouseInformationBasic,
            /// <summary>
            /// 
            /// </summary>
            bInCombat,
            /// <summary>
            /// 
            /// </summary>
            bIsAutoAttacking,
            /// <summary>
            /// 
            /// </summary>
            bIsDevSelf,
            /// <summary>
            /// 
            /// </summary>
            bIsDrowning,
            /// <summary>
            /// 
            /// </summary>
            bIsGMSelf,
            /// <summary>
            /// 
            /// </summary>
            bIsGroupedSelf,
            /// <summary>
            /// 
            /// </summary>
            bIsGroupLeaderSelf,
            /// <summary>
            /// 
            /// </summary>
            bIsGroupMasterLooterSelf,
            /// <summary>
            /// 
            /// </summary>
            bIsGroupNeedBeforeGreed,
            /// <summary>
            /// 
            /// </summary>
            bIsGroupRollForLoot,
            /// <summary>
            /// 
            /// </summary>
            bIsGroupRoundRobin,
            /// <summary>
            /// 
            /// </summary>
            bIsInvulSelf,
            /// <summary>
            /// 
            /// </summary>
            bIsLFG,
            /// <summary>
            /// 
            /// </summary>
            bIsLFM,
            /// <summary>
            /// 
            /// </summary>
            bIsTestSelf,
            /// <summary>
            /// 
            /// </summary>
            bIsWounded,
            /// <summary>
            /// 
            /// </summary>
            bJournalQuestSelected,
            /// <summary>
            /// 
            /// </summary>
            bLayoutMode,
            /// <summary>
            /// 
            /// </summary>
            bMailSendAsCoD,
            /// <summary>
            /// 
            /// </summary>
            bMarketMaxResults,
            /// <summary>
            /// 
            /// </summary>
            bMiniMapCanZoomIn,
            /// <summary>
            /// 
            /// </summary>
            bMiniMapCanZoomOut,
            /// <summary>
            /// 
            /// </summary>
            bOnAShip,
            /// <summary>
            /// 
            /// </summary>
            bParleyLost,
            /// <summary>
            /// 
            /// </summary>
            bParleyOppPass,
            /// <summary>
            /// 
            /// </summary>
            bParleyPass,
            /// <summary>
            /// 
            /// </summary>
            bParleyWon,
            /// <summary>
            /// 
            /// </summary>
            bPCPoolAdvGeneral,
            /// <summary>
            /// 
            /// </summary>
            bPCPoolAdvSpellSchools,
            /// <summary>
            /// 
            /// </summary>
            bPCPoolAdvWeaponSpecialization,
            /// <summary>
            /// 
            /// </summary>
            bPermAllGuildMembers,
            /// <summary>
            /// 
            /// </summary>
            bPermAllowModify,
            /// <summary>
            /// 
            /// </summary>
            bPermAllowView,
            /// <summary>
            /// 
            /// </summary>
            bPermAllPlayers,
            /// <summary>
            /// 
            /// </summary>
            bPermManageConstruction,
            /// <summary>
            /// 
            /// </summary>
            bPermMoveFixture,
            /// <summary>
            /// 
            /// </summary>
            bPermNoAccess,
            /// <summary>
            /// 
            /// </summary>
            bPermOpenDoor,
            /// <summary>
            /// 
            /// </summary>
            bPermPayUpkeep,
            /// <summary>
            /// 
            /// </summary>
            bPermPickupFixture,
            /// <summary>
            /// 
            /// </summary>
            bPermPlaceFixture,
            /// <summary>
            /// 
            /// </summary>
            bPermViewFixtureList,
            /// <summary>
            /// 
            /// </summary>
            bPermViewUpkeepBank,
            /// <summary>
            /// 
            /// </summary>
            bPlotCanEditPermissions,
            /// <summary>
            /// 
            /// </summary>
            bPlotCanPayUpkeep,
            /// <summary>
            /// 
            /// </summary>
            bPlotCanViewPermissions,
            /// <summary>
            /// 
            /// </summary>
            bPlotCanViewUpkeepBank,
            /// <summary>
            /// 
            /// </summary>
            bPlotForSale,
            /// <summary>
            /// 
            /// </summary>
            bPlotHasBuilding,
            /// <summary>
            /// 
            /// </summary>
            bPlotHasConstruction,
            /// <summary>
            /// 
            /// </summary>
            bPlotInformation,
            /// <summary>
            /// 
            /// </summary>
            bPlotIsMine,
            /// <summary>
            /// 
            /// </summary>
            bPlotManageConstruction,
            /// <summary>
            /// 
            /// </summary>
            bPlotMissedUpkeepPayment,
            /// <summary>
            /// 
            /// </summary>
            bPlotStartConstruction,
            /// <summary>
            /// 
            /// </summary>
            bRefRecipeHasLimitedUses,
            /// <summary>
            /// 
            /// </summary>
            bRefRecipeSelected,
            /// <summary>
            /// 
            /// </summary>
            bSelectedGuildMemberIsMe,
            /// <summary>
            /// 
            /// </summary>
            bShowMyTitles,
            /// <summary>
            /// 
            /// </summary>
            bShowOtherTitles,
            /// <summary>
            /// 
            /// </summary>
            bSphereAdvAllowed,
            /// <summary>
            /// 
            /// </summary>
            bSphereAdvEquipped,
            /// <summary>
            /// 
            /// </summary>
            bSphereAdvNotAllowed,
            /// <summary>
            /// 
            /// </summary>
            bSphereCraAllowed,
            /// <summary>
            /// 
            /// </summary>
            bSphereCraEquipped,
            /// <summary>
            /// 
            /// </summary>
            bSphereCraNotAllowed,
            /// <summary>
            /// 
            /// </summary>
            bSphereDipAllowed,
            /// <summary>
            /// 
            /// </summary>
            bSphereDipEquipped,
            /// <summary>
            /// 
            /// </summary>
            bSphereDipNotAllowed,
            /// <summary>
            /// 
            /// </summary>
            bSphereHarAllowed,
            /// <summary>
            /// 
            /// </summary>
            bSphereHarEquipped,
            /// <summary>
            /// 
            /// </summary>
            bSphereHarNotAllowed,
            /// <summary>
            /// 
            /// </summary>
            bTargetIsGolden,
            /// <summary>
            /// 
            /// </summary>
            bTargetPointValue1,
            /// <summary>
            /// 
            /// </summary>
            bTargetPointValue2,
            /// <summary>
            /// 
            /// </summary>
            bTargetPointValue3,
            /// <summary>
            /// 
            /// </summary>
            bTargetPointValue4,
            /// <summary>
            /// 
            /// </summary>
            bTargetPointValue5,
            /// <summary>
            /// 
            /// </summary>
            bToolbelt1Active,
            /// <summary>
            /// 
            /// </summary>
            bToolbelt2Active,
            /// <summary>
            /// 
            /// </summary>
            bToolbelt3Active,
            /// <summary>
            /// 
            /// </summary>
            bTooltipWindowVisibility,
            /// <summary>
            /// 
            /// </summary>
            BuildingConstruction,
            /// <summary>
            /// 
            /// </summary>
            BuildingConstructionResources,
            /// <summary>
            /// 
            /// </summary>
            BuildingDeconstructionConfirm,
            /// <summary>
            /// 
            /// </summary>
            BuildingTearDownButton,
            /// <summary>
            /// 
            /// </summary>
            bUse250System,
            /// <summary>
            /// 
            /// </summary>
            bWorkOrderSelected,
            /// <summary>
            /// 
            /// </summary>
            CaravanLeader,
            /// <summary>
            /// 
            /// </summary>
            CaravanMember,
            /// <summary>
            /// 
            /// </summary>
            CaravanNotActive,
            /// <summary>
            /// 
            /// </summary>
            Chest,
            /// <summary>
            /// 
            /// </summary>
            ClassShowsHealingBonus,
            /// <summary>
            /// 
            /// </summary>
            ClassShowsSpellDamage,
            /// <summary>
            /// 
            /// </summary>
            CompletingOrAbandoningWorkOrder,
            /// <summary>
            /// 
            /// </summary>
            CorpseListPresent,
            /// <summary>
            /// 
            /// </summary>
            CraftingActionFamilyFilled,
            /// <summary>
            /// 
            /// </summary>
            CraftingAutoFillInv,
            /// <summary>
            /// 
            /// </summary>
            CraftingCatalystAvailable,
            /// <summary>
            /// 
            /// </summary>
            CraftingChangingToolbelt,
            /// <summary>
            /// 
            /// </summary>
            CraftingHaveComplication,
            /// <summary>
            /// 
            /// </summary>
            CraftingIsSetupOrCrafting,
            /// <summary>
            /// 
            /// </summary>
            CraTradeArtificer,
            /// <summary>
            /// 
            /// </summary>
            CraTradeBlacksmith,
            /// <summary>
            /// 
            /// </summary>
            CraTradeDefined,
            /// <summary>
            /// 
            /// </summary>
            CraTradeOutfitter,
            /// <summary>
            /// 
            /// </summary>
            DeathReleasePopup,
            /// <summary>
            /// 
            /// </summary>
            DialogActive,
            /// <summary>
            /// 
            /// </summary>
            DiplomacyMyTurn,
            /// <summary>
            /// 
            /// </summary>
            DiplomacyOppTurn,
            /// <summary>
            /// 
            /// </summary>
            DisplayOffTargetTargets,
            /// <summary>
            /// 
            /// </summary>
            DontShowExpertiseValues,
            /// <summary>
            /// 
            /// </summary>
            EscrowMerchantTranactionStarted,
            /// <summary>
            /// 
            /// </summary>
            FellowshipLeader,
            /// <summary>
            /// 
            /// </summary>
            FellowshipMember,
            /// <summary>
            /// 
            /// </summary>
            FellowshipNotActive,
            /// <summary>
            /// 
            /// </summary>
            GroupLootOptionsPopup,
            /// <summary>
            /// 
            /// </summary>
            GroupLootPassOutCashLoot,
            /// <summary>
            /// 
            /// </summary>
            GroupLootShowAllowGroupToLootWindows,
            /// <summary>
            /// 
            /// </summary>
            GroupLootShowItemRarityWindows,
            /// <summary>
            /// 
            /// </summary>
            GroupLootShowLootModeString,
            /// <summary>
            /// 
            /// </summary>
            GroupLootShowLootModeWindows,
            /// <summary>
            /// 
            /// </summary>
            GroupLootShowMasterLooterWindows,
            /// <summary>
            /// 
            /// </summary>
            GroupLootShowRandomForLootGreedButton,
            /// <summary>
            /// 
            /// </summary>
            GroupLootShowRandomForLootNeedButton,
            /// <summary>
            /// 
            /// </summary>
            GroupLootShowRandomForLootPassButton,
            /// <summary>
            /// 
            /// </summary>
            GroupLootShowStartRandomingItemsButton,
            /// <summary>
            /// 
            /// </summary>
            GroupRandomLootInvitationPopup,
            /// <summary>
            /// 
            /// </summary>
            GroupRandomLootShowRoll,
            /// <summary>
            /// 
            /// </summary>
            GroupRandomLootShowStatusMessage,
            /// <summary>
            /// 
            /// </summary>
            GroupRandomLootShowStatusMessage2,
            /// <summary>
            /// 
            /// </summary>
            HarvestingRareItemsPresent,
            /// <summary>
            /// 
            /// </summary>
            InspectVisibility,
            /// <summary>
            /// 
            /// </summary>
            IsGrouped,
            /// <summary>
            /// 
            /// </summary>
            LootIsLooting,
            /// <summary>
            /// 
            /// </summary>
            LootIsPending,
            /// <summary>
            /// 
            /// </summary>
            MailCopperToSendIcon,
            /// <summary>
            /// 
            /// </summary>
            MailGoldToSendIcon,
            /// <summary>
            /// 
            /// </summary>
            MailItemConfirmShippingCost,
            /// <summary>
            /// 
            /// </summary>
            MailPlatToSendIcon,
            /// <summary>
            /// 
            /// </summary>
            MailSendCoinConfirm,
            /// <summary>
            /// 
            /// </summary>
            MailShowItemSlot0,
            /// <summary>
            /// 
            /// </summary>
            MailShowItemSlot1,
            /// <summary>
            /// 
            /// </summary>
            MailSilverToSendIcon,
            /// <summary>
            /// 
            /// </summary>
            MarketWindow,
            /// <summary>
            /// 
            /// </summary>
            MemoryIsAutoMemorize,
            /// <summary>
            /// 
            /// </summary>
            MemoryIsMemorizing,
            /// <summary>
            /// 
            /// </summary>
            MerchantTranactionStarted,
            /// <summary>
            /// 
            /// </summary>
            ObjectActivating,
            /// <summary>
            /// 
            /// </summary>
            ParlayDemandDisabled,
            /// <summary>
            /// 
            /// </summary>
            ParlayFlatterDisabled,
            /// <summary>
            /// 
            /// </summary>
            ParlayInspireDisabled,
            /// <summary>
            /// 
            /// </summary>
            ParlayMyStatementEmpty,
            /// <summary>
            /// 
            /// </summary>
            ParlayOppStatementEmpty,
            /// <summary>
            /// 
            /// </summary>
            ParlayReasonDisabled,
            /// <summary>
            /// 
            /// </summary>
            ParleyInParley,
            /// <summary>
            /// 
            /// </summary>
            PermissionCreate,
            /// <summary>
            /// 
            /// </summary>
            PermissionEdit,
            /// <summary>
            /// 
            /// </summary>
            PlayerInCombat,
            /// <summary>
            /// 
            /// </summary>
            PlayerMaterialSelectPopup,
            /// <summary>
            /// 
            /// </summary>
            PlotPurchaseConfirm,
            /// <summary>
            /// 
            /// </summary>
            PlotRelinquishConfirm,
            /// <summary>
            /// 
            /// </summary>
            ProgressiveFormPhase1,
            /// <summary>
            /// 
            /// </summary>
            ProgressiveFormPhase2,
            /// <summary>
            /// 
            /// </summary>
            ProgressiveFormPhase3,
            /// <summary>
            /// 
            /// </summary>
            ProgressiveFormPhase4,
            /// <summary>
            /// 
            /// </summary>
            ProgressiveFormPhase5,
            /// <summary>
            /// 
            /// </summary>
            PVPDeathReleasePopup,
            /// <summary>
            /// 
            /// </summary>
            RecipeTraining,
            /// <summary>
            /// 
            /// </summary>
            RefiningIsRefining,
            /// <summary>
            /// 
            /// </summary>
            RefiningIsSetup,
            /// <summary>
            /// 
            /// </summary>
            RemedyActionFamilyFilled,
            /// <summary>
            /// 
            /// </summary>
            RepairMerchantTranactionStarted,
            /// <summary>
            /// 
            /// </summary>
            SelectingWorkOrder,
            /// <summary>
            /// 
            /// </summary>
            ShowAcceptRewardButton,
            /// <summary>
            /// 
            /// </summary>
            ShowExpertiseValues,
            /// <summary>
            /// 
            /// </summary>
            SongComposeMode,
            /// <summary>
            /// 
            /// </summary>
            TargetsHaveTarget,
            /// <summary>
            /// 
            /// </summary>
            TradeAwaitingInviteResp,
            /// <summary>
            /// 
            /// </summary>
            TradeInvitePending,
            /// <summary>
            /// 
            /// </summary>
            TradeMyAccepted,
            /// <summary>
            /// 
            /// </summary>
            TradeOthersAccepted,
            /// <summary>
            /// 
            /// </summary>
            TradeTrading,
            /// <summary>
            /// 
            /// </summary>
            Training,
            /// <summary>
            /// 
            /// </summary>
            TravelJournalIsTracking,
        }

        #endregion

        #region GameVariableFloat enum

        /// <summary>
        /// 
        /// </summary>
        public enum GameVariableFloat
        {
            /// <summary>
            /// 
            /// </summary>
            CaravanLocX,
            /// <summary>
            /// 
            /// </summary>
            CaravanLocY,
            /// <summary>
            /// 
            /// </summary>
            CaravanLocZ,
            /// <summary>
            /// 
            /// </summary>
            DeathPendingReleaseTimer,
            /// <summary>
            /// 
            /// </summary>
            fCompassDirection,
            /// <summary>
            /// 
            /// </summary>
            fMovementSpeedSelf,
            /// <summary>
            /// 
            /// </summary>
            LootPendingRandomTimer,
            /// <summary>
            /// 
            /// </summary>
            MarketCommissionPercBase,
            /// <summary>
            /// 
            /// </summary>
            MarketCommissionPercBaseReduction,
            /// <summary>
            /// 
            /// </summary>
            MarketCommissionPercBaseTotal,
            /// <summary>
            /// 
            /// </summary>
            TravelJournalTrackAngle,
            /// <summary>
            /// 
            /// </summary>
            TravelJournalTrackDistance,
        }

        #endregion

        #region GameVariableInt enum

        /// <summary>
        /// 
        /// </summary>
        public enum GameVariableInt
        {
            /// <summary>
            /// 
            /// </summary>
            ActiveGroupLootItemRarityIndex,
            /// <summary>
            /// 
            /// </summary>
            ActiveGroupLootModeIndex,
            /// <summary>
            /// 
            /// </summary>
            ActiveMasterLooterSelectionIndex,
            /// <summary>
            /// 
            /// </summary>
            AdvMaxExpertisePct,
            /// <summary>
            /// 
            /// </summary>
            AsmRecipeIngredientHave0,
            /// <summary>
            /// 
            /// </summary>
            AsmRecipeIngredientHave1,
            /// <summary>
            /// 
            /// </summary>
            AsmRecipeIngredientHave2,
            /// <summary>
            /// 
            /// </summary>
            AsmRecipeIngredientHave3,
            /// <summary>
            /// 
            /// </summary>
            AsmRecipeIngredientHave4,
            /// <summary>
            /// 
            /// </summary>
            AsmRecipeIngredientRequired0,
            /// <summary>
            /// 
            /// </summary>
            AsmRecipeIngredientRequired1,
            /// <summary>
            /// 
            /// </summary>
            AsmRecipeIngredientRequired2,
            /// <summary>
            /// 
            /// </summary>
            AsmRecipeIngredientRequired3,
            /// <summary>
            /// 
            /// </summary>
            AsmRecipeIngredientRequired4,
            /// <summary>
            /// 
            /// </summary>
            AssemblyNumSlots,
            /// <summary>
            /// 
            /// </summary>
            CaravanChunkX,
            /// <summary>
            /// 
            /// </summary>
            CaravanChunkY,
            /// <summary>
            /// 
            /// </summary>
            CaravanChunkZ,
            /// <summary>
            /// 
            /// </summary>
            ChunkX,
            /// <summary>
            /// 
            /// </summary>
            ChunkY,
            /// <summary>
            /// 
            /// </summary>
            CombatInvSlotsTaken,
            /// <summary>
            /// 
            /// </summary>
            CurrentCombatStyleAdv,
            /// <summary>
            /// 
            /// </summary>
            CurrentSongBaseCost,
            /// <summary>
            /// 
            /// </summary>
            CurrentSongFinalCost,
            /// <summary>
            /// 
            /// </summary>
            CurrentSongRestReduction,
            /// <summary>
            /// 
            /// </summary>
            DiplomacyStrategySlots,
            /// <summary>
            /// 
            /// </summary>
            GuildMembersOnline,
            /// <summary>
            /// 
            /// </summary>
            GuildMembersTotal,
            /// <summary>
            /// 
            /// </summary>
            InventoryNumCombatSlots,
            /// <summary>
            /// 
            /// </summary>
            InventoryRelativeSizeX,
            /// <summary>
            /// 
            /// </summary>
            InventoryRelativeSizeY,
            /// <summary>
            /// 
            /// </summary>
            InventorySpaceAvailable,
            /// <summary>
            /// 
            /// </summary>
            LFMLevelMax,
            /// <summary>
            /// 
            /// </summary>
            LFMLevelMin,
            /// <summary>
            /// 
            /// </summary>
            MarketMaxItemsPerPlayer,
            /// <summary>
            /// 
            /// </summary>
            MarketSelectedClass,
            /// <summary>
            /// 
            /// </summary>
            MarketSelectedEquipSlot,
            /// <summary>
            /// 
            /// </summary>
            MarketSelectedRarity,
            /// <summary>
            /// 
            /// </summary>
            MarketSelectedSphere,
            /// <summary>
            /// 
            /// </summary>
            MarketSelectedType,
            /// <summary>
            /// 
            /// </summary>
            MemoryDisciplineSlots,
            /// <summary>
            /// 
            /// </summary>
            MemoryDisciplineSlotsUsed,
            /// <summary>
            /// 
            /// </summary>
            MemoryMasterySlots,
            /// <summary>
            /// 
            /// </summary>
            MemoryMasterySlotsUsed,
            /// <summary>
            /// 
            /// </summary>
            MerchantState,
            /// <summary>
            /// 
            /// </summary>
            nAdventureClassType,
            /// <summary>
            /// 
            /// </summary>
            nAdvExpSelf,
            /// <summary>
            /// 
            /// </summary>
            nAdvLevelSelf,
            /// <summary>
            /// 
            /// </summary>
            nArmorClass,
            /// <summary>
            /// 
            /// </summary>
            nCraftExpSelf,
            /// <summary>
            /// 
            /// </summary>
            nCraftingRecipeSectionFourState,
            /// <summary>
            /// 
            /// </summary>
            nCraftingRecipeSectionOneState,
            /// <summary>
            /// 
            /// </summary>
            nCraftingRecipeSectionThreeState,
            /// <summary>
            /// 
            /// </summary>
            nCraftingRecipeSectionTwoState,
            /// <summary>
            /// 
            /// </summary>
            nCraftLevelSelf,
            /// <summary>
            /// 
            /// </summary>
            nDialogWindowState,
            /// <summary>
            /// 
            /// </summary>
            NetFPSGV,
            /// <summary>
            /// 
            /// </summary>
            nFarewellButtonState,
            /// <summary>
            /// 
            /// </summary>
            nHarvLevelSelf,
            /// <summary>
            /// 
            /// </summary>
            nJournalAssemblyTrade,
            /// <summary>
            /// 
            /// </summary>
            nQuestDetailsState,
            /// <summary>
            /// 
            /// </summary>
            nRecipeSelectRefineOrFinish,
            /// <summary>
            /// 
            /// </summary>
            nWorkOrderWindowState,
            /// <summary>
            /// 
            /// </summary>
            nWoundsHead,
            /// <summary>
            /// 
            /// </summary>
            nWoundsLeftArm,
            /// <summary>
            /// 
            /// </summary>
            nWoundsLeg,
            /// <summary>
            /// 
            /// </summary>
            nWoundsRightArm,
            /// <summary>
            /// 
            /// </summary>
            nWoundsTorso,
            /// <summary>
            /// 
            /// </summary>
            PacketLossInGV,
            /// <summary>
            /// 
            /// </summary>
            PacketLossOutGV,
            /// <summary>
            /// 
            /// </summary>
            PCAdvConstitution,
            /// <summary>
            /// 
            /// </summary>
            PCAdvDexterity,
            /// <summary>
            /// 
            /// </summary>
            PCAdvEnduranceMax,
            /// <summary>
            /// 
            /// </summary>
            PCAdvEnergyMax,
            /// <summary>
            /// 
            /// </summary>
            PCAdvHealingFocus,
            /// <summary>
            /// 
            /// </summary>
            PCAdvHitpointsMax,
            /// <summary>
            /// 
            /// </summary>
            PCAdvIntelligence,
            /// <summary>
            /// 
            /// </summary>
            PCAdvResArcane,
            /// <summary>
            /// 
            /// </summary>
            PCAdvResCold,
            /// <summary>
            /// 
            /// </summary>
            PCAdvResFire,
            /// <summary>
            /// 
            /// </summary>
            PCAdvResMental,
            /// <summary>
            /// 
            /// </summary>
            PCAdvResPhysical,
            /// <summary>
            /// 
            /// </summary>
            PCAdvResSpiritual,
            /// <summary>
            /// 
            /// </summary>
            PCAdvSpellDamageFocus,
            /// <summary>
            /// 
            /// </summary>
            PCAdvStrength,
            /// <summary>
            /// 
            /// </summary>
            PCAdvVitality,
            /// <summary>
            /// 
            /// </summary>
            PCAdvWisdom,
            /// <summary>
            /// 
            /// </summary>
            PCCraArmorSmithing,
            /// <summary>
            /// 
            /// </summary>
            PCCraArtificing,
            /// <summary>
            /// 
            /// </summary>
            PCCraBlacksmithing,
            /// <summary>
            /// 
            /// </summary>
            PCCraCarpentry,
            /// <summary>
            /// 
            /// </summary>
            PCCraFinesse,
            /// <summary>
            /// 
            /// </summary>
            PCCraForging,
            /// <summary>
            /// 
            /// </summary>
            PCCraForgingTools,
            /// <summary>
            /// 
            /// </summary>
            PCCraForgingUtilities,
            /// <summary>
            /// 
            /// </summary>
            PCCraForming,
            /// <summary>
            /// 
            /// </summary>
            PCCraIngenuity,
            /// <summary>
            /// 
            /// </summary>
            PCCraLeatherworking,
            /// <summary>
            /// 
            /// </summary>
            PCCraMaterialPreparation,
            /// <summary>
            /// 
            /// </summary>
            PCCraMaterialProcessing,
            /// <summary>
            /// 
            /// </summary>
            PCCraMaterialProcessingTools,
            /// <summary>
            /// 
            /// </summary>
            PCCraMaterialProcessingUtilities,
            /// <summary>
            /// 
            /// </summary>
            PCCraMetallurgy,
            /// <summary>
            /// 
            /// </summary>
            PCCraMineralogy,
            /// <summary>
            /// 
            /// </summary>
            PCCraOutfitting,
            /// <summary>
            /// 
            /// </summary>
            PCCraProblemSolving,
            /// <summary>
            /// 
            /// </summary>
            PCCraReasoning,
            /// <summary>
            /// 
            /// </summary>
            PCCraSculpting,
            /// <summary>
            /// 
            /// </summary>
            PCCraSculptingTools,
            /// <summary>
            /// 
            /// </summary>
            PCCraSculptingUtilities,
            /// <summary>
            /// 
            /// </summary>
            PCCraShaping,
            /// <summary>
            /// 
            /// </summary>
            PCCraShapingTools,
            /// <summary>
            /// 
            /// </summary>
            PCCraShapingUtilities,
            /// <summary>
            /// 
            /// </summary>
            PCCraSmelting,
            /// <summary>
            /// 
            /// </summary>
            PCCraSmeltingTools,
            /// <summary>
            /// 
            /// </summary>
            PCCraSmeltingUtilities,
            /// <summary>
            /// 
            /// </summary>
            PCCraStitching,
            /// <summary>
            /// 
            /// </summary>
            PCCraStitchingTools,
            /// <summary>
            /// 
            /// </summary>
            PCCraStitchingUtilities,
            /// <summary>
            /// 
            /// </summary>
            PCCraTailoring,
            /// <summary>
            /// 
            /// </summary>
            PCCraWeaponSmithing,
            /// <summary>
            /// 
            /// </summary>
            PCHarDeftness,
            /// <summary>
            /// 
            /// </summary>
            PCHarDemolition,
            /// <summary>
            /// 
            /// </summary>
            PCHarDiscernment,
            /// <summary>
            /// 
            /// </summary>
            PCHarGathering,
            /// <summary>
            /// 
            /// </summary>
            PCHarHarvesting,
            /// <summary>
            /// 
            /// </summary>
            PCHarLumberjacking,
            /// <summary>
            /// 
            /// </summary>
            PCHarMight,
            /// <summary>
            /// 
            /// </summary>
            PCHarMining,
            /// <summary>
            /// 
            /// </summary>
            PCHarPrimaryValue,
            /// <summary>
            /// 
            /// </summary>
            PCHarQuarrying,
            /// <summary>
            /// 
            /// </summary>
            PCHarReaping,
            /// <summary>
            /// 
            /// </summary>
            PCHarScavenging,
            /// <summary>
            /// 
            /// </summary>
            PCHarSecondaryValue,
            /// <summary>
            /// 
            /// </summary>
            PCHarSkinning,
            /// <summary>
            /// 
            /// </summary>
            PCHarStamina,
            /// <summary>
            /// 
            /// </summary>
            PCHarVigor,
            /// <summary>
            /// 
            /// </summary>
            PCPoolAdvCombat,
            /// <summary>
            /// 
            /// </summary>
            PCPoolAdvCombatMax,
            /// <summary>
            /// 
            /// </summary>
            PCPoolAdvCombatSpent,
            /// <summary>
            /// 
            /// </summary>
            PCPoolAdvGeneral,
            /// <summary>
            /// 
            /// </summary>
            PCPoolAdvGeneralMax,
            /// <summary>
            /// 
            /// </summary>
            PCPoolAdvGeneralSpent,
            /// <summary>
            /// 
            /// </summary>
            PCPoolAdvPerception,
            /// <summary>
            /// 
            /// </summary>
            PCPoolAdvPerceptionMax,
            /// <summary>
            /// 
            /// </summary>
            PCPoolAdvPerceptionSpent,
            /// <summary>
            /// 
            /// </summary>
            PCPoolAdvSpellSchools,
            /// <summary>
            /// 
            /// </summary>
            PCPoolAdvSpellSchoolsMax,
            /// <summary>
            /// 
            /// </summary>
            PCPoolAdvSpellSchoolsSpent,
            /// <summary>
            /// 
            /// </summary>
            PCPoolAdvWeaponSpecialization,
            /// <summary>
            /// 
            /// </summary>
            PCPoolAdvWeaponSpecializationMax,
            /// <summary>
            /// 
            /// </summary>
            PCPoolAdvWeaponSpecializationSpent,
            /// <summary>
            /// 
            /// </summary>
            PCPoolAdvWeaponTypes,
            /// <summary>
            /// 
            /// </summary>
            PCPoolAdvWeaponTypesMax,
            /// <summary>
            /// 
            /// </summary>
            PCPoolAdvWeaponTypesSpent,
            /// <summary>
            /// 
            /// </summary>
            PCPoolCraArtificerGeneralMaterialRefining,
            /// <summary>
            /// 
            /// </summary>
            PCPoolCraArtificerGeneralMaterialRefiningMax,
            /// <summary>
            /// 
            /// </summary>
            PCPoolCraArtificerGeneralMaterialRefiningSpent,
            /// <summary>
            /// 
            /// </summary>
            PCPoolCraArtificerMaterialFinishing,
            /// <summary>
            /// 
            /// </summary>
            PCPoolCraArtificerMaterialFinishingMax,
            /// <summary>
            /// 
            /// </summary>
            PCPoolCraArtificerMaterialFinishingSpent,
            /// <summary>
            /// 
            /// </summary>
            PCPoolCraArtificerMaterialRefining,
            /// <summary>
            /// 
            /// </summary>
            PCPoolCraArtificerMaterialRefiningMax,
            /// <summary>
            /// 
            /// </summary>
            PCPoolCraArtificerMaterialRefiningSpent,
            /// <summary>
            /// 
            /// </summary>
            PCPoolCraArtificerMaterialSpecializations,
            /// <summary>
            /// 
            /// </summary>
            PCPoolCraArtificerMaterialSpecializationsMax,
            /// <summary>
            /// 
            /// </summary>
            PCPoolCraArtificerMaterialSpecializationsSpent,
            /// <summary>
            /// 
            /// </summary>
            PCPoolCraBlacksmithGeneralMetalRefining,
            /// <summary>
            /// 
            /// </summary>
            PCPoolCraBlacksmithGeneralMetalRefiningMax,
            /// <summary>
            /// 
            /// </summary>
            PCPoolCraBlacksmithGeneralMetalRefiningSpent,
            /// <summary>
            /// 
            /// </summary>
            PCPoolCraBlacksmithMetalFinishing,
            /// <summary>
            /// 
            /// </summary>
            PCPoolCraBlacksmithMetalFinishingMax,
            /// <summary>
            /// 
            /// </summary>
            PCPoolCraBlacksmithMetalFinishingSpent,
            /// <summary>
            /// 
            /// </summary>
            PCPoolCraBlacksmithMetalRefining,
            /// <summary>
            /// 
            /// </summary>
            PCPoolCraBlacksmithMetalRefiningMax,
            /// <summary>
            /// 
            /// </summary>
            PCPoolCraBlacksmithMetalRefiningSpent,
            /// <summary>
            /// 
            /// </summary>
            PCPoolCraBlacksmithMetalSpecializations,
            /// <summary>
            /// 
            /// </summary>
            PCPoolCraBlacksmithMetalSpecializationsMax,
            /// <summary>
            /// 
            /// </summary>
            PCPoolCraBlacksmithMetalSpecializationsSpent,
            /// <summary>
            /// 
            /// </summary>
            PCPoolCraOutfitterGeneralMaterialRefining,
            /// <summary>
            /// 
            /// </summary>
            PCPoolCraOutfitterGeneralMaterialRefiningMax,
            /// <summary>
            /// 
            /// </summary>
            PCPoolCraOutfitterGeneralMaterialRefiningSpent,
            /// <summary>
            /// 
            /// </summary>
            PCPoolCraOutfitterMaterialFinishing,
            /// <summary>
            /// 
            /// </summary>
            PCPoolCraOutfitterMaterialFinishingMax,
            /// <summary>
            /// 
            /// </summary>
            PCPoolCraOutfitterMaterialFinishingSpent,
            /// <summary>
            /// 
            /// </summary>
            PCPoolCraOutfitterMaterialRefining,
            /// <summary>
            /// 
            /// </summary>
            PCPoolCraOutfitterMaterialRefiningMax,
            /// <summary>
            /// 
            /// </summary>
            PCPoolCraOutfitterMaterialRefiningSpent,
            /// <summary>
            /// 
            /// </summary>
            PCPoolCraOutfitterMaterialSpecializations,
            /// <summary>
            /// 
            /// </summary>
            PCPoolCraOutfitterMaterialSpecializationsMax,
            /// <summary>
            /// 
            /// </summary>
            PCPoolCraOutfitterMaterialSpecializationsSpent,
            /// <summary>
            /// 
            /// </summary>
            PCPoolHarHarvestingSkills,
            /// <summary>
            /// 
            /// </summary>
            PCPoolHarHarvestingSkillsMax,
            /// <summary>
            /// 
            /// </summary>
            PCPoolHarHarvestingSkillsSpent,
            /// <summary>
            /// 
            /// </summary>
            PCPoolHarResourceSpecificSkills,
            /// <summary>
            /// 
            /// </summary>
            PCPoolHarResourceSpecificSkillsMax,
            /// <summary>
            /// 
            /// </summary>
            PCPoolHarResourceSpecificSkillsSpent,
            /// <summary>
            /// 
            /// </summary>
            PCPotentialPoolAdv,
            /// <summary>
            /// 
            /// </summary>
            PCPotentialPoolCra,
            /// <summary>
            /// 
            /// </summary>
            PCPotentialPoolDip,
            /// <summary>
            /// 
            /// </summary>
            PCRefundPoolAdv,
            /// <summary>
            /// 
            /// </summary>
            PCRefundPoolCra,
            /// <summary>
            /// 
            /// </summary>
            PCVirtuePointsSelf,
            /// <summary>
            /// 
            /// </summary>
            PetNumGraftsAllowed,
            /// <summary>
            /// 
            /// </summary>
            PingGV,
            /// <summary>
            /// 
            /// </summary>
            ProgressiveFormPhase,
            /// <summary>
            /// 
            /// </summary>
            PsionicPointPoolCurr,
            /// <summary>
            /// 
            /// </summary>
            PsionicPointPoolMax,
            /// <summary>
            /// 
            /// </summary>
            RefiningActionPointAvailable,
            /// <summary>
            /// 
            /// </summary>
            RefiningActionPointsUsed,
            /// <summary>
            /// 
            /// </summary>
            RefiningProgressStepNumber,
            /// <summary>
            /// 
            /// </summary>
            RefiningRecipeId,
            /// <summary>
            /// 
            /// </summary>
            RefiningState,
            /// <summary>
            /// 
            /// </summary>
            SelectedAssemblyPrimaryCategoryIndex,
            /// <summary>
            /// 
            /// </summary>
            SelectedAssemblySecondaryCategoryIndex,
            /// <summary>
            /// 
            /// </summary>
            SelectedAssemblyTertiaryCategoryIndex,
            /// <summary>
            /// 
            /// </summary>
            SelectedAssemblyTypeIndex,
            /// <summary>
            /// 
            /// </summary>
            ShipSailStageInt,
            /// <summary>
            /// 
            /// </summary>
            SongBridgesSlots,
            /// <summary>
            /// 
            /// </summary>
            SongChorusesSlots,
            /// <summary>
            /// 
            /// </summary>
            SongCodasSlots,
            /// <summary>
            /// 
            /// </summary>
            SongEmbellishmentsSlots,
            /// <summary>
            /// 
            /// </summary>
            SongLyricsSlots,
            /// <summary>
            /// 
            /// </summary>
            SongMelodySlots,
            /// <summary>
            /// 
            /// </summary>
            SongVersesSlots,
            /// <summary>
            /// 
            /// </summary>
            TimeHoursGV,
            /// <summary>
            /// 
            /// </summary>
            TimeMinutesGV,
            /// <summary>
            /// 
            /// </summary>
            TimeSecondsGV,
            /// <summary>
            /// 
            /// </summary>
            TitlesPostfixActiveIndex,
            /// <summary>
            /// 
            /// </summary>
            TitlesPrefixActiveIndex,
            /// <summary>
            /// 
            /// </summary>
            TradeState,
        }

        #endregion

        #region GameVariableList enum

        /// <summary>
        /// 
        /// </summary>
        public enum GameVariableList
        {
            /// <summary>
            /// 
            /// </summary>
            AbilityResearchAdv,
            /// <summary>
            /// 
            /// </summary>
            AbilityResearchDip,
            /// <summary>
            /// 
            /// </summary>
            ActiveQuestList,
            /// <summary>
            /// 
            /// </summary>
            AdventuringAbilityList,
            /// <summary>
            /// 
            /// </summary>
            AdvJournalFinishingRecipeList,
            /// <summary>
            /// 
            /// </summary>
            AdvJournalRefiningRecipeList,
            /// <summary>
            /// 
            /// </summary>
            AntiGroupCombatInfo,
            /// <summary>
            /// 
            /// </summary>
            AntiGroupUpdatesText,
            /// <summary>
            /// 
            /// </summary>
            AssemblyItemList,
            /// <summary>
            /// 
            /// </summary>
            AssemblyPrimaryCategories,
            /// <summary>
            /// 
            /// </summary>
            AssemblySecondaryCategories,
            /// <summary>
            /// 
            /// </summary>
            AssemblyTertiaryCategories,
            /// <summary>
            /// 
            /// </summary>
            AssemblyTrainerRecipeList,
            /// <summary>
            /// 
            /// </summary>
            AssemblyTypes,
            /// <summary>
            /// 
            /// </summary>
            AttachedAbilitiesBeneficialList,
            /// <summary>
            /// 
            /// </summary>
            AttachedAbilitiesHarmfulList,
            /// <summary>
            /// 
            /// </summary>
            AttachedAbilitiesList,
            /// <summary>
            /// 
            /// </summary>
            BankInventoryList,
            /// <summary>
            /// 
            /// </summary>
            BuildingConstructionResourceList,
            /// <summary>
            /// 
            /// </summary>
            BuildingFixtureList,
            /// <summary>
            /// 
            /// </summary>
            BuildingMaterialItemList,
            /// <summary>
            /// 
            /// </summary>
            BuildingPermissionList,
            /// <summary>
            /// 
            /// </summary>
            BuildingPermissionNameList,
            /// <summary>
            /// 
            /// </summary>
            CaravanMemberList,
            /// <summary>
            /// 
            /// </summary>
            ChainAbilityList,
            /// <summary>
            /// 
            /// </summary>
            ChestInventoryList,
            /// <summary>
            /// 
            /// </summary>
            CivicDiplomacyStats,
            /// <summary>
            /// 
            /// </summary>
            CombatFormsListAdv,
            /// <summary>
            /// 
            /// </summary>
            CombatFormTextListAdv,
            /// <summary>
            /// 
            /// </summary>
            CombatOpenersListAdv,
            /// <summary>
            /// 
            /// </summary>
            CorpseList,
            /// <summary>
            /// 
            /// </summary>
            CounterAbilityList,
            /// <summary>
            /// 
            /// </summary>
            CraftingActionFamily,
            /// <summary>
            /// 
            /// </summary>
            CraftingCatalyst,
            /// <summary>
            /// 
            /// </summary>
            CraftingComplications,
            /// <summary>
            /// 
            /// </summary>
            CraftingCorrections,
            /// <summary>
            /// 
            /// </summary>
            CraftingFullInventory,
            /// <summary>
            /// 
            /// </summary>
            CraftingRecipeStepProgress0,
            /// <summary>
            /// 
            /// </summary>
            CraftingRecipeStepProgress1,
            /// <summary>
            /// 
            /// </summary>
            CraftingRecipeStepProgress2,
            /// <summary>
            /// 
            /// </summary>
            CraftingRecipeStepProgress3,
            /// <summary>
            /// 
            /// </summary>
            CraftingRecipeStepProgress4,
            /// <summary>
            /// 
            /// </summary>
            CraftingRecipeStepSection0,
            /// <summary>
            /// 
            /// </summary>
            CraftingRecipeStepSection1,
            /// <summary>
            /// 
            /// </summary>
            CraftingRecipeStepSection2,
            /// <summary>
            /// 
            /// </summary>
            CraftingRecipeStepSection3,
            /// <summary>
            /// 
            /// </summary>
            CraftingRecipeStepSection4,
            /// <summary>
            /// 
            /// </summary>
            CraftingRecipeStepsRequiringItems,
            /// <summary>
            /// 
            /// </summary>
            CraftingRecipeUsableItemList,
            /// <summary>
            /// 
            /// </summary>
            CurrentSongBridgesList,
            /// <summary>
            /// 
            /// </summary>
            CurrentSongChorusesList,
            /// <summary>
            /// 
            /// </summary>
            CurrentSongCodasList,
            /// <summary>
            /// 
            /// </summary>
            CurrentSongEmbellishmentsList,
            /// <summary>
            /// 
            /// </summary>
            CurrentSongLyricsList,
            /// <summary>
            /// 
            /// </summary>
            CurrentSongMelodyList,
            /// <summary>
            /// 
            /// </summary>
            CurrentSongVersesList,
            /// <summary>
            /// 
            /// </summary>
            CurrentWorkOrderList,
            /// <summary>
            /// 
            /// </summary>
            DialogResponses,
            /// <summary>
            /// 
            /// </summary>
            DialogTypeResponses,
            /// <summary>
            /// 
            /// </summary>
            DiplomacyAbilityList,
            /// <summary>
            /// 
            /// </summary>
            DiplomacyRepertoire,
            /// <summary>
            /// 
            /// </summary>
            DiplomacyStrategy,
            /// <summary>
            /// 
            /// </summary>
            EscrowMerchantItemList,
            /// <summary>
            /// 
            /// </summary>
            FellowshipMemberList,
            /// <summary>
            /// 
            /// </summary>
            FindClassList,
            /// <summary>
            /// 
            /// </summary>
            FindList,
            /// <summary>
            /// 
            /// </summary>
            FinisherAbilityList,
            /// <summary>
            /// 
            /// </summary>
            FinishingMiscellaneousRecipes,
            /// <summary>
            /// 
            /// </summary>
            FinishingPrimaryRecipes,
            /// <summary>
            /// 
            /// </summary>
            FinishingSecondaryRecipes,
            /// <summary>
            /// 
            /// </summary>
            FinishingUniqueRecipes,
            /// <summary>
            /// 
            /// </summary>
            FinishingWorkOrderRecipes,
            /// <summary>
            /// 
            /// </summary>
            FriendsList,
            /// <summary>
            /// 
            /// </summary>
            FullSongList,
            /// <summary>
            /// 
            /// </summary>
            GeneralAbilityList,
            /// <summary>
            /// 
            /// </summary>
            GroupLootItemRarities,
            /// <summary>
            /// 
            /// </summary>
            GroupLootMasterLooterSelectionList,
            /// <summary>
            /// 
            /// </summary>
            GroupLootModes,
            /// <summary>
            /// 
            /// </summary>
            GroupMemberList,
            /// <summary>
            /// 
            /// </summary>
            GuildAccessRankList,
            /// <summary>
            /// 
            /// </summary>
            GuildMemberList,
            /// <summary>
            /// 
            /// </summary>
            GuildRecruitList,
            /// <summary>
            /// 
            /// </summary>
            HarvestingRareItemList,
            /// <summary>
            /// 
            /// </summary>
            HarvestingRewards,
            /// <summary>
            /// 
            /// </summary>
            IgnoreList,
            /// <summary>
            /// 
            /// </summary>
            InspectList,
            /// <summary>
            /// 
            /// </summary>
            InventoryCombatInvList,
            /// <summary>
            /// 
            /// </summary>
            InventoryContainerID_Neg1,
            /// <summary>
            /// 
            /// </summary>
            InventoryContainerID_103,
            /// <summary>
            /// 
            /// </summary>
            InventoryContainerID_104,
            /// <summary>
            /// 
            /// </summary>
            InventoryContainerID_11,
            /// <summary>
            /// 
            /// </summary>
            InventoryContainerID_110,
            /// <summary>
            /// 
            /// </summary>
            InventoryContainerID_16,
            /// <summary>
            /// 
            /// </summary>
            InventoryContainerID_30,
            /// <summary>
            /// 
            /// </summary>
            InventoryContainerID_39,
            /// <summary>
            /// 
            /// </summary>
            InventoryContainerID_5,
            /// <summary>
            /// 
            /// </summary>
            InventoryList,
            /// <summary>
            /// 
            /// </summary>
            InventoryPetList,
            /// <summary>
            /// 
            /// </summary>
            JournalWorkOrderList,
            /// <summary>
            /// 
            /// </summary>
            LFMCastersList,
            /// <summary>
            /// 
            /// </summary>
            LFMFightersList,
            /// <summary>
            /// 
            /// </summary>
            LFMHealersList,
            /// <summary>
            /// 
            /// </summary>
            LFMTanksList,
            /// <summary>
            /// 
            /// </summary>
            LocationsList,
            /// <summary>
            /// 
            /// </summary>
            LootItemList,
            /// <summary>
            /// 
            /// </summary>
            MailItemList,
            /// <summary>
            /// 
            /// </summary>
            MailMessageList,
            /// <summary>
            /// 
            /// </summary>
            MaintainedAbilitiesList,
            /// <summary>
            /// 
            /// </summary>
            MarketListingItemList,
            /// <summary>
            /// 
            /// </summary>
            MarketSearchClassList,
            /// <summary>
            /// 
            /// </summary>
            MarketSearchItemList,
            /// <summary>
            /// 
            /// </summary>
            MarketSearchRarityList,
            /// <summary>
            /// 
            /// </summary>
            MarketSearchSlotList,
            /// <summary>
            /// 
            /// </summary>
            MarketSearchSphereList,
            /// <summary>
            /// 
            /// </summary>
            MarketSearchTypeList,
            /// <summary>
            /// 
            /// </summary>
            MemorizedDisciplines,
            /// <summary>
            /// 
            /// </summary>
            MemorizedMasteries,
            /// <summary>
            /// 
            /// </summary>
            MemoryMemQueue,
            /// <summary>
            /// 
            /// </summary>
            MerchantBuybackList,
            /// <summary>
            /// 
            /// </summary>
            MerchantItemList,
            /// <summary>
            /// 
            /// </summary>
            NPCDialogText,
            /// <summary>
            /// 
            /// </summary>
            ParlayAttachedAbilitiesList,
            /// <summary>
            /// 
            /// </summary>
            PCAbsorptionList,
            /// <summary>
            /// 
            /// </summary>
            PCArmorSkillList,
            /// <summary>
            /// 
            /// </summary>
            PCAttributeList,
            /// <summary>
            /// 
            /// </summary>
            PCCombatSkillList,
            /// <summary>
            /// 
            /// </summary>
            PCCraftAlchemistFinishingParentSkillList,
            /// <summary>
            /// 
            /// </summary>
            PCCraftAlchemistFinishingSkillList,
            /// <summary>
            /// 
            /// </summary>
            PCCraftAlchemistRefiningParentSkillList,
            /// <summary>
            /// 
            /// </summary>
            PCCraftAlchemistRefiningSkillList,
            /// <summary>
            /// 
            /// </summary>
            PCCraftArmorSkillList,
            /// <summary>
            /// 
            /// </summary>
            PCCraftArtificerFinishingParentSkillList,
            /// <summary>
            /// 
            /// </summary>
            PCCraftArtificerFinishingSkillList,
            /// <summary>
            /// 
            /// </summary>
            PCCraftArtificerRefiningParentSkillList,
            /// <summary>
            /// 
            /// </summary>
            PCCraftArtificerRefiningSkillList,
            /// <summary>
            /// 
            /// </summary>
            PCCraftAttributeList,
            /// <summary>
            /// 
            /// </summary>
            PCCraftBlacksmithFinishingParentSkillList,
            /// <summary>
            /// 
            /// </summary>
            PCCraftBlacksmithFinishingSkillList,
            /// <summary>
            /// 
            /// </summary>
            PCCraftBlacksmithRefiningParentSkillList,
            /// <summary>
            /// 
            /// </summary>
            PCCraftBlacksmithRefiningSkillList,
            /// <summary>
            /// 
            /// </summary>
            PCCraftCombatSkillList,
            /// <summary>
            /// 
            /// </summary>
            PCCraftGemworkerFinishingParentSkillList,
            /// <summary>
            /// 
            /// </summary>
            PCCraftGemworkerFinishingSkillList,
            /// <summary>
            /// 
            /// </summary>
            PCCraftGemworkerRefiningParentSkillList,
            /// <summary>
            /// 
            /// </summary>
            PCCraftGemworkerRefiningSkillList,
            /// <summary>
            /// 
            /// </summary>
            PCCraftingSkillList,
            /// <summary>
            /// 
            /// </summary>
            PCCraftingToolsSkillList,
            /// <summary>
            /// 
            /// </summary>
            PCCraftOutfitterFinishingParentSkillList,
            /// <summary>
            /// 
            /// </summary>
            PCCraftOutfitterFinishingSkillList,
            /// <summary>
            /// 
            /// </summary>
            PCCraftOutfitterRefiningParentSkillList,
            /// <summary>
            /// 
            /// </summary>
            PCCraftOutfitterRefiningSkillList,
            /// <summary>
            /// 
            /// </summary>
            PCCraftPerceptionAndConcealmentSkillList,
            /// <summary>
            /// 
            /// </summary>
            PCCraftWeaponOverskillSkillList,
            /// <summary>
            /// 
            /// </summary>
            PCCraftWeaponSpecializationSkillList,
            /// <summary>
            /// 
            /// </summary>
            PCCraftWieldTypesSkillList,
            /// <summary>
            /// 
            /// </summary>
            PCDiplomacyAttributeList,
            /// <summary>
            /// 
            /// </summary>
            PCDiplomacyExpendableList,
            /// <summary>
            /// 
            /// </summary>
            PCDiplomacyParlaySkillList,
            /// <summary>
            /// 
            /// </summary>
            PCDiplomacyPresenceList,
            /// <summary>
            /// 
            /// </summary>
            PCDiplomacyTraitList,
            /// <summary>
            /// 
            /// </summary>
            PCExpendableList,
            /// <summary>
            /// 
            /// </summary>
            PCGeneralSkillList,
            /// <summary>
            /// 
            /// </summary>
            PCHarvestAttributeList,
            /// <summary>
            /// 
            /// </summary>
            PCHarvestExpendableList,
            /// <summary>
            /// 
            /// </summary>
            PCHarvestSkillList,
            /// <summary>
            /// 
            /// </summary>
            PCHarvestSpecificSkillList,
            /// <summary>
            /// 
            /// </summary>
            PCPerceptionAndConcealmentSkillList,
            /// <summary>
            /// 
            /// </summary>
            PCPlayerFactions,
            /// <summary>
            /// 
            /// </summary>
            PCPrestigeFactions,
            /// <summary>
            /// 
            /// </summary>
            PCResistanceSkillList,
            /// <summary>
            /// 
            /// </summary>
            PCSpellSchoolSkillList,
            /// <summary>
            /// 
            /// </summary>
            PCWeaponOverskillSkillList,
            /// <summary>
            /// 
            /// </summary>
            PCWeaponSpecializationSkillList,
            /// <summary>
            /// 
            /// </summary>
            PCWieldTypesSkillList,
            /// <summary>
            /// 
            /// </summary>
            PetAbilityList,
            /// <summary>
            /// 
            /// </summary>
            PetAutoList,
            /// <summary>
            /// 
            /// </summary>
            PlayerMaterialItemList,
            /// <summary>
            /// 
            /// </summary>
            PlotOptionList,
            /// <summary>
            /// 
            /// </summary>
            PsionicConcentrationList,
            /// <summary>
            /// 
            /// </summary>
            QuestRewardGroupList,
            /// <summary>
            /// 
            /// </summary>
            RecipeLabelList,
            /// <summary>
            /// 
            /// </summary>
            RecipeList,
            /// <summary>
            /// 
            /// </summary>
            RefiningAlerts,
            /// <summary>
            /// 
            /// </summary>
            RefiningButtons,
            /// <summary>
            /// 
            /// </summary>
            RefiningGeneralRecipes,
            /// <summary>
            /// 
            /// </summary>
            RefiningQueuedActions,
            /// <summary>
            /// 
            /// </summary>
            RefiningRecipeProgressList,
            /// <summary>
            /// 
            /// </summary>
            RefiningUniqueRecipes,
            /// <summary>
            /// 
            /// </summary>
            RefiningWorkOrderRecipes,
            /// <summary>
            /// 
            /// </summary>
            RemedyActionFamily,
            /// <summary>
            /// 
            /// </summary>
            RepairMerchantItemList,
            /// <summary>
            /// 
            /// </summary>
            RescueAbilityList,
            /// <summary>
            /// 
            /// </summary>
            SelectedQuestLocationsList,
            /// <summary>
            /// 
            /// </summary>
            SelectedQuestRewardGroupList,
            /// <summary>
            /// 
            /// </summary>
            SongBridgeList,
            /// <summary>
            /// 
            /// </summary>
            SongChorusList,
            /// <summary>
            /// 
            /// </summary>
            SongCodaList,
            /// <summary>
            /// 
            /// </summary>
            SongEmbellishmentList,
            /// <summary>
            /// 
            /// </summary>
            SongLyricList,
            /// <summary>
            /// 
            /// </summary>
            SongMelodyList,
            /// <summary>
            /// 
            /// </summary>
            SongRestList,
            /// <summary>
            /// 
            /// </summary>
            SongVerseList,
            /// <summary>
            /// 
            /// </summary>
            SympatheticAbilityList,
            /// <summary>
            /// 
            /// </summary>
            TargetAttachedAbilitiesList,
            /// <summary>
            /// 
            /// </summary>
            TargetInFlightAbilities,
            /// <summary>
            /// 
            /// </summary>
            TaskMasterWorkOrderList,
            /// <summary>
            /// 
            /// </summary>
            TitlesPostfix,
            /// <summary>
            /// 
            /// </summary>
            TitlesPrefix,
            /// <summary>
            /// 
            /// </summary>
            TradeMyItemsList,
            /// <summary>
            /// 
            /// </summary>
            TradeOthersItemsList,
            /// <summary>
            /// 
            /// </summary>
            TrainerAbilityList,
            /// <summary>
            /// 
            /// </summary>
            TrainerRecipeList,
        }

        #endregion

        #region GameVariableLong enum

        /// <summary>
        /// 
        /// </summary>
        public enum GameVariableLong
        {
            /// <summary>
            /// 
            /// </summary>
            BankCoins,
            /// <summary>
            /// 
            /// </summary>
            InventoryCoins,
            /// <summary>
            /// 
            /// </summary>
            TradeMyOfferedCoins,
            /// <summary>
            /// 
            /// </summary>
            TradeOthersOfferedCoins,
        }

        #endregion

        #region GameVariableNoType enum

        /// <summary>
        /// 
        /// </summary>
        public enum GameVariableNoType
        {
            /// <summary>
            /// 
            /// </summary>
            ActiveGroupLootMasterLooterSelectionIndex,
            /// <summary>
            /// 
            /// </summary>
            AvailableWorkOrderIssuedBy,
            /// <summary>
            /// 
            /// </summary>
            BankingCapacity,
            /// <summary>
            /// 
            /// </summary>
            GroupLootAutoSplitCoin,
            /// <summary>
            /// 
            /// </summary>
            Harvester_1_Active,
            /// <summary>
            /// 
            /// </summary>
            Harvester_2_Active,
            /// <summary>
            /// 
            /// </summary>
            Harvester_3_Active,
            /// <summary>
            /// 
            /// </summary>
            Harvester_4_Active,
            /// <summary>
            /// 
            /// </summary>
            Harvester_5_Active,
            /// <summary>
            /// 
            /// </summary>
            Harvester_6_Active,
            /// <summary>
            /// 
            /// </summary>
            Harvester_7_Active,
            /// <summary>
            /// 
            /// </summary>
            Harvester_8_Active,
            /// <summary>
            /// 
            /// </summary>
            LocationCategorySelected,
            /// <summary>
            /// 
            /// </summary>
            MarketCommissionPercReduction,
            /// <summary>
            /// 
            /// </summary>
            MarketCommissionPercTotal,
            /// <summary>
            /// 
            /// </summary>
            ParlayState,
            /// <summary>
            /// 
            /// </summary>
            PermissionText,
            /// <summary>
            /// 
            /// </summary>
            RecipeTrainerCurrRecipeCost,
            /// <summary>
            /// 
            /// </summary>
            RefiningEndButton,
            /// <summary>
            /// 
            /// </summary>
            RefiningHandlingAlertsString,
            /// <summary>
            /// 
            /// </summary>
            RefiningMaxRounds,
            /// <summary>
            /// 
            /// </summary>
            RefiningRound,
            /// <summary>
            /// 
            /// </summary>
            RefiningRounds,
        }

        #endregion

        #region GameVariableString enum

        /// <summary>
        /// 
        /// </summary>
        public enum GameVariableString
        {
            /// <summary>
            /// 
            /// </summary>
            AbilityExamineTimeRemaining,
            /// <summary>
            /// 
            /// </summary>
            AbilityListPrimaryLabel,
            /// <summary>
            /// 
            /// </summary>
            AbilityListPrimarySubsetLabel,
            /// <summary>
            /// 
            /// </summary>
            AbilityListSecondaryLabel,
            /// <summary>
            /// 
            /// </summary>
            AdvACMeleeMitigation,
            /// <summary>
            /// 
            /// </summary>
            AdvACSpellMitigation,
            /// <summary>
            /// 
            /// </summary>
            AdvArcaneResistance,
            /// <summary>
            /// 
            /// </summary>
            AdvArcaneResistFull,
            /// <summary>
            /// 
            /// </summary>
            AdvArcaneResistMelee,
            /// <summary>
            /// 
            /// </summary>
            AdvArcaneResistPartial,
            /// <summary>
            /// 
            /// </summary>
            AdvArcaneResistSpellFull,
            /// <summary>
            /// 
            /// </summary>
            AdvArcaneResistSpellPartial,
            /// <summary>
            /// 
            /// </summary>
            AdvArmorClass,
            /// <summary>
            /// 
            /// </summary>
            AdvBlockChance,
            /// <summary>
            /// 
            /// </summary>
            AdvColdResistance,
            /// <summary>
            /// 
            /// </summary>
            AdvColdResistFull,
            /// <summary>
            /// 
            /// </summary>
            AdvColdResistMelee,
            /// <summary>
            /// 
            /// </summary>
            AdvColdResistPartial,
            /// <summary>
            /// 
            /// </summary>
            AdvColdResistSpellFull,
            /// <summary>
            /// 
            /// </summary>
            AdvColdResistSpellPartial,
            /// <summary>
            /// 
            /// </summary>
            AdvConstitution,
            /// <summary>
            /// 
            /// </summary>
            AdvConstitutionHP,
            /// <summary>
            /// 
            /// </summary>
            AdvConstitutionResists,
            /// <summary>
            /// 
            /// </summary>
            AdvDefense,
            /// <summary>
            /// 
            /// </summary>
            AdvDexterity,
            /// <summary>
            /// 
            /// </summary>
            AdvDexterityAvoid,
            /// <summary>
            /// 
            /// </summary>
            AdvDexterityCritMelee,
            /// <summary>
            /// 
            /// </summary>
            AdvDexterityDodge,
            /// <summary>
            /// 
            /// </summary>
            AdvDexterityDodgeMax,
            /// <summary>
            /// 
            /// </summary>
            AdvDexterityParry,
            /// <summary>
            /// 
            /// </summary>
            AdvDexterityParryMax,
            /// <summary>
            /// 
            /// </summary>
            AdvDexterityRngDmg,
            /// <summary>
            /// 
            /// </summary>
            AdvDodgeChance,
            /// <summary>
            /// 
            /// </summary>
            AdvEnduranceTooltip,
            /// <summary>
            /// 
            /// </summary>
            AdvEnergyTooltip,
            /// <summary>
            /// 
            /// </summary>
            AdvEvasionMelee,
            /// <summary>
            /// 
            /// </summary>
            AdvEvasionSpell,
            /// <summary>
            /// 
            /// </summary>
            AdvFireResistance,
            /// <summary>
            /// 
            /// </summary>
            AdvFireResistFull,
            /// <summary>
            /// 
            /// </summary>
            AdvFireResistMelee,
            /// <summary>
            /// 
            /// </summary>
            AdvFireResistPartial,
            /// <summary>
            /// 
            /// </summary>
            AdvFireResistSpellFull,
            /// <summary>
            /// 
            /// </summary>
            AdvFireResistSpellPartial,
            /// <summary>
            /// 
            /// </summary>
            AdvHealingFocus,
            /// <summary>
            /// 
            /// </summary>
            AdvHealingFocusBonus,
            /// <summary>
            /// 
            /// </summary>
            AdvHealingFocusPotential,
            /// <summary>
            /// 
            /// </summary>
            AdvHitpoints,
            /// <summary>
            /// 
            /// </summary>
            AdvIntelligence,
            /// <summary>
            /// 
            /// </summary>
            AdvIntelligenceDmg,
            /// <summary>
            /// 
            /// </summary>
            AdvMeleeAcc,
            /// <summary>
            /// 
            /// </summary>
            AdvMeleeAtk,
            /// <summary>
            /// 
            /// </summary>
            AdvMeleeAtkOffhand,
            /// <summary>
            /// 
            /// </summary>
            AdvMeleeAutoAttackDPS,
            /// <summary>
            /// 
            /// </summary>
            AdvMeleeOffhandAutoAttackDPS,
            /// <summary>
            /// 
            /// </summary>
            AdvMentalResistance,
            /// <summary>
            /// 
            /// </summary>
            AdvMentalResistFull,
            /// <summary>
            /// 
            /// </summary>
            AdvMentalResistMelee,
            /// <summary>
            /// 
            /// </summary>
            AdvMentalResistPartial,
            /// <summary>
            /// 
            /// </summary>
            AdvMentalResistSpellFull,
            /// <summary>
            /// 
            /// </summary>
            AdvMentalResistSpellPartial,
            /// <summary>
            /// 
            /// </summary>
            AdvMitigationMelee,
            /// <summary>
            /// 
            /// </summary>
            AdvMitigationSpell,
            /// <summary>
            /// 
            /// </summary>
            AdvParryChance,
            /// <summary>
            /// 
            /// </summary>
            AdvPhysicalResistance,
            /// <summary>
            /// 
            /// </summary>
            AdvPhysicalResistFull,
            /// <summary>
            /// 
            /// </summary>
            AdvPhysicalResistMelee,
            /// <summary>
            /// 
            /// </summary>
            AdvPhysicalResistPartial,
            /// <summary>
            /// 
            /// </summary>
            AdvPhysicalResistSpellFull,
            /// <summary>
            /// 
            /// </summary>
            AdvPhysicalResistSpellPartial,
            /// <summary>
            /// 
            /// </summary>
            AdvRangeAcc,
            /// <summary>
            /// 
            /// </summary>
            AdvRangeAtk,
            /// <summary>
            /// 
            /// </summary>
            AdvRangedAcc,
            /// <summary>
            /// 
            /// </summary>
            AdvRangedAtk,
            /// <summary>
            /// 
            /// </summary>
            AdvSpellAcc,
            /// <summary>
            /// 
            /// </summary>
            AdvSpellAtk,
            /// <summary>
            /// 
            /// </summary>
            AdvSpellDamageFocus,
            /// <summary>
            /// 
            /// </summary>
            AdvSpellDamageFocusArcane,
            /// <summary>
            /// 
            /// </summary>
            AdvSpellDamageFocusBonus,
            /// <summary>
            /// 
            /// </summary>
            AdvSpellDamageFocusBonusArcane,
            /// <summary>
            /// 
            /// </summary>
            AdvSpellDamageFocusBonusCold,
            /// <summary>
            /// 
            /// </summary>
            AdvSpellDamageFocusBonusFire,
            /// <summary>
            /// 
            /// </summary>
            AdvSpellDamageFocusBonusMental,
            /// <summary>
            /// 
            /// </summary>
            AdvSpellDamageFocusBonusPhysical,
            /// <summary>
            /// 
            /// </summary>
            AdvSpellDamageFocusBonusSpiritual,
            /// <summary>
            /// 
            /// </summary>
            AdvSpellDamageFocusCold,
            /// <summary>
            /// 
            /// </summary>
            AdvSpellDamageFocusFire,
            /// <summary>
            /// 
            /// </summary>
            AdvSpellDamageFocusMental,
            /// <summary>
            /// 
            /// </summary>
            AdvSpellDamageFocusPhysical,
            /// <summary>
            /// 
            /// </summary>
            AdvSpellDamageFocusPotential,
            /// <summary>
            /// 
            /// </summary>
            AdvSpellDamageFocusSpiritual,
            /// <summary>
            /// 
            /// </summary>
            AdvSpiritualResistance,
            /// <summary>
            /// 
            /// </summary>
            AdvSpiritualResistFull,
            /// <summary>
            /// 
            /// </summary>
            AdvSpiritualResistMelee,
            /// <summary>
            /// 
            /// </summary>
            AdvSpiritualResistPartial,
            /// <summary>
            /// 
            /// </summary>
            AdvSpiritualResistSpellFull,
            /// <summary>
            /// 
            /// </summary>
            AdvSpiritualResistSpellPartial,
            /// <summary>
            /// 
            /// </summary>
            AdvStrength,
            /// <summary>
            /// 
            /// </summary>
            AdvStrengthBlock,
            /// <summary>
            /// 
            /// </summary>
            AdvStrengthBlockMax,
            /// <summary>
            /// 
            /// </summary>
            AdvStrengthDmg,
            /// <summary>
            /// 
            /// </summary>
            AdvStrengthWeight,
            /// <summary>
            /// 
            /// </summary>
            AdvVitality,
            /// <summary>
            /// 
            /// </summary>
            AdvVitalityEndurance,
            /// <summary>
            /// 
            /// </summary>
            AdvVitalityHealBonus,
            /// <summary>
            /// 
            /// </summary>
            AdvVitalityHPRegenBonus,
            /// <summary>
            /// 
            /// </summary>
            AdvVitalityRunSpeed,
            /// <summary>
            /// 
            /// </summary>
            AdvWisdom,
            /// <summary>
            /// 
            /// </summary>
            AdvWisdomCritSpell,
            /// <summary>
            /// 
            /// </summary>
            AdvWisdomEnergy,
            /// <summary>
            /// 
            /// </summary>
            AsmRecipeIngredientName0,
            /// <summary>
            /// 
            /// </summary>
            AsmRecipeIngredientName1,
            /// <summary>
            /// 
            /// </summary>
            AsmRecipeIngredientName2,
            /// <summary>
            /// 
            /// </summary>
            AsmRecipeIngredientName3,
            /// <summary>
            /// 
            /// </summary>
            AsmRecipeIngredientName4,
            /// <summary>
            /// 
            /// </summary>
            AsmRecipeIngredientStatus0,
            /// <summary>
            /// 
            /// </summary>
            AsmRecipeIngredientStatus1,
            /// <summary>
            /// 
            /// </summary>
            AsmRecipeIngredientStatus2,
            /// <summary>
            /// 
            /// </summary>
            AsmRecipeIngredientStatus3,
            /// <summary>
            /// 
            /// </summary>
            AsmRecipeIngredientStatus4,
            /// <summary>
            /// 
            /// </summary>
            AsmRecipeName,
            /// <summary>
            /// 
            /// </summary>
            AssemblyTrainerCurrRecipeCost,
            /// <summary>
            /// 
            /// </summary>
            AssemblyTrainerCurrRecipeDescription,
            /// <summary>
            /// 
            /// </summary>
            AssemblyTrainerCurrRecipeIcon,
            /// <summary>
            /// 
            /// </summary>
            AssemblyTrainerCurrRecipeName,
            /// <summary>
            /// 
            /// </summary>
            AvailableWorkOrderDescription,
            /// <summary>
            /// 
            /// </summary>
            AvailableWorkOrderDifficulty,
            /// <summary>
            /// 
            /// </summary>
            AvailableWorkOrderName,
            /// <summary>
            /// 
            /// </summary>
            AvailableWorkOrderNeededItems,
            /// <summary>
            /// 
            /// </summary>
            AvailableWorkOrderRecipes,
            /// <summary>
            /// 
            /// </summary>
            AvailableWorkOrderSkill,
            /// <summary>
            /// 
            /// </summary>
            AvailableWorkOrderSteps,
            /// <summary>
            /// 
            /// </summary>
            BankCoinsCopper,
            /// <summary>
            /// 
            /// </summary>
            BankCoinsGold,
            /// <summary>
            /// 
            /// </summary>
            BankCoinsPlatinum,
            /// <summary>
            /// 
            /// </summary>
            BankCoinsSilver,
            /// <summary>
            /// 
            /// </summary>
            BankingDisplayName,
            /// <summary>
            /// 
            /// </summary>
            BuildingBuildDate,
            /// <summary>
            /// 
            /// </summary>
            BuildingDebugInfo,
            /// <summary>
            /// 
            /// </summary>
            BuildingOwnerText,
            /// <summary>
            /// 
            /// </summary>
            BuildingPermissionName,
            /// <summary>
            /// 
            /// </summary>
            CaravanDestination,
            /// <summary>
            /// 
            /// </summary>
            ChestCountText,
            /// <summary>
            /// 
            /// </summary>
            ChestDisplayName,
            /// <summary>
            /// 
            /// </summary>
            ChestMaxText,
            /// <summary>
            /// 
            /// </summary>
            CombatInfoAggro,
            /// <summary>
            /// 
            /// </summary>
            CombatInfoCon,
            /// <summary>
            /// 
            /// </summary>
            CombatInfoOwnership,
            /// <summary>
            /// 
            /// </summary>
            ConnectionsGV,
            /// <summary>
            /// 
            /// </summary>
            CraftingAlertText,
            /// <summary>
            /// 
            /// </summary>
            CraftingQualityLetter,
            /// <summary>
            /// 
            /// </summary>
            CraftingRecipeSectionName,
            /// <summary>
            /// 
            /// </summary>
            CraftingRecipeSelectDescription,
            /// <summary>
            /// 
            /// </summary>
            CraftingRecipeSelectMissingItems,
            /// <summary>
            /// 
            /// </summary>
            CraftingRecipeSelectName,
            /// <summary>
            /// 
            /// </summary>
            CraftingRecipeSelectNumUses,
            /// <summary>
            /// 
            /// </summary>
            CurrentConstructionProjectStatusText,
            /// <summary>
            /// 
            /// </summary>
            CurrentConstructionProjectText,
            /// <summary>
            /// 
            /// </summary>
            CurrentWorkOrderDescription,
            /// <summary>
            /// 
            /// </summary>
            CurrentWorkOrderDifficulty,
            /// <summary>
            /// 
            /// </summary>
            CurrentWorkOrderIssuedBy,
            /// <summary>
            /// 
            /// </summary>
            CurrentWorkOrderName,
            /// <summary>
            /// 
            /// </summary>
            CurrentWorkOrderNeededItems,
            /// <summary>
            /// 
            /// </summary>
            CurrentWorkOrderRecipes,
            /// <summary>
            /// 
            /// </summary>
            CurrentWorkOrderSkill,
            /// <summary>
            /// 
            /// </summary>
            CurrentWorkOrderSteps,
            /// <summary>
            /// 
            /// </summary>
            DefTargetName,
            /// <summary>
            /// 
            /// </summary>
            DialogResponseMode,
            /// <summary>
            /// 
            /// </summary>
            DualWieldPenalty,
            /// <summary>
            /// 
            /// </summary>
            EnergyRegenPerSecond,
            /// <summary>
            /// 
            /// </summary>
            FellowshipMOTD,
            /// <summary>
            /// 
            /// </summary>
            FellowshipMOTDSetBy,
            /// <summary>
            /// 
            /// </summary>
            FellowshipName,
            /// <summary>
            /// 
            /// </summary>
            FixtureCountText,
            /// <summary>
            /// 
            /// </summary>
            FixtureMaxText,
            /// <summary>
            /// 
            /// </summary>
            fMovementSpeedSelfPct,
            /// <summary>
            /// 
            /// </summary>
            GuildMotdLastModified,
            /// <summary>
            /// 
            /// </summary>
            GuildMotdText,
            /// <summary>
            /// 
            /// </summary>
            GuildName,
            /// <summary>
            /// 
            /// </summary>
            HarvestingActionName,
            /// <summary>
            /// 
            /// </summary>
            InventoryCoinsCopper,
            /// <summary>
            /// 
            /// </summary>
            InventoryCoinsGold,
            /// <summary>
            /// 
            /// </summary>
            InventoryCoinsPlatinum,
            /// <summary>
            /// 
            /// </summary>
            InventoryCoinsSilver,
            /// <summary>
            /// 
            /// </summary>
            InventoryWeight,
            /// <summary>
            /// 
            /// </summary>
            InventoryWeightCur,
            /// <summary>
            /// 
            /// </summary>
            InventoryWeightMax,
            /// <summary>
            /// 
            /// </summary>
            ItemExamineTimeRemaining,
            /// <summary>
            /// 
            /// </summary>
            JournalAdvCombatFormDisplayText,
            /// <summary>
            /// 
            /// </summary>
            JournalFinRecipeDescription,
            /// <summary>
            /// 
            /// </summary>
            JournalFinRecipeIcon,
            /// <summary>
            /// 
            /// </summary>
            JournalFinRecipeMastered,
            /// <summary>
            /// 
            /// </summary>
            JournalFinRecipeMissingItems,
            /// <summary>
            /// 
            /// </summary>
            JournalFinRecipeName,
            /// <summary>
            /// 
            /// </summary>
            JournalFinRecipeNumUses,
            /// <summary>
            /// 
            /// </summary>
            JournalRefRecipeDescription,
            /// <summary>
            /// 
            /// </summary>
            JournalRefRecipeIcon,
            /// <summary>
            /// 
            /// </summary>
            JournalRefRecipeMastered,
            /// <summary>
            /// 
            /// </summary>
            JournalRefRecipeMissingItems,
            /// <summary>
            /// 
            /// </summary>
            JournalRefRecipeName,
            /// <summary>
            /// 
            /// </summary>
            JournalRefRecipeNumUses,
            /// <summary>
            /// 
            /// </summary>
            JournalWorkOrderDescription,
            /// <summary>
            /// 
            /// </summary>
            JournalWorkOrderDifficulty,
            /// <summary>
            /// 
            /// </summary>
            JournalWorkOrderIssuedBy,
            /// <summary>
            /// 
            /// </summary>
            JournalWorkOrderName,
            /// <summary>
            /// 
            /// </summary>
            JournalWorkOrderNeededItems,
            /// <summary>
            /// 
            /// </summary>
            JournalWorkOrderRecipes,
            /// <summary>
            /// 
            /// </summary>
            JournalWorkOrderSkill,
            /// <summary>
            /// 
            /// </summary>
            JournalWorkOrderSteps,
            /// <summary>
            /// 
            /// </summary>
            LFMComment,
            /// <summary>
            /// 
            /// </summary>
            LootFrom,
            /// <summary>
            /// 
            /// </summary>
            MailCopperToSend,
            /// <summary>
            /// 
            /// </summary>
            MailGoldToSend,
            /// <summary>
            /// 
            /// </summary>
            MailItemInsuranceCost,
            /// <summary>
            /// 
            /// </summary>
            MailItemShippingCost,
            /// <summary>
            /// 
            /// </summary>
            MailItemShippingCostCopper,
            /// <summary>
            /// 
            /// </summary>
            MailItemShippingCostSilver,
            /// <summary>
            /// 
            /// </summary>
            MailPlatToSend,
            /// <summary>
            /// 
            /// </summary>
            MailPostage,
            /// <summary>
            /// 
            /// </summary>
            MailSilverToSend,
            /// <summary>
            /// 
            /// </summary>
            MailTotalCost,
            /// <summary>
            /// 
            /// </summary>
            MapID,
            /// <summary>
            /// 
            /// </summary>
            MapMouseChunk,
            /// <summary>
            /// 
            /// </summary>
            MarketCommission,
            /// <summary>
            /// 
            /// </summary>
            MarketDepositAmount,
            /// <summary>
            /// 
            /// </summary>
            MarketDepositAmountPercBase,
            /// <summary>
            /// 
            /// </summary>
            MarketDepositAmountPercReduction,
            /// <summary>
            /// 
            /// </summary>
            MarketDepositAmountPercTotal,
            /// <summary>
            /// 
            /// </summary>
            MarketMyItemItemNameText,
            /// <summary>
            /// 
            /// </summary>
            MarketName,
            /// <summary>
            /// 
            /// </summary>
            MarketSearchItemNameText,
            /// <summary>
            /// 
            /// </summary>
            MarketSearchMaxLevelText,
            /// <summary>
            /// 
            /// </summary>
            MarketSearchMinLevelText,
            /// <summary>
            /// 
            /// </summary>
            MarketSearchSellerNameText,
            /// <summary>
            /// 
            /// </summary>
            MarketSelectedBuyItemName,
            /// <summary>
            /// 
            /// </summary>
            MarketSelectedListItemName,
            /// <summary>
            /// 
            /// </summary>
            MarketSellerPrice,
            /// <summary>
            /// 
            /// </summary>
            MarketTotalCost,
            /// <summary>
            /// 
            /// </summary>
            MarketTotalCostConfirm,
            /// <summary>
            /// 
            /// </summary>
            MemoryMemorizeCurrName,
            /// <summary>
            /// 
            /// </summary>
            ObjectActivationText,
            /// <summary>
            /// 
            /// </summary>
            OffTargetName,
            /// <summary>
            /// 
            /// </summary>
            ParlayDialogPoints,
            /// <summary>
            /// 
            /// </summary>
            ParlayOpponentDialogPoints,
            /// <summary>
            /// 
            /// </summary>
            ParleyOpponentClass,
            /// <summary>
            /// 
            /// </summary>
            ParleyOpponentName,
            /// <summary>
            /// 
            /// </summary>
            PawnHoverName,
            /// <summary>
            /// 
            /// </summary>
            PawnHoverNPCRace,
            /// <summary>
            /// 
            /// </summary>
            PawnHoverNPCTitle,
            /// <summary>
            /// 
            /// </summary>
            PawnHoverPCClass,
            /// <summary>
            /// 
            /// </summary>
            PawnHoverPCInfamy,
            /// <summary>
            /// 
            /// </summary>
            PawnHoverPCLevel,
            /// <summary>
            /// 
            /// </summary>
            PCHarPrimaryName,
            /// <summary>
            /// 
            /// </summary>
            PCHarSecondaryName,
            /// <summary>
            /// 
            /// </summary>
            PCPoolAdvWeaponTypesStr,
            /// <summary>
            /// 
            /// </summary>
            PetName,
            /// <summary>
            /// 
            /// </summary>
            PetType,
            /// <summary>
            /// 
            /// </summary>
            RecipeTrainerCurrRecipeDescription,
            /// <summary>
            /// 
            /// </summary>
            RecipeTrainerCurrRecipeIcon,
            /// <summary>
            /// 
            /// </summary>
            RecipeTrainerCurrRecipeName,
            /// <summary>
            /// 
            /// </summary>
            RecipeTrainerCurrRecipePrice,
            /// <summary>
            /// 
            /// </summary>
            RefiningCurrentRecipeName,
            /// <summary>
            /// 
            /// </summary>
            ReleaseTimerLabel,
            /// <summary>
            /// 
            /// </summary>
            SelectedConstructionProjectName,
            /// <summary>
            /// 
            /// </summary>
            ShipSailStage,
            /// <summary>
            /// 
            /// </summary>
            ShipWaterDepth,
            /// <summary>
            /// 
            /// </summary>
            ShipWaterDepthMax,
            /// <summary>
            /// 
            /// </summary>
            ShipWindDirection,
            /// <summary>
            /// 
            /// </summary>
            SongNowPlaying,
            /// <summary>
            /// 
            /// </summary>
            StatusInfamySelf,
            /// <summary>
            /// 
            /// </summary>
            strAdvClassInspectTarget,
            /// <summary>
            /// 
            /// </summary>
            strAdvClassSelf,
            /// <summary>
            /// 
            /// </summary>
            strAdvEquipExpertisePct,
            /// <summary>
            /// 
            /// </summary>
            strAdvLevelRaceClass,
            /// <summary>
            /// 
            /// </summary>
            strAssemblingRecipeInfo,
            /// <summary>
            /// 
            /// </summary>
            strBindLocationSelf,
            /// <summary>
            /// 
            /// </summary>
            strCastingSpellInfo,
            /// <summary>
            /// 
            /// </summary>
            strCharacterCreateClass,
            /// <summary>
            /// 
            /// </summary>
            strCharacterCreateClassDescription,
            /// <summary>
            /// 
            /// </summary>
            strCharacterCreateError,
            /// <summary>
            /// 
            /// </summary>
            strCharacterCreateGender,
            /// <summary>
            /// 
            /// </summary>
            strCharacterCreateHeader,
            /// <summary>
            /// 
            /// </summary>
            strCharacterCreateRace,
            /// <summary>
            /// 
            /// </summary>
            strCharacterCreateRaceClass,
            /// <summary>
            /// 
            /// </summary>
            strCharacterCreateRaceDescription,
            /// <summary>
            /// 
            /// </summary>
            strCharacterCreateRacialIntro,
            /// <summary>
            /// 
            /// </summary>
            strCharacterSelectInfo,
            /// <summary>
            /// 
            /// </summary>
            strCompassDirection,
            /// <summary>
            /// 
            /// </summary>
            strConstructionBuildingName,
            /// <summary>
            /// 
            /// </summary>
            strConstructionBuildingNumChests,
            /// <summary>
            /// 
            /// </summary>
            strConstructionBuildingNumFixtures,
            /// <summary>
            /// 
            /// </summary>
            strConstructionBuildingType,
            /// <summary>
            /// 
            /// </summary>
            strContesType,
            /// <summary>
            /// 
            /// </summary>
            strCraEquipExpertisePct,
            /// <summary>
            /// 
            /// </summary>
            strCraftingTradeSelf,
            /// <summary>
            /// 
            /// </summary>
            strCraftTitleSelf,
            /// <summary>
            /// 
            /// </summary>
            strCraLevelRaceClass,
            /// <summary>
            /// 
            /// </summary>
            strCurrentChunk,
            /// <summary>
            /// 
            /// </summary>
            strDefense,
            /// <summary>
            /// 
            /// </summary>
            strDipLevelRaceClass,
            /// <summary>
            /// 
            /// </summary>
            strDiplomatClassSelf,
            /// <summary>
            /// 
            /// </summary>
            strDiplomatRankSelf,
            /// <summary>
            /// 
            /// </summary>
            strFormsLabel,
            /// <summary>
            /// 
            /// </summary>
            strGameTime,
            /// <summary>
            /// 
            /// </summary>
            strGenderSelf,
            /// <summary>
            /// 
            /// </summary>
            strGroupLootBeingRandomed,
            /// <summary>
            /// 
            /// </summary>
            strGroupLootMode,
            /// <summary>
            /// 
            /// </summary>
            strGroupLootPlayerRoll,
            /// <summary>
            /// 
            /// </summary>
            strGroupLootStatusMessage,
            /// <summary>
            /// 
            /// </summary>
            strGroupLootStatusMessage2,
            /// <summary>
            /// 
            /// </summary>
            strGuildRankName1,
            /// <summary>
            /// 
            /// </summary>
            strGuildRankName10,
            /// <summary>
            /// 
            /// </summary>
            strGuildRankName2,
            /// <summary>
            /// 
            /// </summary>
            strGuildRankName3,
            /// <summary>
            /// 
            /// </summary>
            strGuildRankName4,
            /// <summary>
            /// 
            /// </summary>
            strGuildRankName5,
            /// <summary>
            /// 
            /// </summary>
            strGuildRankName6,
            /// <summary>
            /// 
            /// </summary>
            strGuildRankName7,
            /// <summary>
            /// 
            /// </summary>
            strGuildRankName8,
            /// <summary>
            /// 
            /// </summary>
            strGuildRankName9,
            /// <summary>
            /// 
            /// </summary>
            strHarLevelRaceClass,
            /// <summary>
            /// 
            /// </summary>
            strHarvClassSelf,
            /// <summary>
            /// 
            /// </summary>
            strHouseLocationSelf,
            /// <summary>
            /// 
            /// </summary>
            strInterfaceType,
            /// <summary>
            /// 
            /// </summary>
            strLagMeterOverall,
            /// <summary>
            /// 
            /// </summary>
            strLoginWaitingAction,
            /// <summary>
            /// 
            /// </summary>
            strLoginWaitingInfo,
            /// <summary>
            /// 
            /// </summary>
            strMissedPayments,
            /// <summary>
            /// 
            /// </summary>
            strNameFullSelf,
            /// <summary>
            /// 
            /// </summary>
            strNameInspectTarget,
            /// <summary>
            /// 
            /// </summary>
            strNameSelf,
            /// <summary>
            /// 
            /// </summary>
            strOpenersLabel,
            /// <summary>
            /// 
            /// </summary>
            strPlotCost,
            /// <summary>
            /// 
            /// </summary>
            strPlotDebugInfo,
            /// <summary>
            /// 
            /// </summary>
            strPlotOwner,
            /// <summary>
            /// 
            /// </summary>
            strPlotPurchaseDate,
            /// <summary>
            /// 
            /// </summary>
            strPositionSelf,
            /// <summary>
            /// 
            /// </summary>
            strRaceSelf,
            /// <summary>
            /// 
            /// </summary>
            strRealWorldTime,
            /// <summary>
            /// 
            /// </summary>
            strSignText,
            /// <summary>
            /// 
            /// </summary>
            strStatusSelf,
            /// <summary>
            /// 
            /// </summary>
            strUpkeepBankBalance,
            /// <summary>
            /// 
            /// </summary>
            strUpkeepCost,
            /// <summary>
            /// 
            /// </summary>
            strUpkeepLastDeduction,
            /// <summary>
            /// 
            /// </summary>
            strUpkeepNextDeduction,
            /// <summary>
            /// 
            /// </summary>
            TalkingNPCName,
            /// <summary>
            /// 
            /// </summary>
            TestData0,
            /// <summary>
            /// 
            /// </summary>
            TestData1,
            /// <summary>
            /// 
            /// </summary>
            TitlesPostfixActive,
            /// <summary>
            /// 
            /// </summary>
            TitlesPrefixActive,
            /// <summary>
            /// 
            /// </summary>
            TooltipAbilityDesc,
            /// <summary>
            /// 
            /// </summary>
            TooltipAbilityName,
            /// <summary>
            /// 
            /// </summary>
            TooltipReactionName,
            /// <summary>
            /// 
            /// </summary>
            TooltipReactionTime,
            /// <summary>
            /// 
            /// </summary>
            TooltipStatusBarPct,
            /// <summary>
            /// 
            /// </summary>
            TooltipStatusBarValues,
            /// <summary>
            /// 
            /// </summary>
            TooltipString,
            /// <summary>
            /// 
            /// </summary>
            TradeOfferCoinsCopper,
            /// <summary>
            /// 
            /// </summary>
            TradeOfferCoinsGold,
            /// <summary>
            /// 
            /// </summary>
            TradeOfferCoinsPlatinum,
            /// <summary>
            /// 
            /// </summary>
            TradeOfferCoinsSilver,
            /// <summary>
            /// 
            /// </summary>
            TradeOthersName,
            /// <summary>
            /// 
            /// </summary>
            TrainerCurrAbilityCost,
            /// <summary>
            /// 
            /// </summary>
            TrainerCurrAbilityDescription,
            /// <summary>
            /// 
            /// </summary>
            TrainerCurrAbilityIcon,
            /// <summary>
            /// 
            /// </summary>
            TrainerCurrAbilityName,
        }

        #endregion

        #region GameVariableUnknown enum

        /// <summary>
        /// 
        /// </summary>
        public enum GameVariableUnknown
        {
            /// <summary>
            /// 
            /// </summary>
            Status_AbilityCastTimeStatus,
            /// <summary>
            /// 
            /// </summary>
            Status_AdvCannotChangeFormStatus,
            /// <summary>
            /// 
            /// </summary>
            Status_AdvEquipExpertisePct,
            /// <summary>
            /// 
            /// </summary>
            Status_AdvExpDebtPctSelf,
            /// <summary>
            /// 
            /// </summary>
            Status_AdvExpPctSelf,
            /// <summary>
            /// 
            /// </summary>
            Item_AsmRecipeIngredientItem0,
            /// <summary>
            /// 
            /// </summary>
            Item_AsmRecipeIngredientItem1,
            /// <summary>
            /// 
            /// </summary>
            Item_AsmRecipeIngredientItem2,
            /// <summary>
            /// 
            /// </summary>
            Item_AsmRecipeIngredientItem3,
            /// <summary>
            /// 
            /// </summary>
            Item_AsmRecipeIngredientItem4,
            /// <summary>
            /// 
            /// </summary>
            Item_AsmRecipeRewardItem,
            /// <summary>
            /// 
            /// </summary>
            Status_AssemblyTimeStatus,
            /// <summary>
            /// 
            /// </summary>
            Text_Field_CombatIncomingResults,
            /// <summary>
            /// 
            /// </summary>
            Status_ComplicationHealthBar1,
            /// <summary>
            /// 
            /// </summary>
            Status_ComplicationHealthBar2,
            /// <summary>
            /// 
            /// </summary>
            Status_ComplicationHealthBar3,
            /// <summary>
            /// 
            /// </summary>
            Status_CraEquipExpertisePct,
            /// <summary>
            /// 
            /// </summary>
            Status_CraftExpPctSelf,
            /// <summary>
            /// 
            /// </summary>
            Status_CraftingQuality,
            /// <summary>
            /// 
            /// </summary>
            Status_CraftingSectionStatusBar,
            /// <summary>
            /// 
            /// </summary>
            Status_CraftingStatusBarSection0,
            /// <summary>
            /// 
            /// </summary>
            Status_CraftingStatusBarSection1,
            /// <summary>
            /// 
            /// </summary>
            Status_CraftingStatusBarSection2,
            /// <summary>
            /// 
            /// </summary>
            Status_CraftingStatusBarSection3,
            /// <summary>
            /// 
            /// </summary>
            Status_CraftingStatusBarSection4,
            /// <summary>
            /// 
            /// </summary>
            Status_CraftingTimeRemaining,
            /// <summary>
            /// 
            /// </summary>
            Combat_Form_CurrentFormAdv,
            /// <summary>
            /// 
            /// </summary>
            Status_DefTargetLifePoints,
            /// <summary>
            /// 
            /// </summary>
            Parlay_Card_DiplomacyMyStatement,
            /// <summary>
            /// 
            /// </summary>
            Parlay_Card_DiplomacyOppStatement,
            /// <summary>
            /// 
            /// </summary>
            Status_DipSkillPctSelf,
            /// <summary>
            /// 
            /// </summary>
            Button_EquippedToolButton,
            /// <summary>
            /// 
            /// </summary>
            Tree_FilteredAssemblyRecipeTree,
            /// <summary>
            /// 
            /// </summary>
            Tree_FinishingRecipeTree,
            /// <summary>
            /// 
            /// </summary>
            Status_HarSkillPctSelf,
            /// <summary>
            /// 
            /// </summary>
            Statistic_HarvestingQuantity,
            /// <summary>
            /// 
            /// </summary>
            Status_HarvestingTargetSI,
            /// <summary>
            /// 
            /// </summary>
            Combat_Form_JournalAdvCombatFormDisplay,
            /// <summary>
            /// 
            /// </summary>
            Status_LifePointsSelf,
            /// <summary>
            /// 
            /// </summary>
            Tree_LocationsCategories,
            /// <summary>
            /// 
            /// </summary>
            Status_LootRollTimeRemaining,
            /// <summary>
            /// 
            /// </summary>
            Item_MarketMyOfferItemSlot,
            /// <summary>
            /// 
            /// </summary>
            Item_MarketSelectedBuyItemSlot,
            /// <summary>
            /// 
            /// </summary>
            Status_MemoryMemTimeRemaining,
            /// <summary>
            /// 
            /// </summary>
            Status_MentalStaminaSelf,
            /// <summary>
            /// 
            /// </summary>
            Status_ObjectActivationStatus,
            /// <summary>
            /// 
            /// </summary>
            Status_OffTargetLifePoints,
            /// <summary>
            /// 
            /// </summary>
            Status_ParlayDemand,
            /// <summary>
            /// 
            /// </summary>
            Statistic_ParlayDialogStatus,
            /// <summary>
            /// 
            /// </summary>
            Status_ParlayFlatter,
            /// <summary>
            /// 
            /// </summary>
            Status_ParlayInspire,
            /// <summary>
            /// 
            /// </summary>
            Status_ParlayOpponentDemand,
            /// <summary>
            /// 
            /// </summary>
            Status_ParlayOpponentFlatter,
            /// <summary>
            /// 
            /// </summary>
            Status_ParlayOpponentInspire,
            /// <summary>
            /// 
            /// </summary>
            Status_ParlayOpponentReason,
            /// <summary>
            /// 
            /// </summary>
            Status_ParlayReason,
            /// <summary>
            /// 
            /// </summary>
            Status_PCPoolAdvCombatPct,
            /// <summary>
            /// 
            /// </summary>
            Status_PCPoolAdvGeneralPct,
            /// <summary>
            /// 
            /// </summary>
            Status_PCPoolAdvPerceptionPct,
            /// <summary>
            /// 
            /// </summary>
            Status_PCPoolAdvSpellSchoolsPct,
            /// <summary>
            /// 
            /// </summary>
            Status_PCPoolAdvWeaponSpecializationPct,
            /// <summary>
            /// 
            /// </summary>
            Status_PCPoolAdvWeaponTypesPct,
            /// <summary>
            /// 
            /// </summary>
            Status_PCPoolCraArtificerGeneralMaterialRefiningPct,
            /// <summary>
            /// 
            /// </summary>
            Status_PCPoolCraArtificerMaterialFinishingPct,
            /// <summary>
            /// 
            /// </summary>
            Status_PCPoolCraArtificerMaterialRefiningPct,
            /// <summary>
            /// 
            /// </summary>
            Status_PCPoolCraArtificerMaterialSpecializationsPct,
            /// <summary>
            /// 
            /// </summary>
            Status_PCPoolCraBlacksmithGeneralMetalRefiningPct,
            /// <summary>
            /// 
            /// </summary>
            Status_PCPoolCraBlacksmithMetalFinishingPct,
            /// <summary>
            /// 
            /// </summary>
            Status_PCPoolCraBlacksmithMetalRefiningPct,
            /// <summary>
            /// 
            /// </summary>
            Status_PCPoolCraBlacksmithMetalSpecializationsPct,
            /// <summary>
            /// 
            /// </summary>
            Status_PCPoolCraOutfitterGeneralMaterialRefiningPct,
            /// <summary>
            /// 
            /// </summary>
            Status_PCPoolCraOutfitterMaterialFinishingPct,
            /// <summary>
            /// 
            /// </summary>
            Status_PCPoolCraOutfitterMaterialRefiningPct,
            /// <summary>
            /// 
            /// </summary>
            Status_PCPoolCraOutfitterMaterialSpecializationsPct,
            /// <summary>
            /// 
            /// </summary>
            Status_PCPoolHarHarvestingSkillsPct,
            /// <summary>
            /// 
            /// </summary>
            Status_PCPoolHarResourceSpecificSkillsPct,
            /// <summary>
            /// 
            /// </summary>
            Status_PetStatus,
            /// <summary>
            /// 
            /// </summary>
            Status_PhysicalStaminaSelf,
            /// <summary>
            /// 
            /// </summary>
            Status_PowerSelf,
            /// <summary>
            /// 
            /// </summary>
            Status_ProgressiveFormStatus,
            /// <summary>
            /// 
            /// </summary>
            Status_PsionicPointPoolStatus,
            /// <summary>
            /// 
            /// </summary>
            Quest_qstOfferedQuest,
            /// <summary>
            /// 
            /// </summary>
            Quest_qstSelectedQuest,
            /// <summary>
            /// 
            /// </summary>
            Status_RefiningActionPointBar,
            /// <summary>
            /// 
            /// </summary>
            Refining_Recipe_RefiningRecipe,
            /// <summary>
            /// 
            /// </summary>
            Tree_RefiningRecipeTree,
            /// <summary>
            /// 
            /// </summary>
            Guild_Member_SelectedGuildMember,
            /// <summary>
            /// 
            /// </summary>
            Player_Statistic_StatEndurance,
            /// <summary>
            /// 
            /// </summary>
            Player_Statistic_StatEnergy,
            /// <summary>
            /// 
            /// </summary>
            Player_Statistic_StatHitPoints,
            /// <summary>
            /// 
            /// </summary>
            Player_Statistic_StatStrength,
            /// <summary>
            /// 
            /// </summary>
            Status_StatusBreathSelf,
            /// <summary>
            /// 
            /// </summary>
            Status_StatusEnduranceSelf,
            /// <summary>
            /// 
            /// </summary>
            Status_StatusEnergyTypeSelf,
            /// <summary>
            /// 
            /// </summary>
            Status_StatusHitpointsSelf,
            /// <summary>
            /// 
            /// </summary>
            Status_StatusStaminaSelf,
            /// <summary>
            /// 
            /// </summary>
            Status_StatusVirtuePointsSelf,
            /// <summary>
            /// 
            /// </summary>
            Combat_Info_TargetCombatInfo,
            /// <summary>
            /// 
            /// </summary>
            Text_Field_TargetsUpdateText,
        }

        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="GV"/> class.
        /// </summary>
        /// <param name="Obj">The obj.</param>
        public GV(LavishScriptObject Obj) : base(Obj) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="GV"/> class.
        /// </summary>
        /// <param name="Args">The args.</param>
        public GV(params string[] Args) : base(LavishScript.Objects.GetObject("GV", Args)) {}

        /// <summary>
        /// Gets the specified game variable.
        /// </summary>
        /// <param name="gameVariable">The game variable.</param>
        /// <returns></returns>
        public string Get(GameVariableString gameVariable)
        {
            return GetMember<string>("string", gameVariable.ToString());
        }

        /// <summary>
        /// Gets the specified game variable.
        /// </summary>
        /// <param name="gameVariable">The game variable.</param>
        /// <returns></returns>
        public float Get(GameVariableFloat gameVariable)
        {
            return GetMember<float>("float", gameVariable.ToString());
        }

        /// <summary>
        /// Gets the specified game variable.
        /// </summary>
        /// <param name="gameVariable">The game variable.</param>
        /// <returns></returns>
        public int Get(GameVariableInt gameVariable)
        {
            return GetMember<int>("int", gameVariable.ToString());
        }

        /// <summary>
        /// Gets the specified game variable.
        /// </summary>
        /// <param name="gameVariable">The game variable.</param>
        /// <returns></returns>
        public long Get(GameVariableLong gameVariable)
        {
            return GetMember<long>("int64", gameVariable.ToString());
        }

        /// <summary>
        /// Gets the specified game variable.
        /// </summary>
        /// <param name="gameVariable">The game variable.</param>
        /// <returns></returns>
        public bool Get(GameVariableBool gameVariable)
        {
            return GetMember<bool>("bool", gameVariable.ToString());
        }
    }
}