using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    /// <summary>
    /// 
    /// </summary>
    public class ParlayCard : LavishScriptObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParlayCard"/> class.
        /// </summary>
        public ParlayCard()
            :
                base(LavishScript.Objects.GetObject("ParlayCard")) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="ParlayCard"/> class.
        /// </summary>
        /// <param name="Copy">The copy.</param>
        public ParlayCard(LavishScriptObject Copy)
            :
                base(Copy) {}

        /// <summary>
        /// Gets the name of this <see cref="ParlayCard"/>.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get { return GetMember<string>("Name"); } }

        /// <summary>
        /// Gets the ID of this <see cref="ParlayCard"/>.
        /// </summary>
        /// <value>The ID.</value>
        public int ID { get { return GetMember<int>("ID"); } }

        /// <summary>
        /// Gets the refresh range lower of this <see cref="ParlayCard"/>.
        /// </summary>
        /// <value>The refresh range lower.</value>
        public int RefreshRangeLower { get { return GetMember<int>("RefreshRangeLower"); } }

        /// <summary>
        /// Gets the refresh range upper of this <see cref="ParlayCard"/>.
        /// </summary>
        /// <value>The refresh range upper.</value>
        public int RefreshRangeUpper { get { return GetMember<int>("RefreshRangeUpper"); } }

        /// <summary>
        /// Gets the rounds to refresh of this <see cref="ParlayCard"/>.
        /// </summary>
        /// <value>The rounds to refresh.</value>
        public int RoundsToRefresh { get { return GetMember<int>("RoundsToRefresh"); } }

        /// <summary>
        /// Gets the influence of this <see cref="ParlayCard"/>.
        /// </summary>
        /// <value>The influence.</value>
        public int Influence { get { return GetMember<int>("Influence"); } }

        /// <summary>
        /// Gets the reason cost of this <see cref="ParlayCard"/>.
        /// </summary>
        /// <value>The reason cost.</value>
        public int ReasonCost { get { return GetMember<int>("ReasonCost"); } }

        /// <summary>
        /// Gets the inspire cost of this <see cref="ParlayCard"/>.
        /// </summary>
        /// <value>The inspire cost.</value>
        public int InspireCost { get { return GetMember<int>("InspireCost"); } }

        /// <summary>
        /// Gets the flatter cost of this <see cref="ParlayCard"/>.
        /// </summary>
        /// <value>The flatter cost.</value>
        public int FlatterCost { get { return GetMember<int>("FlatterCost"); } }

        /// <summary>
        /// Gets the demand cost of this <see cref="ParlayCard"/>.
        /// </summary>
        /// <value>The demand cost.</value>
        public int DemandCost { get { return GetMember<int>("DemandCost"); } }

        /// <summary>
        /// Gets the reason gained of this <see cref="ParlayCard"/>.
        /// </summary>
        /// <value>The reason gained.</value>
        public int ReasonGained { get { return GetMember<int>("ReasonGained"); } }

        /// <summary>
        /// Gets the reason given of this <see cref="ParlayCard"/>.
        /// </summary>
        /// <value>The reason given.</value>
        public int ReasonGiven { get { return GetMember<int>("ReasonGiven"); } }

        /// <summary>
        /// Gets the inspire gained of this <see cref="ParlayCard"/>.
        /// </summary>
        /// <value>The inspire gained.</value>
        public int InspireGained { get { return GetMember<int>("InspireGained"); } }

        /// <summary>
        /// Gets the inspire given of this <see cref="ParlayCard"/>.
        /// </summary>
        /// <value>The inspire given.</value>
        public int InspireGiven { get { return GetMember<int>("InspireGiven"); } }

        /// <summary>
        /// Gets the flatter gained of this <see cref="ParlayCard"/>.
        /// </summary>
        /// <value>The flatter gained.</value>
        public int FlatterGained { get { return GetMember<int>("FlatterGained"); } }

        /// <summary>
        /// Gets the flatter given of this <see cref="ParlayCard"/>.
        /// </summary>
        /// <value>The flatter given.</value>
        public int FlatterGiven { get { return GetMember<int>("FlatterGiven"); } }

        /// <summary>
        /// Gets the demand gained of this <see cref="ParlayCard"/>.
        /// </summary>
        /// <value>The demand gained.</value>
        public int DemandGained { get { return GetMember<int>("DemandGained"); } }

        /// <summary>
        /// Gets the demand given of this <see cref="ParlayCard"/>.
        /// </summary>
        /// <value>The demand given.</value>
        public int DemandGiven { get { return GetMember<int>("DemandGiven"); } }

        /// <summary>
        /// selects this card to be used as your next statement
        /// </summary>
        /// <returns></returns>
        public bool Select()
        {
            return ExecuteMethod("Select");
        }
    }
}