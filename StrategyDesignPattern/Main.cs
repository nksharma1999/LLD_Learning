class StrategyDesignMain
{
    public void Initialize()
    {
        Robot robot1 = new Robot(new NormalWalk(),new NormalFly(), new NormalTalk(), new NormalSwim());
        robot1.Walk();
        robot1.Fly();
        robot1.Talk();
        robot1.Swim();
        Console.WriteLine("---------------------------------------------------");
        Robot robot2 = new Robot(new NoWalk(), new NoFly(), new NoTalk(), new NoSwim());
        robot2.Walk();
        robot2.Fly();
        robot2.Talk();
        robot2.Swim();
    }
}