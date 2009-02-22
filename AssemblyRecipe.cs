using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    /// <summary>
    /// 
    /// </summary>
    public class AssemblyRecipe : LavishScriptObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssemblyRecipe"/> class.
        /// </summary>
        /// <param name="Obj">The obj.</param>
        public AssemblyRecipe(LavishScriptObject Obj)
            : base(Obj) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="AssemblyRecipe"/> class.
        /// </summary>
        public AssemblyRecipe()
            : base(LavishScript.Objects.GetObject("AssemblyRecipe")) {}
    }
}