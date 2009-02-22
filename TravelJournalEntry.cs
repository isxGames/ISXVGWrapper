using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    /// <summary>
    /// 
    /// </summary>
    public class TravelJournalEntry : LavishScriptObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TravelJournalEntry"/> class.
        /// </summary>
        /// <param name="Obj">The obj.</param>
        public TravelJournalEntry(LavishScriptObject Obj)
            : base(Obj) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="TravelJournalEntry"/> class.
        /// </summary>
        public TravelJournalEntry()
            : base(LavishScript.Objects.GetObject("TravelJournalEntry")) {}

        /// <summary>
        /// Gets the name of this <see cref="TravelJournalEntry"/>.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get { return GetMember<string>("Name"); } }

        /// <summary>
        /// Gets the category of this <see cref="TravelJournalEntry"/>.
        /// </summary>
        /// <value>The category.</value>
        public string Category { get { return GetMember<string>("Category"); } }

        /// <summary>
        /// Gets the X of this <see cref="TravelJournalEntry"/>.
        /// </summary>
        /// <value>The X.</value>
        public float X { get { return GetMember<float>("X"); } }

        /// <summary>
        /// Gets the Y of this <see cref="TravelJournalEntry"/>.
        /// </summary>
        /// <value>The Y.</value>
        public float Y { get { return GetMember<float>("Y"); } }

        /// <summary>
        /// Gets the Z of this <see cref="TravelJournalEntry"/>.
        /// </summary>
        /// <value>The Z.</value>
        public float Z { get { return GetMember<float>("Z"); } }

        /// <summary>
        /// Gets the chunk X of this <see cref="TravelJournalEntry"/>.
        /// </summary>
        /// <value>The chunk X.</value>
        public int ChunkX { get { return GetMember<int>("ChunkX"); } }

        /// <summary>
        /// Gets the chunk Y of this <see cref="TravelJournalEntry"/>.
        /// </summary>
        /// <value>The chunk Y.</value>
        public int ChunkY { get { return GetMember<int>("ChunkY"); } }

        /// <summary>
        /// Tracks this <see cref="TravelJournalEntry"/>.
        /// </summary>
        /// <returns></returns>
        public bool Track()
        {
            return ExecuteMethod("Track");
        }

        /// <summary>
        /// Removes this <see cref="TravelJournalEntry"/>.
        /// </summary>
        /// <returns></returns>
        public bool Remove()
        {
            return ExecuteMethod("Remove");
        }
    }
}