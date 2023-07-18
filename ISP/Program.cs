using ISP.v1;

IWatch watch = new MechanicalWatch();

Console.WriteLine("Current time is " + watch.GetCurrentTime());

watch.AnswerCall();
