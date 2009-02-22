using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    /// <summary>
    /// This DataType includes all of the data available to ISXVG that is related to player forms.
    /// </summary>
    public class Form : LavishScriptObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Form"/> class.
        /// </summary>
        /// <param name="Obj">The obj.</param>
        public Form(LavishScriptObject Obj) : base(Obj) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="Form"/> class.
        /// </summary>
        public Form() : base(LavishScript.Objects.GetObject("Form")) {}

        /// <summary>
        /// Gets the name of this <see cref="Form"/>.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get { return GetMember<string>("Name"); } }

        /// <summary>
        /// Gets the description of this <see cref="Form"/>.
        /// </summary>
        /// <value>The description.</value>
        public string Description { get { return GetMember<string>("Description"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="Form"/> is ready.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="Form"/> is ready; otherwise, <c>false</c>.
        /// </value>
        public bool IsReady { get { return GetMember<bool>("IsReady"); } }

        /// <summary>
        /// Changes to.
        /// </summary>
        /// <param name="Args">The args.</param>
        /// <returns></returns>
        public bool ChangeTo(params string[] Args)
        {
            return ExecuteMethod("ChangeTo", Args);
        }
    }
}