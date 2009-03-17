using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    ///<summary>
    ///</summary>
    public class VGLocation : LavishScriptObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VGLocation"/> class.
        /// </summary>
        /// <param name="Obj">The obj.</param>
        public VGLocation(LavishScriptObject Obj)
            : base(Obj) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="VGLocation"/> class.
        /// </summary>
        /// <param name="Args">The args.</param>
        public VGLocation(params string[] Args)
            : base(LavishScript.Objects.GetObject("VGLoc", Args)) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="VGLocation"/> class.
        /// </summary>
        /// <param name="Index">The index.</param>
        public VGLocation(int Index)
            : base(LavishScript.Objects.GetObject("VGLoc", Index.ToString())) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="VGLocation"/> class.
        /// </summary>
        public VGLocation()
            : base(LavishScript.Objects.GetObject("VGLoc", "1")) {}

        /// <summary>
        /// Gets the label of this <see cref="VGLocation"/>.
        /// </summary>
        /// <value>The label.</value>
        public string Label { get { return GetMember<string>("Label"); } }

        /// <summary>
        /// Gets the notes of this <see cref="VGLocation"/>.
        /// </summary>
        /// <value>The notes.</value>
        public string Notes { get { return GetMember<string>("Notes"); } }

        /// <summary>
        /// Gets the name of the map.
        /// </summary>
        /// <value>The name of the map.</value>
        public string MapName { get { return GetMember<string>("MapName"); } }

        /// <summary>
        /// Gets the short name of the map.
        /// </summary>
        /// <value>The short name of the map.</value>
        public string MapShortName { get { return GetMember<string>("MapShortName"); } }

        /// <summary>
        /// Gets the display name of the map.
        /// </summary>
        /// <value>The display name of the map.</value>
        public string MapDisplayName { get { return GetMember<string>("MapDisplayName"); } }

        /// <summary>
        /// Gets the X of this <see cref="VGLocation"/>.
        /// </summary>
        /// <value>The X.</value>
        public float X { get { return GetMember<float>("X"); } }

        /// <summary>
        /// Gets the Y of this <see cref="VGLocation"/>.
        /// </summary>
        /// <value>The Y.</value>
        public float Y { get { return GetMember<float>("Y"); } }

        /// <summary>
        /// Gets the Z of this <see cref="VGLocation"/>.
        /// </summary>
        /// <value>The Z.</value>
        public float Z { get { return GetMember<float>("Z"); } }

        /// <summary>
        /// Gets the chunk X of this <see cref="VGLocation"/>.
        /// </summary>
        /// <value>The chunk X.</value>
        public int ChunkX { get { return GetMember<int>("ChunkX"); } }

        /// <summary>
        /// Gets the chunk Y of this <see cref="VGLocation"/>.
        /// </summary>
        /// <value>The chunk Y.</value>
        public int ChunkY { get { return GetMember<int>("ChunkY"); } }

        /// <summary>
        /// Gets the sector X of this <see cref="VGLocation"/>.
        /// </summary>
        /// <value>The sector X.</value>
        public int SectorX { get { return GetMember<int>("SectorX"); } }

        /// <summary>
        /// Gets the sector Y of this <see cref="VGLocation"/>.
        /// </summary>
        /// <value>The sector Y.</value>
        public int SectorY { get { return GetMember<int>("SectorY"); } }

        /// <summary>
        /// Deletes this <see cref="VGLocation"/>.
        /// </summary>
        /// <returns></returns>
        public bool Delete()
        {
            return ExecuteMethod("Delete");
        }

        /// <summary>
        /// Ports to this <see cref="VGLocation"/>.
        /// </summary>
        /// <returns></returns>
        public bool Port()
        {
            return ExecuteMethod("Port");
        }
    }
}