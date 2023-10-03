using System.Globalization;

namespace Horsepower_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o torque (kgfm): ");
            double torque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com o RPM máximo: ");
            int rpm = int.Parse(Console.ReadLine());

            Calculator C1 = new Calculator(torque, rpm);

            Console.WriteLine(C1 + "\n");

            System.Console.ReadKey();
        }
    }
}