using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class Character : LavishScriptPersistentObject
    {
        public Character() 
            : base(LavishScript.Objects.GetPersistentObject("Me"))
        {
        }

        public Character(LavishScriptPersistentObject Copy) 
            : base(Copy)
        {
        }

        public string FName
        {
            get 
            { 
                return GetMember<string>("FName"); 
            }
        }

        public string LName
        {
            get 
            { 
                return GetMember<string>("LName"); 
            }
        }

        public string Class
        {
            get 
            { 
                return GetMember<string>("Class"); 
            }
        }

        public string ClassAbrv
        {
            get 
            { 
                return GetMember<string>("ClassAbrv"); 
            }
        }

        public int Level
        {
            get 
            { 
                return GetMember<int>("Level"); 
            }
        }

        public int CraftingLevel
        {
            get 
            { 
                return GetMember<int>("CraftingLevel"); 
            }
        }

        public int HarvestingLevel
        {
            get 
            { 
                return GetMember<int>("HarvestingLevel"); 
            }
        }

        public int XP
        {
            get 
            { 
                return GetMember<int>("XP"); 
            }
        }

        public int XPPct
        {
            get 
            { 
                return GetMember<int>("XPPct"); 
            }
        }

        public int XPDebtPct
        {
            get 
            { 
                return GetMember<int>("XPDebtPct"); 
            }
        }

        public int CraftXP
        {
            get 
            { 
                return GetMember<int>("CraftXP"); 
            }
        }

        public int CraftXPPct
        {
            get 
            { 
                return GetMember<int>("CraftXPPct"); 
            }
        }

        public int HarvestXPPct
        {
            get 
            { 
                return GetMember<int>("HarvestXPPct"); 
            }
        }

        public int DiplomacyXPPct
        {
            get 
            { 
                return GetMember<int>("DiplomacyXPPct"); 
            }
        }

        public string HealthStr 
        {
            get 
            { 
                return GetMember<string>("HealthStr"); 
            }
        }

        public int Health
        {
            get 
            { 
                return GetMember<int>("Health"); 
            }
        }

        public int HealthPct
        {
            get 
            { 
                return GetMember<int>("HealthPct"); 
            }
        }

        public int MaxHealth
        {
            get 
            { 
                return GetMember<int>("MaxHealth"); 
            }
        }

        public string EnergyStr
        {
            get 
            { 
                return GetMember<string>("EnergyStr"); 
            }
        }

        public int Energy
        {
            get 
            { 
                return GetMember<int>("Energy"); 
            }
        }

        public int EnergyPct
        {
            get 
            { 
                return GetMember<int>("EnergyPct"); 
            }
        }

        public int MaxEnergy
        {
            get 
            { 
                return GetMember<int>("MaxEnergy"); 
            }
        }

        public string EnduranceStr
        {
            get 
            {
                return GetMember<string>("EnduranceStr"); 
            }
        }

        public int Endurance
        {
            get 
            {
                return GetMember<int>("Endurance"); 
            }
        }

        public int EndurancePct
        {
            get 
            {
                return GetMember<int>("EndurancePct"); 
            }
        }

        public int MaxEndurance
        {
            get 
            { 
                return GetMember<int>("MaxEndurance"); 
            }
        }

        public float X
        {
            get 
            { 
                return GetMember<float>("X"); 
            }
        }

        public float Y
        {
            get 
            { 
                return GetMember<float>("Y"); 
            }
        }

        public float Z
        {
            get 
            {
                return GetMember<float>("Z"); 
            }
        }

        public int Heading
        {
            get
            {
                return GetMember<int>("Heading"); 
            }
        }

        public Int64 ID
        {
            get 
            { 
                return GetMember<Int64>("ID"); 
            }
        }

        public string Casting 
        {
            get 
            {
                return GetMember<string>("Casting"); 
            }
        }

        public bool IsCasting
        {
            get
            {
                return GetMember<bool>("IsCasting"); 
            }
        }

        public bool InCombat 
        {
            get
            {
                return GetMember<bool>("InCombat"); 
            }
        }

        public bool HasDefensiveTarget 
        {
            get
            {
                return GetMember<bool>("HasDefensiveTarget"); 
            }
        }

        public bool HasVirtue 
        {
            get 
            {
                return GetMember<bool>("HasVirtue"); 
            }
        }

        public bool HasCombatForms 
        {
            get
            {
                return GetMember<bool>("HasCombatForms"); 
            }
        }

        public bool IsDrowning
        {
            get 
            {
                return GetMember<bool>("IsDrowning"); 
            }
        }

        public bool AutoAttackOn
        {
            get
            {
                return GetMember<bool>("AutoAttackOn"); 
            }
        }

        public bool IsCamping
        {
            get
            {
                return GetMember<bool>("IsCamping"); 
            }
        }

        public int BreathPct
        {
            get
            {
                return GetMember<int>("BreathPct"); 
            }
        }

        public int Copper
        {
            get
            {
                return GetMember<int>("Copper"); 
            }
        }

        public int Silver
        {
            get 
            {
                return GetMember<int>("Silver"); 
            }
        }

        public int Gold
        {
            get
            { 
                return GetMember<int>("Gold"); 
            }
        }

        public int Platinum
        {
            get
            {
                return GetMember<int>("Platinum"); 
            }
        }

        public bool AutoFollowOn
        {
            get 
            {
                return GetMember<bool>("AutoFollowOn"); 
            }
        }

        public int AdvEquipExpertiseUsed
        {
            get
            {
                return GetMember<int>("AdvEquipExpertiseUsed"); 
            }
        }

        public int CraftEquipExpertiseUsed
        {
            get 
            {
                return GetMember<int>("CraftEquipExpertiseUsed"); 
            }
        }

        public bool AdvEquipExpertiseUsedAsString
        {
            get 
            {
                return GetMember<bool>("AdvEquipExpertiseUsedAsString"); 
            }
        }

        public bool CraftEquipExpertiseUsedAsString
        {
            get
            {
                return GetMember<bool>("CraftEquipExpertiseUsedAsString"); 
            }
        }

        public int TargetHPs
        {
            get
            {
                return GetMember<int>("TargetHPs"); 
            }
        }

        public int TargetHealth
        {
            get 
            {
                return GetMember<int>("TargetHealth"); 
            }
        }

        public int DTargetHPs
        {
            get 
            {
                return GetMember<int>("DTargetHPs"); 
            }
        }

        public int DTargetHealth
        {
            get 
            {
                return GetMember<int>("DTargetHealth"); 
            }
        }

        public int NumAbilities
        {
            get 
            {
                return GetMember<int>("NumAbilities"); 
            }
        }

        public bool HavePet
        {
            get
            {
                return GetMember<bool>("HavePet"); 
            }
        }

        public int PetHPs
        {
            get
            {
                return GetMember<int>("PetHPs"); 
            }
        }

        public int PetHealth
        {
            get
            {
                return GetMember<int>("PetHealth"); 
            }
        }

        public string PetType
        {
            get
            {
                return GetMember<string>("PetType"); 
            }
        }

        public bool HaveMinion
        {
            get
            {
                return GetMember<bool>("HaveMinion"); 
            }
        }

        public float Weight
        {
            get
            { 
                return GetMember<float>("Weight"); 
            }
        }

        public float MaxWeight
        {
            get 
            {
                return GetMember<float>("MaxWeight"); 
            }
        }

        public bool InGroup
        {
            get
            {
                return GetMember<bool>("InGroup"); 
            }
        }

        public bool IsGrouped
        {
            get
            {
                return GetMember<bool>("IsGrouped"); 
            }
        }

        public bool IsGroupLeader
        {
            get 
            {
                return GetMember<bool>("IsGroupLeader"); 
            }
        }

        public bool GroupInvitePending
        {
            get 
            {
                return GetMember<bool>("GroupInvitePending"); 
            }
        }

        public bool IsLooting
        {
            get 
            {
                return GetMember<bool>("IsLooting"); 
            }
        }

        public bool LootingMyCorpse
        {
            get
            {
                return GetMember<bool>("LootingMyCorpse"); 
            }
        }

        public int NukeModTotal
        {
            get
            {
                return GetMember<int>("NukeModTotal"); 
            }
        }

        public int HealModTotal
        {
            get
            {
                return GetMember<int>("HealModTotal"); 
            }
        }

        public float TotalGenInvSlots
        {
            get 
            {
                return GetMember<float>("TotalGenInvSlots"); 
            }
        }

        public float GenInvSlotsUsed
        {
            get
            {
                return GetMember<float>("GenInvSlotsUsed"); 
            }
        }

        public Pawn Pet
        {
            get
            {
                LavishScriptPersistentObject Obj = GetPersistentMember("Pet");
                return new Pawn(Obj);
            }
        }

        public Chunk Chunk
        {
            get
            {
                LavishScriptObject Obj = GetMember("Chunk");
                return new Chunk(Obj);
            }
        }

        public Pawn Target
        {
            get
            {
                LavishScriptPersistentObject Obj = GetPersistentMember("Target");
                return new Pawn(Obj);
            }
        }

        public Pawn DTarget
        {
            get
            {
                LavishScriptPersistentObject Obj = GetPersistentMember("DTarget");
                return new Pawn(Obj);
            }
        }

        public Pawn TargetOfTarget
        {
            get
            {
                LavishScriptPersistentObject Obj = GetPersistentMember("TargetOfTarget");
                return new Pawn(Obj);
            }
        }

        public Pawn ToT
        {
            get
            {
                LavishScriptPersistentObject Obj = GetPersistentMember("TargetOfTarget");
                return new Pawn(Obj);
            }
        }

        public Encounter TargetAsEncounter
        {
            get
            {
                LavishScriptObject Obj = GetMember("TargetAsEncounter");
                return new Encounter(Obj);
            }
        }

        /// <summary>
        /// Number of minions your character currently controls 
        /// </summary>
        public int MinionCount
        {
            get
            {
                return GetMember<int>("Minion");
            }
        }

        public Minion Minion(int MinionNum)
        {
            LavishScriptObject Obj = GetMember("MinionAsPawn", MinionNum.ToString());
            return new Minion(Obj);
        }

        public Pawn MinionAsPawn(int MinionNum)
        {
            LavishScriptPersistentObject Obj = GetPersistentMember("MinionAsPawn", MinionNum.ToString());
            return new Pawn(Obj);
        }

        /// <summary>
        /// Number of abilities your character possesses
        /// </summary>
        public int AbilityCount
        {
            get
            {
                return GetMember<int>("Ability");
            }
        }

        public Ability Ability(int AbilityNum)
        {
            LavishScriptObject Obj = GetMember("Ability", AbilityNum.ToString());
            return new Ability(Obj);
        }

        public Ability Ability(string AbilityName)
        {
            LavishScriptObject Obj = GetMember("Ability", AbilityName);
            return new Ability(Obj);
        }

        /// <summary>
        ///Number of effects on your character 
        /// </summary>
        public int EffectCount
        {
            get
            {
                return GetMember<int>("Effect");
            }
        }

        public Effect Effect(int EffectNum)
        {
            LavishScriptObject Obj = GetMember("Effect", EffectNum.ToString());
            return new Effect(Obj);
        }

        public Effect Effect(string EffectName)
        {
            LavishScriptObject Obj = GetMember("Effect", EffectName);
            return new Effect(Obj);
        }

        /// <summary>
        ///Number of maintained buffs on your character 
        /// </summary>
        public int MaintainedCount
        {
            get
            {
                return GetMember<int>("Maintained");
            }
        }

        public Effect Maintained(int MaintainedNum)
        {
            LavishScriptObject Obj = GetMember("Maintained", MaintainedNum.ToString());
            return new Effect(Obj);
        }

        public Effect Maintained(string MaintainedName)
        {
            LavishScriptObject Obj = GetMember("Maintained", MaintainedName);
            return new Effect(Obj);
        }

        /// <summary>
        ///Number of effects on your current target 
        /// </summary>
        public int TargetEffectCount
        {
            get
            {
                return GetMember<int>("TargetEffect");
            }
        }

        public Effect TargetEffect(int TargetEffectNum)
        {
            LavishScriptObject Obj = GetMember("TargetEffect", TargetEffectNum.ToString());
            return new Effect(Obj);
        }

        public Effect TargetEffect(string TargetEffectName)
        {
            LavishScriptObject Obj = GetMember("TargetEffect", TargetEffectName);
            return new Effect(Obj);
        }

        /// <summary>
        ///Number of pawns in your current encounter 
        /// </summary>
        public int EncounterCount
        {
            get
            {
                return GetMember<int>("Encounter");
            }
        }

        public Encounter Encounter(int EncounterNum)
        {
            LavishScriptObject Obj = GetMember("Encounter", EncounterNum.ToString());
            return new Encounter(Obj);
        }

        public Encounter Encounter(string EncounterName)
        {
            LavishScriptObject Obj = GetMember("Encounter", EncounterName);
            return new Encounter(Obj);
        }

        public Item Inventory(params string[] Parameters)
        {
            LavishScriptObject Obj = GetMember("Inventory", Parameters);
            return new Item(Obj);
        }

        public Item Inventory(int Index)
        {
            LavishScriptObject Obj = GetMember("Inventory", Index.ToString());
            return new Item(Obj);
        }

        public Item Bank(params string[] Parameters)
        {
            LavishScriptObject Obj = GetMember("Bank", Parameters);
            return new Item(Obj);
        }

        public Item Bank(int Index)
        {
            LavishScriptObject Obj = GetMember("Bank", Index.ToString());
            return new Item(Obj);
        }

        /// <summary>
        ///Total number of forms avialble to you
        /// </summary>
        public int FormCount
        {
            get
            {
                return GetMember<int>("Form");
            }
        }

        public Form Form(int FormNum)
        {
            LavishScriptObject Obj = GetMember("Form", FormNum.ToString());
            return new Form(Obj);

        }

        public Form Form(string FormName)
        {
            LavishScriptObject Obj = GetMember("Form", FormName);
            return new Form(Obj);
        }

        public Form CurrentForm
        {
            get
            {
                LavishScriptObject Obj = GetMember("CurrentForm");
                return new Form(Obj);
            }
        }
    }
}
