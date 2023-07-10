using SRP;

//mathematical operations
Calculator calculator = new();
Console.WriteLine(calculator.Adding(1, 2));
Console.WriteLine(calculator.Subtraction(5, 3));
Console.WriteLine(calculator.Multiplication(2, 2));
Console.WriteLine(calculator.Divide(9, 3));

//send operations
ReportingService reportingService = new();