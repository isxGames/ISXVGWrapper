using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class Refining : LavishScriptObject
    {
        public Refining(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public Refining()
            : base(LavishScript.Objects.GetObject("Refining"))
        {
        }

        public bool InRecovery
        {
            get
            {
                return GetMember<bool>("InRecovery");
            }
        }

        public float Recovery
        {
            get
            {
                return GetMember<float>("Recovery");
            }
        }
        public int RecipeCount
        {
            get
            {
                return GetMember<int>("RecipeCount");
            }
        }
        public int State
        {
            get
            {
                return GetMember<int>("State");
            }
        }

        public CraftingStage Stage()
        {
            LavishScriptObject Obj = GetMember("Stage");
            return new CraftingStage(Obj);
        }

        public int OrigActionPointsAvail
        {
            get
            {
                return GetMember<int>("OrigActionPointsAvail");
            }
        }

        public RefiningRecipe CurrentRecipe()
        {
            LavishScriptObject Obj = GetMember("CurrentRecipe");
            return new RefiningRecipe(Obj);
        }
        public RefiningRecipe Recipe(string Name)
        {
            LavishScriptObject Obj = GetMember("CurrentRecipe", Name);
            return new RefiningRecipe(Obj);
        }
        public RefiningRecipe Recipe(int Index)
        {
            LavishScriptObject Obj = GetMember("CurrentRecipe", Index.ToString());
            return new RefiningRecipe(Obj);
        }
        public int ActionPointsUsed
        {
            get
            {
                return GetMember<int>("ActionPointsUsed");
            }
        }

        public int UseableItemCount
        {
            get
            {
                return GetMember<int>("UseableItemCount");
            }
        }

        public Item UseableItem(int Arg)
        {
            LavishScriptObject Obj = GetMember("UseableItem", Arg.ToString());
            return new Item(Obj);
        }
        public Item UseableItem(string Arg)
        {
            LavishScriptObject Obj = GetMember("UseableItem", Arg);
            return new Item(Obj);
        }
        public int TotalTableSpace
        {
            get
            {
                return GetMember<int>("TotalTableSpace");
            }
        }
        /// <summary>
        /// Number of item stacks currently on the table
        /// </summary>
        public int Table()
        {
            return GetMember<int>("Table");
        }

        public CraftingTableItem Table(int Arg)
        {
            LavishScriptObject Obj = GetMember("Table", Arg.ToString());
            return new CraftingTableItem(Obj);
        }
        public CraftingTableItem Table(string Arg)
        {
            LavishScriptObject Obj = GetMember("Table", Arg);
            return new CraftingTableItem(Obj);
        }
        public int Quality
        {
            get
            {
                return GetMember<int>("Quality");
            }
        }

        public bool IsSetupComplete
        {
            get
            {
                return GetMember<bool>("IsSetupComplete");
            }
        }

        public int ComplicationCount
        {
            get
            {
                return GetMember<int>("ComplicationCount");
            }
        }

        public Complication Complication(int Arg)
        {
            LavishScriptObject Obj = GetMember("Complication", Arg.ToString());
            return new Complication(Obj);
        }

        public int CorrectionCount
        {
            get
            {
                return GetMember<int>("CorrectionCount");
            }
        }

        public Correction Correction(int Arg)
        {
            LavishScriptObject Obj = GetMember("Correction", Arg.ToString());
            return new Correction(Obj);
        }

        public bool Begin()
        {
            return ExecuteMethod("Begin");
        }

        public bool ChangeToolbelt(int ToolbeltID)
        {
            return ExecuteMethod("ChangeToolbelt", ToolbeltID.ToString());
        }
        public bool AddItemToTable(int ItemID)
        {
            return ExecuteMethod("AddItemToTable", ItemID.ToString());
        }
        public bool DoSetup()
        {
            return ExecuteMethod("DoSetup");
        }

        public bool Start()
        {
            return ExecuteMethod("Start");
        }

        public bool Cancel()
        {
            return ExecuteMethod("Cancel");
        }
        public bool Select()
        {
            return ExecuteMethod("Select");
        }
        public bool End()
        {
            return ExecuteMethod("End");
        }

    }

}