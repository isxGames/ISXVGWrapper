using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class Item : LavishScriptObject
    {
        public Item(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public Item(string ItemName)
            : base(LavishScript.Objects.GetObject("Item"))
        {
        }

        public float ExpertiseCost
        {
            get
            {
                return GetMember<float>("ExpertiseCost");
            }
        }

        public int Condition
        {
            get
            {
                return GetMember<int>("Condition");
            }
        }

        public int Level
        {
            get
            {
                return GetMember<int>("Level");
            }
        }

        public int ID
        {
            get
            {
                return GetMember<int>("ID");
            }
        }

        public string ToLink()
        {
            return GetMember<string>("ToLink");
        }

        public string ToLink(string CustomName)
        {
            return GetMember<string>("ToLink", CustomName.ToString());
        }

        public string Description
        {
            get
            {
                return GetMember<string>("Description");
            }
        }

        public string CraftedBy
        {
            get
            {
                return GetMember<string>("CraftedBy");
            }
        }

        public string Type
        {
            get
            {
                return GetMember<string>("Type");
            }
        }

        public string Rarity
        {
            get
            {
                return GetMember<string>("Rarity");
            }
        }

        public string CurrentEquipSlot
        {
            get
            {
                return GetMember<string>("CurrentEquipSlot");
            }
        }

        public string DefaultEquipSlot
        {
            get
            {
                return GetMember<string>("DefaultEquipSlot");
            }
        }

        public float Weight
        {
            get
            {
                return GetMember<float>("Weight");
            }
        }

        public int NumSlots
        {
            get
            {
                return GetMember<int>("NumSlots");
            }
        }

        public string Keyword1
        {
            get
            {
                return GetMember<string>("Keyword1");
            }
        }

        public string Keyword2
        {
            get
            {
                return GetMember<string>("Keyword2");
            }
        }

        public int CurrentDmg
        {
            get
            {
                return GetMember<int>("CurrentDmg");
            }
        }

        public int DefaultDmg
        {
            get
            {
                return GetMember<int>("DefaultDmg");
            }
        }

        public float Speed
        {
            get
            {
                return GetMember<float>("Speed");
            }
        }

        public string ArmorType
        {
            get
            {
                return GetMember<string>("ArmorType");
            }
        }

        public int ArmorClassMod
        {
            get
            {
                return GetMember<int>("ArmorClassMod");
            }
        }

        public int ArmorClassModMax
        {
            get
            {
                return GetMember<int>("ArmorClassModMax");
            }
        }

        public string RangedWeaponType
        {
            get
            {
                return GetMember<string>("RangedWeaponType");
            }
        }

        public int NumModifiers
        {
            get
            {
                return GetMember<int>("NumModifiers");
            }
        }

        public string Flags
        {
            get
            {
                return GetMember<string>("Flags");
            }
        }

        public int Quantity
        {
            get
            {
                return GetMember<int>("Quantity");
            }
        }

        public int Index
        {
            get
            {
                return GetMember<int>("Index");
            }
        }

        public ItemModifier Modifier(int ModifierNumber)
        {
            return GetMember<ItemModifier>("Modifier", ModifierNumber.ToString());
        }

        public ItemModifier Modifier(string ModifierName)
        {
            return GetMember<ItemModifier>("Modifier", ModifierName.ToString());
        }

        public bool LootNDC
        {
            get { return ExecuteMethod("Loot","NDC"); }
        }

        public bool Loot
        {
            get { return ExecuteMethod("Loot"); }
        }

        public bool Use
        {
            get { return ExecuteMethod("Use"); }
        }

        public bool Delete
        {
            get { return ExecuteMethod("Delete"); }
        }

        public bool Equip
        {
            get { return ExecuteMethod("Equip"); }
        }

        public bool EquipNDC
        {
            get { return ExecuteMethod("Equip","NDC"); }
        }

        public bool Unequip
        {
            get { return ExecuteMethod("Unequip"); }
        }

        public bool StartConvert
        {
            get { return ExecuteMethod("StartConvert"); }
        }

        public bool StackWith(int StackWith)
        {
            return ExecuteMethod("StackWith",StackWith.ToString());
        }

        public bool PutInContainer(int ContainerIndex)
        {
            return ExecuteMethod("PutInContainer", ContainerIndex.ToString());
        }

        public bool PutIn(int ContainerIndex)
        {
            return ExecuteMethod("PutIn", ContainerIndex.ToString());
        }
    }
}
