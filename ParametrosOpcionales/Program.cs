using System;

namespace ParametrosOpcionales
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1 = 7;
            double valor2 = 5.2;
            double valor3 = 8.3;
            Console.WriteLine(suma(valor1, valor2, valor3));
        }

        static double suma(int num1, double num2, double num3 = 0) => num1 + num2 + num3;
        static double suma(int num1, double num2) => num1 + num2;
    }
}
