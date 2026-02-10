namespace CalculatorHelper
{
    public class Calculator
    {
        // Adds two numbers
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Subtracts b from a
        public int Sub(int a, int b)
        {
            return a - b;
        }

        // Multiplies two numbers
        public int Mul(int a, int b)
        {
            return a * b;
        }

        // Divides a by b, throws DivideByZeroException if b is zero
        public double Div(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return (double)a / b;
        }

        public double Mod(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot mod by zero.");
            }
            return (double)a % b;
        }
    }
}