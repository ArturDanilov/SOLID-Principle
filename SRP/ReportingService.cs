namespace SRP
{
    internal class ReportingService
    {
        Calculator calculator = new Calculator();
        public ReportingService()
        {
            Console.WriteLine("\n\nSent " + calculator.Adding(10, 20));
        }
    }
}
