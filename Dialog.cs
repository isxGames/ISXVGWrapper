using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class Dialog : LavishScriptObject
    {
        public Dialog(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public Dialog()
            : base(LavishScript.Objects.GetObject("Dialog"))
        {
        }

        public int ResponseCount
        {
            get
            {
                return GetMember<int>("ResponseCount");
            }
        }

        public Pawn NPCTalkingWith
        {
            get
            {
                LavishScriptPersistentObject Obj = GetPersistentMember("NPCTalkingWith");
                return new Pawn(Obj);
            }
        }
    }
}