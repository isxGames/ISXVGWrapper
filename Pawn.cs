using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class Pawn : LavishScriptPersistentObject
    {
        public Pawn(params string[] Args)
            :
            base(LavishScript.Objects.GetPersistentObject("Pawn",Args))
        {
        }

        public Pawn(LavishScriptPersistentObject Copy)
            :
            base(Copy)
        {
        }

        public string Name
        {
            get
            {
                return GetMember<string>("Name");
            }
        }

        public Int64 ID
        {
            get
            {
                return GetMember<Int64>("ID");
            }
        }

        public string Type
        {
            get
            {
                return GetMember<string>("Type");
            }
        }

        public Point3f Location
        {
            get
            {
                return GetMember<Point3f>("Location");
            }
        }

        public Point3f Velocity
        {
            get
            {
                return GetMember<Point3f>("Velocity");
            }
        }

        public bool IsMoving
        {
            get
            {
                return GetMember<bool>("IsMoving");
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
        public int Level
        {
            get
            {
                return GetMember<int>("Level");
            }
        }
        /// <summary>
        /// This is the heading that the pawn is currently facing and/or heading.  Not to be confused with "HeadingTo", which
        /// is the heading YOU would take to reach the pawn.
        /// </summary>
        public int Heading
        {
            get
            {
                return GetMember<int>("Heading");
            }
        }
        public int Pitch
        {
            get
            {
                return GetMember<int>("Pitch");
            }
        }

        public int Yaw
        {
            get
            {
                return GetMember<int>("Yaw");
            }
        }

        public int Roll
        {
            get
            {
                return GetMember<int>("Roll");
            }
        }

        public float Distance
        {
            get
            {
                return GetMember<float>("Distance");
            }
        }

        public float TwoDemDistance
        {
            get
            {
                return GetMember<float>("TwoDemDistance");
            }
        }

        public float HeadingTo
        {
            get
            {
                return GetMember<float>("HeadingTo");
            }
        }

        public string Gender
        {
            get
            {
                return GetMember<string>("Gender");
            }
        }

        public string TrueGender
        {
            get
            {
                return GetMember<string>("TrueGender");
            }
        }

        public int RaceID
        {
            get
            {
                return GetMember<int>("RaceID");
            }
        }

        public bool IsMounted
        {
            get
            {
                return GetMember<bool>("IsMounted");
            }
        }

        public string Race
        {
            get
            {
                return GetMember<string>("Race");
            }
        }

        public string RaceAbr
        {
            get
            {
                return GetMember<string>("RaceAbr");
            }
        }

        public string Posture
        {
            get
            {
                return GetMember<string>("Posture");
            }
        }

        public int CombatState
        {
            get
            {
                return GetMember<int>("CombatState");
            }
        }

        public int GuildID
        {
            get
            {
                return GetMember<int>("GuildID");
             }
        }
        /// <summary>
        /// works for PCs only
        /// </summary>
        public int PVPPoints
        {
            get
            {
                return GetMember<int>("PVPPoints");
            }
        }

        public int FactionID
        {
            get
            {
                return GetMember<int>("FactionID");
            }
        }

        public float Speed
        {
            get
            {
                return GetMember<float>("Speed");
            }
        }

        public float MaxSpeed
        {
            get
            {
                return GetMember<float>("MaxSpeed");
            }
        }

        public bool CanSeeMeIfInRange
        {
            get
            {
                return GetMember<bool>("CanSeeMeIfInRange");
            }
        }

        public bool CanSeeMeIfStealthed
        {
            get
            {
                return GetMember<bool>("CanSeeMeIfStealthed");
            }
        }

        public bool CanFly
        {
            get
            {
                return GetMember<bool>("CanFly");
            }
        }

        public bool CanSwim
        {
            get
            {
                return GetMember<bool>("CanSwim");
            }
        }

        public bool IsDead
        {
            get
            {
                return GetMember<bool>("IsDead");
            }
        }

        public bool IsStealthed
        {
            get
            {
                return GetMember<bool>("IsStealthed");
            }
        }

        public bool IsLFG
        {
            get
            {
                return GetMember<bool>("IsLFG");
            }
        }

        public bool IsInOffensiveForm
        {
            get
            {
                return GetMember<bool>("IsInOffensiveForm");
            }
        }

        public bool IsOutside
        {
            get
            {
                return GetMember<bool>("IsOutside");
            }
        }

        public bool IsIndoors
        {
            get
            {
                return GetMember<bool>("IsIndoors");
            }
        }

        public bool IsAggro
        {
            get
            {
                return GetMember<bool>("IsAggro");
            }
        }

        public bool IsGroupMember
        {
            get
            {
                return GetMember<bool>("IsGroupMember");
            }
        }

        public bool IsInMyGroup
        {
            get
            {
                return GetMember<bool>("IsInMyGroup");
            }
        }

        public bool IsAttackable
        {
            get
            {
                return GetMember<bool>("IsAttackable");
            }
        }

        public bool IsClickable
        {
            get
            {
                return GetMember<bool>("IsClickable");
            }
        }

        public bool IsAPet
        {
            get
            {
                return GetMember<bool>("IsAPet");
            }
        }

        public float CullDistance
        {
            get
            {
                return GetMember<float>("CullDistance");
            }
        }

        public bool HasQuestFlag
        {
            get
            {
                return GetMember<bool>("HasQuestFlag");
            }
        }

        public string QuestFlagColor
        {
            get
            {
                return GetMember<string>("QuestFlagColor");
            }
        }

        public bool ContainsLoot
        {
            get
            {
                return GetMember<bool>("ContainsLoot");
            }
        }

        public bool IsHarvestable
        {
            get
            {
                return GetMember<bool>("IsHarvestable");
            }
        }

        public string Title
        {
            get
            {
                return GetMember<string>("Title");
            }
        }

        public string TitlePre
        {
            get
            {
                return GetMember<string>("TitlePre");
            }
        }

        public string TitlePost
        {
            get
            {
                return GetMember<string>("TitlePost");
            }
        }

        public bool HaveLOSTo
        {
            get
            {
                return GetMember<bool>("HaveLOSTo");
            }
        }

        public bool OwnedByMe
        {
            get
            {
                return GetMember<bool>("OwnedByMe");
            }
        }

        public bool OwnerIsMe
        {
            get
            {
                return GetMember<bool>("OwnerIsMe");
            }
        }
        public bool IsStunned
        {
            get
            {
                return GetMember<bool>("IsStunned");
            }
        }
        public bool IsReady
        {
            get
            {
                return GetMember<bool>("IsReady");
            }
        }

        public Pawn Owner
        {
            get
            {
                LavishScriptPersistentObject Obj = GetPersistentMember("Owner");
                return new Pawn(Obj);
            }
        }
        public Actor CheckCollision()
        {
                LavishScriptObject Obj = GetMember("CheckCollision");
                return new Actor(Obj);

        }
        public Actor CheckCollision(float X, float Y, float Z)
        {
                LavishScriptObject Obj = GetMember("CheckCollision", X.ToString(), Y.ToString(), Z.ToString());
                return new Actor(Obj);
        }
        public Actor ToActor
        {
            get
            {
                return GetMember<Actor>("ToActor");
            }
        }


        public bool Loot()
        {
            return ExecuteMethod("Loot");
        }

        public bool LootAll()
        {
            return ExecuteMethod("LootAll");
        }

        public bool Target()
        {
            return ExecuteMethod("Target"); 
        }

        public bool Face()
        {
            return ExecuteMethod("Face");
        }

        /// <summary>
        /// As of 3.31.2007, this method works for the following pawn types:  Banker, Broker, Taskmaster, Merchant, Trainer, QuestNPC, 
        /// Corpse, Mailbox, Crafting Station, and Resource.
        /// </summary>
        /// <returns></returns>
        public bool DoubleClick()
        {
            return ExecuteMethod("DoubleClick");
        }

    }
}
