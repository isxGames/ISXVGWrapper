using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    /// <summary>
    /// 
    /// </summary>
    public class RefiningRecipe : LavishScriptObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RefiningRecipe"/> class.
        /// </summary>
        /// <param name="Obj">The obj.</param>
        public RefiningRecipe(LavishScriptObject Obj)
            : base(Obj) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="RefiningRecipe"/> class.
        /// </summary>
        public RefiningRecipe()
            : base(LavishScript.Objects.GetObject("RefiningRecipie")) {}

        /// <summary>
        /// Gets the ID of this <see cref="RefiningRecipe"/>.
        /// </summary>
        /// <value>The ID.</value>
        public int ID { get { return GetMember<int>("ID"); } }

        /// <summary>
        /// Gets the name of this <see cref="RefiningRecipe"/>.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get { return GetMember<string>("Name"); } }

        /// <summary>
        /// Gets the description of this <see cref="RefiningRecipe"/>.
        /// </summary>
        /// <value>The description.</value>
        public string Description { get { return GetMember<string>("Description"); } }

        /// <summary>
        /// Gets the name of the stage1.
        /// </summary>
        /// <value>The name of the stage1.</value>
        public string Stage1Name { get { return GetMember<string>("Stage1Name"); } }

        /// <summary>
        /// Gets the name of the stage2.
        /// </summary>
        /// <value>The name of the stage2.</value>
        public string Stage2Name { get { return GetMember<string>("Stage2Name"); } }

        /// <summary>
        /// Gets the name of the stage3.
        /// </summary>
        /// <value>The name of the stage3.</value>
        public string Stage3Name { get { return GetMember<string>("Stage3Name"); } }

        /// <summary>
        /// Gets the name of the stage4.
        /// </summary>
        /// <value>The name of the stage4.</value>
        public string Stage4Name { get { return GetMember<string>("Stage4Name"); } }

        /// <summary>
        /// Gets the action points total of this <see cref="RefiningRecipe"/>.
        /// </summary>
        /// <value>The action points total.</value>
        public int ActionPointsTotal { get { return GetMember<int>("ActionPointsTotal"); } }

        /// <summary>
        /// Gets the progress bar PCT of this <see cref="RefiningRecipe"/>.
        /// </summary>
        /// <value>The progress bar PCT.</value>
        public float ProgressBarPct { get { return GetMember<float>("ProgressBarPct"); } }

        /// <summary>
        /// Gets the num uses of this <see cref="RefiningRecipe"/>.
        /// </summary>
        /// <value>The num uses.</value>
        public int NumUses { get { return GetMember<int>("NumUses"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="RefiningRecipe"/> is work order.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="RefiningRecipe"/> is work order; otherwise, <c>false</c>.
        /// </value>
        public bool IsWorkOrder { get { return GetMember<bool>("IsWorkOrder"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="RefiningRecipe"/> is refining.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="RefiningRecipe"/> is refining; otherwise, <c>false</c>.
        /// </value>
        public bool IsRefining { get { return GetMember<bool>("IsRefining"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="RefiningRecipe"/> is finishing.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="RefiningRecipe"/> is finishing; otherwise, <c>false</c>.
        /// </value>
        public bool IsFinishing { get { return GetMember<bool>("IsFinishing"); } }

        /// <summary>
        /// Gets the step count of this <see cref="RefiningRecipe"/>.
        /// </summary>
        /// <value>The step count.</value>
        public int StepCount { get { return GetMember<int>("StepCount"); } }

        /// <summary>
        /// Steps the specified arg.
        /// </summary>
        /// <param name="Arg">The arg.</param>
        /// <returns></returns>
        public CraftingStep Step(int Arg)
        {
            LavishScriptObject Obj = GetMember("Step", Arg.ToString());
            return new CraftingStep(Obj);
        }
    }
}