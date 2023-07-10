namespace OCP
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
    }

    internal class ExtendetCalculator : Calculator
    {
        public int Multiplication(int a, int b)
        {
            return a * b;
        }

        public decimal Divide(decimal a, decimal b)
        {
            if (a == 0)
                return b;

            if (b == 0)
                return a;

            return a / b;
        }
    }
}
