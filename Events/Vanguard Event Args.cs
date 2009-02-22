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
        /// Initializes a new instance of the <see cref="CanUseUpdatedEventArgs"/> class.
        /// </summary>
        public CanUseUpdatedEventArgs()
        {
            ItemName = Args[0];
            ItemID = int.Parse(Args[1]);
            IsNowReady = Args[2] == "TRUE";
        }

        /// <summary>
        /// Gets or sets the name of the item.
        /// </summary>
        /// <value>The name of the item.</value>
        public string ItemName { get; private set; }

        /// <summary>
        /// Gets or sets the item ID of this <see cref="CanUseUpdatedEventArgs"/>.
        /// </summary>
        /// <value>The item ID.</value>
        public int ItemID { get; private set; }

        /// <summary>
        /// Gets or sets the is now ready of this <see cref="CanUseUpdatedEventArgs"/>.
        /// </summary>
        /// <value>The is now ready.</value>
        public bool IsNowReady { get; private set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class StackCountChangeEventArgs : LSEventArgs
    {
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
        public string ObstacleActorName { get { return Args[0]; } }
        public float X { get { return float.Parse(Args[1]); } }
        public float Y { get { return float.Parse(Args[2]); } }
        public float Z { get { return float.Parse(Args[3]); } }
    }

    public class TouchPawnEventArgs : LSEventArgs
    {
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
        public string Text { get { return Args[0]; } }
    }

    public class CraftingStepCompleteEventArgs : LSEventArgs
    {
        public string StepTypeID { get { return Args[0]; } }
    }

    #endregion

    #region Pawn Related

    public class PawnSpawnedEventArgs : LSEventArgs
    {
        public int ID { get { return Convert.ToInt32(Args[0]); } }
        public string Name { get { return Args[1]; } }
        public int Level { get { return Convert.ToInt32(Args[2]); } }
        public string Type { get { return Args[3]; } }
    }

    public class PawnDespawnedEventArgs : LSEventArgs
    {
        public int ID { get { return Convert.ToInt32(Args[0]); } }
        public string Name { get { return Args[1]; } }
    }

    public class PawnStatusChangedEventArgs : LSEventArgs
    {
        public string ChangeType { get { return Args[0]; } }
        public long PawnID { get { return Convert.ToInt64(Args[1]); } }
        public string PawnName { get { return Args[2]; } }
    }

    public class PawnIDChangedEventArgs : LSEventArgs
    {
        public long OldID { get { return Convert.ToInt64(Args[0]); } }
        public long NewID { get { return Convert.ToInt64(Args[2]); } }
        public string OldName { get { return Args[2]; } }
        public string NewName { get { return Args[3]; } }
    }

    #endregion

    #region Input Related

    public class IncomingTextEventArgs : LSEventArgs
    {
        public string Text { get { return Args[0]; } }
        public int ChannelNumber { get { return Convert.ToInt32(Args[1]); } }
        public string ChannelName { get { return Args[2]; } }
    }

    public class IncomingCombatTextEventArgs : LSEventArgs
    {
        public string Text { get { return Args[0]; } }
        public int Type { get { return Convert.ToInt32(Args[1]); } }
    }

    // Same members and whatnot. Just a different class name. :P
    // Makes it a bit easier to maintain here.
    public class AlertTextEventArgs : IncomingCombatTextEventArgs {}

    public class SoundEffectEventArgs : LSEventArgs
    {
        public string EffectName { get { return Args[0]; } }
    }

    public class TellIgnoredEventArgs : LSEventArgs
    {
        public string Message { get { return Args[0]; } }
    }

    #endregion

    #region Group Related

    public class GroupMemberAddedEventArgs : LSEventArgs
    {
        public string MemberName { get { return Args[0]; } }
    }

    public class GroupMemberBootedEventArgs : GroupMemberAddedEventArgs {}

    public class GroupMemberDeathEventArgs : GroupMemberAddedEventArgs {}

    #endregion

    #region Diplomacy Related

    public class ParlayDialogEventArgs : LSEventArgs
    {
        public string Dialog { get { return Args[0]; } }
    }

    #endregion

    #region Time Related

    public class ReceivedTradeInvitationEventArgs : LSEventArgs
    {
        public string PCName { get { return Args[0]; } }
    }

    public class SentTradeInvitationEventArgs : ReceivedTradeInvitationEventArgs {}

    #endregion
}