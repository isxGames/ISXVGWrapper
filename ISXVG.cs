using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class ISXVG : LavishScriptPersistentObject
    {
        public ISXVG(LavishScriptPersistentObject Copy)
            : base(Copy)
        {
        }

        public ISXVG() 
            : base(LavishScript.Objects.GetPersistentObject("ISXVG"))
        {
        }

        public int NumItems
        {
            get { return GetMember<int>("NumRadars"); }
        }

        public string Version
        {
            get { return GetMember<string>("Version"); }
        }

        public string ConnectionState
        {
            get { return GetMember<string>("ConnectionState"); }
        }

        public string ClipBoardText
        {
            get { return GetMember<string>("ClipBoardText"); }
        }

        public bool AddLoc(string Label)
        {
            return ExecuteMethod("AddLoc", Label);
        }

        public bool AddLoc(string Label, string Notes)
        {
            return ExecuteMethod("AddLoc", Label, Notes);
        }

    }
}
