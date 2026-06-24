interface WalkableRobot
{
    public void Walk();
}

class NormalWalk : WalkableRobot
{
    public void Walk()
    {
        Console.WriteLine("Robot is walking Normally");
    }
}

class NoWalk : WalkableRobot
{
    public void Walk()
    {
        Console.WriteLine("Robot cannot walk");
    }
}

interface FlyableRobot
{
    public void Fly();
}

class NormalFly : FlyableRobot
{
    public void Fly()
    {
        Console.WriteLine("Robot is flying Normally");
    }
}

class NoFly : FlyableRobot
{
    public void Fly()
    {
        Console.WriteLine("Robot cannot fly");
    }
}

interface TalkableRobot
{
    public void Talk();
}
class NormalTalk : TalkableRobot
{
    public void Talk()
    {
        Console.WriteLine("Robot is talking Normally");
    }
}

class NoTalk : TalkableRobot
{
    public void Talk()
    {
        Console.WriteLine("Robot cannot talk");
    }
}
interface SwimmableRobot
{
    public void Swim();
}

class NormalSwim : SwimmableRobot
{
    public void Swim()
    {
        Console.WriteLine("Robot is swimming Normally");
    }
}

class NoSwim : SwimmableRobot
{
    public void Swim()
    {
        Console.WriteLine("Robot cannot swim");
    }
}

interface ProjectableRobot
{
    public void Projection();
}

class NoProjection : ProjectableRobot
{
    public void Projection()
    {
        Console.WriteLine("Robot cannot project");
    }
}

class NormalProjection : ProjectableRobot
{
    public void Projection()
    {
        Console.WriteLine("Robot is projecting Normally");
    }
}


class Robot
{
    protected WalkableRobot walkableRobot;
    protected FlyableRobot flyableRobot;
    protected TalkableRobot talkableRobot;
    protected SwimmableRobot swimmableRobot;
    protected ProjectableRobot projectableRobot;
    private NormalFly normalFly;
    private NormalTalk normalTalk;
    private NormalSwim normalSwim;

    public Robot(WalkableRobot walkableRobot, FlyableRobot flyableRobot, TalkableRobot talkableRobot, SwimmableRobot swimmableRobot, ProjectableRobot projectableRobot)
    {
        this.walkableRobot = walkableRobot;
        this.flyableRobot = flyableRobot;
        this.talkableRobot = talkableRobot;
        this.swimmableRobot = swimmableRobot;
        this.projectableRobot = projectableRobot;
    }

    public void Walk()
    {
        walkableRobot.Walk();
    }

    public void Fly()
    {
        flyableRobot.Fly();
    }

    public void Talk()
    {
        talkableRobot.Talk();
    }

    public void Swim()
    {
        swimmableRobot.Swim();
    }

    public void Projection()
    {
        projectableRobot.Projection();
    }
}

class CompanionRobot : Robot
{
    public CompanionRobot(WalkableRobot walkableRobot, FlyableRobot flyableRobot, TalkableRobot talkableRobot, SwimmableRobot swimmableRobot, ProjectableRobot projectableRobot) 
        : base(walkableRobot, flyableRobot, talkableRobot, swimmableRobot, projectableRobot){}

    public void Projection()
    {
        Console.WriteLine("Companion Robot is projecting");
    }
}

class WorkerRobot : Robot
{
    public WorkerRobot(WalkableRobot walkableRobot, FlyableRobot flyableRobot, TalkableRobot talkableRobot, SwimmableRobot swimmableRobot, ProjectableRobot projectableRobot) 
        : base(walkableRobot, flyableRobot, talkableRobot, swimmableRobot, projectableRobot ){}

}

