using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class ISXVGChunk
    {
        public ISXVGChunk()
        {
        }

        private int _id;
        public int ID
        {
            get
            {
                GetData<int>(ref _id, "ID");
                return _id;
            }
        }

        private string _baseName;
        public string BaseName
        {
            get
            {
                GetData<string>(ref _baseName, "BaseName");
                return _baseName;
            }
        }

        private string _mapName;
        public string MapName
        {
            get
            {
                GetData<string>(ref _mapName, "MapName");
                return _mapName;
            }
        }

        private string _displayName;
        public string DisplayName
        {
            get
            {
                GetData<string>(ref _displayName, "DisplayName");
                return _displayName;
            }
        }

        private string _shortName;
        public string ShortName
        {
            get
            {
                GetData<string>(ref _shortName, "ShortName");
                return _shortName;
            }
        }

        private int _x;
        public int X
        {
            get
            {
                GetData<int>(ref _x, "X");
                return _x;
            }
        }

        private int _y;
        public int Y
        {
            get
            {
                GetData<int>(ref _y, "Y");
                return _y;
            }
        }

        private int _sectorX;
        public int SectorX
        {
            get
            {
                GetData<int>(ref _sectorX, "SectorX");
                return _sectorX;
            }
        }

        private int _sectorY;
        public int SectorY
        {
            get
            {
                GetData<int>(ref _sectorY, "SectorY");
                return _sectorY;
            }
        }

        protected void GetData<T>(ref T obj, string param)
        {
            try
            {
                LavishScript.DataParse<T>("${Me.Chunk." + param + "}", ref obj);
            }
            catch
            {
                InnerSpace.Echo("Exception Raised");
            }
        }
    }
}
