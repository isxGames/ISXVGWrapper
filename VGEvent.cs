using System;
using System.Text;

using LavishVMAPI;
using InnerSpaceAPI;
using LavishScriptAPI;

namespace Vanguard.ISXVG
{
    public class VGEvent
    {
        public static VGEvent Instance = new VGEvent();

        ~VGEvent()
        {
            LavishScript.Events.DetachEventTarget(Extension.GetVGEventID("VG_onStartSwimming"), Eventdel_VGEvent);
        }

        public VGEvent()
        {
            InnerSpace.Echo("Attaching Event: " + Extension.GetVGEventID("VG_onStartSwimming").ToString());
            LavishScript.Events.AttachEventTarget(Extension.GetVGEventID("VG_onStartSwimming"), Eventdel_VGEvent);
        }

        internal static LavishScriptAPI.Delegates.EventTarget Eventdel_VGEvent = Event_VGEvent;

        public static void Event_VGEvent(int argc, uint argv, Object ThisObject)
        {
            /* The event has been fired. argc is now the count of arguments, and argv is the token for GetArg */

            /* Let's echo the event name and the parameter count */
            InnerSpace.Echo("Event Fired: " + argc.ToString());
            /* Now let's echo each parameter individually */
            for (uint i = 0; i < argc; i++)
            {
                /* Echo the arg number, then the value */
                InnerSpace.Echo(i.ToString() + " = " + InnerSpace.GetArg<string>(i, argv));
            }
            /* all done! */
            InnerSpace.Echo("------------------");
        }
    }
}
