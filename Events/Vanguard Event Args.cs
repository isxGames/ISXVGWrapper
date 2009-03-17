using System;
using LavishScriptAPI;

namespace Vanguard.ISXVG.Events
{

    #region Inventory Related

    /// <summary>
    /// Arguments for the VG_onAddInventoryItem event.
    /// </summary>
    public class AddInventoryItemEventArgs : LSEventArgs
    {
        /// <summary>
        ///             Construct an LSEventArgs object with the given args
        /// </summary>
        /// <param name="args"></param>
        internal AddInventoryItemEventArgs(params string[] args) : base(args) {}

        /// <summary>
        /// Gets the name of the item.
        /// </summary>
        /// <value>The name of the item.</value>
        public string ItemName { get { return Args[0]; } }

        /// <summary>
        /// Gets the ID of the item.
        /// </summary>
        /// <value>The item ID.</value>
        public long ItemID { get { return long.Parse(Args[1]); } }

        /// <summary>
        /// Gets the level of the item.
        /// </summary>
        /// <value>The level.</value>
        public int Level { get { return int.Parse(Args[2]); } }

        /// <summary>
        /// Gets the type of the item.
        /// </summary>
        /// <value>The type.</value>
        public string Type { get { return Args[3]; } }

        /// <summary>
        /// Gets the Keyword1 of the item.
        /// </summary>
        /// <value>The keyword1.</value>
        public string Keyword1 { get { return Args[4]; } }

        /// <summary>
        /// Gets the Keyword2 of the item.
        /// </summary>
        /// <value>The keyword2.</value>
        public string Keyword2 { get { return Args[5]; } }

        /// <summary>
        /// Gets the misc description of the item.
        /// </summary>
        /// <value>The misc description.</value>
        public string MiscDescription { get { return Args[6]; } }
    }

    /// <summary>
    /// Event arguments for the VG_onCoinUpdate event.
    /// </summary>
    public class CoinUpdateEventArgs : LSEventArgs
    {
        /// <summary>
        ///             Construct an LSEventArgs object with the given args
        /// </summary>
        /// <param name="args"></param>
        internal CoinUpdateEventArgs(params string[] args) : base(args) {}

        /// <summary>
        /// This is the new total number of coppers your toon now has.
        /// </summary>
        public int NewCopper { get { return int.Parse(Args[0]); } }
    }

    /// <summary>
    /// 
    /// </summary>
    public class CanUseUpdatedEventArgs : LSEventArgs
    {
        /// <summary>
        ///             Construct an LSEventArgs object with the given args
        /// </summary>
        /// <param name="args"></param>
        internal CanUseUpdatedEventArgs(params string[] args) : base(args) {}

        /// <summary>
        /// Gets or sets the name of the item.
        /// </summary>
        /// <value>The name of the item.</value>
        public string ItemName { get { return Args[0]; } }

        /// <summary>
        /// Gets or sets the item ID of this <see cref="CanUseUpdatedEventArgs"/>.
        /// </summary>
        /// <value>The item ID.</value>
        public int ItemID { get { return int.Parse(Args[1]); } }

        /// <summary>
        /// Gets or sets the is now ready of this <see cref="CanUseUpdatedEventArgs"/>.
        /// </summary>
        /// <value>The is now ready.</value>
        public bool IsNowReady { get { return Args[2].ToUpper() == "TRUE"; } }
    }

    /// <summary>
    /// 
    /// </summary>
    public class StackCountChangeEventArgs : LSEventArgs
    {
        /// <summary>
        ///             Construct an LSEventArgs object with the given args
        /// </summary>
        /// <param name="args"></param>
        internal StackCountChangeEventArgs(params string[] args) : base(args) {}

        /// <summary>
        /// Gets or sets the name of the item.
        /// </summary>
        /// <value>The name of the item.</value>
        public string ItemName { get { return Args[0]; } }

        /// <summary>
        /// Gets or sets the item ID of this <see cref="StackCountChangeEventArgs"/>.
        /// </summary>
        /// <value>The item ID.</value>
        public int ItemID { get { return Convert.ToInt32(Args[1]); } }

        /// <summary>
        /// Gets or sets the new stack count of this <see cref="StackCountChangeEventArgs"/>.
        /// </summary>
        /// <value>The new stack count.</value>
        public int NewStackCount { get { return Convert.ToInt32(Args[2]); } }
    }

    /// <summary>
    /// 
    /// </summary>
    public class WeightUpdateEventArgs : LSEventArgs
    {
        /// <summary>
        ///             Construct an LSEventArgs object with the given args
        /// </summary>
        /// <param name="args"></param>
        internal WeightUpdateEventArgs(params string[] args) : base(args) {}

        /// <summary>
        /// Gets or sets the new weight of this <see cref="WeightUpdateEventArgs"/>.
        /// </summary>
        /// <value>The new weight.</value>
        public float NewWeight { get { return float.Parse(Args[0]); } }

