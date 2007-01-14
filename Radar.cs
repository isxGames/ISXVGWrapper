using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class Radar : Wrapper
    {
        public Radar()
        {
        }

        public Radar(string args)
        {
            Args = "Radar[" + args + "]";
        }

        public Radar(string args, int unused)
        {
            Args = args;
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

        private string _showingClickables;
        public string ShowingClickables
        {
            get
            {
                GetData<string>(ref _showingClickables, "ShowingClickables");
                return _showingClickables;
            }
        }

        private string _showingQuestNPCs;
        public string ShowingQuestNPCs
        {
            get
            {
                GetData<string>(ref _showingQuestNPCs, "ShowingQuestNPCs");
                return _showingQuestNPCs;
            }
        }

        public void FilterMe()
        {
            LavishScript.ExecuteCommand(Args + ":FilterMe");
        }

        public void FilterNPCs()
        {
            LavishScript.ExecuteCommand(Args + ":FilterNPCs");
        }

        public void FilterPCs()
        {
            LavishScript.ExecuteCommand(Args + ":FilterPCs");
        }

        public void FilterSpecials()
        {
            LavishScript.ExecuteCommand(Args + ":FilterSpecials");
        }

        public void FilterResources()
        {
            LavishScript.ExecuteCommand(Args + ":FilterResources");
        }

        public void FilterMerchants()
        {
            LavishScript.ExecuteCommand(Args + ":FilterMerchants");
        }

        public void FilterCorpses()
        {
            LavishScript.ExecuteCommand(Args + ":FilterCorpses");
        }

        public void FilterCraftingStations()
        {
            LavishScript.ExecuteCommand(Args + ":FilterCraftingStations");
        }

        public void FilterTrainers()
        {
            LavishScript.ExecuteCommand(Args + ":FilterTrainers");
        }

        public void FilterGroupMembers()
        {
            LavishScript.ExecuteCommand(Args + ":FilterGroupMembers");
        }

        public void FilterAggroNPCs()
        {
            LavishScript.ExecuteCommand(Args + ":FilterAggroNPCs");
        }

        public void FilterNamedNPCs()
        {
            LavishScript.ExecuteCommand(Args + ":FilterNamedNPCs");
        }

        public void FilterPets()
        {
            LavishScript.ExecuteCommand(Args + ":FilterPets");
        }

        public void FilterMyPet()
        {
            LavishScript.ExecuteCommand(Args + ":FilterMyPet");
        }

        public void SetSize(int size)
        {
            LavishScript.ExecuteCommand(Args + ":SetSize[" + size + "]");
        }

        public void ShowLabels()
        {
            LavishScript.ExecuteCommand(Args + ":ShowLabels");
        }

        public void ZAxisClipping()
        {
            LavishScript.ExecuteCommand(Args + ":ZAxisClipping");
        }

        public void ClipText()
        {
            LavishScript.ExecuteCommand(Args + ":ClipText");
        }

        public void ClipRadius()
        {
            LavishScript.ExecuteCommand(Args + ":ClipRadius");
        }

        public void Rotation()
        {
            LavishScript.ExecuteCommand(Args + ":Rotation");
        }

        public void SetCustomFilter(int args)
        {
            LavishScript.ExecuteCommand(Args + ":SetCustomFilter[" + args + "]");
        }

        public void ZoomIn()
        {
            LavishScript.ExecuteCommand(Args + ":ZoomIn");
        }

        public void ZoomOut()
        {
            LavishScript.ExecuteCommand(Args + ":ZoomOut");
        }

        public void FilterClickables()
        {
            LavishScript.ExecuteCommand(Args + ":FilterClickables");
        }

        public void FilterQuestNPCs()
        {
            LavishScript.ExecuteCommand(Args + ":FilterQuestNPCs");
        }
    }
}
