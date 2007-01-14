using System;
using System.Text;
using System.Runtime.InteropServices;
using InnerSpaceAPI;
using LavishScriptAPI;
using LavishVMAPI;

namespace Vanguard.ISXVG
{
    public class ISXVGVG
    {
        public ISXVGVG()
        {
        }

        private int _pawnCount;
        public int PawnCount
        {
            get
            {
                GetData<int>(ref _pawnCount, "PawnCount");
                return _pawnCount;
            }
        }

        public ISXVGRadar Radar()
        {
            return new ISXVGRadar();
        }

        public ISXVGRadar Radar(string radar)
        {
            return new ISXVGRadar("Radar[" + radar + "]");
        }

        public ISXVGPawn Pawn(string pawn)
        {
            return new ISXVGPawn("Pawn[" + pawn + "]");
        }

        public void VGExecute(string command)
        {
            LavishScript.ExecuteCommand("VGExecute " + command);
        }

        public void VGEcho(string args)
        {
            LavishScript.ExecuteCommand("VGEcho");
        }

        public void Target()
        {
            LavishScript.ExecuteCommand("Target");
        }

        public void Target(string args)
        {
            LavishScript.ExecuteCommand("Target " + args);
        }

        public void Face()
        {
            LavishScript.ExecuteCommand("Face");
        }

        public void Face(string args)
        {
            LavishScript.ExecuteCommand("Face " + args);
        }

        public void Where()
        {
            LavishScript.ExecuteCommand("Where");
        }

        public void Where(string args)
        {
            LavishScript.ExecuteCommand("Where " + args);
        }

        public void ExecBinding(string action)
        {
            LavishScript.ExecuteCommand("VG:ExecBinding[" + action + "]");
        }

        public void ExecBinding(string action, string release)
        {
            LavishScript.ExecuteCommand("VG:ExecBinding[" + action + ",release]");
        }

        protected void GetData<T>(ref T obj, string param)
        {
            LavishScript.DataParse<T>("${VG." + param + "}", ref obj);
        }
    }
}
