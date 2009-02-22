using System;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    /// <summary>
    /// 
    /// </summary>
    public enum PawnType
    {
        /// <summary>
        /// 
        /// </summary>
        NULL = -1,
        /// <summary>
        /// 
        /// </summary>
        Me,
        /// <summary>
        /// 
        /// </summary>
        PC,
        /// <summary>
        /// 
        /// </summary>
        NPC,
        /// <summary>
        /// 
        /// </summary>
        AggroNPC,
        /// <summary>
        /// 
        /// </summary>
        Pet,
        /// <summary>
        /// 
        /// </summary>
        MyPet,
        /// <summary>
        /// 
        /// </summary>
        GroupMember,
        /// <summary>
        /// 
        /// </summary>
        Trainer,
        /// <summary>
        /// 
        /// </summary>
        Merchant,
        /// <summary>
        /// 
        /// </summary>
        Resource,
        /// <summary>
        /// 
        /// </summary>
        CraftingStation,
        /// <summary>
        /// 
        /// </summary>
        Corpse,
        /// <summary>
        /// 
        /// </summary>
        Clickable,
        /// <summary>
        /// 
        /// </summary>
        Attackable,
        /// <summary>
        /// 
        /// </summary>
        Mailbox,
        /// <summary>
        /// 
        /// </summary>
        AssemblyStation,
        /// <summary>
        /// 
        /// </summary>
        Taskmaster,
        /// <summary>
        /// 
        /// </summary>
        Banker,
        /// <summary>
        /// 
        /// </summary>
        Broker,
        /// <summary>
        /// 
        /// </summary>
        Altar,
        /// <summary>
        /// 
        /// </summary>
        Uknown
    }

    /// <summary>
    /// This DataType includes all of the data available to ISXVG that is related to entities within the world. 
    /// </summary>
    public class Pawn : LavishScriptPersistentObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Pawn"/> class.
        /// </summary>
        /// <param name="Args">The args.</param>
        public Pawn(params string[] Args) : base(LavishScript.Objects.GetPersistentObject("Pawn", Args)) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="Pawn"/> class.
        /// </summary>
        /// <param name="Copy"></param>
        public Pawn(LavishScriptPersistentObject Copy) : base(Copy) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="Pawn"/> class.
        /// </summary>
        /// <param name="index">The index.</param>
        public Pawn(int index) : this(index.ToString()) {}

        /// <summary>
        /// Gets the name of this <see cref="Pawn"/>.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get { return GetMember<string>("Name"); } }

        /// <summary>
        /// Gets the ID of this <see cref="Pawn"/>.
        /// </summary>
        /// <value>The ID.</value>
        public Int64 ID { get { return GetMember<Int64>("ID"); } }

        /// <summary>
        /// Gets the type of the pawn.
        /// </summary>
        /// <value>The type of the pawn.</value>
        public PawnType PawnType
        {
            get
            {
                switch (Type)
                {
                    case "Me":
                        return PawnType.Me;
                    case "PC":
                        return PawnType.PC;
                    case "NPC":
                        return PawnType.NPC;
                    case "AggroNPC":
                        return PawnType.AggroNPC;
                    case "Pet":
                        return PawnType.Pet;
                    case "MyPet":
                        return PawnType.MyPet;
                    case "Group Member":
                        return PawnType.GroupMember;
                    case "Trainer":
                        return PawnType.Trainer;
                    case "Merchant":
                        return PawnType.Merchant;
                    case "Resource":
                        return PawnType.Resource;
                    case "Crafting Station":
                        return PawnType.CraftingStation;
                    case "Corpse":
                        return PawnType.Corpse;
                    case "Clickable":
                        return PawnType.Clickable;
                    case "Attackable":
                        return PawnType.Attackable;
                    case "Mailbox":
                        return PawnType.Mailbox;
                    case "Assembly Station":
                        return PawnType.AssemblyStation;
                    case "Taskmaster":
                        return PawnType.Taskmaster;
                    case "Banker":
                        return PawnType.Banker;
                    case "Broker":
                        return PawnType.Broker;
                    case "Altar":
                        return PawnType.Altar;
                    case "Unknown":
                        return PawnType.Uknown;
                    default:
                        return PawnType.NULL;
                }
            }
        }

        /// <summary>
        /// Gets the type of this <see cref="Pawn"/>.
        /// </summary>
        /// <value>The type.</value>
        public string Type { get { return GetMember<string>("Type"); } }

        /// <summary>
        /// Gets the location of this <see cref="Pawn"/>.
        /// </summary>
        /// <value>The location.</value>
        public Point3f Location { get { return GetMember<Point3f>("Location"); } }

        /// <summary>
        /// Gets the velocity of this <see cref="Pawn"/>.
        /// </summary>
        /// <value>The velocity.</value>
        public Point3f Velocity { get { return GetMember<Point3f>("Velocity"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="Pawn"/> is moving.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="Pawn"/> is moving; otherwise, <c>false</c>.
        /// </value>
        public bool IsMoving { get { return GetMember<bool>("IsMoving"); } }

        /// <summary>
        /// Gets the X of this <see cref="Pawn"/>.
        /// </summary>
        /// <value>The X.</value>
        public float X { get { return GetMember<float>("X"); } }

        /// <summary>
        /// Gets the Y of this <see cref="Pawn"/>.
        /// </summary>
        /// <value>The Y.</value>
        public float Y { get { return GetMember<float>("Y"); } }

        /// <summary>
        /// Gets the Z of this <see cref="Pawn"/>.
        /// </summary>
        /// <value>The Z.</value>
        public float Z { get { return GetMember<float>("Z"); } }

        /// <summary>
        /// Gets the level of this <see cref="Pawn"/>.
        /// </summary>
        /// <value>The level.</value>
        public int Level { get { return GetMember<int>("Level"); } }

        /// <summary>
        /// This is the heading that the pawn is currently facing and/or heading.  Not to be confused with "HeadingTo", which
        /// is the heading YOU would take to reach the pawn.
        /// </summary>
        public int Heading { get { return GetMember<int>("Heading"); } }

        /// <summary>
        /// Gets the pitch of this <see cref="Pawn"/>.
        /// </summary>
        /// <value>The pitch.</value>
        public int Pitch { get { return GetMember<int>("Pitch"); } }

        /// <summary>
        /// Gets the yaw of this <see cref="Pawn"/>.
        /// </summary>
        /// <value>The yaw.</value>
        public int Yaw { get { return GetMember<int>("Yaw"); } }

        /// <summary>
        /// Gets the roll of this <see cref="Pawn"/>.
        /// </summary>
        /// <value>The roll.</value>
        public int Roll { get { return GetMember<int>("Roll"); } }

        /// <summary>
        /// Gets the distance of this <see cref="Pawn"/>.
        /// </summary>
        /// <value>The distance.</value>
        public float Distance { get { return GetMember<float>("Distance"); } }

        /// <summary>
        /// Gets the two dem distance of this <see cref="Pawn"/>.
        /// </summary>
        /// <value>The two dem distance.</value>
        public float TwoDemDistance { get { return GetMember<float>("TwoDemDistance"); } }

        /// <summary>
        /// Gets the heading to of this <see cref="Pawn"/>.
        /// </summary>
        /// <value>The heading to.</value>
        public float HeadingTo { get { return GetMember<float>("HeadingTo"); } }

        /// <summary>
        /// Gets the gender of this <see cref="Pawn"/>.
        /// </summary>
        /// <value>The gender.</value>
        public string Gender { get { return GetMember<string>("Gender"); } }

        /// <summary>
        /// Gets the true gender of this <see cref="Pawn"/>.
        /// </summary>
        /// <value>The true gender.</value>
        public string TrueGender { get { return GetMember<string>("TrueGender"); } }

        /// <summary>
        /// Gets the race ID of this <see cref="Pawn"/>.
        /// </summary>
        /// <value>The race ID.</value>
        public int RaceID { get { return GetMember<int>("RaceID"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="Pawn"/> is mounted.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="Pawn"/> is mounted; otherwise, <c>false</c>.
        /// </value>
        public bool IsMounted { get { return GetMember<bool>("IsMounted"); } }

        /// <summary>
        /// Gets the race of this <see cref="Pawn"/>.
        /// </summary>
        /// <value>The race.</value>
        public string Race { get { return GetMember<string>("Race"); } }

        /// <summary>
        /// Gets the race abr of this <see cref="Pawn"/>.
        /// </summary>
        /// <value>The race abr.</value>
        public string RaceAbr { get { return GetMember<string>("RaceAbr"); } }

        /// <summary>
        /// Gets the posture of this <see cref="Pawn"/>.
        /// </summary>
        /// <value>The posture.</value>
        public string Posture { get { return GetMember<string>("Posture"); } }

        /// <summary>
        /// Gets the state of the combat.
        /// </summary>
        /// <value>The state of the combat.</value>
        public int CombatState { get { return GetMember<int>("CombatState"); } }

        /// <summary>
        /// Gets the guild ID of this <see cref="Pawn"/>.
        /// </summary>
        /// <value>The guild ID.</value>
        public int GuildID { get { return GetMember<int>("GuildID"); } }

        /// <summary>
        /// works for PCs only
        /// </summary>
        public int PVPPoints { get { return GetMember<int>("PVPPoints"); } }

        /// <summary>
        /// Gets the faction ID of this <see cref="Pawn"/>.
        /// </summary>
        /// <value>The faction ID.</value>
        public int FactionID { get { return GetMember<int>("FactionID"); } }

        /// <summary>
        /// Gets the speed of this <see cref="Pawn"/>.
        /// </summary>
        /// <value>The speed.</value>
        public float Speed { get { return GetMember<float>("Speed"); } }

        /// <summary>
        /// Gets the max speed of this <see cref="Pawn"/>.
        /// </summary>
        /// <value>The max speed.</value>
        public float MaxSpeed { get { return GetMember<float>("MaxSpeed"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="Pawn"/> can see me if in range.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="Pawn"/> can see me if in range; otherwise, <c>false</c>.
        /// </value>
        public bool CanSeeMeIfInRange { get { return GetMember<bool>("CanSeeMeIfInRange"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="Pawn"/> can see me if stealthed.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="Pawn"/> can see me if stealthed; otherwise, <c>false</c>.
        /// </value>
        public bool CanSeeMeIfStealthed { get { return GetMember<bool>("CanSeeMeIfStealthed"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="Pawn"/> can fly.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="Pawn"/> can fly; otherwise, <c>false</c>.
        /// </value>
        public bool CanFly { get { return GetMember<bool>("CanFly"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="Pawn"/> can swim.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="Pawn"/> can swim; otherwise, <c>false</c>.
        /// </value>
        public bool CanSwim { get { return GetMember<bool>("CanSwim"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="Pawn"/> is dead.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="Pawn"/> is dead; otherwise, <c>false</c>.
        /// </value>
        public bool IsDead { get { return GetMember<bool>("IsDead"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="Pawn"/> is stealthed.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="Pawn"/> is stealthed; otherwise, <c>false</c>.
        /// </value>
        public bool IsStealthed { get { return GetMember<bool>("IsStealthed"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="Pawn"/> is LFG.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="Pawn"/> is LFG; otherwise, <c>false</c>.
        /// </value>
        public bool IsLFG { get { return GetMember<bool>("IsLFG"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="Pawn"/> is in offensive form.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="Pawn"/> is in offensive form; otherwise, <c>false</c>.
        /// </value>
        public bool IsInOffensiveForm { get { return GetMember<bool>("IsInOffensiveForm"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="Pawn"/> is outside.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="Pawn"/> is outside; otherwise, <c>false</c>.
        /// </value>
        public bool IsOutside { get { return GetMember<bool>("IsOutside"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="Pawn"/> is indoors.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="Pawn"/> is indoors; otherwise, <c>false</c>.
        /// </value>
        public bool IsIndoors { get { return GetMember<bool>("IsIndoors"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="Pawn"/> is aggro.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="Pawn"/> is aggro; otherwise, <c>false</c>.
        /// </value>
        public bool IsAggro { get { return GetMember<bool>("IsAggro"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="Pawn"/> is group member.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="Pawn"/> is group member; otherwise, <c>false</c>.
        /// </value>
        public bool IsGroupMember { get { return GetMember<bool>("IsGroupMember"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="Pawn"/> is in my group.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="Pawn"/> is in my group; otherwise, <c>false</c>.
        /// </value>
        public bool IsInMyGroup { get { return GetMember<bool>("IsInMyGroup"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="Pawn"/> is attackable.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="Pawn"/> is attackable; otherwise, <c>false</c>.
        /// </value>
        public bool IsAttackable { get { return GetMember<bool>("IsAttackable"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="Pawn"/> is clickable.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="Pawn"/> is clickable; otherwise, <c>false</c>.
        /// </value>
        public bool IsClickable { get { return GetMember<bool>("IsClickable"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="Pawn"/> is A pet.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="Pawn"/> is A pet; otherwise, <c>false</c>.
        /// </value>
        public bool IsAPet { get { return GetMember<bool>("IsAPet"); } }

        /// <summary>
        /// Gets the cull distance of this <see cref="Pawn"/>.
        /// </summary>
        /// <value>The cull distance.</value>
        public float CullDistance { get { return GetMember<float>("CullDistance"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="Pawn"/> has quest flag.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="Pawn"/> has quest flag; otherwise, <c>false</c>.
        /// </value>
        public bool HasQuestFlag { get { return GetMember<bool>("HasQuestFlag"); } }

        /// <summary>
        /// Gets the color of the quest flag.
        /// </summary>
        /// <value>The color of the quest flag.</value>
        public string QuestFlagColor { get { return GetMember<string>("QuestFlagColor"); } }

        /// <summary>
        /// Gets a value indicating whether [contains loot].
        /// </summary>
        /// <value><c>true</c> if [contains loot]; otherwise, <c>false</c>.</value>
        public bool ContainsLoot { get { return GetMember<bool>("ContainsLoot"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="Pawn"/> is harvestable.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="Pawn"/> is harvestable; otherwise, <c>false</c>.
        /// </value>
        public bool IsHarvestable { get { return GetMember<bool>("IsHarvestable"); } }

        /// <summary>
        /// Gets the title of this <see cref="Pawn"/>.
        /// </summary>
        /// <value>The title.</value>
        public string Title { get { return GetMember<string>("Title"); } }

        /// <summary>
        /// Gets the title pre of this <see cref="Pawn"/>.
        /// </summary>
        /// <value>The title pre.</value>
        public string TitlePre { get { return GetMember<string>("TitlePre"); } }

        /// <summary>
        /// Gets the title post of this <see cref="Pawn"/>.
        /// </summary>
        /// <value>The title post.</value>
        public string TitlePost { get { return GetMember<string>("TitlePost"); } }

        /// <summary>
        /// Gets a value indicating whether [have LOS to].
        /// </summary>
        /// <value><c>true</c> if [have LOS to]; otherwise, <c>false</c>.</value>
        public bool HaveLOSTo { get { return GetMember<bool>("HaveLOSTo"); } }

        /// <summary>
        /// Gets a value indicating whether [owned by me].
        /// </summary>
        /// <value><c>true</c> if [owned by me]; otherwise, <c>false</c>.</value>
        public bool OwnedByMe { get { return GetMember<bool>("OwnedByMe"); } }

        /// <summary>
        /// Gets a value indicating whether [owner is me].
        /// </summary>
        /// <value><c>true</c> if [owner is me]; otherwise, <c>false</c>.</value>
        public bool OwnerIsMe { get { return GetMember<bool>("OwnerIsMe"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="Pawn"/> is stunned.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="Pawn"/> is stunned; otherwise, <c>false</c>.
        /// </value>
        public bool IsStunned { get { return GetMember<bool>("IsStunned"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="Pawn"/> is ready.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="Pawn"/> is ready; otherwise, <c>false</c>.
        /// </value>
        public bool IsReady { get { return GetMember<bool>("IsReady"); } }

        /// <summary>
        /// Gets the owner of this <see cref="Pawn"/>.
        /// </summary>
        /// <value>The owner.</value>
        public Pawn Owner
        {
            get
            {
                LavishScriptPersistentObject Obj = GetPersistentMember("Owner");
                return new Pawn(Obj);
            }
        }

        /// <summary>
        /// Gets to actor of this <see cref="Pawn"/>.
        /// </summary>
        /// <value>To actor.</value>
        public Actor ToActor { get { return GetMember<Actor>("ToActor"); } }

        /// <summary>
        /// Checks the collision.
        /// </summary>
        /// <returns></returns>
        public Actor CheckCollision()
        {
            LavishScriptObject Obj = GetMember("CheckCollision");
            return new Actor(Obj);
        }

        /// <summary>
        /// Checks the collision.
        /// </summary>
        /// <param name="x">The X.</param>
        /// <param name="y">The Y.</param>
        /// <param name="z">The Z.</param>
        /// <returns></returns>
        public Actor CheckCollision(float x, float y, float z)
        {
            LavishScriptObject Obj = GetMember("CheckCollision", x.ToString(), y.ToString(), z.ToString());
            return new Actor(Obj);
        }

        /// <summary>
        /// Loots this <see cref="Pawn"/>.
        /// </summary>
        /// <returns></returns>
        public bool Loot()
        {
            return ExecuteMethod("Loot");
        }

        /// <summary>
        /// Loots all.
        /// </summary>
        /// <returns></returns>
        public bool LootAll()
        {
            return ExecuteMethod("LootAll");
        }

        /// <summary>
        /// Targets this <see cref="Pawn"/>.
        /// </summary>
        /// <returns></returns>
        public bool Target()
        {
            return ExecuteMethod("Target");
        }

        /// <summary>
        /// Faces this <see cref="Pawn"/>.
        /// </summary>
        /// <returns></returns>
        public bool Face()
        {
            return ExecuteMethod("Face");
        }

        /// <summary>
        /// As of 3.31.2007, this method works for the following pawn types:  Banker, Broker, Taskmaster, Merchant, Trainer, QuestNPC, 
        /// Corpse, Mailbox, Crafting Station, and Resource.
        /// </summary>
        /// <returns></returns>
        public bool DoubleClick()
        {
            return ExecuteMethod("DoubleClick");
        }
    }
}