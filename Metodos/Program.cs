using System;

namespace Metodos
{
    class Program
    {
        int numero1 = 5;
        int numero2 = 7;

        static void Main(string[] args)
        {
            Console.WriteLine(sumaNumeros(1,3,55));
        }
        static double divideNumeros(double num1, double num2) => num1 / num2;

        //Ambito y sobrecarga de un metodo
        void primerMetodo(int numero1, int numero2) => Console.WriteLine(numero1+numero2);
        static int sumaNumeros(int num1, int num2) => num1 + num2;
        static double sumaNumeros(double num1, int num2) => num1 + num2;
        static int sumaNumeros(int num1, int num2, int num3) => num1 + num2 + num3;


    }
}
