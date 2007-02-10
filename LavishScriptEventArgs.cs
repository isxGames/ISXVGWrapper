using System;
using System.Collections.Generic;
using System.Text;

namespace Vanguard.ISXVG
{
public class LavishScriptEventArgs : EventArgs 
{
    private readonly int argC;
    private readonly uint argV;
    private readonly object thisObject;

    public LavishScriptEventArgs(int ArgC, uint ArgV, object ThisObject) 
    {
        argC = ArgC;
        argV = ArgV;
        thisObject = ThisObject;
    }

    public int ArgC
    {  
      get { return argC; }
    }

    public uint ArgV 
    {
      get { return argV; } 
    }
    
    /// <summary>
    /// Reserved, not implemented
    /// </summary>
    public object ThisObject
    {
        get { return thisObject; }
    }
}


}
