using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    /// <summary>
    /// This DataType includes all of the data available to ISXVG that is related to the in-game map. 
    /// </summary>
    public class Map : LavishScriptObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Map"/> class.
        /// </summary>
        public Map() : base(LavishScript.Objects.GetObject("Map")) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="Map"/> class.
        /// </summary>
        /// <param name="Copy">The copy.</param>
        public Map(LavishScriptObject Copy) : base(Copy) {}

        /// <summary>
        /// Gets the number of PoIs of this <see cref="Map"/>.
        /// </summary>
        /// <value>The num po is.</value>
        public int NumPoIs { get { return GetMember<int>("NumPoI"); } }

        /// <summary>
        /// Gets the num corpses of this <see cref="Map"/>.
        /// </summary>
        /// <value>The num corpses.</value>
        public int NumCorpses { get { return GetMember<int>("Corpse"); } }

        /// <summary>
        /// Gets the num waypoints of this <see cref="Map"/>.
        /// </summary>
        /// <value>The num waypoints.</value>
        public int NumWaypoints { get { return GetMember<int>("Waypoint"); } }

        /// <summary>
        /// Gets first name.
        /// </summary>
        /// <value>The name of the F.</value>
        public string FName { get { return GetMember<string>("FName"); } }

        /// <summary>
        /// Gets a POI at the specified index.
        /// </summary>
        /// <param name="poi">The poi.</param>
        /// <returns></returns>
        public PoI PoI(int poi)
        {
            return PoI(poi.ToString());
        }

        /// <summary>
        /// Gets a POI by name.
        /// </summary>
        /// <param name="poi">The poi.</param>
        /// <returns></returns>
        public PoI PoI(string poi)
        {
            LavishScriptObject Obj = GetMember("PoI", poi);
            return new PoI(Obj);
        }

        /// <summary>
        /// Gets the <see cref="Vanguard.ISXVG.PoI"/> corpse at the specified index.
        /// </summary>
        /// <param name="Corpse">The corpse.</param>
        /// <returns></returns>
        public PoI Corpse(int Corpse)
        {
            LavishScriptObject Obj = GetMember("Corpse", Corpse.ToString());
            return new PoI(Obj);
        }

        /// <summary>
        /// Gets the <see cref="Vanguard.ISXVG.PoI"/> corpse by name.
        /// </summary>
        /// <param name="Corpse">The corpse.</param>
        /// <returns></returns>
        public PoI Corpse(string Corpse)
        {
            LavishScriptObject Obj = GetMember("Corpse", Corpse);
            return new PoI(Obj);
        }

        /// <summary>
        /// Gets a waypoint by the specified index.
        /// </summary>
        /// <param name="Waypoint">The waypoint.</param>
        /// <returns></returns>
        public PoI Waypoint(int Waypoint)
        {
            LavishScriptObject Obj = GetMember("Waypoint", Waypoint.ToString());
            return new PoI(Obj);
        }

        /// <summary>
        /// Waypoints the specified waypoint.
        /// </summary>
        /// <param name="Waypoint">The waypoint.</param>
        /// <returns></returns>
        public PoI Waypoint(string Waypoint)
        {
            LavishScriptObject Obj = GetMember("Waypoint", Waypoint);
            return new PoI(Obj);
        }

        /// <summary>
        /// Adds the PoI.
        /// </summary>
        /// <param name="Name">The name.</param>
        /// <returns></returns>
        public bool AddPoI(string Name)
        {
            return ExecuteMethod("AddPoI", Name);
        }

        /// <summary>
        /// Adds the PoI.
        /// </summary>
        /// <param name="Args">The args.</param>
        /// <returns></returns>
        public bool AddPoI(params string[] Args)
        {
            return ExecuteMethod("AddPoI", Args);
        }

        /// <summary>
        /// Adds the waypoint.
        /// </summary>
        /// <param name="Name">The name.</param>
        /// <returns></returns>
        public bool AddWaypoint(string Name)
        {
            return ExecuteMethod("AddWaypoint", Name);
        }

        /// <summary>
        /// Adds the waypoint.
        /// </summary>
        /// <param name="Args">The args.</param>
        /// <returns></returns>
        public bool AddWaypoint(params string[] Args)
        {
            return ExecuteMethod("AddWaypoint", Args);
        }
    }
}