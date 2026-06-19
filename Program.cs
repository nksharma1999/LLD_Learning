using System;
using SolidPrinciple.S;

class Program
{
    static void Main()
    {
        SInitialization sInitialization = new SInitialization();
        sInitialization.Initialize();
        OInitialization oInitialization = new OInitialization();
        oInitialization.Initialization();
        LInitialization lInitialization = new LInitialization();
        lInitialization.Initialization();
        IInitialization iInitialization = new IInitialization();
        iInitialization.Initialize();
        DInitialization dInitialization = new DInitialization();
        dInitialization.Initialize();
    }
}
