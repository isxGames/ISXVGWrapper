using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    ///<summary>
    ///</summary>
    public class Parlay : LavishScriptObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Parlay"/> class.
        /// </summary>
        public Parlay() : base(LavishScript.Objects.GetObject("Parlay")) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="Parlay"/> class.
        /// </summary>
        /// <param name="Copy">The copy.</param>
        public Parlay(LavishScriptObject Copy) : base(Copy) {}

        /// <summary>
        /// Gets a value indicating whether [in parlay].
        /// </summary>
        /// <value><c>true</c> if [in parlay]; otherwise, <c>false</c>.</value>
        public bool InParlay { get { return (new VG()).IsInParlay; } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="Parlay"/> is my turn.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="Parlay"/> is my turn; otherwise, <c>false</c>.
        /// </value>
        public bool IsMyTurn { get { return GetMember<bool>("IsMyTurn"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="Parlay"/> is opponent turn.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="Parlay"/> is opponent turn; otherwise, <c>false</c>.
        /// </value>
        public bool IsOpponentTurn { get { return GetMember<bool>("IsOpponentTurn"); } }

        /// <summary>
        /// Gets the status of this <see cref="Parlay"/>. Values will be -10 to 10. Zero is the center.
        /// </summary>
        /// <value>The status.</value>
        public int Status { get { return GetMember<int>("Status"); } }

        /// <summary>
        /// Gets the name of the opponent.
        /// </summary>
        /// <value>The name of the opponent.</value>
        public string OpponentName { get { return GetMember<string>("OpponentName"); } }

        /// <summary>
        /// Gets the inspire of this <see cref="Parlay"/>. Values will be multiplied by 10.
        /// </summary>
        /// <value>The inspire.</value>
        public int Inspire { get { return GetMember<int>("Inspire"); } }

        /// <summary>
        /// Gets the opponent inspire of this <see cref="Parlay"/>. Values will be multiplied by 10.
        /// </summary>
        /// <value>The opponent inspire.</value>
        public int OpponentInspire { get { return GetMember<int>("OpponentInspire"); } }

        /// <summary>
        /// Gets the reason of this <see cref="Parlay"/>.
        /// </summary>
        /// <value>The reason.</value>
        public int Reason { get { return GetMember<int>("Reason"); } }

        /// <summary>
        /// Gets the opponent reason of this <see cref="Parlay"/>.
        /// </summary>
        /// <value>The opponent reason.</value>
        public int OpponentReason { get { return GetMember<int>("OpponentReason"); } }

        /// <summary>
        /// Gets the flatter of this <see cref="Parlay"/>.
        /// </summary>
        /// <value>The flatter.</value>
        public int Flatter { get { return GetMember<int>("Flatter"); } }

        /// <summary>
        /// Gets the opponent flatter of this <see cref="Parlay"/>.
        /// </summary>
        /// <value>The opponent flatter.</value>
        public int OpponentFlatter { get { return GetMember<int>("OpponentFlatter"); } }

        /// <summary>
        /// Gets the demand of this <see cref="Parlay"/>.
        /// </summary>
        /// <value>The demand.</value>
        public int Demand { get { return GetMember<int>("Demand"); } }

        /// <summary>
        /// Gets the opponent demand of this <see cref="Parlay"/>.
        /// </summary>
        /// <value>The opponent demand.</value>
        public int OpponentDemand { get { return GetMember<int>("OpponentDemand"); } }

        /// <summary>
        /// Gets a value indicating whether [inspire disabled].
        /// </summary>
        /// <value><c>true</c> if [inspire disabled]; otherwise, <c>false</c>.</value>
        public bool InspireDisabled { get { return GetMember<bool>("InspireDisabled"); } }

        /// <summary>
        /// Gets a value indicating whether [reason disabled].
        /// </summary>
        /// <value><c>true</c> if [reason disabled]; otherwise, <c>false</c>.</value>
        public bool ReasonDisabled { get { return GetMember<bool>("ReasonDisabled"); } }

        /// <summary>
        /// Gets a value indicating whether [flatter disabled].
        /// </summary>
        /// <value><c>true</c> if [flatter disabled]; otherwise, <c>false</c>.</value>
        public bool FlatterDisabled { get { return GetMember<bool>("FlatterDisabled"); } }

        /// <summary>
        /// Gets a value indicating whether [demand disabled].
        /// </summary>
        /// <value><c>true</c> if [demand disabled]; otherwise, <c>false</c>.</value>
        public bool DemandDisabled { get { return GetMember<bool>("DemandDisabled"); } }

        /// <summary>
        /// Gets the dialog points of this <see cref="Parlay"/>.
        /// </summary>
        /// <value>The dialog points.</value>
        public int DialogPoints { get { return GetMember<int>("DialogPoints"); } }

        /// <summary>
        /// Gets the opponent dialog points of this <see cref="Parlay"/>.
        /// </summary>
        /// <value>The opponent dialog points.</value>
        public int OpponentDialogPoints { get { return GetMember<int>("OpponentDialogPoints"); } }

        /// <summary>
        /// Gets a value indicating whether [my statement empty].
        /// </summary>
        /// <value><c>true</c> if [my statement empty]; otherwise, <c>false</c>.</value>
        public bool MyStatementEmpty { get { return GetMember<bool>("MyStatementEmpty"); } }

        /// <summary>
        /// Gets a value indicating whether [opponent statement empty].
        /// </summary>
        /// <value>
        /// 	<c>true</c> if [opponent statement empty]; otherwise, <c>false</c>.
        /// </value>
        public bool OpponentStatementEmpty { get { return GetMember<bool>("OpponentStatementEmpty"); } }

        /// <summary>
        /// Gets my current card.
        /// </summary>
        /// <returns></returns>
        public ParlayCard MyCurrentCard()
        {
            LavishScriptObject Obj = GetMember("MyCurrentCard");
            return new ParlayCard(Obj);
        }

        /// <summary>
        /// Gets my current opponents card.
        /// </summary>
        /// <returns></returns>
        public ParlayCard CurrentOpponentCard()
        {
            LavishScriptObject Obj = GetMember("CurrentOpponentCard");
            return new ParlayCard(Obj);
        }

        /// <summary>
        /// Assesses the target.
        /// </summary>
        /// <returns></returns>
        public bool AssessTarget()
        {
            return ExecuteMethod("AssessTarget");
        }

        /// <summary>
        /// default is 1
        /// </summary>
        /// <param name="Index"></param>
        /// <returns></returns>
        public bool SelectConversation(int Index)
        {
            return ExecuteMethod("SelectConversation", Index.ToString());
        }

        /// <summary>
        /// plays the selected card
        /// </summary>
        /// <returns></returns>
        public bool PlayCard()
        {
            return ExecuteMethod("PlayCard");
        }

        /// <summary>
        /// pass turn
        /// </summary>
        /// <returns></returns>
        public bool Listen()
        {
            return ExecuteMethod("Listen");
        }

        /// <summary>
        /// [end the parlay (ie, similar to clicking on the 'farewell' button in the middle of a parlay)]
        /// </summary>
        /// <returns></returns>
        public bool Farewell()
        {
            return ExecuteMethod("Farewell");
        }

        /// <summary>
        /// Continues this <see cref="Parlay"/>.
        /// </summary>
        /// <returns></returns>
        public bool Continue()
        {
            return ExecuteMethod("Continue");
        }
    }
}