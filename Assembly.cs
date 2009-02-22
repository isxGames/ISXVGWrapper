using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    /// <summary>
    /// 
    /// </summary>
    public class Assembly : LavishScriptObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Assembly"/> class.
        /// </summary>
        /// <param name="Obj">The obj.</param>
        public Assembly(LavishScriptObject Obj)
            : base(Obj) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="Assembly"/> class.
        /// </summary>
        public Assembly()
            : base(LavishScript.Objects.GetObject("Assembly")) {}
    }
}