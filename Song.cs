using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    /// <summary>
    /// 
    /// </summary>
    public class Song : LavishScriptObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Song"/> class.
        /// </summary>
        /// <param name="Obj">The obj.</param>
        public Song(LavishScriptObject Obj)
            : base(Obj) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="Song"/> class.
        /// </summary>
        /// <param name="Arg">The arg.</param>
        public Song(string Arg)
            : base(LavishScript.Objects.GetObject("Song", Arg)) {}

        /// <summary>
        /// Gets the name of this <see cref="Song"/>.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get { return GetMember<string>("Name"); } }

        /// <summary>
        /// Gets the description of this <see cref="Song"/>.
        /// </summary>
        /// <value>The description.</value>
        public string Description { get { return GetMember<string>("Description"); } }

        /// <summary>
        /// Gets the verse count of this <see cref="Song"/>.
        /// </summary>
        /// <value>The verse count.</value>
        public int VerseCount { get { return GetMember<int>("Verse"); } }

        /// <summary>
        /// Gets the embellishment count of this <see cref="Song"/>.
        /// </summary>
        /// <value>The embellishment count.</value>
        public int EmbellishmentCount { get { return GetMember<int>("Embellishment"); } }

        /// <summary>
        /// Gets the bridge count of this <see cref="Song"/>.
        /// </summary>
        /// <value>The bridge count.</value>
        public int BridgeCount { get { return GetMember<int>("Bridge"); } }

        /// <summary>
        /// Gets the lyric count of this <see cref="Song"/>.
        /// </summary>
        /// <value>The lyric count.</value>
        public int LyricCount { get { return GetMember<int>("Lyric"); } }

        /// <summary>
        /// Gets the chorus count of this <see cref="Song"/>.
        /// </summary>
        /// <value>The chorus count.</value>
        public int ChorusCount { get { return GetMember<int>("Chorus"); } }

        /// <summary>
        /// Gets the coda count of this <see cref="Song"/>.
        /// </summary>
        /// <value>The coda count.</value>
        public int CodaCount { get { return GetMember<int>("Coda"); } }

        /// <summary>
        /// Melodies this <see cref="Song"/>.
        /// </summary>
        /// <returns></returns>
        public Ability Melody()
        {
            LavishScriptObject Obj = GetMember("Melody");
            return new Ability(Obj);
        }

        /// <summary>
        /// Verses the specified index.
        /// </summary>
        /// <param name="Index">The index.</param>
        /// <returns></returns>
        public Ability Verse(int Index)
        {
            LavishScriptObject Obj = GetMember("Verse", Index.ToString());
            return new Ability(Obj);
        }

        /// <summary>
        /// Embellishments the specified index.
        /// </summary>
        /// <param name="Index">The index.</param>
        /// <returns></returns>
        public Ability Embellishment(int Index)
        {
            LavishScriptObject Obj = GetMember("Embellishment", Index.ToString());
            return new Ability(Obj);
        }

        /// <summary>
        /// Bridges the specified index.
        /// </summary>
        /// <param name="Index">The index.</param>
        /// <returns></returns>
        public Ability Bridge(int Index)
        {
            LavishScriptObject Obj = GetMember("Bridge", Index.ToString());
            return new Ability(Obj);
        }

        /// <summary>
        /// Lyrics the specified index.
        /// </summary>
        /// <param name="Index">The index.</param>
        /// <returns></returns>
        public Ability Lyric(int Index)
        {
            LavishScriptObject Obj = GetMember("Lyric", Index.ToString());
            return new Ability(Obj);
        }

        /// <summary>
        /// Choruses the specified index.
        /// </summary>
        /// <param name="Index">The index.</param>
        /// <returns></returns>
        public Ability Chorus(int Index)
        {
            LavishScriptObject Obj = GetMember("Chorus", Index.ToString());
            return new Ability(Obj);
        }

        /// <summary>
        /// Codas the specified index.
        /// </summary>
        /// <param name="Index">The index.</param>
        /// <returns></returns>
        public Ability Coda(int Index)
        {
            LavishScriptObject Obj = GetMember("Coda", Index.ToString());
            return new Ability(Obj);
        }

        /// <summary>
        /// Performs this <see cref="Song"/>.
        /// </summary>
        /// <returns></returns>
        public bool Perform()
        {
            return ExecuteMethod("Perform");
        }
    }
}