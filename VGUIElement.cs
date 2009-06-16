using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    /// <summary>
    /// 
    /// </summary>
    public class VGUIElement : LavishScriptObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VGUIElement"/> class.
        /// </summary>
        /// <param name="Obj">The obj.</param>
        public VGUIElement(LavishScriptObject Obj)
            : base(Obj) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="VGUIElement"/> class.
        /// </summary>
        /// <param name="Args">The args.</param>
        public VGUIElement(params string[] Args)
            : base(LavishScript.Objects.GetObject("VGUIElement", Args)) {}

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="VGUIElement"/> is visible.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="VGUIElement"/> is visible; otherwise, <c>false</c>.
        /// </value>
        public bool IsVisible { get { return GetMember<bool>("IsVisible"); } }

        /// <summary>
        /// Gets a value indicating whether this <seealso cref="VGUIElement"/> is enabled.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this <seealso cref="VGUIElement"/> is enabled; otherwise, <c>false</c>.
        /// </value>
        public bool IsEnabled { get { return GetMember<bool>("IsEnabled"); } }

        /// <summary>
        /// Gets the name of this <see cref="VGUIElement"/>.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get { return GetMember<string>("Name"); } }

        /// <summary>
        /// Gets the text of this <see cref="VGUIElement"/>.
        /// </summary>
        /// <value>The text.</value>
        public string Text { get { return GetMember<string>("Text"); } }

        /// <summary>
        /// Gets the tooltip of this <see cref="VGUIElement"/>.
        /// </summary>
        /// <value>The tooltip.</value>
        public string Tooltip { get { return GetMember<string>("Tooltip"); } }

        /// <summary>
        /// Gets the parent of this <see cref="VGUIElement"/>.
        /// </summary>
        /// <returns></returns>
        public VGUIElement Parent()
        {
            LavishScriptObject Obj = GetMember("Parent");
            return new VGUIElement(Obj);
        }

        /// <summary>
        /// Example:  VGUI(_inventory_examine).Child(_inventory_examine_name).Text
        /// </summary>
        /// <param name="name">The parameter for this is the "name=" field in the xml files, not the "searchKey=" that the VGUI TLO uses.</param>
        /// <returns></returns>
        public VGUIElement Child(string name)
        {
            return GetMember<VGUIElement>("Child", name);
        }

        /// <summary>
        /// Currently only verified to work for "EditBox" type uielements
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public bool SetText(string text)
        {
            return ExecuteMethod("SetText", text);
        }
    }
}