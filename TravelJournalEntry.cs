using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class TravelJournalEntry : LavishScriptObject
    {
        public TravelJournalEntry(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public TravelJournalEntry()
            : base(LavishScript.Objects.GetObject("TravelJournalEntry"))
        {
        }

        public string Name
        {
            get
            {
                return GetMember<string>("Name");
            }
        }

        public string Category
        {
            get
            {
                return GetMember<string>("Category");
            }
        }

        public float X
        {
            get
            {
                return GetMember<float>("X");
            }
        }

        public float Y
        {
            get
            {
                return GetMember<float>("Y");
            }
        }

        public float Z
        {
            get
            {
                return GetMember<float>("Z");
            }
        }
        public int ChunkX
        {
            get
            {
                return GetMember<int>("ChunkX");
            }
        }

        public int ChunkY
        {
            get
            {
                return GetMember<int>("ChunkY");
            }
        }
   
        public bool Track()
        {
            return ExecuteMethod("Track");
        }
        public bool Remove()
        {
            return ExecuteMethod("Remove");
        }
    }
}
