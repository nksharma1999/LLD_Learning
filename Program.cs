using System;
using SolidPrinciple.S;

class Program
{
    static void Main()
    {
        SInitialization sInitialization = new();
        SInitialization.Initialize();
        OInitialization oInitialization = new();
        oInitialization.Initialization();
        LInitialization lInitialization = new();
        lInitialization.Initialization();
        IInitialization iInitialization = new();
        iInitialization.Initialize();
        DInitialization dInitialization = new();
        dInitialization.Initialize();
    }
}