        /// <summary>
        /// Gets or sets the max weight of this <see cref="WeightUpdateEventArgs"/>.
        /// </summary>
        /// <value>The max weight.</value>
        public float MaxWeight { get { return float.Parse(Args[1]); } }
    }

    #endregion

    #region Movement Related

    /// <summary>
    /// 
    /// </summary>
    public class ChangeChunkEventArgs : LSEventArgs
    {
        /// <summary>
        ///             Construct an LSEventArgs object with the given args
        /// </summary>
        /// <param name="args"></param>
        internal ChangeChunkEventArgs(params string[] args) : base(args) {}

        /// <summary>
        /// Gets or sets the new chunk X of this <see cref="ChangeChunkEventArgs"/>.
        /// </summary>
        /// <value>The new chunk X.</value>
        public string NewChunkX { get { return Args[0]; } }

        /// <summary>
        /// Gets or sets the new chunk Y of this <see cref="ChangeChunkEventArgs"/>.
        /// </summary>
        /// <value>The new chunk Y.</value>
        public string NewChunkY { get { return Args[1]; } }
    }

    public class HitObstactleEventArgs : LSEventArgs
    {
        /// <summary>
        ///             Construct an LSEventArgs object with the given args
        /// </summary>
        /// <param name="args"></param>
        internal HitObstactleEventArgs(params string[] args) : base(args) {}

        public string ObstacleActorName { get { return Args[0]; } }
        public float X { get { return float.Parse(Args[1]); } }
        public float Y { get { return float.Parse(Args[2]); } }
        public float Z { get { return float.Parse(Args[3]); } }
    }

    public class TouchPawnEventArgs : LSEventArgs
    {
        /// <summary>
        ///             Construct an LSEventArgs object with the given args
        /// </summary>
        /// <param name="args"></param>
        internal TouchPawnEventArgs(params string[] args) : base(args) {}

        public string PawnName { get { return Args[0]; } }
        public int PawnID { get { return int.Parse(Args[1]); } }
    }

    #endregion

    #region Login/Logut Related

    /// <summary>
    /// 
    /// </summary>
    public class ConnectionStateChangedEventArgs : LSEventArgs
    {
        /// <summary>
        ///             Construct an LSEventArgs object with the given args
        /// </summary>
        /// <param name="args"></param>
        internal ConnectionStateChangedEventArgs(params string[] args) : base(args) {}

        /// <summary>
        /// Gets or sets the new state of the connection.
        /// </summary>
        /// <value>The new state of the connection.</value>
        public IsxVgConnectionState NewConnectionState
        {
            get
            {
                switch (Args[0])
                {
                    case "AT_CHARACTER_SELECT":
                        return IsxVgConnectionState.AtCharacterSelect;
                    case "IN_CHARACTER_CUSTOMIZATION":
                        return IsxVgConnectionState.InCharacterCustomization;
                    case "IN_GAME":
                        return IsxVgConnectionState.InGame;
                    case "Unknown":
                        return IsxVgConnectionState.Unknown;
                    case "Unset":
                        return IsxVgConnectionState.Unset;
                    default:
                        return IsxVgConnectionState.NULL;
                }
            }
        }
    }

    #endregion

    #region Crafting Related

    public class CraftingAlertEventArgs : LSEventArgs
    {
        /// <summary>
        ///             Construct an LSEventArgs object with the given args
        /// </summary>
        /// <param name="args"></param>
        internal CraftingAlertEventArgs(params string[] args) : base(args) {}

        public string Text { get { return Args[0]; } }
    }

    public class CraftingStepCompleteEventArgs : LSEventArgs
    {
        /// <summary>
        ///             Construct an LSEventArgs object with the given args
        /// </summary>
        /// <param name="args"></param>
        public CraftingStepCompleteEventArgs(params string[] args) : base(args) {}

        public string StepTypeID { get { return Args[0]; } }
    }

    #endregion

    #region Pawn Related

    public class PawnSpawnedEventArgs : LSEventArgs
    {
        /// <summary>
        ///             Construct an LSEventArgs object with the given args
        /// </summary>
        /// <param name="args"></param>
        internal PawnSpawnedEventArgs(params string[] args) : base(args) {}

        public int ID { get { return Convert.ToInt32(Args[0]); } }
        public string Name { get { return Args[1]; } }
        public int Level { get { return Convert.ToInt32(Args[2]); } }
        public string Type { get { return Args[3]; } }
    }

    public class PawnDespawnedEventArgs : LSEventArgs
    {
        /// <summary>
        ///             Construct an LSEventArgs object with the given args
        /// </summary>
        /// <param name="args"></param>
        internal PawnDespawnedEventArgs(params string[] args) : base(args) {}

        public int ID { get { return Convert.ToInt32(Args[0]); } }
        public string Name { get { return Args[1]; } }
    }

