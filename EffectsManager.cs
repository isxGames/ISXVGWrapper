using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    /// <summary>
    /// This datatype object represents the overall system that handles any effects that are 'attached' to your character. 
    /// </summary>
    public class EffectsManager : LavishScriptObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EffectsManager"/> class.
        /// </summary>
        /// <param name="Obj">The obj.</param>
        public EffectsManager(LavishScriptObject Obj) : base(Obj) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="EffectsManager"/> class.
        /// </summary>
        public EffectsManager() : base(LavishScript.Objects.GetObject("EffectsManager")) {}

        /// <summary>
        /// Number of effects or maintained buffs on your character. 
        /// NOTE: ISXVG will return the proper number depending upon if you access the effectsmanager via Me.Effect or Me.Maintained 
        /// </summary>
        /// <value>The count.</value>
        public int Count { get { return GetMember<int>("Count"); } }
    }
}