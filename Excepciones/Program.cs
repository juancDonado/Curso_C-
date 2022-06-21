using System;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.MaxValue;
            Console.WriteLine(num);
            int resultado = num + 40;
            Console.WriteLine(resultado);

            Random rnd = new Random();
            int numero = rnd.Next(1, 100);
            int conteo = 0;
            int busqueda;

            do{
                conteo++;
                try
                {
                    Console.WriteLine("Digita un numero");
                    busqueda = int.Parse(Console.ReadLine());
                }
                catch (Exception err) when (err.GetType() != typeof(FormatException))
                {
                    Console.WriteLine("Ha ocurrido un error, se toma este intento como 0");
                    //Console.WriteLine(err.Message);
                    busqueda = 0;
                }catch (FormatException)
                {
                    Console.WriteLine("Has introducido texto");
                    busqueda = 0;
                }

                if (numero > busqueda)
                    Console.WriteLine("El numero digitado es menor que el numero random");
                else
                    Console.WriteLine("El numero digitado es mayor que el numero random");
            }while (numero != busqueda) ;
                Console.WriteLine($"Te ha tomado {conteo} intentos");
            Console.WriteLine("Apartir de esta linea de codigo el programa continuaria...");
        }
    }
}