    public class PawnStatusChangedEventArgs : LSEventArgs
    {
        /// <summary>
        ///             Construct an LSEventArgs object with the given args
        /// </summary>
        /// <param name="args"></param>
        internal PawnStatusChangedEventArgs(params string[] args) : base(args) {}

        public string ChangeType { get { return Args[0]; } }
        public long PawnID { get { return Convert.ToInt64(Args[1]); } }
        public string PawnName { get { return Args[2]; } }
    }

    public class PawnIDChangedEventArgs : LSEventArgs
    {
        /// <summary>
        ///             Construct an LSEventArgs object with the given args
        /// </summary>
        /// <param name="args"></param>
        internal PawnIDChangedEventArgs(params string[] args) : base(args) {}

        public long OldID { get { return Convert.ToInt64(Args[0]); } }
        public long NewID { get { return Convert.ToInt64(Args[2]); } }
        public string OldName { get { return Args[2]; } }
        public string NewName { get { return Args[3]; } }
    }

    #endregion

    #region Input Related

    public class IncomingTextEventArgs : LSEventArgs
    {
        /// <summary>
        ///             Construct an LSEventArgs object with the given args
        /// </summary>
        /// <param name="args"></param>
        internal IncomingTextEventArgs(params string[] args) : base(args) {}

        public string Text { get { return Args[0]; } }
        public int ChannelNumber { get { return Convert.ToInt32(Args[1]); } }
        public string ChannelName { get { return Args[2]; } }
    }

    public class IncomingCombatTextEventArgs : LSEventArgs
    {
        /// <summary>
        ///             Construct an LSEventArgs object with the given args
        /// </summary>
        /// <param name="args"></param>
        internal IncomingCombatTextEventArgs(params string[] args) : base(args) {}

        public string Text { get { return Args[0]; } }
        public int Type { get { return Convert.ToInt32(Args[1]); } }
    }

    // Same members and whatnot. Just a different class name. :P
    // Makes it a bit easier to maintain here.
    public class AlertTextEventArgs : IncomingCombatTextEventArgs
    {
        /// <summary>
        ///             Construct an LSEventArgs object with the given args
        /// </summary>
        /// <param name="args"></param>
        internal AlertTextEventArgs(params string[] args) : base(args) {}
    }

    public class SoundEffectEventArgs : LSEventArgs
    {
        /// <summary>
        ///             Construct an LSEventArgs object with the given args
        /// </summary>
        /// <param name="args"></param>
        internal SoundEffectEventArgs(params string[] args) : base(args) {}

        public string EffectName { get { return Args[0]; } }
    }

    public class TellIgnoredEventArgs : LSEventArgs
    {
        /// <summary>
        ///             Construct an LSEventArgs object with the given args
        /// </summary>
        /// <param name="args"></param>
        internal TellIgnoredEventArgs(params string[] args) : base(args) {}

        public string Message { get { return Args[0]; } }
    }

    #endregion

    #region Group Related

    public class GroupMemberAddedEventArgs : LSEventArgs
    {
        /// <summary>
        ///             Construct an LSEventArgs object with the given args
        /// </summary>
        /// <param name="args"></param>
        internal GroupMemberAddedEventArgs(params string[] args) : base(args) {}

        public string MemberName { get { return Args[0]; } }
    }

    public class GroupMemberBootedEventArgs : GroupMemberAddedEventArgs
    {
        /// <summary>
        ///             Construct an LSEventArgs object with the given args
        /// </summary>
        /// <param name="args"></param>
        internal GroupMemberBootedEventArgs(params string[] args) : base(args) {}
    }

    public class GroupMemberDeathEventArgs : GroupMemberAddedEventArgs
    {
        /// <summary>
        ///             Construct an LSEventArgs object with the given args
        /// </summary>
        /// <param name="args"></param>
        internal GroupMemberDeathEventArgs(params string[] args) : base(args) {}
    }

    #endregion

    #region Diplomacy Related

    public class ParlayDialogEventArgs : LSEventArgs
    {
        /// <summary>
        ///             Construct an LSEventArgs object with the given args
        /// </summary>
        /// <param name="args"></param>
        internal ParlayDialogEventArgs(params string[] args) : base(args) {}

        public string Dialog { get { return Args[0]; } }
    }

    #endregion

    #region Time Related

    public class ReceivedTradeInvitationEventArgs : LSEventArgs
    {
        /// <summary>
        ///             Construct an LSEventArgs object with the given args
        /// </summary>
        /// <param name="args"></param>
        internal ReceivedTradeInvitationEventArgs(params string[] args) : base(args) {}

        public string PCName { get { return Args[0]; } }
    }

    public class SentTradeInvitationEventArgs : ReceivedTradeInvitationEventArgs
    {
        /// <summary>
        ///             Construct an LSEventArgs object with the given args
        /// </summary>
        /// <param name="args"></param>
        internal SentTradeInvitationEventArgs(params string[] args) : base(args) {}
    }

    #endregion
}