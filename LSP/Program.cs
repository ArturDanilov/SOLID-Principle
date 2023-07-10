using LSP;

//adherence to the Liskov substitution principle,
//since the generated classes behave as expected from the Eat() method
public class Dog : Animal
{
    public override void Eat()
    {
        Console.WriteLine("The dog eats dog food...");
    }
}
public class Lion : Animal
{
    public override void Eat()
    {
        Console.WriteLine("The lion eats a zebra...");
    }
}
public class Zebra : Animal
{
    public override void Eat()
    {
        Console.WriteLine("The zebra eats grass...");
    }
}

//RobotDog violates the Liskov substitution principle
//because it changes the expected behavior of the Eat() method
public class RobotDog : Animal
{
    public override void Eat()
    {
        Console.WriteLine("I´m a robot. I don´t eat.");
    }
}