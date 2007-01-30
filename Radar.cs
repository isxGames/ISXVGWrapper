using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class Radar : LavishScriptPersistentObject
    {

        public Radar(LavishScriptPersistentObject Obj)
            : base(Obj)
        {
        }

        public Radar(params string[] Args)
            : base(LavishScript.Objects.GetPersistentObject("Radar", Args))
        {
        }

        public Radar()
            : base(LavishScript.Objects.GetPersistentObject("Radar", "1"))
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

        public bool FilterMe
        {
           get { return ExecuteMethod("FilterMe"); }
        }

        public bool FilterNPCs
        {
           get { return ExecuteMethod("FilterNPCs"); }
        }

        public bool FilterPCs
        {
           get { return ExecuteMethod("FilterPCs"); }
        }

        public bool FilterSpecials
        {
           get { return ExecuteMethod("FilterSpecials"); }
        }

        public bool FilterResources
        {
           get { return ExecuteMethod("FilterResources"); }
        }

        public bool FilterMerchants
        {
           get { return ExecuteMethod("FilterMerchants"); }
        }

        public bool FilterCorpses
        {
           get { return ExecuteMethod("FilterCorpses"); }
        }

        public bool FilterCraftingStations
        {
           get { return ExecuteMethod("FilterCraftingStations"); }
        }

        public bool FilterTrainers
        {
           get { return ExecuteMethod("FilterTrainers"); }
        }

        public bool FilterGroupMembers
        {
           get { return ExecuteMethod("FilterGroupMembers"); }
        }

        public bool FilterAggroNPCs
        {
           get { return ExecuteMethod("FilterAggroNPCs"); }
        }

        public bool FilterNamedNPCs
        {
           get { return ExecuteMethod("FilterNamedNPCs"); }
        }

        public bool FilterPets
        {
           get { return ExecuteMethod("FilterPets"); }
        }

        public bool FilterMyPet
        {
           get { return ExecuteMethod("FilterMyPet"); }
        }

        public bool SetSize(int Size)
        {
            return ExecuteMethod("SetSize", Size.ToString());
        }

        public bool ShowLabels
        {
           get { return ExecuteMethod("ShowLabels"); }
        }

        public bool ZAxisClipping
        {
           get { return ExecuteMethod("ZAxisClipping"); }
        }

        public bool ClipText
        {
           get { return ExecuteMethod("ClipText"); }
        }

        public bool ClipRadius(int ClipRadius)
        {
            return ExecuteMethod("ClipRadius", ClipRadius.ToString());
        }

        public bool Rotation
        {
           get { return ExecuteMethod("Rotation"); }
        }

        public bool SetCustomFilter(string Text)
        {
            return ExecuteMethod("SetCustomFilter", Text);
        }

        public bool ZoomIn
        {
           get { return ExecuteMethod("ZoomIn"); }
        }

        public bool ZoomOut
        {
           get { return ExecuteMethod("ZoomOut"); }
        }

        public bool FilterClickables
        {
           get { return ExecuteMethod("FilterClickables"); }
        }

        public bool FilterQuestNPCs
        {
           get { return ExecuteMethod("FilterQuestNPCs"); }
        }
    }
}
