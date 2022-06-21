using System;

namespace PrimeraAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            /*gg 
             * madafaca       
             */
            Console.WriteLine("Hello World!");

            //Variables numericas
            int variableEntera = 10;
            long variableLong = 46546546545644465L;
            float variableFloat = 3.15F;
            double variableDouble = 3.156467;
            decimal variableDecimal = 3.136456465464546454645446546M;

            //Variables Cadenas
            string variableStrig = "Hola Mundo";
            char variableChar = '%';

            //VariableBooleana
            bool variableBooleana = true;

            Console.WriteLine("Variable entera: " + variableEntera + "\n" +
                "Variable long: " + variableLong + "\n" +
                "Variable float: " + variableFloat + "\n" +
                "Variable double: " + variableDouble + "\n" +
                "Variable decimal: " + variableDecimal + "\n" +
                "Variable string: " + variableStrig + "\n" +
                "Variable char: " + variableChar + "\n" +
                "Variable boolean: " + variableBooleana);

            Console.WriteLine("Digita el primer numero:");
            int numero1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digita el segundo numero:");
            int numero2 = Convert.ToInt16(Console.ReadLine());

            //Interpolacion
            Console.WriteLine($"EL primer numero es {numero1} y el numero dos es {numero2}");

            float res = numero1 + numero2;
            Console.WriteLine("El resultado es: " + res);
            res = numero1 - numero2;
            Console.WriteLine("El resultado es: " + res);
            res = numero1 * numero2;
            Console.WriteLine("El resultado es: " + res);
            res = numero1 / numero2;
            Console.WriteLine("El resultado es: " + res);
            res = numero1 % numero2;
            Console.WriteLine("El resultado es: " + res);

            Console.WriteLine(++numero1);
            Console.WriteLine((--numero1) + 2);

            Console.WriteLine($"EL primer numero es {numero1} y el numero dos es {numero2}");

            int edadPersona1;
            int edadPersona2;
            int edadPersona3;
            int edadPersona4;

            edadPersona1 = edadPersona2 = edadPersona3 = edadPersona4 = 27;
            Console.WriteLine(edadPersona4);

            var temperatura = 34.5;
            int temperaturaMadrid;

            //Conversion explisita (Casting)
            temperaturaMadrid = (int)temperatura;
            Console.WriteLine(temperaturaMadrid);

            //Conversion implicita
            int habitantesCiudad = 100000000;
            long habitantesCiudad2018 = habitantesCiudad;
            Console.WriteLine(habitantesCiudad2018);

            Console.WriteLine("Digita el primer numero:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digita el segundo numero:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"El resultado es: {num1 + num2}");

            //constantes
            const float PI = 3.1416F;
            //Console.WriteLine("El valor del radio es: {0}", PI);
            Console.WriteLine("Introduce la medida del radio");
            double radio = Double.Parse(Console.ReadLine());
            double area = Math.Pow(radio, 2) * PI;
            Console.WriteLine($"El valor del radio es: {area}");


        }
    }
}
