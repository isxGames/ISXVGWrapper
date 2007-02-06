using System;
using System.Collections.Generic;
using System.Text;
using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class Parlay : LavishScriptObject
    {

        public Parlay()
            :
            base(LavishScript.Objects.GetObject("Parlay"))
        {
        }

        public Parlay(LavishScriptObject Copy)
            :
            base(Copy)
        {
        }

        public ParlayCard MyCurrentCard()
        {
            LavishScriptObject Obj = GetMember("MyCurrentCard");
            return new ParlayCard(Obj);
        }

        public ParlayCard CurrentOpponentCard()
        {
            LavishScriptObject Obj = GetMember("CurrentOpponentCard");
            return new ParlayCard(Obj);
        }

        public bool IsMyTurn
        {
            get { return GetMember<bool>("IsMyTurn"); }
        }

        public bool IsOpponentTurn
        {
            get { return GetMember<bool>("IsOpponentTurn"); }
        }

        public int Status
        {
            get { return GetMember<int>("Status"); }
        }

        public string OpponentName
        {
            get { return GetMember<string>("OpponentName"); }
        }

        public int Inspire
        {
            get { return GetMember<int>("Inspire"); }
        }

        public int OpponentInspire
        {
            get { return GetMember<int>("OpponentInspire"); }
        }

        public int Reason
        {
            get { return GetMember<int>("Reason"); }
        }

        public int OpponentReason
        {
            get { return GetMember<int>("OpponentReason"); }
        }

        public int Flatter
        {
            get { return GetMember<int>("Flatter"); }
        }

        public int OpponentFlatter
        {
            get { return GetMember<int>("OpponentFlatter"); }
        }

        public int Demand
        {
            get { return GetMember<int>("Demand"); }
        }

        public int OpponentDemand
        {
            get { return GetMember<int>("OpponentDemand"); }
        }
        
        public bool InspireDisabled
        {
            get { return GetMember<bool>("InspireDisabled"); }
        }

        public bool ReasonDisabled
        {
            get { return GetMember<bool>("ReasonDisabled"); }
        }

        public bool FlatterDisabled
        {
            get { return GetMember<bool>("FlatterDisabled"); }
        }

        public bool DemandDisabled
        {
            get { return GetMember<bool>("DemandDisabled"); }
        }

        public int DialogPoints
        {
            get { return GetMember<int>("DialogPoints"); }
        }

        public int OpponentDialogPoints
        {
            get { return GetMember<int>("OpponentDialogPoints"); }
        }

        public bool MyStatementEmpty
        {
            get { return GetMember<bool>("MyStatementEmpty"); }
        }

        public bool OpponentStatementEmpty
        {
            get { return GetMember<bool>("OpponentStatementEmpty"); }
        }

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

        public bool Continue()
        {
            return ExecuteMethod("Continue");
        }

    }
}
