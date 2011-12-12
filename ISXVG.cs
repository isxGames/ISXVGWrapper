using System;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    /// <summary>
    /// 
    /// </summary>
    public enum IsxVgConnectionState
    {
        /// <summary>
        /// 
        /// </summary>
        NULL = -1,
        /// <summary>
        /// 
        /// </summary>
        AtCharacterSelect,
        /// <summary>
        /// 
        /// </summary>
        InCharacterCustomization,
        /// <summary>
        /// 
        /// </summary>
        InGame,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
        /// <summary>
        /// 
        /// </summary>
        Unset
    }

    public class ISXVG : LavishScriptObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ISXVG"/> class.
        /// </summary>
        /// <param name="Copy"></param>
        public ISXVG(LavishScriptObject Copy) : base(Copy) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="ISXVG"/> class.
        /// </summary>
        public ISXVG() : base(LavishScript.Objects.GetObject("ISXVG")) {}

        /// <summary>
        /// Gets the number of radars of this <see cref="ISXVG"/>.
        /// </summary>
        /// <value>The num radars.</value>
        public int NumRadars { get { return GetMember<int>("NumRadars"); } }

        /// <summary>
        /// Gets the VG locs count of this <see cref="ISXVG"/>.
        /// </summary>
        /// <value>The VG locs count.</value>
        public int VGLocsCount { get { return GetMember<int>("VGLocsCount"); } }

        /// <summary>
        /// Gets the version of this <see cref="ISXVG"/>.
        /// </summary>
        /// <value>The version.</value>
        public string Version { get { return GetMember<string>("Version"); } }

        /// <summary>
        /// Gets the state of the connection.
        /// </summary>
        /// <value>The state of the connection.</value>
        [Obsolete("Use the State property instead.")]
        public string ConnectionState { get { return GetMember<string>("ConnectionState"); } }

        /// <summary>
        /// Gets the connection state of this <see cref="ISXVG"/>.
        /// </summary>
        /// <value>The state.</value>
        public IsxVgConnectionState State
        {
            get
            {
                switch (GetMember<string>("ConnectionState"))
                {
                    case "AT_CHARACTER_SELECT":
                        return IsxVgConnectionState.AtCharacterSelect;
                    case "IN_CHARACTER_CUSTOMIZATION":
                        return IsxVgConnectionState.InCharacterCustomization;
                    case "IN_GAME":
                        return IsxVgConnectionState.InGame;
                    case "Unknown":
                        return IsxVgConnectionState.Unknown;
                    case "Unset":
                        return IsxVgConnectionState.Unset;
                    default:
                        return IsxVgConnectionState.NULL;
                }
            }
        }

        /// <summary>
        /// Gets the clip board text of this <see cref="ISXVG"/>.
        /// </summary>
        /// <value>The clip board text.</value>
        public string ClipBoardText { get { return GetMember<string>("ClipBoardText"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="ISXVG"/> is ready.
        /// This is TRUE once ISXVG has finished with the patching and authentication procedures completely. 
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="ISXVG"/> is ready; otherwise, <c>false</c>.
        /// </value>
        public bool IsReady { get { return GetMember<bool>("IsReady"); } }

        /// <summary>
        /// Saves a custom location in isxvglocations.xml. These are available through the VGLoc TLO (vgloc datatype) 
        /// </summary>
        /// <param name="Label">The label.</param>
        /// <returns></returns>
        public bool AddLoc(string Label)
        {
            return ExecuteMethod("AddLoc", Label);
        }

        /// <summary>
        /// Saves a custom location in isxvglocations.xml. These are available through the VGLoc TLO (vgloc datatype) 
        /// </summary>
        /// <param name="Label">The label.</param>
        /// <param name="Notes">The notes.</param>
        /// <returns></returns>
        public bool AddLoc(string Label, string Notes)
        {
            return ExecuteMethod("AddLoc", Label, Notes);
        }

        /// <summary>
        /// This method is here in case you get to windowed mode and are unable to alt-tab. 
        /// (It is only usable from windowed mode.) This is one method you should memorize as it's 
        /// VERY useful for fixing this particular Sigil bug. 
        /// </summary>
        /// <returns></returns>
        public bool FixAltTab()
        {
            return ExecuteMethod("FixAltTab");
        }
    }
}