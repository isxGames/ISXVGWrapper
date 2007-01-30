using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class VGLocation : LavishScriptObject
    {
        public VGLocation(LavishScriptObject Obj)
            : base(Obj)
        {
        
        }

        public VGLocation(string LocationName)
            : base(LavishScript.Objects.GetObject("VGLocation",LocationName))
        {
        }

        public string Label
        {
            get
            {
                return GetMember<string>("Label");
            }
        }

        public string Notes
        {
            get
            {
                return GetMember<string>("Notes");
            }
        }
        
        public string MapName
        {
            get
            {
                return GetMember<string>("MapName");
            }
        }
        
        public string MapShortName
        {
            get
            {
                return GetMember<string>("MapShortName");
            }
        }

        public string MapDisplayName
        {
            get
            {
                return GetMember<string>("MapDisplayName");
            }
        }

        public float X
        {
            get
            {
                return GetMember<float>("X");
            }
        }

        public float Y
        {
            get
            {
                return GetMember<float>("Y");
            }
        }

        public int ChunkX
        {
            get
            {
                return GetMember<int>("ChunkX");
            }
        }

        public int ChunkY
        {
            get
            {
                return GetMember<int>("ChunkY");
            }
        }

        public int SectorX
        {
            get
            {
                return GetMember<int>("SectorX");
            }
        }

        public int SectorY
        {
            get
            {
                return GetMember<int>("SectorY");
            }
        }

        public bool Delete
        {
            get { return ExecuteMethod("Delete"); }
        }

    }
}
