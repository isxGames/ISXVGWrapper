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
