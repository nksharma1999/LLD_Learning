using SolidPrinciple.S;

class SolidPrincipleExample
{
    public void Run()
    {
        //Solid Principle - Single Responsibility Principle
        SInitialization sInitialization = new();
        SInitialization.Initialize();
        //Solid Principle - Open-Closed Principle
        OInitialization oInitialization = new();
        oInitialization.Initialization();
        //Solid Principle - Liskov Substitution Principle
        LInitialization lInitialization = new();
        lInitialization.Initialization();
        //Solid Principle - Interface Segregation Principle
        IInitialization iInitialization = new();
        iInitialization.Initialize();
        //Solid Principle - Dependency Inversion Principle
        DInitialization dInitialization = new();
        dInitialization.Initialize();
    }
}