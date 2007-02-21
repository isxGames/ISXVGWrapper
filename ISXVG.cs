using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class ISXVG : LavishScriptObject
    {
        public ISXVG(LavishScriptObject Copy)
            : base(Copy)
        {
        }

        public ISXVG() 
            : base(LavishScript.Objects.GetObject("ISXVG"))
        {
        }

        public int NumRadars
        {
            get { return GetMember<int>("NumRadars"); }
        }

        public int VGLocsCount
        {
            get { return GetMember<int>("VGLocsCount"); }
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
