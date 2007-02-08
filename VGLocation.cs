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

        public VGLocation(params string[] Args)
            : base(LavishScript.Objects.GetObject("VGLoc", Args))
        {
        }

        public VGLocation(int Index)
            : base(LavishScript.Objects.GetObject("VGLoc", Index.ToString()))
        {
        }

        public VGLocation()
            : base(LavishScript.Objects.GetObject("VGLoc", "1"))
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

        public float Z
        {
            get
            {
                return GetMember<float>("Z");
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

        public bool Delete()
        {
           return ExecuteMethod("Delete");
        }

    }
}
