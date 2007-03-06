using System;
using System.Collections.Generic;
using System.Text;
using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class GroupMember : LavishScriptObject
    {
        public GroupMember()
            :
            base(LavishScript.Objects.GetObject("GroupMember"))
        {
        }

        public GroupMember(LavishScriptObject Copy)
            :
            base(Copy)
        {
        }

        public Int64 ID
        {
            get { return GetMember<Int64>("ID"); }
        }

        public string Name
        {
            get {
                string s;
                LavishVMAPI.Frame.Lock();
                s=GetMember<string>("Name");
                LavishVMAPI.Frame.Unlock();
                return s;
            }
        }

        public float X
        {
            get { return GetMember<float>("X"); }
        }

        public float Y
        {
            get { return GetMember<float>("Y"); }
        }

        public float Z
        {
            get { return GetMember<float>("Z"); }
        }

        public float Health
        {
            get { return GetMember<float>("Health"); }
        }

        public float Energy
        {
            get { return GetMember<float>("Energy"); }
        }

        public float Endurance
        {
            get { return GetMember<float>("Endurance"); }
        }

        public int ChunkX
        {
            get { return GetMember<int>("ChunkX"); }
        }

        public int ChunkY
        {
            get { return GetMember<int>("ChunkY"); }
        }

        public string Race
        {
            get { return GetMember<string>("Race"); }
        }

        public string Class
        {
            get { return GetMember<string>("Class"); }
        }

        public int HeadingTo
        {
            get { return GetMember<int>("HeadingTo"); }
        }

        public float Distance
        {
            get { return GetMember<float>("Distance"); }
        }
        /// <summary>
        /// Only for group members within your 'pawn visible radius', otherwise it will return the ID# of the group member
        /// </summary>
        public Pawn ToPawn
        {
            get
            {
                LavishScriptObject Obj = GetMember("ToPawn");
                return new Pawn(Obj);
            }
        }
        /// <summary>
        /// ie, remove from the group if you're the group leader
        /// </summary>
        /// <returns></returns>
        public bool Boot()
        {
            return ExecuteMethod("Boot");
        }

        public bool MakeMasterLooter()
        {
            return ExecuteMethod("MakeMasterLooter");
        }






    }

}
