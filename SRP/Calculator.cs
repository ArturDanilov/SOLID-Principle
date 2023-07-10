namespace SRP
{
    internal class Calculator
    {
        public Calculator()
        {
            
        }
        public int Adding(int a, int b)
        {
            return a + b;
        }

        public int Subtraction(int a, int b)
        {
            return (a - b);
        }

        public int Multiplication(int a, int b)
        {
            return a * b;
        }

        public decimal Divide(decimal a, decimal b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            return a / b;
        }
    }
}
