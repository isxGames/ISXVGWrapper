using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class Songbook : LavishScriptObject
    {
        public Songbook(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public Songbook()
            : base(LavishScript.Objects.GetObject("Songbook"))
        {
        }
        public int NumSongs
        {
            get
            {
                return GetMember<int>("NumSongs");
            }
        }
        /// <summary>
        /// alias for NumSongs
        /// </summary>
        public int SongCount
        {
            get
            {
                return GetMember<int>("SongCount");
            }
        }
        public Song CurrentSong
        {
            get
            {
                LavishScriptObject Obj = GetMember("CurrentSong");
                return new Song(Obj);
            }
        }
        public bool StopPerforming()
        {
            return ExecuteMethod("StopPerforming");
        }
    }
}
