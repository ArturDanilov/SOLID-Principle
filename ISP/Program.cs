using ISP;

Human human = new ();
Robot robot = new ();

Console.WriteLine("Human: ");
human.Work();
human.Eat();

Console.WriteLine("\nRobot: ");
robot.Work();

internal class Human : IWorker, IEat
{

    public void Work()
    {
        Console.WriteLine("I work...");
    }
    public void Eat()
    {
        Console.WriteLine("I eat...");
    }
}

internal class Robot : IWorker
{
    public void Work()
    {
        Console.WriteLine("I work...");
    }
}