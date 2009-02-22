using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    /// <summary>
    /// This DataType includes all of the data available to ISXVG that is related to a 'stage' in the crafting process. 
    /// </summary>
    public class CraftingStage : LavishScriptObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CraftingStage"/> class.
        /// </summary>
        /// <param name="Obj">The obj.</param>
        public CraftingStage(LavishScriptObject Obj) : base(Obj) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="CraftingStage"/> class.
        /// </summary>
        public CraftingStage()
            : base(LavishScript.Objects.GetObject("CraftingStep")) {}

        /// <summary>
        /// Gets the name of this <see cref="CraftingStage"/>.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get { return GetMember<string>("Name"); } }

        /// <summary>
        /// Gets the index of this <see cref="CraftingStage"/>.
        /// </summary>
        /// <value>The index.</value>
        public int Index { get { return GetMember<int>("Index"); } }

        /// <summary>
        /// Gets the step count of this <see cref="CraftingStage"/>.
        /// </summary>
        /// <value>The step count.</value>
        public int StepCount { get { return GetMember<int>("StepCount"); } }

        /// <summary>
        /// Gets a <see cref="CraftingStep"/> at the specified index.
        /// </summary>
        /// <param name="index">1-<see cref="StepCount"/>. The number of steps available in this stage.</param>
        /// <returns></returns>
        public CraftingStep Step(int index)
        {
            return Step(index.ToString());
        }

        /// <summary>
        /// Gets a <see cref="CraftingStep"/> with the specified name.
        /// </summary>
        /// <param name="arg">The name of the step.</param>
        /// <returns></returns>
        public CraftingStep Step(string arg)
        {
            return new CraftingStep(GetMember("Step", arg));
        }
    }
}