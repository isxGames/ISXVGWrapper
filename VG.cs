using LavishScriptAPI;

// allows using LavishVMAPI.LavishVM.GetAPI without explicitly specifying LavishVMAPI

namespace Vanguard.ISXVG
{
    public class VG : LavishScriptPersistentObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VG"/> class.
        /// </summary>
        public VG()
            :
                base(LavishScript.Objects.GetPersistentObject("VG")) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="VG"/> class.
        /// </summary>
        /// <param name="Copy"></param>
        public VG(LavishScriptPersistentObject Copy)
            :
                base(Copy) {}

        /// <summary>
        /// Gets the language ID of this <see cref="VG"/>.
        /// </summary>
        /// <value>The language ID.</value>
        public int LanguageID { get { return GetMember<int>("LanguageID"); } }

        /// <summary>
        /// Gets the language subtype ID of this <see cref="VG"/>.
        /// </summary>
        /// <value>The language subtype ID.</value>
        public int LanguageSubtypeID { get { return GetMember<int>("LanguageSubtypeID"); } }

        /// <summary>
        /// Gets the pawn count of this <see cref="VG"/>.
        /// </summary>
        /// <value>The pawn count.</value>
        public int PawnCount { get { return GetMember<int>("PawnCount"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="VG"/> is swimming.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="VG"/> is swimming; otherwise, <c>false</c>.
        /// </value>
        public bool IsSwimming { get { return GetMember<bool>("IsSwimming"); } }

        /// <summary>
        /// Gets a value indicating whether [in global recovery].
        /// </summary>
        /// <value><c>true</c> if [in global recovery]; otherwise, <c>false</c>.</value>
        public bool InGlobalRecovery { get { return GetMember<bool>("InGlobalRecovery"); } }

        /// <summary>
        /// Gets the global recovery of this <see cref="VG"/>.
        /// </summary>
        /// <value>The global recovery.</value>
        public float GlobalRecovery { get { return GetMember<float>("GlobalRecovery"); } }

        /// <summary>
        /// Gets the group invite sender of this <see cref="VG"/>.
        /// </summary>
        /// <value>The group invite sender.</value>
        public string GroupInviteSender { get { return GetMember<string>("GroupInviteSender"); } }

        /// <summary>
        /// Gets the language of this <see cref="VG"/>.
        /// </summary>
        /// <value>The language.</value>
        public string Language { get { return GetMember<string>("Language"); } }

        /// <summary>
        /// Vanguards current build
        /// </summary>
        public string Version { get { return GetMember<string>("Version"); } }

        /// <summary>
        /// Gets the server ID of this <see cref="VG"/>.
        /// </summary>
        /// <value>The server ID.</value>
        public int ServerID { get { return GetMember<int>("ServerID"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="VG"/> is in parlay.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="VG"/> is in parlay; otherwise, <c>false</c>.
        /// </value>
        public bool IsInParlay { get { return GetMember<bool>("IsInParlay"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="VG"/> is minimized.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="VG"/> is minimized; otherwise, <c>false</c>.
        /// </value>
        public bool IsMinimized { get { return GetMember<bool>("IsMinimized"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="VG"/> is maximized.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="VG"/> is maximized; otherwise, <c>false</c>.
        /// </value>
        public bool IsMaximized { get { return GetMember<bool>("IsMaximized"); } }

        /// <summary>
        /// Gets a value indicating whether [in full screen mode].
        /// </summary>
        /// <value><c>true</c> if [in full screen mode]; otherwise, <c>false</c>.</value>
        public bool InFullScreenMode { get { return GetMember<bool>("InFullScreenMode"); } }

        /// <summary>
        /// Gets the install directory of this <see cref="VG"/>.
        /// </summary>
        /// <value>The install directory.</value>
        public string InstallDirectory { get { return GetMember<string>("InstallDirectory"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="VG"/> is converting.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="VG"/> is converting; otherwise, <c>false</c>.
        /// </value>
        public bool IsConverting { get { return GetMember<bool>("IsConverting"); } }

        /// <summary>
        /// Checks the collision.
        /// </summary>
        /// <param name="FromX">From X.</param>
        /// <param name="FromY">From Y.</param>
        /// <param name="FromZ">From Z.</param>
        /// <param name="ToX">To X.</param>
        /// <param name="ToY">To Y.</param>
        /// <param name="ToZ">To Z.</param>
        /// <returns></returns>
        public Actor CheckCollision(float FromX, float FromY, float FromZ, float ToX, float ToY, float ToZ)
        {
            LavishScriptObject Obj = GetMember("CheckCollision", FromX.ToString(), FromY.ToString(), FromZ.ToString(),
                                               ToX.ToString(), ToY.ToString(), ToZ.ToString());
            return new Actor(Obj);
        }

        /// <summary>
        /// Checks the collision.
        /// </summary>
        /// <param name="ToX">To X.</param>
        /// <param name="ToY">To Y.</param>
        /// <param name="ToZ">To Z.</param>
        /// <returns></returns>
        public Actor CheckCollision(float ToX, float ToY, float ToZ)
        {
            LavishScriptObject Obj = GetMember("CheckCollision", ToX.ToString(), ToY.ToString(), ToZ.ToString());
            return new Actor(Obj);
        }

        /// <summary>
        /// Toggles the full screen mode.
        /// </summary>
        /// <returns></returns>
        public bool ToggleFullScreenMode()
        {
            return ExecuteMethod("ToggleFullScreenMode");
        }

        /// <summary>
        /// Maximizes the window.
        /// </summary>
        /// <returns></returns>
        public bool MaximizeWindow()
        {
            return ExecuteMethod("MaximizeWindow");
        }

        /// <summary>
        /// Minimizes the window.
        /// </summary>
        /// <returns></returns>
        public bool MinimizeWindow()
        {
            return ExecuteMethod("MinimizeWindow");
        }

        /// <summary>
        /// Execs the binding.
        /// </summary>
        /// <param name="Action">The action.</param>
        /// <returns></returns>
        public bool ExecBinding(string Action)
        {
            return ExecuteMethod("ExecBinding", Action);
        }

        /// <summary>
        /// Execs the binding.
        /// </summary>
        /// <param name="Action">The action.</param>
        /// <param name="Release">if set to <c>true</c> [release].</param>
        /// <returns></returns>
        public bool ExecBinding(string Action, bool Release)
        {
            return Release
                       ? ExecuteMethod("ExecBinding", Action, "Release")
                       : ExecuteMethod("ExecBinding", Action);
        }

        /// <summary>
        /// Converts the item.
        /// </summary>
        /// <param name="Option">The option.</param>
        /// <returns></returns>
        public bool ConvertItem(int Option)
        {
            return ExecuteMethod("ConvertItem", Option.ToString());
        }

        /// <summary>
        /// Converts the item.
        /// </summary>
        /// <returns></returns>
        public bool ConvertItem()
        {
            return ExecuteMethod("ConvertItem");
        }
    }
}