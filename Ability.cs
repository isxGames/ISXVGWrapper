using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class Ability
    {
        private string _AbilityName;

        public Ability(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public Ability()
        {
        }
        
        public Ability(string AbilityName)
        {
            return new Ability 
        }

        private string _name;
        public string Name
        {
            get
            {
                GetData<string>(ref _name, "Name");
                return _name;
            }
        }

        private string _description;
        public string Description
        {
            get
            {
                GetData<string>(ref _descirption, "Description");
                return _description;
            }
        }

        private float _castTime;
        public float CastTime
        {
            get
            {
                GetData<float>(ref _castTime, "CastTime");
                return _castTime;
            }
        }

        private float _recoveryTime;
        public float RecoveryTime
        {
            get
            {
                GetData<float>(ref _recoveryTime, "RecoveryTime");
                return _recoveryTime;
            }
        }

        private int _range;
        public int Range
        {
            get
            {
                GetData<int>(ref _range, "Range");
                return _range;
            }
        }
        
        private int _healthCost;
        public int HealthCost
        {
            get
            {
                GetData<int>(ref _healthCost, "HealthCost");
                return _healthCost;
            }
        }

        private int _healthCostPerSecond;
        public int HealthCostPerSecond
        {
            get
            {
                GetData<int>(ref _healthCostPerSec, "HealthCostPerSecond");
                return _healthCostPerSecond;
            }
        }

        private int _energyCost;
        public int EnergyCost
        {
            get
            {
                GetData<int>(ref _energyCost, "EnergyCost");
                return _engergyCost;
            }
        }

        private int _energyCostPerSecond;
        public int EnergyCostPerSecond
        {
            get
            {
                GetData<int>(ref _energyCostPerSecond, "EnergyCostPerSecond");
                return _energyCostPerSecond;
            }
        }

        private int _enduranceCost;
        public int EnduranceCost
        {
            get
            {
                GetData<int>(ref _enduranceCost, "EnduranceCost");
                return _enduranceCost;
            }
        }

        private int _enduranceCostPerSecond;
        public int EnduranceCostPerSecond
        {
            get
            {
                GetData<int>(ref _enduranceCostPerSecond, "EnduranceCostPerSecond");
                return _enduranceCostPerSecond;
            }
        }

        private float _timeRemaining;
        public float TimeRemaining
        {
            get
            {
                GetData<flaot>(ref _timeRemaining, "TimeRemaining");
                return _timeRemaining;
            }
        }

        private bool _toggled;
        public bool Toggled
        {
            get
            {
                GetData<bool>(ref _toggled, "Toggled");
                return _toggled;
            }
        }

        private bool _targetInRange;
        public bool TargetInRange
        {
            get
            {
                GetData<string>(ref _targetInRange, "TargetInRange");
                return _targetInRange;
            }
        }

        private bool _isReady;
        public bool IsReady
        {
            get
            {
                GetData<bool>(ref _isReady, "IsReady");
                return _isReady;
            }
        }

        private int _specialPointsCost;
        public int SpecialPointsCost
        {
            get
            {
                GetData<int>(ref _specialPointsCost, "SpecialPointsCost");
                return _specialPointsCost;
            }
        }
        private int _specialPointsCostPerSecond;
        public int SpecialPointsCostPerSecond
        {
            get
            {
                GetData<int>(ref _specialPointsCostPerSecond, "SpecialPointsCostPerSecond");
                return _specialPointsCostPerSecond;
            }
        }

        private int _phenomenaPointsCost;
        public int PhenomenaPointsCost
        {
            get
            {
                GetData<int>(ref _pheonmenaPointsCost, "PhenomenaPointsCost");
                return _phenomenaPointsCost;
            }
        }

        private int _phenomenaPointsCostPerSecond;
        public int PhenomenaPointsCostPerSecond
        {
            get
            {
                GetData<int>(ref _phenomenaPointsCostPersecond, "PhenomenaPointsCostPerSecond");
                return _phenomenaPointsCostPerSecond;
            }
        }

        private int _virtuePointsCost;
        public int VirtuePointsCost
        {
            get
            {
                GetData<int>(ref _virtuePointsCost, "VirtuePointsCost");
                return _virtuePointsCost;
            }
        }

        private int _virtuePointsCostPerSecond;
        public int VirtuePointsCostPerSecond
        {
            get
            {
                GetData<int>(ref _virtuePointsCostPerSecond, "VirtuePointsCostPerSecond");
                return _virtuePointsCostPerSecond;
            }
        }

        private int _jinCost;
        public int JinCost
        {
            get
            {
                GetData<int>(ref _jinCost, "JinCost");
                return _jinCost;
            }
        }

        private int _jinCostPerSecond;
        public int JinCostPerSecond
        {
            get
            {
                GetData<int>(ref _jinCostPerSecond, "JinCostPerSecond");
                return _jinCostPerSecond;
            }
        }
        public void Use(string Name)
        {
            LavishScript.ExecuteCommand("Me.Ability[" + AbilityName + "]:Use");
        }

        protected void GetData<T>(ref T obj, string param)
        {
            try
            {
                LavishScript.DataParse<T>("${Me.Ability[" + param + "]}", ref obj);
            }
            catch
            {

            }
        }
    }
}
