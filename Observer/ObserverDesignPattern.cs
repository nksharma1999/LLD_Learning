interface ISubscriber
{
    void Update();
}

interface IChannel
{
    void Subscribe(ISubscriber subscriber);
    void Unsubscribe(ISubscriber subscriber);
    void NotifySubscribers();
}

class Channel : IChannel
{
    private List<ISubscriber> subscribers = new List<ISubscriber>();
    private string channelName;
    private string latestVideo;

    public Channel(string channelName)
    {
        this.channelName = channelName;
    }

    public void Subscribe(ISubscriber subscriber)
    {
        if(!subscribers.Contains(subscriber))
        {
            subscribers.Add(subscriber);
        }
    }

    public void Unsubscribe(ISubscriber subscriber)
    {
        if(subscribers.Contains(subscriber))
        {
            subscribers.Remove(subscriber);
        }
    }

    public void NotifySubscribers()
    {
        foreach (var subscriber in subscribers)
        {
            subscriber.Update();
        }
    }

    public void UploadVideo(string videoTitle)
    {
        latestVideo = videoTitle;
        Console.WriteLine($"New video uploaded on {channelName}: {videoTitle}");
        NotifySubscribers();
    }

    public string GetLatestVideo()
    {
        return "Latest video on " + channelName + ": " + latestVideo;
    }
}

class Subscriber : ISubscriber
{
    private string subscriberName;
    private Channel channel;

    public Subscriber(string subscriberName, Channel channel)
    {
        this.subscriberName = subscriberName;
        this.channel = channel;
        channel.Subscribe(this);
    }

    public void Update()
    {
        Console.WriteLine($"{subscriberName} received notification: {channel.GetLatestVideo()}");
    }
}

class ObserverDesignPatternExample
{
    public void Initialize()
    {
        Channel techChannel = new Channel("Tech Insights");
        Subscriber alice = new Subscriber("Alice", techChannel);
        Subscriber bob = new Subscriber("Bob", techChannel);

        techChannel.Subscribe(alice);
        techChannel.Subscribe(bob);

        techChannel.UploadVideo("Understanding Observer Pattern");
        techChannel.UploadVideo("Advanced C# Techniques");

        techChannel.Unsubscribe(bob);
        techChannel.UploadVideo("Design Patterns in Depth");
    }
}