namespace OCP.v1
{
    internal class CarMechenic
    {        
        public void Repair(Object engine)
        {
            if (engine is SportCarEngine sportCarEngine)
            {
                sportCarEngine.Stop();
                Console.WriteLine("Engine is being repaired");
                sportCarEngine.Start();
                Console.WriteLine("Checking engine");
                sportCarEngine.Stop();
                Console.WriteLine("Engine repaired!");
            }
            else if (engine is BusEngine busEngine)
            {
                busEngine.Stop();
                Console.WriteLine("Engine is being repaired");
                busEngine.Start();
                Console.WriteLine("Checking engine");
                busEngine.Stop();
                Console.WriteLine("Engine repaired!");
            }            
        }
    }
}
