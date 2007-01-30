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
            : base(LavishScript.Objects.GetObject("Item", ItemName))
        {
        }
        public Item(int ItemNumber)
            : base(LavishScript.Objects.GetObject("Item", ItemNumber.ToString()))
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

        public void Loot(string ItemName)
        {
            LavishScript.ExecuteCommand(ItemName + ":Loot");
        }

        public void LootNDC(string ItemName)
        {
            LavishScript.ExecuteCommand(ItemName + ":Loot[NDC]");
        }

        public void Use(string ItemName)
        {
            LavishScript.ExecuteCommand(ItemName + ":Use");
        }

        public void Delete(string ItemName)
        {
            LavishScript.ExecuteCommand(ItemName + ":Delete");
        }

        public void Equip(string ItemName)
        {
            LavishScript.ExecuteCommand(ItemName + ":Equip");
        }

        public void EquipNDC(string ItemName)
        {
            LavishScript.ExecuteCommand(ItemName + ":Equip[NDC]");
        }

        public void Unequip(string ItemName)
        {
            LavishScript.ExecuteCommand(ItemName + ":Unequip");
        }

        public void StartConvert(string ItemName)
        {
            LavishScript.ExecuteCommand(ItemName + ":StartConvert");
        }

        public void StackWith(string ItemName,int IndexNumber)
        {
            LavishScript.ExecuteCommand(ItemName + ":StackWith[" + IndexNumber + "]");
        }

        public void PutInContainer(string ItemName,int ContainerIndexNumber)
        {
            LavishScript.ExecuteCommand(ItemName + ":PutInContainer[" + ContainerIndexNumber + "]");
        }
    }
}
