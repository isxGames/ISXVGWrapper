using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class ISXVGItem
    {
        public ISXVGItem()
        {
        }

        public ISXVGItem(string tlo)
        {
            TLO = tlo;
        }

        public ISXVGItem(int tlo)
        {
            TLO = tlo.ToString();
        }

        private string _tlo;
        protected string TLO
        {
            get
            {
                return _tlo;
            }
            set
            {
                _tlo = value;
            }
        }

        private int _expertiseCost;
        public int ExpertiseCost
        {
            get
            {
                GetData<int>(ref _expertiseCost, "ExpertiseCost");
                return _expertiseCost;
            }
        }

        private int _id;
        public int ID
        {
            get
            {
                GetData<int>(ref _id, "ID");
                return _id;
            }
        }

        private string _ToLink;
        public string ToLink()
        {
            GetData<string>(ref _ToLink, "ToLink");
            return _ToLink;
        }

        public string ToLink(string customname)
        {
            GetData<string>(ref _ToLink, "ToLink[" + customname + "]");
            return _ToLink;
        }

        private string _description;
        public string Description
        {
            get
            {
                GetData<string>(ref _description, "Description");
                return _description;
            }
        }

        private string _craftedBy;
        public string CraftedBy
        {
            get
            {
                GetData<string>(ref _craftedBy, "CraftedBy");
                return _craftedBy;
            }
        }

        private string _Type;
        public string Type
        {
            get
            {
                GetData<string>(ref _Type, "Type");
                return _Type;
            }
        }

        private string _rarity;
        public string Rarity
        {
            get
            {
                GetData<string>(ref _rarity, "Rarity");
                return _rarity;
            }
        }

        private string _currentEquipSlot;
        public string CurrentEquipSlot
        {
            get
            {
                GetData<string>(ref _currentEquipSlot, "CurrentEquipSlot");
                return _currentEquipSlot;
            }
        }

        private string _defaultEquipSlot;
        public string DefaultEquipSlot
        {
            get
            {
                GetData<string>(ref _defaultEquipSlot, "DefaultEquipSlot");
                return _defaultEquipSlot;
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

        private int _numSlots;
        public int NumSlots
        {
            get
            {
                GetData<int>(ref _numSlots, "NumSlots");
                return _numSlots;
            }
        }

        private string _keyword1;
        public string Keyword1
        {
            get
            {
                GetData<string>(ref _keyword1, "Keyword1");
                return _keyword1;
            }
        }

        private string _keyword2;
        public string Keyword2
        {
            get
            {
                GetData<string>(ref _keyword2, "Keyword2");
                return _keyword2;
            }
        }

        private int _currentDmg;
        public int CurrentDmg
        {
            get
            {
                GetData<int>(ref _currentDmg, "CurrentDmg");
                return _currentDmg;
            }
        }

        private int _defaultDmg;
        public int DefaultDmg
        {
            get
            {
                GetData<int>(ref _defaultDmg, "DefaultDmg");
                return _defaultDmg;
            }
        }

        private float _speed;
        public float Speed
        {
            get
            {
                GetData<float>(ref _speed, "Speed");
                return _speed;
            }
        }

        private string _armorType;
        public string ArmorType
        {
            get
            {
                GetData<string>(ref _armorType, "ArmorType");
                return _armorType;
            }
        }

        private int _armorClassMod;
        public int ArmorClassMod
        {
            get
            {
                GetData<int>(ref _armorClassMod, "ArmorClassModD");
                return _armorClassMod;
            }
        }

        private int _armorClassModMax;
        public int ArmorClassModMax
        {
            get
            {
                GetData<int>(ref _armorClassModMax, "ArmorClassModMax");
                return _armorClassModMax;
            }
        }

        private string _rangedWeaponType;
        public string RangedWeaponType
        {
            get
            {
                GetData<string>(ref _rangedWeaponType, "RangedWeaponType");
                return _rangedWeaponType;
            }
        }

        private int _numModifiers;
        public int NumModifiers
        {
            get
            {
                GetData<int>(ref _numModifiers, "NumModifiers");
                return _numModifiers;
            }
        }

        private string _flags;
        public string Flags
        {
            get
            {
                GetData<string>(ref _flags, "Flags");
                return _flags;
            }
        }

        private int _quantity;
        public int Quantity
        {
            get
            {
                GetData<int>(ref _quantity, "Quantity");
                return _quantity;
            }
        }

        public ISXVGItemModifier Modifier(int modifier)
        {
            return new ISXVGItemModifier(TLO + "[" + modifier + "]");
        }

        public ISXVGItemModifier Modifier(string modifier)
        {
            return new ISXVGItemModifier(TLO + "[" + modifier + "]");
        }

        public void Loot()
        {
            LavishScript.ExecuteCommand(TLO + ":Loot");
        }

        public void LootNDC()
        {
            LavishScript.ExecuteCommand(TLO + ":Loot[NDC]");
        }

        public void Use()
        {
            LavishScript.ExecuteCommand(TLO + ":Use");
        }

        protected void GetData<T>(ref T obj, string param)
        {
            try
            {
                LavishScript.DataParse<T>("${" + TLO + "." + param + "}", ref obj);
            }
            catch
            {
                InnerSpace.Echo("Exception Raised");
            }
        }
    }
}
