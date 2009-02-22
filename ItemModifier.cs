using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    /// <summary>
    /// This DataType includes all of the data available to ISXVG that is related to item modifiers 
    /// </summary>
    public class ItemModifier : LavishScriptObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemModifier"/> class.
        /// </summary>
        /// <param name="Obj">The obj.</param>
        public ItemModifier(LavishScriptObject Obj) : base(Obj) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemModifier"/> class.
        /// </summary>
        public ItemModifier() : base(LavishScript.Objects.GetObject("ItemModifier")) {}

        /// <summary>
        /// Gets the name of this <see cref="ItemModifier"/>.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get { return GetMember<string>("Name"); } }

        /// <summary>
        /// Gets the current mod of this <see cref="ItemModifier"/>.
        /// </summary>
        /// <value>The current mod.</value>
        public int CurrentMod { get { return GetMember<int>("CurrentMod"); } }

        /// <summary>
        /// Gets the max mod of this <see cref="ItemModifier"/>.
        /// </summary>
        /// <value>The max mod.</value>
        public int MaxMod { get { return GetMember<int>("MaxMod"); } }
    }
}