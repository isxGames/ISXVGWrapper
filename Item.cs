using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    /// <summary>
    /// This DataType includes all of the data available to ISXVG that is related to items.
    /// </summary>
    public class Item : LavishScriptObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Item"/> class.
        /// </summary>
        /// <param name="Obj">The obj.</param>
        public Item(LavishScriptObject Obj) : base(Obj) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="Item"/> class.
        /// </summary>
        public Item() : base(LavishScript.Objects.GetObject("Item")) {}

        /// <summary>
        /// Gets the name of this <see cref="Item"/>.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get { return GetMember<string>("Name"); } }

        /// <summary>
        /// Gets the quality of this <see cref="Item"/>.
        /// </summary>
        /// <value>The quality.</value>
        public string Quality { get { return GetMember<string>("Quality"); } }

        /// <summary>
        /// Gets the handle of this <see cref="Item"/>.
        /// </summary>
        /// <value>The handle.</value>
        public int Handle { get { return GetMember<int>("Handle"); } }

        /// <summary>
        /// Gets the continental effect of this <see cref="Item"/>.
        /// </summary>
        /// <value>The continental effect.</value>
        public string ContinentalEffect { get { return GetMember<string>("ContinentalEffect"); } }

        /// <summary>
        /// Gets the expertise cost of this <see cref="Item"/>.
        /// </summary>
        /// <value>The expertise cost.</value>
        public float ExpertiseCost { get { return GetMember<float>("ExpertiseCost"); } }

        /// <summary>
        /// Gets the condition of this <see cref="Item"/>.
        /// </summary>
        /// <value>The condition.</value>
        public int Condition { get { return GetMember<int>("Condition"); } }

        /// <summary>
        /// Gets the durability of this <see cref="Item"/>.
        /// </summary>
        /// <value>The durability.</value>
        public int Durability { get { return GetMember<int>("Durability"); } }

        /// <summary>
        /// Gets the level of this <see cref="Item"/>.
        /// </summary>
        /// <value>The level.</value>
        public int Level { get { return GetMember<int>("Level"); } }

        /// <summary>
        /// Gets the ID of this <see cref="Item"/>.
        /// </summary>
        /// <value>The ID.</value>
        public int ID { get { return GetMember<int>("ID"); } }

        /// <summary>
        /// Gets the max quantity of this <see cref="Item"/>.
        /// </summary>
        /// <value>The max quantity.</value>
        public int MaxQuantity { get { return GetMember<int>("MaxQuantity"); } }

        /// <summary>
        /// Gets the misc description of this <see cref="Item"/>.
        /// </summary>
        /// <value>The misc description.</value>
        public string MiscDescription { get { return GetMember<string>("MiscDescription"); } }

        /// <summary>
        /// Gets the description of this <see cref="Item"/>.
        /// </summary>
        /// <value>The description.</value>
        public string Description { get { return GetMember<string>("Description"); } }

        /// <summary>
        /// Gets the crafted by of this <see cref="Item"/>.
        /// </summary>
        /// <value>The crafted by.</value>
        public string CraftedBy { get { return GetMember<string>("CraftedBy"); } }

        /// <summary>
        /// Gets the in container of this <see cref="Item"/>.
        /// </summary>
        /// <value>The in container.</value>
        public Item InContainer
        {
            get
            {
                LavishScriptObject Obj = GetMember("InContainer");
                return new Item(Obj);
            }
        }

        /// <summary>
        /// Gets the type of this <see cref="Item"/>.
        /// </summary>
        /// <value>The type.</value>
        public string Type { get { return GetMember<string>("Type"); } }

        /// <summary>
        /// Gets the rarity of this <see cref="Item"/>.
        /// </summary>
        /// <value>The rarity.</value>
        public string Rarity { get { return GetMember<string>("Rarity"); } }

        /// <summary>
        /// Gets the current equip slot of this <see cref="Item"/>.
        /// </summary>
        /// <value>The current equip slot.</value>
        public string CurrentEquipSlot { get { return GetMember<string>("CurrentEquipSlot"); } }

        /// <summary>
        /// Gets the default equip slot of this <see cref="Item"/>.
        /// </summary>
        /// <value>The default equip slot.</value>
        public string DefaultEquipSlot { get { return GetMember<string>("DefaultEquipSlot"); } }

        /// <summary>
        /// Gets the weight of this <see cref="Item"/>.
        /// </summary>
        /// <value>The weight.</value>
        public float Weight { get { return GetMember<float>("Weight"); } }

        /// <summary>
        /// Gets the num slots of this <see cref="Item"/>.
        /// </summary>
        /// <value>The num slots.</value>
        public int NumSlots { get { return GetMember<int>("NumSlots"); } }

        /// <summary>
        /// Gets the num slots open of this <see cref="Item"/>.
        /// </summary>
        /// <value>The num slots open.</value>
        public int NumSlotsOpen { get { return GetMember<int>("NumSlotsOpen"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="Item"/> is full.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="Item"/> is full; otherwise, <c>false</c>.
        /// </value>
        public bool IsFull { get { return GetMember<bool>("IsFull"); } }

        /// <summary>
        /// Gets the keyword1 of this <see cref="Item"/>.
        /// </summary>
        /// <value>The keyword1.</value>
        public string Keyword1 { get { return GetMember<string>("Keyword1"); } }

        /// <summary>
        /// Gets the keyword2 of this <see cref="Item"/>.
        /// </summary>
        /// <value>The keyword2.</value>
        public string Keyword2 { get { return GetMember<string>("Keyword2"); } }

        /// <summary>
        /// Gets the current DMG of this <see cref="Item"/>.
        /// </summary>
        /// <value>The current DMG.</value>
        public int CurrentDmg { get { return GetMember<int>("CurrentDmg"); } }

        /// <summary>
        /// Gets the default DMG of this <see cref="Item"/>.
        /// </summary>
        /// <value>The default DMG.</value>
        public int DefaultDmg { get { return GetMember<int>("DefaultDmg"); } }

        /// <summary>
        /// Gets the speed of this <see cref="Item"/>.
        /// </summary>
        /// <value>The speed.</value>
        public float Speed { get { return GetMember<float>("Speed"); } }

        /// <summary>
        /// Gets the type of the armor.
        /// </summary>
        /// <value>The type of the armor.</value>
        public string ArmorType { get { return GetMember<string>("ArmorType"); } }

        /// <summary>
        /// Gets the armor class mod of this <see cref="Item"/>.
        /// </summary>
        /// <value>The armor class mod.</value>
        public int ArmorClassMod { get { return GetMember<int>("ArmorClassMod"); } }

        /// <summary>
        /// Gets the armor class mod max of this <see cref="Item"/>.
        /// </summary>
        /// <value>The armor class mod max.</value>
        public int ArmorClassModMax { get { return GetMember<int>("ArmorClassModMax"); } }

        /// <summary>
        /// Gets the type of the ranged weapon.
        /// </summary>
        /// <value>The type of the ranged weapon.</value>
        public string RangedWeaponType { get { return GetMember<string>("RangedWeaponType"); } }

        /// <summary>
        /// Gets the num modifiers of this <see cref="Item"/>.
        /// </summary>
        /// <value>The num modifiers.</value>
        public int NumModifiers { get { return GetMember<int>("NumModifiers"); } }

        /// <summary>
        /// Gets the flags of this <see cref="Item"/>.
        /// </summary>
        /// <value>The flags.</value>
        public string Flags { get { return GetMember<string>("Flags"); } }

        /// <summary>
        /// Gets the quantity of this <see cref="Item"/>.
        /// </summary>
        /// <value>The quantity.</value>
        public int Quantity { get { return GetMember<int>("Quantity"); } }

        /// <summary>
        /// Gets the index of this <see cref="Item"/>.
        /// </summary>
        /// <value>The index.</value>
        public int Index { get { return GetMember<int>("Index"); } }

        /// <summary>
        /// Gets the icon ID of this <see cref="Item"/>.
        /// </summary>
        /// <value>The icon ID.</value>
        public int IconID { get { return GetMember<int>("IconID"); } }

        /// <summary>
        /// This will produce a string similar to "452977:1902723122::0,0,1".  You can then use that with the vg command "/itemlinkrequest".  
        /// </summary>
        public string Link { get { return GetMember<string>("Link"); } }

        /// <summary>
        /// Gets this <see cref="Item"/> as a link.
        /// </summary>
        /// <returns></returns>
        public string ToLink()
        {
            return GetMember<string>("ToLink");
        }

        /// <summary>
        /// Gets this <see cref="Item"/> as a link.
        /// </summary>
        /// <param name="CustomName">Name of the custom.</param>
        /// <returns></returns>
        public string ToLink(string CustomName)
        {
            return GetMember<string>("ToLink", CustomName);
        }

        /// <summary>
        /// Modifiers the specified modifier number.
        /// </summary>
        /// <param name="ModifierNumber">The modifier number.</param>
        /// <returns></returns>
        public ItemModifier Modifier(int ModifierNumber)
        {
            LavishScriptObject Obj = GetMember("Modifier", ModifierNumber.ToString());
            return new ItemModifier(Obj);
        }

        /// <summary>
        /// Modifiers the specified modifier name.
        /// </summary>
        /// <param name="ModifierName">Name of the modifier.</param>
        /// <returns></returns>
        public ItemModifier Modifier(string ModifierName)
        {
            LavishScriptObject Obj = GetMember("Modifier", ModifierName);
            return new ItemModifier(Obj);
        }

        /// <summary>
        /// Same as Loot but DOES ask for 'no drop' confirmation 
        /// </summary>
        /// <returns></returns>
        public bool LootNDC()
        {
            return ExecuteMethod("Loot", "NDC");
        }

        /// <summary>
        /// Loots the item from a "loot window" without asking for 'no drop' confirmation 
        /// </summary>
        /// <returns></returns>
        public bool Loot()
        {
            return ExecuteMethod("Loot");
        }

        /// <summary>
        /// Uses this <see cref="Item"/>.
        /// </summary>
        /// <returns></returns>
        public bool Use()
        {
            return ExecuteMethod("Use");
        }

        /// <summary>
        /// Equips an item without prompting for "no drop on equip" confirmation 
        /// </summary>
        /// <returns></returns>
        public bool Equip()
        {
            return ExecuteMethod("Equip");
        }

        /// <summary>
        /// Asks for confirmation on "no drop on equip" confirmation 
        /// </summary>
        /// <returns></returns>
        public bool EquipNDC()
        {
            return ExecuteMethod("Equip", "NDC");
        }

        /// <summary>
        /// Unequips this <see cref="Item"/>.
        /// </summary>
        /// <returns></returns>
        public bool Unequip()
        {
            return ExecuteMethod("Unequip");
        }

        /// <summary>
        /// Moves to general inventory.
        /// Only works for items that are currently in a container 
        /// </summary>
        /// <returns></returns>
        public bool MoveToGeneralInventory()
        {
            return ExecuteMethod("MoveToGeneralInventory");
        }

        /// <summary>
        /// Starts the convert.
        /// </summary>
        /// <returns></returns>
        public bool StartConvert()
        {
            return ExecuteMethod("StartConvert");
        }

        /// <summary>
        /// Splits the specified quantity.
        /// The number provided should be the quantity you want the new stack to be. 
        /// In other words, if you have a stack of 20 barbed timber, then issuing this command: 
        /// Me.Inventory[barbed timber]:Split[5] will create a new stack of 5 timber and leave your original stack with 15. 
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        /// <returns></returns>
        public bool Split(int quantity)
        {
            return ExecuteMethod("Split", quantity.ToString());
        }

        /// <summary>
        /// Deletes item if it's a non-stackable, or one item off of a stack. 
        /// </summary>
        /// <returns></returns>
        public bool Delete()
        {
            return ExecuteMethod("Delete");
        }

        /// <summary>
        /// Deletes item if it's a non-stackable, or the ENTIRE stack. 
        /// </summary>
        /// <param name="all">All.</param>
        /// <returns></returns>
        public bool Delete(string all)
        {
            return ExecuteMethod("Delete", all);
        }

        /// <summary>
        /// Combine stack with item of Index # 
        /// </summary>
        /// <param name="StackWith">Number of items to stack.</param>
        /// <returns></returns>
        public bool StackWith(int StackWith)
        {
            return ExecuteMethod("StackWith", StackWith.ToString());
        }

        /// <summary>
        /// add this item to your trade window.
        /// </summary>
        /// <param name="Qty">The quantity of items to add.</param>
        /// <returns></returns>
        public bool OfferInTrade(int Qty)
        {
            return ExecuteMethod("OfferInTrade", Qty.ToString());
        }

        /// <summary>
        /// add this item to your trade window (quanity: 1) 
        /// </summary>
        /// <returns></returns>
        public bool OfferInTrade()
        {
            return ExecuteMethod("OfferInTrade");
        }

        /// <summary>
        /// Place in the container with an Index of # 
        /// </summary>
        /// <param name="ContainerIndex">Index of the container.</param>
        /// <returns></returns>
        public bool PutInContainer(int ContainerIndex)
        {
            return ExecuteMethod("PutInContainer", ContainerIndex.ToString());
        }

        /// <summary>
        /// Puts the in.
        /// </summary>
        /// <param name="ContainerIndex">Index of the container.</param>
        /// <returns></returns>
        public bool PutIn(int ContainerIndex)
        {
            return ExecuteMethod("PutIn", ContainerIndex.ToString());
        }

        /// <summary>
        /// Buys this <see cref="Item"/>.
        /// </summary>
        /// <returns></returns>
        public bool Buy()
        {
            return ExecuteMethod("Buy");
        }

        /// <summary>
        /// Buys the specified num stacks.
        /// </summary>
        /// <param name="NumStacks">The num stacks.</param>
        /// <returns></returns>
        public bool Buy(int NumStacks)
        {
            return ExecuteMethod("Buy", NumStacks.ToString());
        }

        /// <summary>
        /// Sells this <see cref="Item"/>.
        /// </summary>
        /// <returns></returns>
        public bool Sell()
        {
            return ExecuteMethod("Sell");
        }

        /// <summary>
        /// Sells the specified qty in A stack.
        /// </summary>
        /// <param name="QtyInAStack">The qty in A stack.</param>
        /// <returns></returns>
        public bool Sell(int QtyInAStack)
        {
            return ExecuteMethod("Sell", QtyInAStack.ToString());
        }

        /// <summary>
        /// Attaches to mail.
        /// </summary>
        /// <returns></returns>
        public bool AttachToMail()
        {
            return ExecuteMethod("AttachToMail");
        }

        /// <summary>
        /// Adds to consignment.
        /// </summary>
        /// <returns></returns>
        public bool AddToConsignment()
        {
            return ExecuteMethod("AddToConsignment");
        }
    }
}