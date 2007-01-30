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

        public Ability(string AbilityName)
            : base(LavishScript.Objects.GetObject("Ability",AbilityName))
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
        public void Use(string AbilityName)
        {
            LavishScript.ExecuteCommand("Me.Ability[" + AbilityName + "]:Use");
        }
    }
}
