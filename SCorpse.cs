using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class SCorpse : LavishScriptObject
    {
        public SCorpse(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public SCorpse(params string[] Args)
            : base(LavishScript.Objects.GetObject("GV", Args))
        {
        }

        public string Location
        {
            get
            {
                return GetMember<string>("Location");
            }
        }
        /// <summary>
        /// zero based
        /// </summary>
        public int ID
        {
            get
            {
                return GetMember<int>("ID");
            }
        }


        public bool Summon()
        {
            return ExecuteMethod("Summon");
        }
        /// <summary>
        /// This will close the "My Remains" window
        /// </summary>
        public bool Cancel()
        {
            return ExecuteMethod("Cancel");
        }

    }
}