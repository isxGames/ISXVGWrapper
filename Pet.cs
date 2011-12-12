using System;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    /// <summary>
    /// 
    /// </summary>
    public class Pet : LavishScriptObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Pet"/> class.
        /// </summary>
        /// <param name="Obj">The obj.</param>
        public Pet(LavishScriptObject Obj) : base(Obj) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="Pet"/> class.
        /// </summary>
        public Pet() : base(LavishScript.Objects.GetObject("Pet")) {}

        /// <summary>
        /// Gets the name of this <see cref="Pet"/>.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get { return GetMember<string>("Name"); } }

        /// <summary>
        /// Gets the ID of this <see cref="Pet"/>.
        /// </summary>
        /// <value>The ID.</value>
        public Int64 ID { get { return GetMember<Int64>("ID"); } }

        /// <summary>
        /// Gets the health of this <see cref="Pet"/>.
        /// </summary>
        /// <value>The health.</value>
        public float Health { get { return GetMember<float>("Health"); } }

        /// <summary>
        /// Gets the ability count of this <see cref="Pet"/>.
        /// </summary>
        /// <value>The ability count.</value>
        public int AbilityCount { get { return GetMember<int>("AbilityCount"); } }

        /// <summary>
        /// Defaults the ability.
        /// </summary>
        /// <returns></returns>
        public PetAbility DefaultAbility()
        {
            LavishScriptObject Obj = GetMember("DefaultAbility");
            return new PetAbility(Obj);
        }

        /// <summary>
        /// Toes the pawn.
        /// </summary>
        /// <returns></returns>
        public Pawn ToPawn()
        {
            LavishScriptObject Obj = GetMember("ToPawn");
            return new Pawn(Obj);
        }

        /// <summary>
        /// Abilities this <see cref="Pet"/>.
        /// </summary>
        /// <returns></returns>
        public int Ability()
        {
            return GetMember<int>("Ability");
        }

        /// <summary>
        /// Abilities the specified arg.
        /// </summary>
        /// <param name="Arg">The arg.</param>
        /// <returns></returns>
        public PetAbility Ability(int Arg)
        {
            LavishScriptObject Obj = GetMember("Ability", Arg.ToString());
            return new PetAbility(Obj);
        }

        /// <summary>
        /// Abilities the specified arg.
        /// </summary>
        /// <param name="Arg">The arg.</param>
        /// <returns></returns>
        public PetAbility Ability(string Arg)
        {
            LavishScriptObject Obj = GetMember("Ability", Arg);
            return new PetAbility(Obj);
        }
    }
}