using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class Merchant : LavishScriptObject
    {
        public Merchant(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public Merchant()
            : base(LavishScript.Objects.GetObject("Merchant"))
        {
        }
        public int NumItemsForSale
        {
            get
            {
                return GetMember<int>("NumItemsForSale");
            }
        }

        public Item ForSaleItem(string Name)
        {
            LavishScriptObject Obj = GetMember("ForSaleItem", Name);
            return new Item(Obj);
        }

        public Item ForSaleItem(int Index)
        {
            LavishScriptObject Obj = GetMember("ForSaleItem", Index.ToString());
            return new Item(Obj);
        }
        public int NumItemsForRepair
        {
            get
            {
                return GetMember<int>("NumItemsForRepair");
            }
        }

        public RepairItem RepairItem(string Name)
        {
            LavishScriptObject Obj = GetMember("RepairItem", Name);
            return new RepairItem(Obj);
        }

        public RepairItem RepairItem(int Index)
        {
            LavishScriptObject Obj = GetMember("RepairItem", Index.ToString());
            return new RepairItem(Obj);
        }

        /// <summary>
        /// Begins a transaction with a Merchant
        /// </summary>
        /// <param name="Type">BuySell or Repair</param>
        /// <returns></returns>
        public bool Begin(string Type)
        {
            return ExecuteMethod("Begin", Type);
        }

        public bool End()
        {
            return ExecuteMethod("End");
        }

    }
}
