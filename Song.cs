using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class Song : LavishScriptObject
    {
        public Song(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public Song(string Arg)
            : base(LavishScript.Objects.GetObject("Song", Arg))
        {
        }
        public string Name
        {
            get
            {
                return GetMember<string>("Name");
            }
        }
        public string Description
        {
            get
            {
                return GetMember<string>("Description");
            }
        }
        public Ability Melody()
        {
            LavishScriptObject Obj = GetMember("Melody");
            return new Ability(Obj);
        }
        public int VerseCount
        {
            get
            {
                return GetMember<int>("Verse");
            }
        }
        public Ability Verse(int Index)
        {
            LavishScriptObject Obj = GetMember("Verse", Index.ToString());
            return new Ability(Obj);
        }
        public int EmbellishmentCount
        {
            get
            {
                return GetMember<int>("Embellishment");
            }
        }
        public Ability Embellishment(int Index)
        {
            LavishScriptObject Obj = GetMember("Embellishment", Index.ToString());
            return new Ability(Obj);
        }
        public int BridgeCount
        {
            get
            {
                return GetMember<int>("Bridge");
            }
        }
        public Ability Bridge(int Index)
        {
            LavishScriptObject Obj = GetMember("Bridge", Index.ToString());
            return new Ability(Obj);
        }
        public int LyricCount
        {
            get
            {
                return GetMember<int>("Lyric");
            }
        }
        public Ability Lyric(int Index)
        {
            LavishScriptObject Obj = GetMember("Lyric", Index.ToString());
            return new Ability(Obj);
        }
        public int ChorusCount
        {
            get
            {
                return GetMember<int>("Chorus");
            }
        }
        public Ability Chorus(int Index)
        {
            LavishScriptObject Obj = GetMember("Chorus", Index.ToString());
            return new Ability(Obj);
        }
        public int CodaCount
        {
            get
            {
                return GetMember<int>("Coda");
            }
        }
        public Ability Coda(int Index)
        {
            LavishScriptObject Obj = GetMember("Coda", Index.ToString());
            return new Ability(Obj);
        }

        public bool Perform()
        {
            return ExecuteMethod("Perform");
        }
    }
}
