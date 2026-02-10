using CalculatorHelper;

namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Calculator myCalc = new Calculator();

            int x = rnd.Next(1, 100);
            int y = rnd.Next(1, 100);

            Console.WriteLine("x = " + x.ToString());
            Console.WriteLine("y = " + y.ToString());

            Console.WriteLine("Addition: " + myCalc.Add(x, y).ToString());
            Console.WriteLine("Subtraction: " + myCalc.Sub(x, y).ToString());
            Console.WriteLine("Multiplication: " + myCalc.Mul(x, y).ToString());
            Console.WriteLine("Division: " + myCalc.Div(x, y).ToString());
            Console.WriteLine("Modulo: " + myCalc.Mod(x, y).ToString());

            Console.WriteLine("Press Enter to leave");
            Console.ReadLine();
        }
    }
}
