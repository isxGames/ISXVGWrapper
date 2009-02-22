using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    /// <summary>
    /// 
    /// </summary>
    public class PoI : LavishScriptObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PoI"/> class.
        /// </summary>
        /// <param name="Args">The args.</param>
        public PoI(params string[] Args)
            :
                base(LavishScript.Objects.GetObject("PoI", Args)) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="PoI"/> class.
        /// </summary>
        /// <param name="Copy">The copy.</param>
        public PoI(LavishScriptObject Copy)
            :
                base(Copy) {}

        /// <summary>
        /// Gets the name of this <see cref="PoI"/>.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get { return GetMember<string>("Name"); } }

        /// <summary>
        /// Gets the X of this <see cref="PoI"/>.
        /// </summary>
        /// <value>The X.</value>
        public int X { get { return GetMember<int>("X"); } }

        /// <summary>
        /// Gets the Y of this <see cref="PoI"/>.
        /// </summary>
        /// <value>The Y.</value>
        public int Y { get { return GetMember<int>("Y"); } }

        /// <summary>
        /// Gets a value indicating whether this <see cref="PoI"/> is visible.
        /// </summary>
        /// <value><c>true</c> if visible; otherwise, <c>false</c>.</value>
        public bool Visible { get { return GetMember<bool>("Visible"); } }

        /// <summary>
        /// Gets the chunk X of this <see cref="PoI"/>.
        /// </summary>
        /// <value>The chunk X.</value>
        public int ChunkX { get { return GetMember<int>("ChunkX"); } }

        /// <summary>
        /// Gets the chunk Y of this <see cref="PoI"/>.
        /// </summary>
        /// <value>The chunk Y.</value>
        public int ChunkY { get { return GetMember<int>("ChunkY"); } }

        /// <summary>
        /// Hides this <see cref="PoI"/>.
        /// </summary>
        /// <returns></returns>
        public bool Hide()
        {
            return ExecuteMethod("Hide");
        }
    }
}