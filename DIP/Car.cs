namespace DIP
{
    internal class Car
    {
        private IEngine _engine;

        public Car(IEngine engine)
        {
            _engine = engine;
        }

        public void StartEngine() 
        {
            _engine.Start();
        }
    }
}
