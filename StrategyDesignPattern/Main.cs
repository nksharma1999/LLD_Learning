class StrategyDesignMain
{
    public void Initialize()
    {
        Robot robot1 = new Robot(new NormalWalk(),new NormalFly(), new NormalTalk(), new NoSwim(), new NormalProjection());
        robot1.Walk();
        robot1.Fly();
        robot1.Talk();
        robot1.Swim();
        robot1.Projection();
        Console.WriteLine("---------------------------------------------------");
        Robot robot2 = new Robot(new NormalWalk(),new NormalFly(), new NoTalk(), new NoSwim(), new NoProjection());
        robot2.Walk();
        robot2.Fly();
        robot2.Talk();
        robot2.Swim();
        robot2.Projection();
    }
}