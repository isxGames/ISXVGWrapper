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


        /*

        private string _name;
        public string Name
        {
            get
            {
                GetData<string>(ref _name, "Name");
                return _name;
            }
        }

        private Int64 _id;
        public Int64 ID
        {
            get
            {
                GetData<Int64>(ref _id, "ID");
                return _id;
            }
        }

        private string _type;
        public string Type
        {
            get
            {
                GetData<string>(ref _type, "Type");
                return _type;
            }
        }

        private float _x;
        public float X
        {
            get
            {
                GetData<float>(ref _x, "X");
                return _x;
            }
        }

        private float _y;
        public float Y
        {
            get
            {
                GetData<float>(ref _y, "Y");
                return _y;
            }
        }

        private float _z;
        public float Z
        {
            get
            {
                GetData<float>(ref _z, "Z");
                return _z;
            }
        }

        private int _pitch;
        public int Pitch
        {
            get
            {
                GetData<int>(ref _pitch, "Pitch");
                return _pitch;
            }
        }

        private int _yaw;
        public int Yaw
        {
            get
            {
                GetData<int>(ref _yaw, "Yaw");
                return _yaw;
            }
        }

        private int _roll;
        public int Roll
        {
            get
            {
                GetData<int>(ref _roll, "Roll");
                return _roll;
            }
        }

        private float _distance;
        public float Distance
        {
            get
            {
                GetData<float>(ref _distance, "Distance");
                return _distance;
            }
        }

        private float _twoDemDistance;
        public float TwoDemDistance
        {
            get
            {
                GetData<float>(ref _twoDemDistance, "TwoDemDistance");
                return _twoDemDistance;
            }
        }

        private float _headingTo;
        public float HeadingTo
        {
            get
            {
                GetData<float>(ref _headingTo, "HeadingTo");
                return _headingTo;
            }
        }

        private int _level;
        public int Level
        {
            get
            {
                GetData<int>(ref _level, "Level");
                return _level;
            }
        }

        private string _gender;
        public string Gender
        {
            get
            {
                GetData<string>(ref _gender, "Gender");
                return _gender;
            }
        }

        private string _trueGender;
        public string TrueGender
        {
            get
            {
                GetData<string>(ref _trueGender, "TrueGender");
                return _trueGender;
            }
        }

        private string _race;
        public string Race
        {
            get
            {
                GetData<string>(ref _race, "Race");
                return _race;
            }
        }

        private string _raceAbr;
        public string RaceAbr
        {
            get
            {
                GetData<string>(ref _raceAbr, "RaceAbr");
                return _raceAbr;
            }
        }

        private string _posture;
        public string Posture
        {
            get
            {
                GetData<string>(ref _posture, "Posture");
                return _posture;
            }
        }

        private int _combatState;
        public int CombatState
        {
            get
            {
                GetData<int>(ref _combatState, "CombatState");
                return _combatState;
            }
        }

        private int _guildID;
        public int GuildID
        {
            get
            {
                GetData<int>(ref _guildID, "GuildID");
                return _guildID;
            }
        }

        private int _factionID;
        public int FactionID
        {
            get
            {
                GetData<int>(ref _factionID, "FactionID");
                return _factionID;
            }
        }

        private float _speed;
        public float Speed
        {
            get
            {
                GetData<float>(ref _speed, "Speed");
                return _speed;
            }
        }

        private float _maxSpeed;
        public float MaxSpeed
        {
            get
            {
                GetData<float>(ref _maxSpeed, "MaxSpeed");
                return _maxSpeed;
            }
        }

        private bool _canSeeMeIfInRange;
        public bool CanSeeMeIfInRange
        {
            get
            {
                GetData<bool>(ref _canSeeMeIfInRange, "CanSeeMeIfInRange");
                return _canSeeMeIfInRange;
            }
        }

        private bool _canSeeIfInRange;
        public bool CanSeeIfInRange(Int64 actorid)
        {
            GetData<bool>(ref _canSeeIfInRange, "CanSeeIfInRange[" + actorid + "]");
            return _canSeeIfInRange;
        }

        private bool _canSeeMeIfStealthed;
        public bool CanSeeMeIfStealthed
        {
            get
            {
                GetData<bool>(ref _canSeeMeIfStealthed, "CanSeeMeIfStealthed");
                return _canSeeMeIfStealthed;
            }
        }

        private bool _CanSeeIfStealthed;
        public bool CanSeeIfStealthed(Int64 actorid)
        {
            GetData<bool>(ref _CanSeeIfStealthed, "CanSeeIfStealthed[" + actorid + "]");
            return _CanSeeIfStealthed;
        }

        private bool _canFly;
        public bool CanFly
        {
            get
            {
                GetData<bool>(ref _canFly, "CanFly");
                return _canFly;
            }
        }

        private bool _canSwim;
        public bool CanSwim
        {
            get
            {
                GetData<bool>(ref _canSwim, "CanSwim");
                return _canSwim;
            }
        }

        private bool _isDead;
        public bool IsDead
        {
            get
            {
                GetData<bool>(ref _isDead, "IsDead");
                return _isDead;
            }
        }

        private bool _isStealthed;
        public bool IsStealthed
        {
            get
            {
                GetData<bool>(ref _isStealthed, "IsStealthed");
                return _isStealthed;
            }
        }

        private bool _isLFG;
        public bool IsLFG
        {
            get
            {
                GetData<bool>(ref _isLFG, "IsLFG");
                return _isLFG;
            }
        }

        private bool _isInOffensiveForm;
        public bool IsInOffensiveForm
        {
            get
            {
                GetData<bool>(ref _isInOffensiveForm, "IsInOffensiveForm");
                return _isInOffensiveForm;
            }
        }

        private bool _isOutside;
        public bool IsOutside
        {
            get
            {
                GetData<bool>(ref _isOutside, "IsOutside");
                return _isOutside;
            }
        }

        private bool _isIndoors;
        public bool IsIndoors
        {
            get
            {
                GetData<bool>(ref _isIndoors, "IsIndoors");
                return _isIndoors;
            }
        }

        private bool _isAggro;
        public bool IsAggro
        {
            get
            {
                GetData<bool>(ref _isAggro, "IsAggro");
                return _isAggro;
            }
        }

        private bool _isGroupMember;
        public bool IsGroupMember
        {
            get
            {
                GetData<bool>(ref _isGroupMember, "IsGroupMember");
                return _isGroupMember;
            }
        }

        private bool _isAttackable;
        public bool IsAttackable
        {
            get
            {
                GetData<bool>(ref _isAttackable, "IsAttackable");
                return _isAttackable;
            }
        }

        private bool _isClickable;
        public bool IsClickable
        {
            get
            {
                GetData<bool>(ref _isClickable, "IsClickable");
                return _isClickable;
            }
        }

        private bool _isAPet;
        public bool IsAPet
        {
            get
            {
                GetData<bool>(ref _isAPet, "IsAPet");
                return _isAPet;
            }
        }

        private float _cullDistance;
        public float CullDistance
        {
            get
            {
                GetData<float>(ref _cullDistance, "CullDistance");
                return _cullDistance;
            }
        }

        private bool _hasQuestFlag;
        public bool HasQuestFlag
        {
            get
            {
                GetData<bool>(ref _hasQuestFlag, "HasQuestFlag");
                return _hasQuestFlag;
            }
        }

        private string _questFlagColor;
        public string QuestFlagColor
        {
            get
            {
                GetData<string>(ref _questFlagColor, "QuestFlagColor");
                return _questFlagColor;
            }
        }

        private bool _containsLoot;
        public bool ContainsLoot
        {
            get
            {
                GetData<bool>(ref _containsLoot, "ContainsLoot");
                return _containsLoot;
            }
        }

        private string _title;
        public string Title
        {
            get
            {
                GetData<string>(ref _title, "Title");
                return _title;
            }
        }

        private string _titlePre;
        public string TitlePre
        {
            get
            {
                GetData<string>(ref _titlePre, "TitlePre");
                return _titlePre;
            }
        }

        private string _titlePost;
        public string TitlePost
        {
            get
            {
                GetData<string>(ref _titlePost, "TitlePost");
                return _titlePost;
            }
        }

        private bool _haveLOSTo;
        public bool HaveLOSTo
        {
            get
            {
                GetData<bool>(ref _haveLOSTo, "HaveLOSTo");
                return _haveLOSTo;
            }
        }

        private bool _ownedByMe;
        public bool OwnedByMe
        {
            get
            {
                GetData<bool>(ref _ownedByMe, "OwnedByMe");
                return _ownedByMe;
            }
        }

        private bool _ownerIsMe;
        public bool OwnerIsMe
        {
            get
            {
                GetData<bool>(ref _ownerIsMe, "OwnerIsMe");
                return _ownerIsMe;
            }
        }

        private Pawn _owner;
        public Pawn Owner
        {
            get
            {
                _owner = new Pawn(Args + ".Owner",1);
                return _owner;
            }
        }

        public void Loot()
        {
            LavishScript.ExecuteCommand(Args + ":Loot");
        }

        public void Target()
        {
            LavishScript.ExecuteCommand(Args + ":Target");
        }

        public void Face()
        {
            LavishScript.ExecuteCommand(Args + ":Face");
        }

        public void Use()
        {
            LavishScript.ExecuteCommand(Args + ":Use");
        }
        */
    }
}
