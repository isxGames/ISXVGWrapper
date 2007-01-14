using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class ISXVGAbility
    {
        public ISXVGAbility()
        {
        }

        public ISXVGAbility(string tlo)
        {
            TLO = tlo;
        }

        public ISXVGAbility(int tlo)
        {
            TLO = tlo.ToString();
        }

        private string _tlo;
        protected string TLO
        {
            get
            {
                return _tlo;
            }
            set
            {
                _tlo = value;
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

        private int _specialPointsCostPerSec;
        public int SpecialPointsCostPerSec
        {
            get
            {
                GetData<int>(ref _specialPointsCostPerSec, "SpecialPointsCostPerSec");
                return _specialPointsCostPerSec;
            }
        }

        private int _phenomenaPointsCost;
        public int PhenomenaPointsCost
        {
            get
            {
                GetData<int>(ref _phenomenaPointsCost, "PhenomenaPointsCost");
                return _phenomenaPointsCost;
            }
        }

        private int _phenomenaPointsCostPerSec;
        public int PhenomenaPointsCostPerSec
        {
            get
            {
                GetData<int>(ref _phenomenaPointsCostPerSec, "PhenomenaPointsCostPerSec");
                return _phenomenaPointsCostPerSec;
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

        private int _virtuePointsCostPerSec;
        public int VirtuePointsCostPerSec
        {
            get
            {
                GetData<int>(ref _virtuePointsCostPerSec, "VirtuePointsCostPerSec");
                return _virtuePointsCostPerSec;
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

        private int _jinCostPerSec;
        public int JinCostPerSec
        {
            get
            {
                GetData<int>(ref _jinCostPerSec, "JinCostPerSec");
                return _jinCostPerSec;
            }
        }

        private float _timeRemaining;
        public float TimeRemaining
        {
            get
            {
                GetData<float>(ref _timeRemaining, "TimeRemaining");
                return _timeRemaining;
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

        private bool _targetInRange;
        public bool TargetInRange
        {
            get
            {
                GetData<bool>(ref _targetInRange, "TargetInRange");
                return _targetInRange;
            }
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
                GetData<string>(ref _description, "Description");
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

        private int _energyCost;
        public int EnergyCost
        {
            get
            {
                GetData<int>(ref _energyCost, "EnergyCost");
                return _energyCost;
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

        private int _healthCost;
        public int HealthCost
        {
            get
            {
                GetData<int>(ref _healthCost, "HealthCost");
                return _healthCost;
            }
        }

        private int _healthCostPerSec;
        public int HealthCostPerSec
        {
            get
            {
                GetData<int>(ref _healthCostPerSec, "HealthCostPerSec");
                return _healthCostPerSec;
            }
        }

        private int _energyCostPerSec;
        public int EnergyCostPerSec
        {
            get
            {
                GetData<int>(ref _energyCostPerSec, "EnergyCostPerSec");
                return _energyCostPerSec;
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

        private int _enduranceCostPerSec;
        public int EnduranceCostPerSec
        {
            get
            {
                GetData<int>(ref _enduranceCostPerSec, "EnduranceCostPerSec");
                return _enduranceCostPerSec;
            }
        }

        public void Use()
        {
            LavishScript.ExecuteCommand(TLO + ":Use");
        }

        protected void GetData<T>(ref T obj, string param)
        {
            try
            {
                LavishScript.DataParse<T>("${" + TLO + "." + param + "}", ref obj);
            }
            catch
            {
                InnerSpace.Echo("Exception Raised");
            }
        }
    }
}
