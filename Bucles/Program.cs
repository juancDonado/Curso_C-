using System;

namespace Bucles
{
    class Program
    {
        static void Main(string[] args)
        {
            int z = 10;

            do
            {
                Console.WriteLine("Impresion "+z);
                z++;
            }while (z < 10);

            Random rnd = new Random();
            int numero = rnd.Next(1, 100);
            int conteo = 0;
            Console.WriteLine("Digita un numero");
            int busqueda = 0;

            while (numero != busqueda)
            {
                conteo++;
                busqueda = int.Parse(Console.ReadLine());

                if (numero > busqueda)
                    Console.WriteLine("El numero digitado es menor que el numero random");
                else
                    Console.WriteLine("El numero digitado es mayor que el numero random");
            }
            Console.WriteLine($"Te ha tomado {conteo} intentos");

            Console.WriteLine(numero);
            Console.WriteLine("Deseas entar en el bucle while");
            string respuesta = Console.ReadLine();

            while (respuesta != "no")
            {
                Console.WriteLine("Estas dentro del bucle while");
                Console.WriteLine("Introduce tu nombre:");
                string nombre = Console.ReadLine();
                Console.WriteLine($"Hola {nombre}, saldras del bucle cuando respondas no a la pregunta");
                Console.WriteLine("Deseas repetir otra vez");

                respuesta = Console.ReadLine();
            }
            Console.WriteLine("Has salido del bucle");
        }
    }
}
