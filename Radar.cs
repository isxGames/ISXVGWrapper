using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    /// <summary>
    /// 
    /// </summary>
    public class Radar : LavishScriptPersistentObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Radar"/> class.
        /// </summary>
        /// <param name="Obj">The obj.</param>
        public Radar(LavishScriptPersistentObject Obj)
            : base(Obj) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="Radar"/> class.
        /// </summary>
        /// <param name="Args">The args.</param>
        public Radar(params string[] Args)
            : base(LavishScript.Objects.GetPersistentObject("Radar", Args)) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="Radar"/> class.
        /// </summary>
        /// <param name="Index">The index.</param>
        public Radar(int Index)
            : base(LavishScript.Objects.GetPersistentObject("Radar", Index.ToString())) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="Radar"/> class.
        /// </summary>
        public Radar()
            : base(LavishScript.Objects.GetPersistentObject("Radar", "1")) {}

        /// <summary>
        /// Gets a value indicating whether [showing me].
        /// </summary>
        /// <value><c>true</c> if [showing me]; otherwise, <c>false</c>.</value>
        public bool ShowingMe { get { return GetMember<bool>("ShowingMe"); } }

        /// <summary>
        /// Gets a value indicating whether [showing NP cs].
        /// </summary>
        /// <value><c>true</c> if [showing NP cs]; otherwise, <c>false</c>.</value>
        public bool ShowingNPCs { get { return GetMember<bool>("ShowingNPCs"); } }

        /// <summary>
        /// Gets a value indicating whether [showing P cs].
        /// </summary>
        /// <value><c>true</c> if [showing P cs]; otherwise, <c>false</c>.</value>
        public bool ShowingPCs { get { return GetMember<bool>("ShowingPCs"); } }

        /// <summary>
        /// Gets a value indicating whether [showing specials].
        /// </summary>
        /// <value><c>true</c> if [showing specials]; otherwise, <c>false</c>.</value>
        public bool ShowingSpecials { get { return GetMember<bool>("ShowingSpecials"); } }

        /// <summary>
        /// Gets a value indicating whether [showing resources].
        /// </summary>
        /// <value><c>true</c> if [showing resources]; otherwise, <c>false</c>.</value>
        public bool ShowingResources { get { return GetMember<bool>("ShowingResources"); } }

        /// <summary>
        /// Gets a value indicating whether [showing merchants].
        /// </summary>
        /// <value><c>true</c> if [showing merchants]; otherwise, <c>false</c>.</value>
        public bool ShowingMerchants { get { return GetMember<bool>("ShowingMerchants"); } }

        /// <summary>
        /// Gets a value indicating whether [showing corpses].
        /// </summary>
        /// <value><c>true</c> if [showing corpses]; otherwise, <c>false</c>.</value>
        public bool ShowingCorpses { get { return GetMember<bool>("ShowingCorpses"); } }

        /// <summary>
        /// Gets a value indicating whether [showing crafting stations].
        /// </summary>
        /// <value>
        /// 	<c>true</c> if [showing crafting stations]; otherwise, <c>false</c>.
        /// </value>
        public bool ShowingCraftingStations { get { return GetMember<bool>("ShowingCraftingStations"); } }

        /// <summary>
        /// Gets a value indicating whether [showing trainers].
        /// </summary>
        /// <value><c>true</c> if [showing trainers]; otherwise, <c>false</c>.</value>
        public bool ShowingTrainers { get { return GetMember<bool>("ShowingTrainers"); } }

        /// <summary>
        /// Gets a value indicating whether [showing group members].
        /// </summary>
        /// <value><c>true</c> if [showing group members]; otherwise, <c>false</c>.</value>
        public bool ShowingGroupMembers { get { return GetMember<bool>("ShowingGroupMembers"); } }

        /// <summary>
        /// Gets a value indicating whether [showing aggro NP cs].
        /// </summary>
        /// <value><c>true</c> if [showing aggro NP cs]; otherwise, <c>false</c>.</value>
        public bool ShowingAggroNPCs { get { return GetMember<bool>("ShowingAggroNPCs"); } }

        /// <summary>
        /// Gets a value indicating whether [showing named NP cs].
        /// </summary>
        /// <value><c>true</c> if [showing named NP cs]; otherwise, <c>false</c>.</value>
        public bool ShowingNamedNPCs { get { return GetMember<bool>("ShowingNamedNPCs"); } }

        /// <summary>
        /// Gets a value indicating whether [showing pets].
        /// </summary>
        /// <value><c>true</c> if [showing pets]; otherwise, <c>false</c>.</value>
        public bool ShowingPets { get { return GetMember<bool>("ShowingPets"); } }

        /// <summary>
        /// Gets a value indicating whether [showing my pet].
        /// </summary>
        /// <value><c>true</c> if [showing my pet]; otherwise, <c>false</c>.</value>
        public bool ShowingMyPet { get { return GetMember<bool>("ShowingMyPet"); } }

        /// <summary>
        /// Gets the size of this <see cref="Radar"/>.
        /// </summary>
        /// <value>The size.</value>
        public int Size { get { return GetMember<int>("Size"); } }

        /// <summary>
        /// Gets a value indicating whether [showing labels].
        /// </summary>
        /// <value><c>true</c> if [showing labels]; otherwise, <c>false</c>.</value>
        public bool ShowingLabels { get { return GetMember<bool>("ShowingLabels"); } }

        /// <summary>
        /// Gets a value indicating whether [Z axis clipping on].
        /// </summary>
        /// <value><c>true</c> if [Z axis clipping on]; otherwise, <c>false</c>.</value>
        public bool ZAxisClippingOn { get { return GetMember<bool>("ZAxisClippingOn"); } }

        /// <summary>
        /// Gets a value indicating whether [clip radius on].
        /// </summary>
        /// <value><c>true</c> if [clip radius on]; otherwise, <c>false</c>.</value>
        public bool ClipRadiusOn { get { return GetMember<bool>("ClipRadiusOn"); } }

        /// <summary>
        /// Gets a value indicating whether [clipping text on].
        /// </summary>
        /// <value><c>true</c> if [clipping text on]; otherwise, <c>false</c>.</value>
        public bool ClippingTextOn { get { return GetMember<bool>("ClippingTextOn"); } }

        /// <summary>
        /// Gets a value indicating whether [rotation on].
        /// </summary>
        /// <value><c>true</c> if [rotation on]; otherwise, <c>false</c>.</value>
        public bool RotationOn { get { return GetMember<bool>("RotationOn"); } }

        /// <summary>
        /// Gets the name of this <see cref="Radar"/>.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get { return GetMember<string>("Name"); } }

        /// <summary>
        /// Gets a value indicating whether [showing clickables].
        /// </summary>
        /// <value><c>true</c> if [showing clickables]; otherwise, <c>false</c>.</value>
        public bool ShowingClickables { get { return GetMember<bool>("ShowingClickables"); } }

        /// <summary>
        /// Gets a value indicating whether [showing quest NP cs].
        /// </summary>
        /// <value><c>true</c> if [showing quest NP cs]; otherwise, <c>false</c>.</value>
        public bool ShowingQuestNPCs { get { return GetMember<bool>("ShowingQuestNPCs"); } }

        /// <summary>
        /// Gets the num custom filters of this <see cref="Radar"/>.
        /// </summary>
        /// <value>The num custom filters.</value>
        public int NumCustomFilters { get { return GetMember<int>("NumCustomFilters"); } }

        /// <summary>
        /// Gets the custom filter of this <see cref="Radar"/>.
        /// </summary>
        /// <value>The custom filter.</value>
        public string CustomFilter { get { return GetMember<string>("CustomFilter"); } }

        /// <summary>
        /// Gets the custom filter list of this <see cref="Radar"/>.
        /// </summary>
        /// <value>The custom filter list.</value>
        public string CustomFilterList { get { return GetMember<string>("CustomFilterList"); } }

        /// <summary>
        /// Gets a value indicating whether [showing mailboxes].
        /// </summary>
        /// <value><c>true</c> if [showing mailboxes]; otherwise, <c>false</c>.</value>
        public bool ShowingMailboxes { get { return GetMember<bool>("ShowingMailboxes"); } }

        /// <summary>
        /// Gets a value indicating whether [showing assembly stations].
        /// </summary>
        /// <value>
        /// 	<c>true</c> if [showing assembly stations]; otherwise, <c>false</c>.
        /// </value>
        public bool ShowingAssemblyStations { get { return GetMember<bool>("ShowingAssemblyStations"); } }

        /// <summary>
        /// Gets a value indicating whether [showing taskmasters].
        /// </summary>
        /// <value><c>true</c> if [showing taskmasters]; otherwise, <c>false</c>.</value>
        public bool ShowingTaskmasters { get { return GetMember<bool>("ShowingTaskmasters"); } }

        /// <summary>
        /// Gets a value indicating whether [showing bankers].
        /// </summary>
        /// <value><c>true</c> if [showing bankers]; otherwise, <c>false</c>.</value>
        public bool ShowingBankers { get { return GetMember<bool>("ShowingBankers"); } }

        /// <summary>
        /// Gets a value indicating whether [showing brokers].
        /// </summary>
        /// <value><c>true</c> if [showing brokers]; otherwise, <c>false</c>.</value>
        public bool ShowingBrokers { get { return GetMember<bool>("ShowingBrokers"); } }

        /// <summary>
        /// Gets a value indicating whether [showing altars].
        /// </summary>
        /// <value><c>true</c> if [showing altars]; otherwise, <c>false</c>.</value>
        public bool ShowingAltars { get { return GetMember<bool>("ShowingAltars"); } }

        /// <summary>
        /// Filters me.
        /// </summary>
        /// <returns></returns>
        public bool FilterMe()
        {
            return ExecuteMethod("FilterMe");
        }

        /// <summary>
        /// Filters the NP cs.
        /// </summary>
        /// <returns></returns>
        public bool FilterNPCs()
        {
            return ExecuteMethod("FilterNPCs");
        }

        /// <summary>
        /// Filters the P cs.
        /// </summary>
        /// <returns></returns>
        public bool FilterPCs()
        {
            return ExecuteMethod("FilterPCs");
        }

        /// <summary>
        /// Filters the specials.
        /// </summary>
        /// <returns></returns>
        public bool FilterSpecials()
        {
            return ExecuteMethod("FilterSpecials");
        }

        /// <summary>
        /// Filters the resources.
        /// </summary>
        /// <returns></returns>
        public bool FilterResources()
        {
            return ExecuteMethod("FilterResources");
        }

        /// <summary>
        /// Filters the merchants.
        /// </summary>
        /// <returns></returns>
        public bool FilterMerchants()
        {
            return ExecuteMethod("FilterMerchants");
        }

        /// <summary>
        /// Filters the corpses.
        /// </summary>
        /// <returns></returns>
        public bool FilterCorpses()
        {
            return ExecuteMethod("FilterCorpses");
        }

        /// <summary>
        /// Filters the crafting stations.
        /// </summary>
        /// <returns></returns>
        public bool FilterCraftingStations()
        {
            return ExecuteMethod("FilterCraftingStations");
        }

        /// <summary>
        /// Filters the trainers.
        /// </summary>
        /// <returns></returns>
        public bool FilterTrainers()
        {
            return ExecuteMethod("FilterTrainers");
        }

        /// <summary>
        /// Filters the group members.
        /// </summary>
        /// <returns></returns>
        public bool FilterGroupMembers()
        {
            return ExecuteMethod("FilterGroupMembers");
        }

        /// <summary>
        /// Filters the aggro NP cs.
        /// </summary>
        /// <returns></returns>
        public bool FilterAggroNPCs()
        {
            return ExecuteMethod("FilterAggroNPCs");
        }

        /// <summary>
        /// Filters the named NP cs.
        /// </summary>
        /// <returns></returns>
        public bool FilterNamedNPCs()
        {
            return ExecuteMethod("FilterNamedNPCs");
        }

        /// <summary>
        /// Filters the pets.
        /// </summary>
        /// <returns></returns>
        public bool FilterPets()
        {
            return ExecuteMethod("FilterPets");
        }

        /// <summary>
        /// Filters my pet.
        /// </summary>
        /// <returns></returns>
        public bool FilterMyPet()
        {
            return ExecuteMethod("FilterMyPet");
        }

        /// <summary>
        /// Sets the size.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <returns></returns>
        public bool SetSize(int size)
        {
            return ExecuteMethod("SetSize", size.ToString());
        }

        /// <summary>
        /// Shows the labels.
        /// </summary>
        /// <returns></returns>
        public bool ShowLabels()
        {
            return ExecuteMethod("ShowLabels");
        }

        /// <summary>
        /// Zs the axis clipping.
        /// </summary>
        /// <returns></returns>
        public bool ZAxisClipping()
        {
            return ExecuteMethod("ZAxisClipping");
        }

        /// <summary>
        /// Clips the text.
        /// </summary>
        /// <returns></returns>
        public bool ClipText()
        {
            return ExecuteMethod("ClipText");
        }

        /// <summary>
        /// Clips the radius.
        /// </summary>
        /// <param name="ClipRadius">The clip radius.</param>
        /// <returns></returns>
        public bool ClipRadius(int ClipRadius)
        {
            return ExecuteMethod("ClipRadius", ClipRadius.ToString());
        }

        /// <summary>
        /// Rotations this <see cref="Radar"/>.
        /// </summary>
        /// <returns></returns>
        public bool Rotation()
        {
            return ExecuteMethod("Rotation");
        }

        /// <summary>
        /// Sets the custom filter.
        /// </summary>
        /// <param name="Text">The text.</param>
        /// <returns></returns>
        public bool SetCustomFilter(string Text)
        {
            return ExecuteMethod("SetCustomFilter", Text);
        }

        /// <summary>
        /// Zooms the in.
        /// </summary>
        /// <returns></returns>
        public bool ZoomIn()
        {
            return ExecuteMethod("ZoomIn");
        }

        /// <summary>
        /// Zooms the out.
        /// </summary>
        /// <returns></returns>
        public bool ZoomOut()
        {
            return ExecuteMethod("ZoomOut");
        }

        /// <summary>
        /// Filters the clickables.
        /// </summary>
        /// <returns></returns>
        public bool FilterClickables()
        {
            return ExecuteMethod("FilterClickables");
        }

        /// <summary>
        /// Filters the quest NP cs.
        /// </summary>
        /// <returns></returns>
        public bool FilterQuestNPCs()
        {
            return ExecuteMethod("FilterQuestNPCs");
        }

        /// <summary>
        /// Filters the mailboxes.
        /// </summary>
        /// <returns></returns>
        public bool FilterMailboxes()
        {
            return ExecuteMethod("FilterMailboxes");
        }

        /// <summary>
        /// Filters the assembly stations.
        /// </summary>
        /// <returns></returns>
        public bool FilterAssemblyStations()
        {
            return ExecuteMethod("FilterAssemblyStations");
        }

        /// <summary>
        /// Filters the taskmasters.
        /// </summary>
        /// <returns></returns>
        public bool FilterTaskmasters()
        {
            return ExecuteMethod("FilterTaskmasters");
        }

        /// <summary>
        /// Filters the bankers.
        /// </summary>
        /// <returns></returns>
        public bool FilterBankers()
        {
            return ExecuteMethod("FilterBankers");
        }

        /// <summary>
        /// Filters the brokers.
        /// </summary>
        /// <returns></returns>
        public bool FilterBrokers()
        {
            return ExecuteMethod("FilterBrokers");
        }

        /// <summary>
        /// Filters the altars.
        /// </summary>
        /// <returns></returns>
        public bool FilterAltars()
        {
            return ExecuteMethod("FilterAltars");
        }
    }
}