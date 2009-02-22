using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    /// <summary>
    /// 
    /// </summary>
    public class SCorpse : LavishScriptObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SCorpse"/> class.
        /// </summary>
        /// <param name="Obj">The obj.</param>
        public SCorpse(LavishScriptObject Obj)
            : base(Obj) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="SCorpse"/> class.
        /// </summary>
        /// <param name="Args">The args.</param>
        public SCorpse(params string[] Args)
            : base(LavishScript.Objects.GetObject("GV", Args)) {}

        /// <summary>
        /// Gets the location of this <see cref="SCorpse"/>.
        /// </summary>
        /// <value>The location.</value>
        public string Location { get { return GetMember<string>("Location"); } }

        /// <summary>
        /// zero based
        /// </summary>
        public int ID { get { return GetMember<int>("ID"); } }

        /// <summary>
        /// Summons this <see cref="SCorpse"/>.
        /// </summary>
        /// <returns></returns>
        public bool Summon()
        {
            return ExecuteMethod("Summon");
        }

        /// <summary>
        /// This will close the "My Remains" window
        /// </summary>
        public bool Cancel()
        {
            return ExecuteMethod("Cancel");
        }
    }
}