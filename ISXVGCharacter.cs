using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class ISXVGCharacter
    {
        public ISXVGCharacter()
        {
        }

        private string _fName;
        public string FName
        {
            get
            {
                GetData<string>(ref _fName, "FName");
                return _fName;
            }
        }

        private string _lName;
        public string LName
        {
            get
            {
                GetData<string>(ref _lName, "LName");
                return _lName;
            }
        }

        private string _class;
        public string Class
        {
            get
            {
                GetData<string>(ref _class, "Class");
                return _class;
            }
        }

        private string _classAbrv;
        public string ClassAbrv
        {
            get
            {
                GetData<string>(ref _classAbrv, "ClassAbrv");
                return _classAbrv;
            }
        }

        private int _level;
        public int Level
        {
            get
            {
                GetData<int>(ref _level, "Level");
                return _level;
            }
        }

        private int _craftingLevel;
        public int CraftingLevel
        {
            get
            {
                GetData<int>(ref _craftingLevel, "CraftingLevel");
                return _craftingLevel;
            }
        }

        private int _harvestingLevel;
        public int HarvestingLevel
        {
            get
            {
                GetData<int>(ref _harvestingLevel, "HarvestingLevel");
                return _harvestingLevel;
            }
        }

        private int _xp;
        public int XP
        {
            get
            {
                GetData<int>(ref _xp, "XP");
                return _xp;
            }
        }

        private int _xpPct;
        public int XPPct
        {
            get
            {
                GetData<int>(ref _xpPct, "XPPct");
                return _xpPct;
            }
        }
        private int _xpDebtPct;
        public int XPDebtPct
        {
            get
            {
                GetData<int>(ref _xpDebtPct, "XPDebtPct");
                return _xpDebtPct;
            }
        }
        private int _craftXP;
        public int CraftXP
        {
            get
            {
                GetData<int>(ref _craftXP, "CraftXP");
                return _craftXP;
            }
        }
        private int _craftXPPct;
        public int CraftXPPct
        {
            get
            {
                GetData<int>(ref _craftXPPct, "CraftXPPct");
                return _craftXPPct;
            }
        }

        private int _harvestXPPct;
        public int HarvestXPPct
        {
            get
            {
                GetData<int>(ref _harvestXPPct, "HarvestXPPct");
                return _harvestXPPct;
            }
        }

        private int _diplomacyXPPct;
        public int DiplomacyXPPct
        {
            get
            {
                GetData<int>(ref _diplomacyXPPct, "DiplomacyXPPct");
                return _diplomacyXPPct;
            }
        }

        private string _healthStr;
        public string HealthStr 
        {
            get
            {
                GetData<string>(ref _healthStr, "HealthStr");
                return _healthStr;
            }
        }

        private int _health;
        public int Health
        {
            get
            {
                GetData<int>(ref _health, "Health");
                return _health;
            }
        }

        private int _healthPct;
        public int HealthPct
        {
            get
            {
                GetData<int>(ref _healthPct, "HealthPct");
                return _healthPct;
            }
        }

        private int _maxHealth;
        public int MaxHealth
        {
            get
            {
                GetData<int>(ref _maxHealth, "MaxHealth");
                return _maxHealth;
            }
        }

        private string _energyStr;
        public string EnergyStr
        {
            get
            {
                GetData<string>(ref _energyStr, "EnergyStr");
                return _energyStr;
            }
        }

        private int _energy;
        public int Energy
        {
            get
            {
                GetData<int>(ref _energy, "Energy");
                return _energy;
            }
        }

        private int _energyPct;
        public int EnergyPct
        {
            get
            {
                GetData<int>(ref _energyPct, "EnergyPct");
                return _energyPct;
            }
        }

        private int _maxEnergy;
        public int MaxEnergy
        {
            get
            {
                GetData<int>(ref _maxEnergy, "MaxEnergy");
                return _maxEnergy;
            }
        }

        private string _enduranceStr;
        public string EnduranceStr
        {
            get
            {
                GetData<string>(ref _enduranceStr, "EnduranceStr");
                return _enduranceStr;
            }
        }

        private int _endurance;
        public int Endurance
        {
            get
            {
                GetData<int>(ref _endurance, "Endurance");
                return _endurance;
            }
        }

        private int _endurancePct;
        public int EndurancePct
        {
            get
            {
                GetData<int>(ref _endurancePct, "EndurancePct");
                return _endurancePct;
            }
        }

        private int _maxEndurance;
        public int MaxEndurance
        {
            get
            {
                GetData<int>(ref _maxEndurance, "MaxEndurance");
                return _maxEndurance;
            }
        }

        private float _x;
        public float X
        {
            get
            {
                GetData<float>(ref _x, "X");
                return _x;
            }
        }

        private float _y;
        public float Y
        {
            get
            {
                GetData<float>(ref _y, "Y");
                return _y;
            }
        }

        private float _z;
        public float Z
        {
            get
            {
                GetData<float>(ref _z, "Z");
                return _z;
            }
        }

        private int _heading;
        public int Heading
        {
            get
            {
                GetData<int>(ref _heading, "Heading");
                return _heading;
            }
        }

        private Int64 _id;
        public Int64 ID
        {
            get
            {
                GetData<Int64>(ref _id, "ID");
                return _id;
            }
        }

        private string _casting;
        public string Casting 
        {
            get
            {
                GetData<string>(ref _casting, "Casting");
                return _casting;
            }
        }

        private bool _isCasting;
        public bool IsCasting
        {
            get
            {
                GetData<bool>(ref _isCasting, "IsCasting");
                return _isCasting;
            }
        }

        private bool _inCombat;
        public bool InCombat 
        {
            get
            {
                GetData<bool>(ref _inCombat, "InCombat");
                return _inCombat;
            }
        }

        private bool _hasDefensiveTarget;
        public bool HasDefensiveTarget 
        {
            get
            {
                GetData<bool>(ref _hasDefensiveTarget, "HasDefensiveTarget");
                return _hasDefensiveTarget;
            }
        }

        private bool _hasVirtue;
        public bool HasVirtue 
        {
            get
            {
                GetData<bool>(ref _hasVirtue, "HasVirtue");
                return _hasVirtue;
            }
        }

        private bool _hasCombatForms;
        public bool HasCombatForms 
        {
            get
            {
                GetData<bool>(ref _hasCombatForms, "HasCombatForms");
                return _hasCombatForms;
            }
        }

        private bool _isDrowning;
        public bool IsDrowning
        {
            get
            {
                GetData<bool>(ref _isDrowning, "IsDrowning");
                return _isDrowning;
            }
        }

        private bool _autoAttackOn;
        public bool AutoAttackOn
        {
            get
            {
                GetData<bool>(ref _autoAttackOn, "AutoAttackOn");
                return _autoAttackOn;
            }
        }

        private bool _isCamping;
        public bool IsCamping
        {
            get
            {
                GetData<bool>(ref _isCamping, "IsCamping");
                return _isCamping;
            }
        }

        private int _breathPct;
        public int BreathPct
        {
            get
            {
                GetData<int>(ref _breathPct, "BreathPct");
                return _breathPct;
            }
        }

        private int _copper;
        public int Copper
        {
            get
            {
                GetData<int>(ref _copper, "Copper");
                return _copper;
            }
        }

        private int _silver;
        public int Silver
        {
            get
            {
                GetData<int>(ref _silver, "Silver");
                return _silver;
            }
        }

        private int _gold;
        public int Gold
        {
            get
            {
                GetData<int>(ref _gold, "Gold");
                return _gold;
            }
        }

        private int _platinum;
        public int Platinum
        {
            get
            {
                GetData<int>(ref _platinum, "Platinum");
                return _platinum;
            }
        }

        private bool _autoFollowOn;
        public bool AutoFollowOn
        {
            get
            {
                GetData<bool>(ref _autoFollowOn, "AutoFollowOn");
                return _autoFollowOn;
            }
        }

        private int _advEquipExpertiseUsed;
        public int AdvEquipExpertiseUsed
        {
            get
            {
                GetData<int>(ref _advEquipExpertiseUsed, "AdvEquipExpertiseUsed");
                return _advEquipExpertiseUsed;
            }
        }

        private int _craftEquipExpertiseUsed;
        public int CraftEquipExpertiseUsed
        {
            get
            {
                GetData<int>(ref _craftEquipExpertiseUsed, "CraftEquipExpertiseUsed");
                return _craftEquipExpertiseUsed;
            }
        }

        private bool _advEquipExpertiseUsedAsString;
        public bool AdvEquipExpertiseUsedAsString
        {
            get
            {
                GetData<bool>(ref _advEquipExpertiseUsedAsString, "AdvEquipExpertiseUsedAsString");
                return _advEquipExpertiseUsedAsString;
            }
        }

        private bool _craftEquipExpertiseUsedAsString;
        public bool CraftEquipExpertiseUsedAsString
        {
            get
            {
                GetData<bool>(ref _craftEquipExpertiseUsedAsString, "CraftEquipExpertiseUsedAsString");
                return _craftEquipExpertiseUsedAsString;
            }
        }

        private int _targetHPs;
        public int TargetHPs
        {
            get
            {
                GetData<int>(ref _targetHPs, "TargetHPs");
                return _targetHPs;
            }
        }

        private int _targetHealth;
        public int TargetHealth
        {
            get
            {
                GetData<int>(ref _targetHealth, "TargetHealth");
                return _targetHealth;
            }
        }

        private int _dTargetHPs;
        public int DTargetHPs
        {
            get
            {
                GetData<int>(ref _dTargetHPs, "DTargetHPs");
                return _dTargetHPs;
            }
        }

        private int _dTargetHealth;
        public int DTargetHealth
        {
            get
            {
                GetData<int>(ref _dTargetHealth, "DTargetHealth");
                return _dTargetHealth;
            }
        }

        private int _numAbilities;
        public int NumAbilities
        {
            get
            {
                GetData<int>(ref _numAbilities, "NumAbilities");
                return _numAbilities;
            }
        }

        private bool _havePet;
        public bool HavePet
        {
            get
            {
                GetData<bool>(ref _havePet, "HavePet");
                return _havePet;
            }
        }

        private int _petHPs;
        public int PetHPs
        {
            get
            {
                GetData<int>(ref _petHPs, "PetHPs");
                return _petHPs;
            }
        }

        private int _petHealth;
        public int PetHealth
        {
            get
            {
                GetData<int>(ref _petHealth, "PetHealth");
                return _petHealth;
            }
        }

        private string _petType;
        public string PetType
        {
            get
            {
                GetData<string>(ref _petType, "PetType");
                return _petType;
            }
        }

        private bool _haveMinion;
        public bool HaveMinion
        {
            get
            {
                GetData<bool>(ref _haveMinion, "HaveMinion");
                return _haveMinion;
            }
        }

        private float _weight;
        public float Weight
        {
            get
            {
                GetData<float>(ref _weight, "Weight");
                return _weight;
            }
        }

        private float _maxWeight;
        public float MaxWeight
        {
            get
            {
                GetData<float>(ref _maxWeight, "MaxWeight");
                return _maxWeight;
            }
        }

        private bool _inGroup;
        public bool InGroup
        {
            get
            {
                GetData<bool>(ref _inGroup, "InGroup");
                return _inGroup;
            }
        }

        private bool _isGrouped;
        public bool IsGrouped
        {
            get
            {
                GetData<bool>(ref _isGrouped, "IsGrouped");
                return _isGrouped;
            }
        }

        private bool _isGroupLeader;
        public bool IsGroupLeader
        {
            get
            {
                GetData<bool>(ref _isGroupLeader, "IsGroupLeader");
                return _isGroupLeader;
            }
        }

        private bool _groupInvitePending;
        public bool GroupInvitePending
        {
            get
            {
                GetData<bool>(ref _groupInvitePending, "GroupInvitePending");
                return _groupInvitePending;
            }
        }

        private bool _isLooting;
        public bool IsLooting
        {
            get
            {
                GetData<bool>(ref _isLooting, "IsLooting");
                return _isLooting;
            }
        }

        private bool _lootingMyCorpse;
        public bool LootingMyCorpse
        {
            get
            {
                GetData<bool>(ref _lootingMyCorpse, "LootingMyCorpse");
                return _lootingMyCorpse;
            }
        }

        private int _nukeModTotal;
        public int NukeModTotal
        {
            get
            {
                GetData<int>(ref _nukeModTotal, "NukeModTotal");
                return _nukeModTotal;
            }
        }

        private int _healModTotal;
        public int HealModTotal
        {
            get
            {
                GetData<int>(ref _healModTotal, "HealModTotal");
                return _healModTotal;
            }
        }

        private ISXVGMinion _pet;
        public ISXVGMinion Pet
        {
            get
            {
                _pet = new ISXVGMinion("Me.Pet");
                return _pet;
            }
        }

        private ISXVGChunk _chunk;
        public ISXVGChunk Chunk
        {
            get
            {
                _chunk = new ISXVGChunk();
                return _chunk;
            }
        }

        private ISXVGPawn _target;
        public ISXVGPawn Target
        {
            get
            {
                _target = new ISXVGPawn("Me.Target");
                return _target;
            }
        }

        private ISXVGPawn _dTarget;
        public ISXVGPawn DTarget
        {
            get
            {
                _dTarget = new ISXVGPawn("Me.DTarget");
                return _dTarget;
            }
        }

        private int _minion;
        public int Minion()
        {
            GetData<int>(ref _minion, "Me.Minion");
            return _minion;
        }

        public ISXVGMinion Minion(int minion)
        {
            return new ISXVGMinion("Me.Minion[" + minion + "]");
        }

        public ISXVGPawn MinionAsPawn(int minion)
        {
            return new ISXVGPawn("Me.MinionAsPawn[" + minion + "]");
        }

        public ISXVGAbility Ability(int ability)
        {
            return new ISXVGAbility("Me.Ability[" + ability + "]");
        }

        public ISXVGAbility Ability(string ability)
        {
            return new ISXVGAbility("Me.Ability[" + ability + "]");
        }

        private int _effect;
        public int Effect()
        {
            GetData<int>(ref _effect, "Me.Effect");
            return _effect;
        }

        public ISXVGEffect Effect(int effect)
        {
            return new ISXVGEffect("Me.Effect[" + effect + "]");
        }

        public ISXVGEffect Effect(string effect)
        {
            return new ISXVGEffect("Me.Effect[" + effect + "]");
        }

        private int _maintained;
        public int Maintained()
        {
            GetData<int>(ref _maintained, "Me.Maintained");
            return _maintained;
        }

        public ISXVGEffect Maintained(int maintained)
        {
            return new ISXVGEffect("Me.Maintained[" + maintained + "]");
        }

        public ISXVGEffect Maintained(string maintained)
        {
            return new ISXVGEffect("Me.Maintained[" + maintained + "]");
        }

        private int _targetEffect;
        public int TargetEffect()
        {
            GetData<int>(ref _targetEffect, "Me.TargetEffect");
            return _targetEffect;
        }

        public ISXVGEffect TargetEffect(int targetEffect)
        {
            return new ISXVGEffect("Me.TargetEffect[" + targetEffect + "]");
        }

        public ISXVGEffect TargetEffect(string targetEffect)
        {
            return new ISXVGEffect("Me.TargetEffect[" + targetEffect + "]");
        }

        private int _encounter;
        public int Encounter()
        {
            GetData<int>(ref _encounter, "Encounter");
            return _encounter;
        }

        public ISXVGEncounter Encounter(int encounter)
        {
            return new ISXVGEncounter("Me.Encounter[" + encounter + "]");
        }

        public ISXVGEncounter Encounter(string encounter)
        {
            return new ISXVGEncounter("Me.Encounter[" + encounter + "]");
        }

        public ISXVGItem Inventory(string inventory)
        {
            return new ISXVGItem("Me.Inventory[" + inventory + "]");
        }

        public ISXVGItem Bank(string bank)
        {
            return new ISXVGItem("Me.Bank[" + bank + "]");
        }

        private int _form;
        public int Form
        {
            get
            {
                GetData<int>(ref _form, "Form");
                return _form;
            }
        }

        protected void GetData<T>(ref T obj, string param)
        {
            try
            {
                LavishScript.DataParse<T>("${Me." + param + "}", ref obj);
            }
            catch
            {

            }
        }

/*        public enum VGAdventuring
        {
            Alteration,
			Arcane Resistance,
			Archery,
			Awareness,
			Axe,
			Bash,
			Bow,
			Club,
			Cold Resistance,
			Combat Awareness,
			Conjuration,
			Constitution,
			Crossbow,
			Dagger and Knife,
			Detection,
			Dexterity,
			Dodge,
			Dual Wield,
			Evocation,
			Fire Resistance,
			Hamme,
			Hand to Hand,
			Heavy Harvesting Tools,
			Hide,
			Intelligence,
			Kick,
			Longsword,
			Maul,
			Mental Resistance,
			One-handed Blunt,
			One-handed Piercing,
			One-handed Slashing,
			One-handed Wielding,
			Parry,
			Physical Resistance,
			Ranged Wielding,
			Safe Fall,
			Short Sword,
			Sneak,
			Spirit Resistance,
			Strength,
			Tactic Recognition,
			Thrown,
			Thrown Axes,
			Thrown Daggers,
			Thrown Hammers,
			Vitality,
			Wisdom
        }
 */
    }
}
