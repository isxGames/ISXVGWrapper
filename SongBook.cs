using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    /// <summary>
    /// 
    /// </summary>
    public class Songbook : LavishScriptObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Songbook"/> class.
        /// </summary>
        /// <param name="Obj">The obj.</param>
        public Songbook(LavishScriptObject Obj)
            : base(Obj) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="Songbook"/> class.
        /// </summary>
        public Songbook()
            : base(LavishScript.Objects.GetObject("Songbook")) {}

        /// <summary>
        /// Gets the num songs of this <see cref="Songbook"/>.
        /// </summary>
        /// <value>The num songs.</value>
        public int NumSongs { get { return GetMember<int>("NumSongs"); } }

        /// <summary>
        /// alias for NumSongs
        /// </summary>
        /// <value>The song count.</value>
        public int SongCount { get { return GetMember<int>("SongCount"); } }

        /// <summary>
        /// Gets the current song of this <see cref="Songbook"/>.
        /// </summary>
        /// <value>The current song.</value>
        public Song CurrentSong
        {
            get
            {
                LavishScriptObject Obj = GetMember("CurrentSong");
                return new Song(Obj);
            }
        }

        /// <summary>
        /// Stops the performing.
        /// </summary>
        /// <returns></returns>
        public bool StopPerforming()
        {
            return ExecuteMethod("StopPerforming");
        }
    }
}