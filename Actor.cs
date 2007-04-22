using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class Actor : LavishScriptObject
    {
        public Actor(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public Actor(params string[] Args)
            : base(LavishScript.Objects.GetObject("Actor", Args))
        {
        }

        /// <summary>
        /// This will return the actor's base name, even if the actor is technically a pawn and has a legit 'display' name.
        /// </summary>
        public string Name
        {
            get
            {
                return GetMember<string>("Name");
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
        public float Distance
        {
            get
            {
                return GetMember<float>("Distance");
            }
        }
        /// <summary>
        /// If the actor is not a pawn type, this will return NULL
        /// </summary>
        public Pawn ToPawn
        {
            get
            {
                return GetMember<Pawn>("ToPawn");
            }
        }
        /// <summary>
        /// ie, provides collision
        /// </summary>
        public bool IsCollidable
        {
            get
            {
                return GetMember<bool>("IsCollidable");
            }
        }
        public float CollisionRadius
        {
            get
            {
                return GetMember<float>("CollisionRadius");
            }
        }
        public float CollisionHeight
        {
            get
            {
                return GetMember<float>("CollisionHeight");
            }
        }

    }
}