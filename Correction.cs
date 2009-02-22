using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    /// <summary>
    /// This DataType includes all of the data available to ISXVG that is related 
    /// to crafting corrections (brought about because of 'complications') 
    /// </summary>
    public class Correction : LavishScriptObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Correction"/> class.
        /// </summary>
        /// <param name="Obj">The obj.</param>
        public Correction(LavishScriptObject Obj) : base(Obj) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="Correction"/> class.
        /// </summary>
        public Correction()
            : base(LavishScript.Objects.GetObject("Correction")) {}

        /// <summary>
        /// Gets the name of this <see cref="Correction"/>.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get { return GetMember<string>("Name"); } }

        /// <summary>
        /// Gets the description of this <see cref="Correction"/>.
        /// </summary>
        /// <value>The description.</value>
        public string Description { get { return GetMember<string>("Description"); } }

        /// <summary>
        /// Gets the available actions count of this <see cref="Correction"/>.
        /// </summary>
        /// <value>The avail actions count.</value>
        public int AvailActionsCount { get { return GetMember<int>("AvailActionsCount"); } }

        /// <summary>
        /// Avails the action.
        /// </summary>
        /// <param name="Arg">The arg.</param>
        /// <returns></returns>
        public CraftingAction AvailAction(int Arg)
        {
            return new CraftingAction(GetMember("AvailAction", Arg.ToString()));
        }
    }
}