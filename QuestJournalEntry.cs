using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class QuestJournalEntry : LavishScriptObject
    {
        public QuestJournalEntry(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public QuestJournalEntry()
            : base(LavishScript.Objects.GetObject("QuestJournalEntry"))
        {
        }

        public string Name
        {
            get
            {
                return GetMember<string>("Name");
            }
        }

        public string Desription
        {
            get
            {
                return GetMember<string>("Description");
            }
        }

        public string Objectives
        {
            get
            {
                return GetMember<string>("Objectives");
            }
        }


        public string ObjectivesShort
        {
            get
            {
                return GetMember<string>("ObjectivesShort");
            }
        }

        public int CoinReward
        {
            get
            {
                return GetMember<int>("CoinReward");
            }
        }

        public int Status
        {
            get
            {
                return GetMember<int>("Status");
            }
        }

        public bool IsTracking
        {
            get
            {
                return GetMember<bool>("IsTracking");
            }
        }

        public TravelJournalEntry EndLocation
        {
            get
            {

                LavishScriptObject Obj = GetMember("EndLocation");
                return new TravelJournalEntry(Obj);
            }
        }

        public int WaypointCount
        {
            get
            {
                return GetMember<int>("WaypointCount");
            }
        }

        public TravelJournalEntry Waypoint(string Name)
        {
            LavishScriptObject Obj = GetMember("Waypoint", Name);
            return new TravelJournalEntry(Obj);
        }
        public TravelJournalEntry Waypoint(int Index)
        {
            LavishScriptObject Obj = GetMember("Waypoint", Index.ToString());
            return new TravelJournalEntry(Obj);
        }


        public int RewardGroupCount
        {
            get
            {
                return GetMember<int>("RewardGroupCount");
            }
        }

        public QuestRewardGroup RewardGroup(int Index)
        {
            LavishScriptObject Obj = GetMember("RewardGroup", Index.ToString());
            return new QuestRewardGroup(Obj);
        }

        public bool Track()
        {
            return ExecuteMethod("Track");
        }

        public bool Select()
        {
            return ExecuteMethod("Select");
        }
    }
}
