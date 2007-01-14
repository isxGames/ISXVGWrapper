using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class Encounter : Wrapper
    {
        public Encounter()
        {
        }

        public Encounter(string tlo)
        {
            TLO = tlo;
        }

        public Encounter(int tlo)
        {
            TLO = tlo.ToString();
        }

        private string _name;
        public string Name
        {
            get
            {
                GetData<string>(ref _name, "Name");
                return _name;
            }
        }

        private int _pctHealth;
        public int PctHealth
        {
            get
            {
                GetData<int>(ref _pctHealth, "PctHealth");
                return _pctHealth;
            }
        }

        private int _distance;
        public int Distance
        {
            get
            {
                GetData<int>(ref _distance, "Distance");
                return _distance;
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

        private int _difficulty;
        public int Difficulty
        {
            get
            {
                GetData<int>(ref _difficulty, "Difficulty");
                return _difficulty;
            }
        }

        private Pawn _targetOfTarget;
        public Pawn TargetOfTarget
        {
            get
            {
                _targetOfTarget = new Pawn(TLO + ".TargetOfTarget",1);
                return _targetOfTarget;
            }
        }
    }
}
