using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class VG
    {
        public VG()
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

        private bool _isSwimming;
        public bool IsSwimming
        {
            get
            {
                GetData<bool>(ref _isSwimming, "IsSwimming");
                return _isSwimming;
            }
        }

        private int _serverID;
        public int ServerID
        {
            get
            {
                GetData<int>(ref _serverID, "ServerID");
                return _serverID;
            }
        }

        public Radar Radar()
        {
            return new Radar();
        }

        public Radar Radar(string radar)
        {
            return new Radar("Radar[" + radar + "]");
        }

        public void VGExecute(string Command)
        {
            LavishScript.ExecuteCommand("VGExecute " + Command);
        }

        public void VGEcho(string Args)
        {
            LavishScript.ExecuteCommand("VGEcho " + Args);
        }

        public void Target()
        {
            LavishScript.ExecuteCommand("Target");
        }

        public void Target(string Args)
        {
            LavishScript.ExecuteCommand("Target " + Args);
        }

        public void Face()
        {
            LavishScript.ExecuteCommand("Face");
        }

        public void Face(string Args)
        {
            LavishScript.ExecuteCommand("Face " + Args);
        }

        public void Where()
        {
            LavishScript.ExecuteCommand("Where");
        }

        public void Where(string Args)
        {
            LavishScript.ExecuteCommand("Where " + Args);
        }

        public void ExecBinding(string Action)
        {
            LavishScript.ExecuteCommand("VG:ExecBinding[" + Action + "]");
        }

        public void ExecBinding(string Action, int Release)
        {
            LavishScript.ExecuteCommand("VG:ExecBinding[" + Action + ",release]");
        }

        protected void GetData<T>(ref T obj, string param)
        {
            LavishScript.DataParse<T>("${VG." + param + "}", ref obj);
        }
    }
}
