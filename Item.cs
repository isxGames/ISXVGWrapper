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

        public Item()
            : base(LavishScript.Objects.GetObject("Item"))
        {
        }
        public string Name
        {
            get
            {
                return GetMember<string>("Name");
            }
        }
        public string Quality
        {
            get
            {
                return GetMember<string>("Quality");
            }
        }
        public int Handle
        {
            get
            {
                return GetMember<int>("Handle");
            }
        }
        public string ContinentalEffect
        {
            get
            {
                return GetMember<string>("ContinentalEffect");
            }
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

        public int MaxQuantity
        {
            get
            {
                return GetMember<int>("MaxQuantity");
            }
        }

        public string MiscDescription
        {
            get
            {
                return GetMember<string>("MiscDescription");
            }
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

        public int NumSlotsOpen
        {
            get
            {
                return GetMember<int>("NumSlotsOpen");
            }
        }

        public bool IsFull
        {
            get
            {
                return GetMember<bool>("IsFull");
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

        public int IconID
        {
            get
            {
                return GetMember<int>("IconID");
            }
        }

        public ItemModifier Modifier(int ModifierNumber)
        {
            LavishScriptObject Obj = GetMember("Modifier", ModifierNumber.ToString());
            return new ItemModifier(Obj);
        }

        public ItemModifier Modifier(string ModifierName)
        {
            LavishScriptObject Obj = GetMember("Modifier", ModifierName);
            return new ItemModifier(Obj);
        }

        public bool LootNDC()
        {
            return ExecuteMethod("Loot","NDC");
        }

        public bool Loot()
        {
            return ExecuteMethod("Loot");
        }

        public bool Use()
        {
            return ExecuteMethod("Use");
        }

        public bool Delete()
        {
            return ExecuteMethod("Delete");
        }

        public bool Equip()
        {
            return ExecuteMethod("Equip");
        }

        public bool EquipNDC()
        {
            return ExecuteMethod("Equip","NDC");
        }

        public bool Unequip()
        {
            return ExecuteMethod("Unequip");
        }

        public bool MoveToGeneralInventory()
        {
            return ExecuteMethod("MoveToGeneralInventory");
        }

        public bool StartConvert()
        {
            return ExecuteMethod("StartConvert");
        }

        public bool StackWith(int StackWith)
        {
            return ExecuteMethod("StackWith",StackWith.ToString());
        }
        public bool OfferInTrade(int Qty)
        {
            return ExecuteMethod("OfferInTrade", Qty.ToString());
        }
        public bool OfferInTrade()
        {
            return ExecuteMethod("OfferInTrade");
        }
        public bool PutInContainer(int ContainerIndex)
        {
            return ExecuteMethod("PutInContainer", ContainerIndex.ToString());
        }

        public bool PutIn(int ContainerIndex)
        {
            return ExecuteMethod("PutIn", ContainerIndex.ToString());
        }
        public bool Buy()
        {
            return ExecuteMethod("Buy");
        }
        public bool Buy(int NumStacks)
        {
            return ExecuteMethod("Buy", NumStacks.ToString());
        }
        public bool Sell()
        {
            return ExecuteMethod("Sell");
        }
        public bool Sell(int QtyInAStack)
        {
            return ExecuteMethod("Sell", QtyInAStack.ToString());
        }
    }
}
