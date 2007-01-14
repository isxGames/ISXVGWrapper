using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class ISXVGRadar
    {
        public ISXVGRadar()
        {
        }

        public ISXVGRadar(string tlo)
        {
            TLO = tlo;
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

        private bool _showingMe;
        public bool ShowingMe
        {
            get
            {
                GetData<bool>(ref _showingMe, "ShowingMe");
                return _showingMe;
            }
        }

        private bool _showingNPCs;
        public bool ShowingNPCs
        {
            get
            {
                GetData<bool>(ref _showingNPCs, "ShowingNPCs");
                return _showingNPCs;
            }
        }

        private bool _showingPCs;
        public bool ShowingPCs
        {
            get
            {
                GetData<bool>(ref _showingPCs, "ShowingPCs");
                return _showingPCs;
            }
        }

        private bool _showingSpecials;
        public bool ShowingSpecials
        {
            get
            {
                GetData<bool>(ref _showingSpecials, "ShowingSpecials");
                return _showingSpecials;
            }
        }

        private bool _showingResources;
        public bool ShowingResources
        {
            get
            {
                GetData<bool>(ref _showingResources, "ShowingResources");
                return _showingResources;
            }
        }

        private bool _showingMerchants;
        public bool ShowingMerchants
        {
            get
            {
                GetData<bool>(ref _showingMerchants, "ShowingMerchants");
                return _showingMerchants;
            }
        }

        private bool _showingCorpses;
        public bool ShowingCorpses
        {
            get
            {
                GetData<bool>(ref _showingCorpses, "ShowingCorpses");
                return _showingCorpses;
            }
        }

        private bool _showingCraftingStations;
        public bool ShowingCraftingStations
        {
            get
            {
                GetData<bool>(ref _showingCraftingStations, "ShowingCraftingStations");
                return _showingCraftingStations;
            }
        }

        private bool _showingTrainers;
        public bool ShowingTrainers
        {
            get
            {
                GetData<bool>(ref _showingTrainers, "ShowingTrainers");
                return _showingTrainers;
            }
        }

        private bool _showingGroupMembers;
        public bool ShowingGroupMembers
        {
            get
            {
                GetData<bool>(ref _showingGroupMembers, "ShowingGroupMembers");
                return _showingGroupMembers;
            }
        }

        private bool _showingAggroNPCs;
        public bool ShowingAggroNPCs
        {
            get
            {
                GetData<bool>(ref _showingAggroNPCs, "ShowingAggroNPCs");
                return _showingAggroNPCs;
            }
        }

        private bool _showingNamedNPCs;
        public bool ShowingNamedNPCs
        {
            get
            {
                GetData<bool>(ref _showingNamedNPCs, "ShowingNamedNPCs");
                return _showingNamedNPCs;
            }
        }

        private bool _showingPets;
        public bool ShowingPets
        {
            get
            {
                GetData<bool>(ref _showingPets, "ShowingPets");
                return _showingPets;
            }
        }

        private bool _showingMyPet;
        public bool ShowingMyPet
        {
            get
            {
                GetData<bool>(ref _showingMyPet, "ShowingMyPet");
                return _showingMyPet;
            }
        }

        private bool _numCustomFilters;
        public bool NumCustomFilters
        {
            get
            {
                GetData<bool>(ref _numCustomFilters, "NumCustomFilters");
                return _numCustomFilters;
            }
        }

        private string _customFilter;
        public string CustomFilter(int args)
        {
            GetData<string>(ref _customFilter, "CustomFilters[" + args + "]");
            return _customFilter;
        }

        private bool _bcustomFilter;
        public bool CustomFilter(string args)
        {
            GetData<bool>(ref _bcustomFilter, "CustomFilters[" + args + "]");
            return _bcustomFilter;
        }

        private string _customFiltersList;
        public string CustomFiltersList
        {
            get
            {
                GetData<string>(ref _customFiltersList, "CustomFiltersList");
                return _customFiltersList;
            }
        }

        private int _size;
        public int Size
        {
            get
            {
                GetData<int>(ref _size, "Size");
                return _size;
            }
        }

        private bool _showingLabels;
        public bool ShowingLabels
        {
            get
            {
                GetData<bool>(ref _showingLabels, "ShowingLabels");
                return _showingLabels;
            }
        }

        private bool _zAxisClippingOn;
        public bool ZAxisClippingOn
        {
            get
            {
                GetData<bool>(ref _zAxisClippingOn, "ZAxisClippingOn");
                return _zAxisClippingOn;
            }
        }

        private bool _clipRadiusOn;
        public bool ClipRadiusOn
        {
            get
            {
                GetData<bool>(ref _clipRadiusOn, "ClipRadiusOn");
                return _clipRadiusOn;
            }
        }

        private bool _clippingTextOn;
        public bool ClippingTextOn
        {
            get
            {
                GetData<bool>(ref _clippingTextOn, "ClippingTextOn");
                return _clippingTextOn;
            }
        }

        private bool _rotationOn;
        public bool RotationOn
        {
            get
            {
                GetData<bool>(ref _rotationOn, "RotationOn");
                return _rotationOn;
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

        public void FilterMe()
        {
            LavishScript.ExecuteCommand(TLO + ":FilterMe");
        }

        public void FilterNPCs()
        {
            LavishScript.ExecuteCommand(TLO + ":FilterNPCs");
        }

        public void FilterPCs()
        {
            LavishScript.ExecuteCommand(TLO + ":FilterPCs");
        }

        public void FilterSpecials()
        {
            LavishScript.ExecuteCommand(TLO + ":FilterSpecials");
        }

        public void FilterResources()
        {
            LavishScript.ExecuteCommand(TLO + ":FilterResources");
        }

        public void FilterMerchants()
        {
            LavishScript.ExecuteCommand(TLO + ":FilterMerchants");
        }

        public void FilterCorpses()
        {
            LavishScript.ExecuteCommand(TLO + ":FilterCorpses");
        }

        public void FilterCraftingStations()
        {
            LavishScript.ExecuteCommand(TLO + ":FilterCraftingStations");
        }

        public void FilterTrainers()
        {
            LavishScript.ExecuteCommand(TLO + ":FilterTrainers");
        }

        public void FilterGroupMembers()
        {
            LavishScript.ExecuteCommand(TLO + ":FilterGroupMembers");
        }

        public void FilterAggroNPCs()
        {
            LavishScript.ExecuteCommand(TLO + ":FilterAggroNPCs");
        }

        public void FilterNamedNPCs()
        {
            LavishScript.ExecuteCommand(TLO + ":FilterNamedNPCs");
        }

        public void FilterPets()
        {
            LavishScript.ExecuteCommand(TLO + ":FilterPets");
        }

        public void FilterMyPet()
        {
            LavishScript.ExecuteCommand(TLO + ":FilterMyPet");
        }

        public void SetSize(int size)
        {
            LavishScript.ExecuteCommand(TLO + ":SetSize[" + size + "]");
        }

        public void ShowLabels()
        {
            LavishScript.ExecuteCommand(TLO + ":ShowLabels");
        }

        public void ZAxisClipping()
        {
            LavishScript.ExecuteCommand(TLO + ":ZAxisClipping");
        }

        public void ClipText()
        {
            LavishScript.ExecuteCommand(TLO + ":ClipText");
        }

        public void ClipRadius()
        {
            LavishScript.ExecuteCommand(TLO + ":ClipRadius");
        }

        public void Rotation()
        {
            LavishScript.ExecuteCommand(TLO + ":Rotation");
        }

        public void SetCustomFilter(int args)
        {
            LavishScript.ExecuteCommand(TLO + ":SetCustomFilter[" + args + "]");
        }

        public void ZoomIn()
        {
            LavishScript.ExecuteCommand(TLO + ":ZoomIn");
        }

        public void ZoomOut()
        {
            LavishScript.ExecuteCommand(TLO + ":ZoomOut");
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
