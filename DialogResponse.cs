using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    /// <summary>
    /// This DataType includes all of the data available to ISXVG that is related to the current dialog responses with an NPC. 
    /// </summary>
    public class DialogResponse : LavishScriptObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialogResponse"/> class.
        /// </summary>
        /// <param name="Obj">The obj.</param>
        public DialogResponse(LavishScriptObject Obj) : base(Obj) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="DialogResponse"/> class.
        /// </summary>
        public DialogResponse() : base(LavishScript.Objects.GetObject("DialogResponse")) {}

        /// <summary>
        /// Gets the text of this <see cref="DialogResponse"/>.
        /// </summary>
        /// <value>The text.</value>
        public string Text { get { return GetMember<string>("Text"); } }

        /// <summary>
        /// Gets the type of this <see cref="DialogResponse"/>.
        /// </summary>
        /// <value>The type.</value>
        public int Type { get { return GetMember<int>("Type"); } }

        /// <summary>
        /// Gets the presence required of this <see cref="DialogResponse"/>.
        /// </summary>
        /// <value>The presence required.</value>
        public int PresenceRequired { get { return GetMember<int>("PresenceRequired"); } }

        /// <summary>
        /// Gets the type of the presence required.
        /// </summary>
        /// <value>The type of the presence required.</value>
        public string PresenceRequiredType { get { return GetMember<string>("PresenceRequiredType"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="DialogResponse"/> is civic diplomacy response.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="DialogResponse"/> is civic diplomacy response; otherwise, <c>false</c>.
        /// </value>
        public bool IsCivicDiplomacyResponse { get { return GetMember<bool>("IsCivicDiplomacyResponse"); } }

        /// <summary>
        /// Selects this <see cref="DialogResponse"/>.
        /// </summary>
        /// <returns></returns>
        public bool Select()
        {
            return ExecuteMethod("Select");
        }
    }
}