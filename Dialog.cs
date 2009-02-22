using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    /// <summary>
    /// Retrieves a dialog or dialogresponse object representing information about your character's current dialog with an NPC. 
    /// </summary>
    public class Dialog : LavishScriptObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Dialog"/> class.
        /// </summary>
        /// <param name="Obj">The obj.</param>
        public Dialog(LavishScriptObject Obj) : base(Obj) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="Dialog"/> class.
        /// </summary>
        public Dialog() : base(LavishScript.Objects.GetObject("Dialog")) {}

        /// <summary>
        /// Gets the response count of this <see cref="Dialog"/>.
        /// </summary>
        /// <value>The response count.</value>
        public int ResponseCount { get { return GetMember<int>("ResponseCount"); } }

        /// <summary>
        /// Gets the NPC talking with of this <see cref="Dialog"/>.
        /// </summary>
        /// <value>The NPC talking with.</value>
        public Pawn NPCTalkingWith { get { return new Pawn(GetPersistentMember("NPCTalkingWith")); } }
    }
}