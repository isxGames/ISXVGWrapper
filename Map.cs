using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class Map : LavishScriptObject
    {

        public Map()
            :
            base(LavishScript.Objects.GetObject("Map"))
        {
        }

        public Map(LavishScriptObject Copy)
            :
            base(Copy)
        {
        }

        public int NumPoIs
        {
            get { return GetMember<int>("NumPoI"); }
        }

        public PoI PoI(int poi)
        {
            LavishScriptObject Obj = GetMember("PoI", poi.ToString());
            return new PoI(Obj);
        }

        public PoI PoI(string poi)
        {
            LavishScriptObject Obj = GetMember("PoI", poi);
            return new PoI(Obj);
        }

        public int NumCorpses
        {
            get
            {
                return GetMember<int>("Corpse");
            }
        }

        public PoI Corpse(int Corpse)
        {
            LavishScriptObject Obj = GetMember("Corpse", Corpse.ToString());
            return new PoI(Obj);
        }

        public PoI Corpse(string Corpse)
        {
            LavishScriptObject Obj = GetMember("Corpse", Corpse);
            return new PoI(Obj);
        }

        public int NumWaypoints
        {
            get
            {
                return GetMember<int>("Waypoint");
            }
        }

        public PoI Waypoint(int Waypoint)
        {
            LavishScriptObject Obj = GetMember("Waypoint", Waypoint.ToString());
            return new PoI(Obj);
        }

        public PoI Waypoint(string Waypoint)
        {
            LavishScriptObject Obj = GetMember("Waypoint", Waypoint);
            return new PoI(Obj);
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
