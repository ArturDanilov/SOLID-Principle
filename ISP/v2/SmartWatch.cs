namespace ISP.v2
{
    internal class SmartWatch : IWatch, IAnswering
    {
        public TimeOnly GetCurrentTime() => TimeOnly.FromDateTime(DateTime.Now);

        public void AnswerCall() => Console.WriteLine("Answering call...");

    }
}
