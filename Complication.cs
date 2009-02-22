using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    /// <summary>
    /// This DataType includes all of the data available to ISXVG that is related to crafting complications. 
    /// </summary>
    public class Complication : LavishScriptObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Complication"/> class.
        /// </summary>
        /// <param name="Obj">The obj.</param>
        public Complication(LavishScriptObject Obj)
            : base(Obj) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="Complication"/> class.
        /// </summary>
        public Complication()
            : base(LavishScript.Objects.GetObject("Complication")) {}

        /// <summary>
        /// Gets the name of this <see cref="Complication"/>.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get { return GetMember<string>("Name"); } }

        /// <summary>
        /// Gets the description of this <see cref="Complication"/>.
        /// </summary>
        /// <value>The description.</value>
        public string Description { get { return GetMember<string>("Description"); } }
    }
}