using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class Chunk : LavishScriptObject
    {

        public Chunk(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public Chunk()
            : base(LavishScript.Objects.GetObject("Chunk"))
        {
        }

        public uint ID
        {
            get
            {
                return GetMember<uint>("ID");
            }
        }

        public string BaseName
        {
            get
            {
                return GetMember<string>("BaseName");
            }
        }

        public string MapName
        {
            get
            {
                return GetMember<string>("MapName");
            }
        }

        public string DisplayName
        {
            get
            {
                return GetMember<string>("DisplayName");
            }
        }

        public string ShortName
        {
            get
            {
                return GetMember<string>("ShortName");
            }
        }

        public int X
        {
            get
            {
                return GetMember<int>("X");
            }
        }

        public int Y
        {
            get
            {
                return GetMember<int>("Y");
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
    }
}
