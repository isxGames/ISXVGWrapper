using LavishScriptAPI;
using LavishVMAPI;

namespace Vanguard.ISXVG
{
    /// <summary>
    /// The actor TLO and data type are used to get information about any/all 
    /// objects in the game world. This is different from the pawn TLO and data type, 
    /// which is generally used to get information about interactive objects in the game world. 
    /// All pawn objects are also actor objects, but not all actor objects are pawn objects. 
    /// This is why the ToPawn member of the actor object can return a NULL, but the ToActor 
    /// member of the pawn object should always return a valid actor object.
    /// </summary>
    public class Actor : LavishScriptObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Actor"/> class.
        /// </summary>
        /// <param name="Obj">The obj.</param>
        public Actor(LavishScriptObject Obj) : base(Obj) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="Actor"/> class.
        /// </summary>
        /// <param name="Args">The args.</param>
        public Actor(params string[] Args) : base(LavishScript.Objects.GetObject("Actor", Args)) {}

        /// <summary>
        /// This will return the actor's base name, even if the actor is technically a pawn and has a legit 'display' name.
        /// </summary>
        public string Name { get { return GetMember<string>("Name"); } }

        /// <summary>
        /// Gets the location.
        /// </summary>
        /// <value>The location.</value>
        public Point3f Location
        {
            get
            {
                // Framelock is required here.
                // Point3f tends to have some funky issues if
                // not called within a framelock.
                using (new FrameLock(true))
                {
                    return GetMember<Point3f>("Location");
                }
            }
        }

        /// <summary>
        /// Gets the X coordinate.
        /// </summary>
        /// <value>The X.</value>
        public float X { get { return GetMember<float>("X"); } }

        /// <summary>
        /// Gets the Y coordinate.
        /// </summary>
        /// <value>The Y.</value>
        public float Y { get { return GetMember<float>("Y"); } }

        /// <summary>
        /// Gets the Z coordinate.
        /// </summary>
        /// <value>The Z.</value>
        public float Z { get { return GetMember<float>("Z"); } }

        /// <summary>
        /// Gets the distance this <see cref="Actor"/> is away from us.
        /// </summary>
        /// <value>The distance.</value>
        public float Distance { get { return GetMember<float>("Distance"); } }

        /// <summary>
        /// If the actor is not a pawn type, this will return NULL
        /// </summary>
        public Pawn ToPawn
        {
            get
            {
                //return (Pawn) this;
                return GetMember<Pawn>("ToPawn");
            }
        }

        /// <summary>
        /// ie, provides collision
        /// </summary>
        public bool IsCollidable { get { return GetMember<bool>("IsCollidable"); } }

        /// <summary>
        /// Gets the collision radius.
        /// </summary>
        /// <value>The collision radius.</value>
        public float CollisionRadius { get { return GetMember<float>("CollisionRadius"); } }

        /// <summary>
        /// Gets the height of the collision.
        /// </summary>
        /// <value>The height of the collision.</value>
        public float CollisionHeight { get { return GetMember<float>("CollisionHeight"); } }

        /// <summary>
        /// Performs an explicit conversion from <see cref="Vanguard.ISXVG.Actor"/> to <see cref="Vanguard.ISXVG.Pawn"/>.
        /// </summary>
        /// <param name="a">A.</param>
        /// <returns>The result of the conversion.</returns>
        public static explicit operator Pawn(Actor a)
        {
            return a.GetMember<Pawn>("ToPawn");
        }
    }
}