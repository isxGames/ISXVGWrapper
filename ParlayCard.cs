using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class ParlayCard : LavishScriptObject
    {
        public ParlayCard()
            :
                base(LavishScript.Objects.GetObject("ParlayCard")) {}

        public ParlayCard(LavishScriptObject Copy)
            :
                base(Copy) {}

        public string Name { get { return GetMember<string>("Name"); } }

        public int ID { get { return GetMember<int>("ID"); } }

        public int RefreshRangeLower { get { return GetMember<int>("RefreshRangeLower"); } }

        public int RefreshRangeUpper { get { return GetMember<int>("RefreshRangeUpper"); } }

        public int RoundsToRefresh { get { return GetMember<int>("RoundsToRefresh"); } }

        public int Influence { get { return GetMember<int>("Influence"); } }

        public int ReasonCost { get { return GetMember<int>("ReasonCost"); } }

        public int InspireCost { get { return GetMember<int>("InspireCost"); } }

        public int FlatterCost { get { return GetMember<int>("FlatterCost"); } }

        public int DemandCost { get { return GetMember<int>("DemandCost"); } }

        public int ReasonGained { get { return GetMember<int>("ReasonGained"); } }

        public int ReasonGiven { get { return GetMember<int>("ReasonGiven"); } }

        public int InspireGained { get { return GetMember<int>("InspireGained"); } }

        public int InspireGiven { get { return GetMember<int>("InspireGiven"); } }

        public int FlatterGained { get { return GetMember<int>("FlatterGained"); } }

        public int FlatterGiven { get { return GetMember<int>("FlatterGiven"); } }

        public int DemandGained { get { return GetMember<int>("DemandGained"); } }

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