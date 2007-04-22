using System;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class VGUIElement : LavishScriptObject
    {
        public VGUIElement(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public VGUIElement(params string[] Args)
            : base(LavishScript.Objects.GetObject("VGUI", Args))
        {
        }

        public bool IsDrawn
        {
            get
            {
                return GetMember<bool>("IsDrawn");
            }
        }
        public bool IsVisible
        {
            get
            {
                return GetMember<bool>("IsVisible");
            }
        }
        public bool IsEnabled
        {
            get
            {
                return GetMember<bool>("IsEnabled");
            }
        }
        public VGUIElement Parent()
        {
            LavishScriptObject Obj = GetMember("Parent");
            return new VGUIElement(Obj);
        }
        /// <summary>
        /// Example:  VGUI(_inventory_examine).Child(_inventory_examine_name).Text
        /// </summary>
        /// <param name="Name">The parameter for this is the "name=" field in the xml files, not the "searchKey=" that the VGUI TLO uses.</param>
        /// <returns></returns>
        public VGUIElement Child(string Name)
        {
            return GetMember<VGUIElement>("Child", Name);
        }
        public string Name
        {
            get
            {
                return GetMember<string>("Name");
            }
        }
        public string Text
        {
            get
            {
                return GetMember<string>("Text");
            }
        }
        public string Tooltip
        {
            get
            {
                return GetMember<string>("Tooltip");
            }
        }

        /// <summary>
        /// Currently only verified to work for "EditBox" type uielements
        /// </summary>
        /// <param name="Text"></param>
        /// <returns></returns>
        public bool SetText(string Text)
        {
            return ExecuteMethod("SetText", Text);
        }

    }
}