using System;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    /// <summary>
    /// This DataType includes all of the data available to ISXVG that is related to groups. 
    /// </summary>
    public class GroupMember : LavishScriptObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupMember"/> class.
        /// </summary>
        public GroupMember() : base(LavishScript.Objects.GetObject("GroupMember")) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupMember"/> class.
        /// </summary>
        /// <param name="Copy">The copy.</param>
        public GroupMember(LavishScriptObject Copy) : base(Copy) {}

        /// <summary>
        /// Gets the ID of this <see cref="GroupMember"/>.
        /// </summary>
        /// <value>The ID.</value>
        public Int64 ID { get { return GetMember<Int64>("ID"); } }

        /// <summary>
        /// Gets the name of this <see cref="GroupMember"/>.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get { return GetMember<string>("Name"); } }

        /// <summary>
        /// Gets the X of this <see cref="GroupMember"/>.
        /// </summary>
        /// <value>The X.</value>
        public float X { get { return GetMember<float>("X"); } }

        /// <summary>
        /// Gets the Y of this <see cref="GroupMember"/>.
        /// </summary>
        /// <value>The Y.</value>
        public float Y { get { return GetMember<float>("Y"); } }

        /// <summary>
        /// Gets the Z of this <see cref="GroupMember"/>.
        /// </summary>
        /// <value>The Z.</value>
        public float Z { get { return GetMember<float>("Z"); } }

        /// <summary>
        /// Gets the health of this <see cref="GroupMember"/>.
        /// </summary>
        /// <value>The health.</value>
        public float Health { get { return GetMember<float>("Health"); } }

        /// <summary>
        /// Gets the energy of this <see cref="GroupMember"/>.
        /// </summary>
        /// <value>The energy.</value>
        public float Energy { get { return GetMember<float>("Energy"); } }

        /// <summary>
        /// Gets the endurance of this <see cref="GroupMember"/>.
        /// </summary>
        /// <value>The endurance.</value>
        public float Endurance { get { return GetMember<float>("Endurance"); } }

        /// <summary>
        /// Gets the chunk X of this <see cref="GroupMember"/>.
        /// </summary>
        /// <value>The chunk X.</value>
        public int ChunkX { get { return GetMember<int>("ChunkX"); } }

        public int ChunkY { get { return GetMember<int>("ChunkY"); } }

        /// <summary>
        /// Gets the race of this <see cref="GroupMember"/>.
        /// </summary>
        /// <value>The race.</value>
        public string Race { get { return GetMember<string>("Race"); } }

        /// <summary>
        /// Gets the class of this <see cref="GroupMember"/>.
        /// </summary>
        /// <value>The class.</value>
        public string Class { get { return GetMember<string>("Class"); } }

        /// <summary>
        /// Gets the heading to of this <see cref="GroupMember"/>.
        /// </summary>
        /// <value>The heading to.</value>
        public int HeadingTo { get { return GetMember<int>("HeadingTo"); } }

        /// <summary>
        /// Gets the distance of this <see cref="GroupMember"/>.
        /// </summary>
        /// <value>The distance.</value>
        public float Distance { get { return GetMember<float>("Distance"); } }

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
        /// Remove from the group if you're the group leader
        /// </summary>
        /// <returns></returns>
        public bool Boot()
        {
            return ExecuteMethod("Boot");
        }

        /// <summary>
        /// Makes the master looter.
        /// </summary>
        /// <returns></returns>
        public bool MakeMasterLooter()
        {
            return ExecuteMethod("MakeMasterLooter");
        }
    }
}