using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class Map : LavishScriptObject
    {

        public Map(params string[] Args)
            :
            base(LavishScript.Objects.GetObject("Map",Args))
        {
        }

        public Map(LavishScriptObject Copy)
            :
            base(Copy)
        {
        }

        public int NumPoI
        {
            get { return GetMember<int>("NumPoI"); }
        }

        public PoI PoI(int poi)
        {
            return GetMember<PoI>("PoI", poi.ToString());
        }

        public PoI PoI(string poi)
        {
            return GetMember<PoI>("PoI", poi);
        }

        public int NumCorpse
        {
            get
            {
                return GetMember<int>("Corpse");
            }
        }

        public PoI Corpse(int Corpse)
        {
                return GetMember<PoI>("Corpse", Corpse.ToString());
        }

        public PoI Corpse(string corpse)
        {
            return GetMember<PoI>("Corpse", corpse);
        }

        public int NumWaypoint
        {
            get
            {
                return GetMember<int>("Waypoint");
            }
        }

        public PoI Waypoint(int Waypoint)
        {
            return GetMember<PoI>("Waypoint", Waypoint.ToString());
        }

        public PoI Waypoint(string Waypoint)
        {
            return GetMember<PoI>("Waypoint", Waypoint);
        }
        public string FName
        {
            get
            {
                return GetMember<string>("FName");
            }
        }
   
        public bool AddPoI(string Name)
        {
            return ExecuteMethod("AddPoI", Name);
        }

        public bool AddPoI(params string[] Args)
        {
            return ExecuteMethod("AddPoI", Args);
        }

        public bool AddWaypoint(string Name)
        {
            return ExecuteMethod("AddWaypoint", Name);
        }

        public bool AddWaypoint(params string[] Args)
        {
            return ExecuteMethod("AddWaypoint", Args);
        }
    }
}
