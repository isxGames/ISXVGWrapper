using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class Ability : LavishScriptObject
    {
        public Ability(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public Ability()
            : base(LavishScript.Objects.GetObject("Ability"))
        {
        }

        public string Name
        {
            get
            {
                return GetMember<string>("Name");
            }
        }
        public string Description
        {
            get
            {
                return GetMember<string>("Description");
            }
        }
        public float CastTime
        {
            get
            {
                return GetMember<float>("CastTime");
            }
        }
        public float RecoveryTime
        {
            get
            {
                return GetMember<float>("RecoveryTime");
            }
        }
        public int Range
        {
            get
            {
                return GetMember<int>("Range");
            }
        }
        public string Type
        {
            get
            {
                return GetMember<string>("Type");
            }
        }
        public string SongType
        {
            get
            {
                return GetMember<string>("SongType");
            }
        }
        public string TargetType
        {
            get
            {
                return GetMember<string>("TargetType");
            }
        }
        public bool IsChain
        {
            get
            {
                return GetMember<bool>("IsChain");
            }
        }
        public bool IsCounter
        {
            get
            {
                return GetMember<bool>("IsCounter");
            }
        }
        public bool IsRescue
        {
            get
            {
                return GetMember<bool>("IsRescue");
            }
        }
        public bool IsOffensive
        {
            get
            {
                return GetMember<bool>("IsOffensive");
            }
        }
        public float TriggeredCountdown
        {
            get
            {
                return GetMember<float>("TriggeredCountdown");
            }
        }
        public int LevelGranted
        {
            get
            {
                return GetMember<int>("LevelGranted");
            }
        }
        public int HealthCost
        {
            get
            {
                return GetMember<int>("HealthCost");
            }
        }
        public int HealthCostPerSecond
        {
            get
            {
                return GetMember<int>("HealthCostPerSecond");
            }
        }
        public int EnergyCost
        {
            get
            {
                return GetMember<int>("EnergyCost");
            }
        }
        public int EnergyCostPerSecond
        {
            get
            {
                return GetMember<int>("EnergyCostPerSecond");
            }
        }
        public int EnduranceCost
        {
            get
            {
                return GetMember<int>("EnduranceCost");
            }
        }
        public int EnduranceCostPerSecond
        {
            get
            {
                return GetMember<int>("EnduranceCostPerSecond");
            }
        }
        public float TimeRemaining
        {
            get
            {
                return GetMember<float>("TimeRemaining");
            }
        }
        public bool Toggled
        {
            get
            {
                return GetMember<bool>("Toggled");
            }
        }
        public bool TargetInRange
        {
            get
            {
                return GetMember<bool>("TargetInRange");
            }
        }

        public bool IsReady
        {
            get
            {
                return GetMember<bool>("IsReady");
            }
        }
        public int SpecialPointsCost
        {
            get
            {
                return GetMember<int>("SpecialPointsCost");
            }
        }

        public int SpecialPointsCostPerSecond
        {
            get
            {
                return GetMember<int>("SpecialPointsCostPerSecond");
            }
        }

        public int PhenomenaPointsCost
        {
            get
            {
                return GetMember<int>("PhenomenaPointsCost");
            }
        }

        public int PhenomenaPointsCostPerSecond
        {
            get
            {
                return GetMember<int>("PhenomenaPointsCostPerSecond");
            }
        }

        public int VirtuePointsCost
        {
            get
            {
                return GetMember<int>("VirtuePointsCost");
            }
        }

        public int VirtuePointsCostPerSecond
        {
            get
            {
                return GetMember<int>("VirtuePointsCostPerSecond");
            }
        }

        public int JinCost
        {
            get
            {
                return GetMember<int>("JinCost");
            }
        }

        public int JinCostPerSecond
        {
            get
            {
                return GetMember<int>("JinCostPerSecond");
            }
        }

        public string School
        {
            get
            {
                return GetMember<string>("School");
            }
        }

        public int BloodUnionRequired
        {
            get
            {
                return GetMember<int>("BloodUnionRequired");
            }
        }

        public string Requirements
        {
            get
            {
                return GetMember<string>("Requirements");
            }
        }

        public string Restrictions
        {
            get
            {
                return GetMember<string>("Restrictions");
            }
        }

        public bool Use()
        {
            return ExecuteMethod("Use"); 
        }
    }
}
