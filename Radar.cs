using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class Radar : LavishScriptObject
    {

        public Radar(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public Radar(params string[] Args)
            : base(LavishScript.Objects.GetObject("Radar", Args))
        {
        }

        public Radar(int Index)
            : base(LavishScript.Objects.GetObject("Radar", Index.ToString()))
        {
        }

        public Radar()
            : base(LavishScript.Objects.GetObject("Radar", "1"))
        {
        }

        public bool ShowingMe
        {
            get
            {
                return GetMember<bool>("ShowingMe");
            }
        }

        public bool ShowingNPCs
        {
            get
            {
                return GetMember<bool>("ShowingNPCs");
            }
        }

        public bool ShowingPCs
        {
            get
            {
                return GetMember<bool>("ShowingPCs");
            }
        }

        public bool ShowingSpecials
        {
            get
            {
                return GetMember<bool>("ShowingSpecials");
            }
        }

        public bool ShowingResources
        {
            get
            {
                return GetMember<bool>("ShowingResources");
            }
        }

        public bool ShowingMerchants
        {
            get
            {
                return GetMember<bool>("ShowingMerchants");
            }
        }

        public bool ShowingCorpses
        {
            get
            {
                return GetMember<bool>("ShowingCorpses");
            }
        }

        public bool ShowingCraftingStations
        {
            get
            {
                return GetMember<bool>("ShowingCraftingStations");
            }
        }

        public bool ShowingTrainers
        {
            get
            {
                return GetMember<bool>("ShowingTrainers");
            }
        }

        public bool ShowingGroupMembers
        {
            get
            {
                return GetMember<bool>("ShowingGroupMembers");
            }
        }

        public bool ShowingAggroNPCs
        {
            get
            {
                return GetMember<bool>("ShowingAggroNPCs");
            }
        }

        public bool ShowingNamedNPCs
        {
            get
            {
                return GetMember<bool>("ShowingNamedNPCs");
            }
        }

        public bool ShowingPets
        {
            get
            {
                return GetMember<bool>("ShowingPets");
            }
        }

        public bool ShowingMyPet
        {
            get
            {
                return GetMember<bool>("ShowingMyPet");
            }
        }

        public int Size
        {
            get
            {
                return GetMember<int>("Size");
            }
        }

        public bool ShowingLabels
        {
            get
            {
                return GetMember<bool>("ShowingLabels");
            }
        }

        public bool ZAxisClippingOn
        {
            get
            {
                return GetMember<bool>("ZAxisClippingOn");
            }
        }

        public bool ClipRadiusOn
        {
            get
            {
                return GetMember<bool>("ClipRadiusOn");
            }
        }

        public bool ClippingTextOn
        {
            get
            {
                return GetMember<bool>("ClippingTextOn");
            }
        }

        public bool RotationOn
        {
            get
            {
                return GetMember<bool>("RotationOn");
            }
        }

        public string Name
        {
            get
            {
                return GetMember<string>("Name");
            }
        }

        public bool ShowingClickables
        {
            get
            {
                return GetMember<bool>("ShowingClickables");
            }
        }

        public bool ShowingQuestNPCs
        {
            get
            {
                return GetMember<bool>("ShowingQuestNPCs");
            }
        }


        public int NumCustomFilters
        {
            get
            {
                return GetMember<int>("NumCustomFilters");
            }
        }

        public string CustomFilter
        {
            get
            {
                return GetMember<string>("CustomFilter");
            }
        }

        public string CustomFilterList
        {
            get
            {
                return GetMember<string>("CustomFilterList");
            }
        }

        public bool FilterMe()
        {
           return ExecuteMethod("FilterMe");
        }

        public bool FilterNPCs()
        {
           return ExecuteMethod("FilterNPCs");
        }

        public bool FilterPCs()
        {
           return ExecuteMethod("FilterPCs");
        }

        public bool FilterSpecials()
        {
           return ExecuteMethod("FilterSpecials");
        }

        public bool FilterResources()
        {
           return ExecuteMethod("FilterResources");
        }

        public bool FilterMerchants()
        {
           return ExecuteMethod("FilterMerchants");
        }

        public bool FilterCorpses()
        {
           return ExecuteMethod("FilterCorpses");
        }

        public bool FilterCraftingStations()
        {
           return ExecuteMethod("FilterCraftingStations");
        }

        public bool FilterTrainers()
        {
           return ExecuteMethod("FilterTrainers");
        }

        public bool FilterGroupMembers()
        {
           return ExecuteMethod("FilterGroupMembers");
        }

        public bool FilterAggroNPCs()
        {
            return ExecuteMethod("FilterAggroNPCs");
        }

        public bool FilterNamedNPCs()
        {
            return ExecuteMethod("FilterNamedNPCs");
        }

        public bool FilterPets()
        {
           return ExecuteMethod("FilterPets");
        }

        public bool FilterMyPet()
        {
           return ExecuteMethod("FilterMyPet");
        }

        public bool SetSize(int Size)
        {
            return ExecuteMethod("SetSize", Size.ToString());
        }

        public bool ShowLabels()
        {
           return ExecuteMethod("ShowLabels");
        }

        public bool ZAxisClipping()
        {
           return ExecuteMethod("ZAxisClipping");
        }

        public bool ClipText()
        {
           return ExecuteMethod("ClipText");
        }

        public bool ClipRadius(int ClipRadius)
        {
            return ExecuteMethod("ClipRadius", ClipRadius.ToString());
        }

        public bool Rotation()
        {
           return ExecuteMethod("Rotation");
        }

        public bool SetCustomFilter(string Text)
        {
            return ExecuteMethod("SetCustomFilter", Text);
        }

        public bool ZoomIn()
        {
           return ExecuteMethod("ZoomIn");
        }

        public bool ZoomOut()
        {
           return ExecuteMethod("ZoomOut");
        }

        public bool FilterClickables()
        {
           return ExecuteMethod("FilterClickables");
        }

        public bool FilterQuestNPCs()
        {
           return ExecuteMethod("FilterQuestNPCs");
        }
    }
}
