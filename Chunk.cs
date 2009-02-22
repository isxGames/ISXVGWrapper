using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    /// <summary>
    /// 
    /// </summary>
    public class Chunk : LavishScriptObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Chunk"/> class.
        /// </summary>
        /// <param name="Obj">The obj.</param>
        public Chunk(LavishScriptObject Obj)
            : base(Obj) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="Chunk"/> class.
        /// </summary>
        public Chunk()
            : base(LavishScript.Objects.GetObject("Chunk")) {}

        /// <summary>
        /// Gets the ID of this <see cref="Chunk"/>.
        /// </summary>
        /// <value>The ID.</value>
        public uint ID { get { return GetMember<uint>("ID"); } }

        /// <summary>
        /// Gets the base name of this <see cref="Chunk"/>
        /// </summary>
        /// <value>The name of the base.</value>
        public string BaseName { get { return GetMember<string>("BaseName"); } }

        /// <summary>
        /// Gets the map name of this <see cref="Chunk"/>
        /// </summary>
        /// <value>The name of the map.</value>
        public string MapName { get { return GetMember<string>("MapName"); } }

        /// <summary>
        /// Gets the display name of this <see cref="Chunk"/>.
        /// </summary>
        /// <value>The display name.</value>
        public string DisplayName { get { return GetMember<string>("DisplayName"); } }

        /// <summary>
        /// Gets the short name of this <see cref="Chunk"/>.
        /// </summary>
        /// <value>The short name.</value>
        public string ShortName { get { return GetMember<string>("ShortName"); } }

        /// <summary>
        /// Gets the X of this <see cref="Chunk"/>.
        /// </summary>
        /// <value>The X.</value>
        public int X { get { return GetMember<int>("X"); } }

        /// <summary>
        /// Gets the Y of this <see cref="Chunk"/>.
        /// </summary>
        /// <value>The Y.</value>
        public int Y { get { return GetMember<int>("Y"); } }

        /// <summary>
        /// Gets the sector X of this <see cref="Chunk"/>.
        /// </summary>
        /// <value>The sector X.</value>
        public int SectorX { get { return GetMember<int>("SectorX"); } }

        /// <summary>
        /// Gets the sector Y of this <see cref="Chunk"/>.
        /// </summary>
        /// <value>The sector Y.</value>
        public int SectorY { get { return GetMember<int>("SectorY"); } }
    }
}