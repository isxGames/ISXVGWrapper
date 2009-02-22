using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    /// <summary>
    /// 
    /// </summary>
    public class RepairItem : LavishScriptObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RepairItem"/> class.
        /// </summary>
        /// <param name="Obj">The obj.</param>
        public RepairItem(LavishScriptObject Obj)
            : base(Obj) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="RepairItem"/> class.
        /// </summary>
        public RepairItem()
            : base(LavishScript.Objects.GetObject("RepairItem")) {}

        /// <summary>
        /// cost in copper
        /// </summary>
        public int RepairCost { get { return GetMember<int>("RepairCost"); } }

        /// <summary>
        /// Repairs this <see cref="RepairItem"/>.
        /// </summary>
        /// <returns></returns>
        public bool Repair()
        {
            return ExecuteMethod("Repair");
        }
    }
}