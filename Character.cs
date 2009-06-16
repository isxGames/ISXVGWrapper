using System;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    /// <summary>
    /// This Data Type includes all of the data available to ISXVG that can be gathered from the character Information structure.
    /// </summary>
    public class Character : LavishScriptPersistentObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Character"/> class.
        /// </summary>
        public Character()
            : base(LavishScript.Objects.GetPersistentObject("Me")) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="Character"/> class.
        /// </summary>
        /// <param name="Copy"></param>
        public Character(LavishScriptPersistentObject Copy)
            : base(Copy) {}

        /// <summary>
        /// Gets the first name of this <see cref="Character"/>
        /// </summary>
        /// <value>The name of the F.</value>
        public string FName { get { return GetMember<string>("FName"); } }

        /// <summary>
        /// Gets the last name of this <see cref="Character"/>
        /// </summary>
        /// <value>The name of the L.</value>
        public string LName { get { return GetMember<string>("LName"); } }

        /// <summary>
        /// Gets the class of this <see cref="Character"/>.
        /// </summary>
        /// <value>The class.</value>
        public string Class { get { return GetMember<string>("Class"); } }

        /// <summary>
        /// Gets the class abreviateion of this <see cref="Character"/>.
        /// </summary>
        /// <value>The class abrv.</value>
        public string ClassAbrv { get { return GetMember<string>("ClassAbrv"); } }

        /// <summary>
        /// Gets the level of this <see cref="Character"/>.
        /// </summary>
        /// <value>The level.</value>
        public int Level { get { return GetMember<int>("Level"); } }

        /// <summary>
        /// Gets the crafting level of this <see cref="Character"/>.
        /// </summary>
        /// <value>The crafting level.</value>
        public int CraftingLevel { get { return GetMember<int>("CraftingLevel"); } }

        /// <summary>
        /// Gets the harvesting level of this <see cref="Character"/>.
        /// </summary>
        /// <value>The harvesting level.</value>
        public int HarvestingLevel { get { return GetMember<int>("HarvestingLevel"); } }

        /// <summary>
        /// Gets the XP of this <see cref="Character"/>.
        /// </summary>
        /// <value>The XP.</value>
        public int XP { get { return GetMember<int>("XP"); } }

        /// <summary>
        /// Gets the XP PCT of this <see cref="Character"/>.
        /// </summary>
        /// <value>The XP PCT.</value>
        public int XPPct { get { return GetMember<int>("XPPct"); } }

        /// <summary>
        /// Gets the XP debt PCT of this <see cref="Character"/>.
        /// </summary>
        /// <value>The XP debt PCT.</value>
        public int XPDebtPct { get { return GetMember<int>("XPDebtPct"); } }

        /// <summary>
        /// Gets the craft XP of this <see cref="Character"/>.
        /// </summary>
        /// <value>The craft XP.</value>
        public int CraftXP { get { return GetMember<int>("CraftXP"); } }

        /// <summary>
        /// Gets the craft XP PCT of this <see cref="Character"/>.
        /// </summary>
        /// <value>The craft XP PCT.</value>
        public int CraftXPPct { get { return GetMember<int>("CraftXPPct"); } }

        /// <summary>
        /// Gets the harvest XP PCT of this <see cref="Character"/>.
        /// </summary>
        /// <value>The harvest XP PCT.</value>
        public int HarvestXPPct { get { return GetMember<int>("HarvestXPPct"); } }

        /// <summary>
        /// Gets the diplomacy XP PCT of this <see cref="Character"/>.
        /// </summary>
        /// <value>The diplomacy XP PCT.</value>
        public int DiplomacyXPPct { get { return GetMember<int>("DiplomacyXPPct"); } }

        /// <summary>
        /// Gets the health STR of this <see cref="Character"/>.
        /// </summary>
        /// <value>The health STR.</value>
        public string HealthStr { get { return GetMember<string>("HealthStr"); } }

        /// <summary>
        /// Gets the health of this <see cref="Character"/>.
        /// </summary>
        /// <value>The health.</value>
        public int Health { get { return GetMember<int>("Health"); } }

        /// <summary>
        /// Gets the health PCT of this <see cref="Character"/>.
        /// </summary>
        /// <value>The health PCT.</value>
        public int HealthPct { get { return GetMember<int>("HealthPct"); } }

        /// <summary>
        /// Gets the max health of this <see cref="Character"/>.
        /// </summary>
        /// <value>The max health.</value>
        public int MaxHealth { get { return GetMember<int>("MaxHealth"); } }

        /// <summary>
        /// Gets the energy STR of this <see cref="Character"/>.
        /// </summary>
        /// <value>The energy STR.</value>
        public string EnergyStr { get { return GetMember<string>("EnergyStr"); } }

        /// <summary>
        /// Gets the energy of this <see cref="Character"/>.
        /// </summary>
        /// <value>The energy.</value>
        public int Energy { get { return GetMember<int>("Energy"); } }

        /// <summary>
        /// Gets the energy PCT of this <see cref="Character"/>.
        /// </summary>
        /// <value>The energy PCT.</value>
        public int EnergyPct { get { return GetMember<int>("EnergyPct"); } }

        /// <summary>
        /// Gets the max energy of this <see cref="Character"/>.
        /// </summary>
        /// <value>The max energy.</value>
        public int MaxEnergy { get { return GetMember<int>("MaxEnergy"); } }

        /// <summary>
        /// Gets the endurance STR of this <see cref="Character"/>.
        /// </summary>
        /// <value>The endurance STR.</value>
        public string EnduranceStr { get { return GetMember<string>("EnduranceStr"); } }

        /// <summary>
        /// Gets the endurance of this <see cref="Character"/>.
        /// </summary>
        /// <value>The endurance.</value>
        public int Endurance { get { return GetMember<int>("Endurance"); } }

        /// <summary>
        /// Gets the endurance PCT of this <see cref="Character"/>.
        /// </summary>
        /// <value>The endurance PCT.</value>
        public int EndurancePct { get { return GetMember<int>("EndurancePct"); } }

        /// <summary>
        /// Gets the max endurance of this <see cref="Character"/>.
        /// </summary>
        /// <value>The max endurance.</value>
        public int MaxEndurance { get { return GetMember<int>("MaxEndurance"); } }

        /// <summary>
        /// Gets the X of this <see cref="Character"/>.
        /// </summary>
        /// <value>The X.</value>
        public float X { get { return GetMember<float>("X"); } }

        /// <summary>
        /// Gets the Y of this <see cref="Character"/>.
        /// </summary>
        /// <value>The Y.</value>
        public float Y { get { return GetMember<float>("Y"); } }

        /// <summary>
        /// Gets the Z of this <see cref="Character"/>.
        /// </summary>
        /// <value>The Z.</value>
        public float Z { get { return GetMember<float>("Z"); } }

        /// <summary>
        /// Gets the heading of this <see cref="Character"/>.
        /// </summary>
        /// <value>The heading.</value>
        public float Heading { get { return GetMember<float>("Heading"); } }

        /// <summary>
        /// Gets the casting of this <see cref="Character"/>.
        /// </summary>
        /// <value>The casting.</value>
        public string Casting { get { return GetMember<string>("Casting"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="Character"/> is casting.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="Character"/> is casting; otherwise, <c>false</c>.
        /// </value>
        public bool IsCasting { get { return GetMember<bool>("IsCasting"); } }

        /// <summary>
        /// Gets a value indicating whether [in combat].
        /// </summary>
        /// <value><c>true</c> if [in combat]; otherwise, <c>false</c>.</value>
        public bool InCombat { get { return GetMember<bool>("InCombat"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="Character"/> has defensive target.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="Character"/> has defensive target; otherwise, <c>false</c>.
        /// </value>
        public bool HasDefensiveTarget { get { return GetMember<bool>("HasDefensiveTarget"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="Character"/> has virtue.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="Character"/> has virtue; otherwise, <c>false</c>.
        /// </value>
        public bool HasVirtue { get { return GetMember<bool>("HasVirtue"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="Character"/> has combat forms.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="Character"/> has combat forms; otherwise, <c>false</c>.
        /// </value>
        public bool HasCombatForms { get { return GetMember<bool>("HasCombatForms"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="Character"/> is drowning.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="Character"/> is drowning; otherwise, <c>false</c>.
        /// </value>
        public bool IsDrowning { get { return GetMember<bool>("IsDrowning"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="Character"/> is camping.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="Character"/> is camping; otherwise, <c>false</c>.
        /// </value>
        public bool IsCamping { get { return GetMember<bool>("IsCamping"); } }

        /// <summary>
        /// Gets the breath PCT of this <see cref="Character"/>.
        /// </summary>
        /// <value>The breath PCT.</value>
        public int BreathPct { get { return GetMember<int>("BreathPct"); } }

        /// <summary>
        /// Gets the copper of this <see cref="Character"/>.
        /// </summary>
        /// <value>The copper.</value>
        public int Copper { get { return GetMember<int>("Copper"); } }

        /// <summary>
        /// Gets the silver of this <see cref="Character"/>.
        /// </summary>
        /// <value>The silver.</value>
        public int Silver { get { return GetMember<int>("Silver"); } }

        /// <summary>
        /// Gets the gold of this <see cref="Character"/>.
        /// </summary>
        /// <value>The gold.</value>
        public int Gold { get { return GetMember<int>("Gold"); } }

        /// <summary>
        /// Gets the platinum of this <see cref="Character"/>.
        /// </summary>
        /// <value>The platinum.</value>
        public int Platinum { get { return GetMember<int>("Platinum"); } }

        /// <summary>
        /// Gets a value indicating whether [auto follow on].
        /// </summary>
        /// <value><c>true</c> if [auto follow on]; otherwise, <c>false</c>.</value>
        public bool AutoFollowOn { get { return GetMember<bool>("AutoFollowOn"); } }

        /// <summary>
        /// Gets the adv equip expertise used of this <see cref="Character"/>.
        /// </summary>
        /// <value>The adv equip expertise used.</value>
        public int AdvEquipExpertiseUsed { get { return GetMember<int>("AdvEquipExpertiseUsed"); } }

        /// <summary>
        /// Gets the craft equip expertise used of this <see cref="Character"/>.
        /// </summary>
        /// <value>The craft equip expertise used.</value>
        public int CraftEquipExpertiseUsed { get { return GetMember<int>("CraftEquipExpertiseUsed"); } }

        /// <summary>
        /// Gets a value indicating whether [adv equip expertise used as string].
        /// </summary>
        /// <value>
        /// 	<c>true</c> if [adv equip expertise used as string]; otherwise, <c>false</c>.
        /// </value>
        public bool AdvEquipExpertiseUsedAsString { get { return GetMember<bool>("AdvEquipExpertiseUsedAsString"); } }

        /// <summary>
        /// Gets a value indicating whether [craft equip expertise used as string].
        /// </summary>
        /// <value>
        /// 	<c>true</c> if [craft equip expertise used as string]; otherwise, <c>false</c>.
        /// </value>
        public bool CraftEquipExpertiseUsedAsString { get { return GetMember<bool>("CraftEquipExpertiseUsedAsString"); } }

        /// <summary>
        /// Gets the health of this <see cref="Character"/>'s target.
        /// </summary>
        /// <value>The target H ps.</value>
        public int TargetHPs { get { return GetMember<int>("TargetHPs"); } }

        /// <summary>
        /// Gets the health of this <see cref="Character"/>'s target.
        /// </summary>
        /// <value>The target health.</value>
        public int TargetHealth { get { return GetMember<int>("TargetHealth"); } }

        /// <summary>
        /// Gets the defensive hitpoints of the target.
        /// </summary>
        /// <value>The D target H ps.</value>
        public int DTargetHPs { get { return GetMember<int>("DTargetHPs"); } }

        /// <summary>
        /// Gets the defensive hitpoints of the target as a percent.
        /// </summary>
        /// <value>The D target health.</value>
        public int DTargetHealth { get { return GetMember<int>("DTargetHealth"); } }

        /// <summary>
        /// Gets the num abilities of this <see cref="Character"/>.
        /// </summary>
        /// <value>The num abilities.</value>
        public int NumAbilities { get { return GetMember<int>("NumAbilities"); } }

        /// <summary>
        /// Gets a value indicating whether [have pet].
        /// </summary>
        /// <value><c>true</c> if [have pet]; otherwise, <c>false</c>.</value>
        public bool HavePet { get { return GetMember<bool>("HavePet"); } }

        /// <summary>
        /// Gets the type of the pet.
        /// </summary>
        /// <value>The type of the pet.</value>
        public string PetType { get { return GetMember<string>("PetType"); } }

        /// <summary>
        /// Gets a value indicating whether [have minion].
        /// </summary>
        /// <value><c>true</c> if [have minion]; otherwise, <c>false</c>.</value>
        public bool HaveMinion { get { return GetMember<bool>("HaveMinion"); } }

        /// <summary>
        /// Gets the weight of this <see cref="Character"/>.
        /// </summary>
        /// <value>The weight.</value>
        public float Weight { get { return GetMember<float>("Weight"); } }

        /// <summary>
        /// Gets the max weight of this <see cref="Character"/>.
        /// </summary>
        /// <value>The max weight.</value>
        public float MaxWeight { get { return GetMember<float>("MaxWeight"); } }

        /// <summary>
        /// Gets a value indicating whether [in group].
        /// </summary>
        /// <value><c>true</c> if [in group]; otherwise, <c>false</c>.</value>
        public bool InGroup { get { return GetMember<bool>("InGroup"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="Character"/> is sprinting.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="Character"/> is sprinting; otherwise, <c>false</c>.
        /// </value>
        public bool IsSprinting { get { return GetMember<bool>("IsSprinting"); } }

        /// <summary>
        /// Gets a value indicating whether [afterburner ready].
        /// </summary>
        /// <value><c>true</c> if [afterburner ready]; otherwise, <c>false</c>.</value>
        public bool AfterburnerReady { get { return GetMember<bool>("AfterburnerReady"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="Character"/> can port.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="Character"/> can port; otherwise, <c>false</c>.
        /// </value>
        public bool CanPort { get { return GetMember<bool>("CanPort"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="Character"/> is grouped.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="Character"/> is grouped; otherwise, <c>false</c>.
        /// </value>
        public bool IsGrouped { get { return GetMember<bool>("IsGrouped"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="Character"/> is group leader.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="Character"/> is group leader; otherwise, <c>false</c>.
        /// </value>
        public bool IsGroupLeader { get { return GetMember<bool>("IsGroupLeader"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="Character"/> is group master looter.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="Character"/> is group master looter; otherwise, <c>false</c>.
        /// </value>
        public bool IsGroupMasterLooter { get { return GetMember<bool>("IsGroupMasterLooter"); } }

        /// <summary>
        /// Gets a value indicating whether [group invite pending].
        /// </summary>
        /// <value><c>true</c> if [group invite pending]; otherwise, <c>false</c>.</value>
        public bool GroupInvitePending { get { return GetMember<bool>("GroupInvitePending"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="Character"/> is looting.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="Character"/> is looting; otherwise, <c>false</c>.
        /// </value>
        public bool IsLooting { get { return GetMember<bool>("IsLooting"); } }

        /// <summary>
        /// Gets a value indicating whether [looting my corpse].
        /// </summary>
        /// <value><c>true</c> if [looting my corpse]; otherwise, <c>false</c>.</value>
        public bool LootingMyCorpse { get { return GetMember<bool>("LootingMyCorpse"); } }

        /// <summary>
        /// Gets the nuke mod total of this <see cref="Character"/>.
        /// </summary>
        /// <value>The nuke mod total.</value>
        public int NukeModTotal { get { return GetMember<int>("NukeModTotal"); } }

        /// <summary>
        /// Gets the heal mod total of this <see cref="Character"/>.
        /// </summary>
        /// <value>The heal mod total.</value>
        public int HealModTotal { get { return GetMember<int>("HealModTotal"); } }

        /// <summary>
        /// Gets the total gen inv slots of this <see cref="Character"/>.
        /// </summary>
        /// <value>The total gen inv slots.</value>
        public float TotalGenInvSlots { get { return GetMember<float>("TotalGenInvSlots"); } }

        /// <summary>
        /// Gets the inventory slots open of this <see cref="Character"/>.
        /// </summary>
        /// <value>The inventory slots open.</value>
        public int InventorySlotsOpen { get { return GetMember<int>("InventorySlotsOpen"); } }

        /// <summary>
        /// Gets the gen inventory slots used of this <see cref="Character"/>.
        /// </summary>
        /// <value>The gen inv slots used.</value>
        public float GenInvSlotsUsed { get { return GetMember<float>("GenInvSlotsUsed"); } }

        /// <summary>
        /// Gets the pet of this <see cref="Character"/>.
        /// </summary>
        /// <value>The pet.</value>
        public Pet Pet
        {
            get
            {
                LavishScriptObject Obj = GetMember("Pet");
                return new Pet(Obj);
            }
        }

        /// <summary>
        /// Gets the chunk of this <see cref="Character"/>.
        /// </summary>
        /// <value>The chunk.</value>
        public Chunk Chunk
        {
            get
            {
                LavishScriptObject Obj = GetMember("Chunk");
                return new Chunk(Obj);
            }
        }

        /// <summary>
        /// Gets the target of this <see cref="Character"/>.
        /// </summary>
        /// <value>The target.</value>
        public Pawn Target
        {
            get
            {
                LavishScriptPersistentObject Obj = GetPersistentMember("Target");
                return new Pawn(Obj);
            }
        }

        /// <summary>
        /// Gets the D target of this <see cref="Character"/>.
        /// </summary>
        /// <value>The D target.</value>
        public Pawn DTarget
        {
            get
            {
                LavishScriptPersistentObject Obj = GetPersistentMember("DTarget");
                return new Pawn(Obj);
            }
        }

        /// <summary>
        /// Gets the target of target of this <see cref="Character"/>.
        /// </summary>
        /// <value>The target of target.</value>
        public Pawn TargetOfTarget
        {
            get
            {
                LavishScriptPersistentObject Obj = GetPersistentMember("TargetOfTarget");
                return new Pawn(Obj);
            }
        }

        /// <summary>
        /// Gets the target of target of this <see cref="Character"/>.
        /// </summary>
        /// <value>To T.</value>
        public Pawn ToT
        {
            get
            {
                LavishScriptPersistentObject Obj = GetPersistentMember("TargetOfTarget");
                return new Pawn(Obj);
            }
        }

        /// <summary>
        /// Gets this <see cref="Character"/> in a Pawn datatype.
        /// </summary>
        /// <value>To pawn.</value>
        public Pawn ToPawn
        {
            get
            {
                LavishScriptPersistentObject Obj = GetPersistentMember("ToPawn");
                return new Pawn(Obj);
            }
        }

        /// <summary>
        /// Gets the target as encounter of this <see cref="Character"/>.
        /// </summary>
        /// <value>The target as encounter.</value>
        public CombatNPC TargetAsEncounter
        {
            get
            {
                LavishScriptObject Obj = GetMember("TargetAsEncounter");
                return new CombatNPC(Obj);
            }
        }

        /// <summary>
        /// Number of minions your character currently controls 
        /// </summary>
        public int MinionCount { get { return GetMember<int>("Minion"); } }

        /// <summary>
        /// Number of abilities your character possesses
        /// </summary>
        public int AbilityCount { get { return GetMember<int>("NumAbilities"); } }

        /// <summary>
        ///Number of debuffs on your current target 
        /// </summary>
        public int TargetDebuffCount { get { return GetMember<int>("TargetDebuff"); } }

        /// <summary>
        /// Gets the target my debuff count of this <see cref="Character"/>.
        /// </summary>
        /// <value>The target my debuff count.</value>
        public int TargetMyDebuffCount { get { return GetMember<int>("TargetMyDebuff"); } }

        /// <summary>
        /// Gets the target buff count of this <see cref="Character"/>.
        /// </summary>
        /// <value>The target buff count.</value>
        public int TargetBuffCount { get { return GetMember<int>("TargetBuff"); } }

        /// <summary>
        ///Number of pawns in your current encounter 
        /// </summary>
        public int EncounterCount { get { return GetMember<int>("Encounter"); } }

        /// <summary>
        /// Gets the inventory count of this <see cref="Character"/>.
        /// </summary>
        /// <value>The inventory count.</value>
        public int InventoryCount { get { return GetMember<int>("Inventory"); } }

        /// <summary>
        /// Total number of forms avialble to you
        /// </summary>
        public int FormCount { get { return GetMember<int>("Form"); } }

        /// <summary>
        /// Gets the current form of this <see cref="Character"/>.
        /// </summary>
        /// <value>The current form.</value>
        public Form CurrentForm
        {
            get
            {
                LavishScriptObject Obj = GetMember("CurrentForm");
                return new Form(Obj);
            }
        }

        /// <summary>
        /// Gets the target casting of this <see cref="Character"/>.
        /// </summary>
        /// <value>The target casting.</value>
        public string TargetCasting { get { return GetMember<string>("TargetCasting"); } }

        /// <summary>
        /// Gets the blood union of this <see cref="Character"/>.
        /// </summary>
        /// <value>The blood union.</value>
        public int BloodUnion { get { return GetMember<int>("BloodUnion"); } }

        /// <summary>
        /// Sprints this <see cref="Character"/>.
        /// </summary>
        /// <returns></returns>
        public bool Sprint()
        {
            return ExecuteMethod("Sprint");
        }

        /// <summary>
        /// Sprints using the specified percentage.
        /// </summary>
        /// <param name="Percentage">The percentage.</param>
        /// <returns></returns>
        public bool Sprint(int Percentage)
        {
            return ExecuteMethod("Sprint", Percentage.ToString());
        }

        /// <summary>
        /// Afterburners this <see cref="Character"/>.
        /// </summary>
        /// <returns></returns>
        public bool Afterburner()
        {
            return ExecuteMethod("Afterburner");
        }

        /// <summary>
        /// Minions the specified minion num.
        /// </summary>
        /// <param name="MinionNum">The minion num.</param>
        /// <returns></returns>
        public Minion Minion(int MinionNum)
        {
            LavishScriptObject Obj = GetMember("Minion", MinionNum.ToString());
            return new Minion(Obj);
        }

        /// <summary>
        /// Minions the specified minion name.
        /// </summary>
        /// <param name="MinionName">Name of the minion.</param>
        /// <returns></returns>
        public Minion Minion(string MinionName)
        {
            LavishScriptObject Obj = GetMember("Minion", MinionName);
            return new Minion(Obj);
        }

        /// <summary>
        /// Minions as pawn.
        /// </summary>
        /// <param name="MinionNum">The minion num.</param>
        /// <returns></returns>
        public Pawn MinionAsPawn(int MinionNum)
        {
            LavishScriptPersistentObject Obj = GetPersistentMember("MinionAsPawn", MinionNum.ToString());
            return new Pawn(Obj);
        }

        /// <summary>
        /// Gets this <see cref="Character"/>s ability at the <paramref name="AbilityNum"/> index.
        /// This is a 1 based index.
        /// </summary>
        /// <param name="AbilityNum">The ability num.</param>
        /// <returns></returns>
        public Ability Ability(int AbilityNum)
        {
            return Ability(AbilityNum.ToString());
        }

        /// <summary>
        /// Gets this <see cref="Character"/>s ability at the <paramref name="AbilityNum"/> index.
        /// This is a 1 based index.
        /// </summary>
        /// <param name="AbilityNum">The ability num.</param>
        /// <returns></returns>
        public Ability Ability(uint AbilityNum)
        {
            return Ability(AbilityNum.ToString());
        }

        /// <summary>
        /// Abilities the specified ability name.
        /// </summary>
        /// <param name="AbilityName">Name of the ability.</param>
        /// <returns></returns>
        public Ability Ability(string AbilityName)
        {
            LavishScriptObject Obj = GetMember("Ability", AbilityName);
            return new Ability(Obj);
        }

        /// <summary>
        /// Gets an ability of this <see cref="Character"/> by its abilityID.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns></returns>
        public Ability AbilityByID(uint id)
        {
            return new Ability(GetMember("Ability", "id", id.ToString()));
        }

        /// <summary>
        /// Effects this <see cref="Character"/>.
        /// </summary>
        /// <returns></returns>
        public EffectsManager Effect()
        {
            LavishScriptObject Obj = GetMember("Effect");
            return new EffectsManager(Obj);
        }

        /// <summary>
        /// Effects the specified effect num.
        /// </summary>
        /// <param name="EffectNum">The effect num.</param>
        /// <returns></returns>
        public Effect Effect(int EffectNum)
        {
            LavishScriptObject Obj = GetMember("Effect", EffectNum.ToString());
            return new Effect(Obj);
        }

        /// <summary>
        /// Effects the specified effect name.
        /// </summary>
        /// <param name="EffectName">Name of the effect.</param>
        /// <returns></returns>
        public Effect Effect(string EffectName)
        {
            LavishScriptObject Obj = GetMember("Effect", EffectName);
            return new Effect(Obj);
        }

        /// <summary>
        /// Maintaineds this <see cref="Character"/>.
        /// </summary>
        /// <returns></returns>
        public EffectsManager Maintained()
        {
            LavishScriptObject Obj = GetMember("Maintained");
            return new EffectsManager(Obj);
        }

        /// <summary>
        /// Maintaineds the specified maintained num.
        /// </summary>
        /// <param name="MaintainedNum">The maintained num.</param>
        /// <returns></returns>
        public Effect Maintained(int MaintainedNum)
        {
            LavishScriptObject Obj = GetMember("Maintained", MaintainedNum.ToString());
            return new Effect(Obj);
        }

        /// <summary>
        /// Maintaineds the specified maintained name.
        /// </summary>
        /// <param name="MaintainedName">Name of the maintained.</param>
        /// <returns></returns>
        public Effect Maintained(string MaintainedName)
        {
            LavishScriptObject Obj = GetMember("Maintained", MaintainedName);
            return new Effect(Obj);
        }

        /// <summary>
        /// The number of weaknesses on a target
        /// </summary>
        /// <returns>int</returns>
        public int TargetWeakness()
        {
            return GetMember<int>("TargetWeakness");
        }

        /// <summary>
        /// The target's weakness
        /// </summary>
        /// <param name="TargetDebuffNum">The target weakness num.</param>
        /// <returns></returns>
        public TargetEffect TargetWeakness(int TargetWeaknessNum)
        {
            LavishScriptObject Obj = GetMember("TargetWeakness", TargetWeaknessNum.ToString());
            return new TargetEffect(Obj);
        }

        /// <summary>
        /// The target's weakness
        /// </summary>
        /// <param name="TargetDebuffName">Name of the weakness name.</param>
        /// <returns></returns>
        public TargetEffect TargetWeakness(string TargetWeaknessName)
        {
            LavishScriptObject Obj = GetMember("TargetWeakness", TargetWeaknessName);
            return new TargetEffect(Obj);
        }


        /// <summary>
        /// Targets the debuff.
        /// </summary>
        /// <param name="TargetDebuffNum">The target debuff num.</param>
        /// <returns></returns>
        public TargetEffect TargetDebuff(int TargetDebuffNum)
        {
            LavishScriptObject Obj = GetMember("TargetDebuff", TargetDebuffNum.ToString());
            return new TargetEffect(Obj);
        }

        /// <summary>
        /// Targets the debuff.
        /// </summary>
        /// <param name="TargetDebuffName">Name of the target debuff.</param>
        /// <returns></returns>
        public TargetEffect TargetDebuff(string TargetDebuffName)
        {
            LavishScriptObject Obj = GetMember("TargetDebuff", TargetDebuffName);
            return new TargetEffect(Obj);
        }

        /// <summary>
        /// Targets my debuff.
        /// </summary>
        /// <param name="TargetMyDebuffNum">The target my debuff num.</param>
        /// <returns></returns>
        public TargetEffect TargetMyDebuff(int TargetMyDebuffNum)
        {
            LavishScriptObject Obj = GetMember("TargetMyDebuff", TargetMyDebuffNum.ToString());
            return new TargetEffect(Obj);
        }

        /// <summary>
        /// Targets my debuff.
        /// </summary>
        /// <param name="TargetMyDebuffName">Name of the target my debuff.</param>
        /// <returns></returns>
        public TargetEffect TargetMyDebuff(string TargetMyDebuffName)
        {
            LavishScriptObject Obj = GetMember("TargetMyDebuff", TargetMyDebuffName);
            return new TargetEffect(Obj);
        }

        /// <summary>
        /// Targets the buff.
        /// </summary>
        /// <param name="TargetBuffNum">The target buff num.</param>
        /// <returns></returns>
        public TargetEffect TargetBuff(int TargetBuffNum)
        {
            LavishScriptObject Obj = GetMember("TargetBuff", TargetBuffNum.ToString());
            return new TargetEffect(Obj);
        }

        /// <summary>
        /// Targets the buff.
        /// </summary>
        /// <param name="TargetBuffName">Name of the target buff.</param>
        /// <returns></returns>
        public TargetEffect TargetBuff(string TargetBuffName)
        {
            LavishScriptObject Obj = GetMember("TargetBuff", TargetBuffName);
            return new TargetEffect(Obj);
        }

        /// <summary>
        /// Encounters the specified encounter num.
        /// </summary>
        /// <param name="EncounterNum">The encounter num.</param>
        /// <returns></returns>
        public CombatNPC Encounter(int EncounterNum)
        {
            LavishScriptObject Obj = GetMember("Encounter", EncounterNum.ToString());
            return new CombatNPC(Obj);
        }

        /// <summary>
        /// Encounters the specified encounter name.
        /// </summary>
        /// <param name="EncounterName">Name of the encounter.</param>
        /// <returns></returns>
        public CombatNPC Encounter(string EncounterName)
        {
            LavishScriptObject Obj = GetMember("Encounter", EncounterName);
            return new CombatNPC(Obj);
        }

        /// <summary>
        /// Inventories the specified parameters.
        /// </summary>
        /// <param name="Parameters">The parameters.</param>
        /// <returns></returns>
        public Item Inventory(params string[] Parameters)
        {
            LavishScriptObject Obj = GetMember("Inventory", Parameters);
            return new Item(Obj);
        }

        /// <summary>
        /// Inventories the specified index.
        /// </summary>
        /// <param name="Index">The index.</param>
        /// <returns></returns>
        public Item Inventory(int Index)
        {
            LavishScriptObject Obj = GetMember("Inventory", Index.ToString());
            return new Item(Obj);
        }

        /// <summary>
        /// Banks the specified parameters.
        /// </summary>
        /// <param name="Parameters">The parameters.</param>
        /// <returns></returns>
        public Item Bank(params string[] Parameters)
        {
            LavishScriptObject Obj = GetMember("Bank", Parameters);
            return new Item(Obj);
        }

        /// <summary>
        /// Banks the specified index.
        /// </summary>
        /// <param name="Index">The index.</param>
        /// <returns></returns>
        public Item Bank(int Index)
        {
            LavishScriptObject Obj = GetMember("Bank", Index.ToString());
            return new Item(Obj);
        }

        /// <summary>
        /// Forms the specified form num.
        /// </summary>
        /// <param name="FormNum">The form num.</param>
        /// <returns></returns>
        public Form Form(int FormNum)
        {
            LavishScriptObject Obj = GetMember("Form", FormNum.ToString());
            return new Form(Obj);
        }

        /// <summary>
        /// Forms the specified form name.
        /// </summary>
        /// <param name="FormName">Name of the form.</param>
        /// <returns></returns>
        public Form Form(string FormName)
        {
            LavishScriptObject Obj = GetMember("Form", FormName);
            return new Form(Obj);
        }

        /// <summary>
        /// Stats the specified stat type.
        /// </summary>
        /// <param name="StatType">Type of the stat.</param>
        /// <param name="StatName">Name of the stat.</param>
        /// <returns></returns>
        public int Stat(string StatType, String StatName)
        {
            return GetMember<int>("Stat", StatType, StatName);
        }
    }
}