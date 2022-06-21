using System;

namespace SentenciaIF_ELSE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce tu edad");
            int edad = int.Parse(Console.ReadLine());

            if (edad < 18) Console.WriteLine("Eres un niño");
            else if (edad >= 18 && edad < 30) Console.WriteLine("Eres un joven");
            else if (edad >= 30 && edad < 60) Console.WriteLine("Eres adulto");
            else if (edad > 60 && edad <= 150) Console.WriteLine("Ya estas en cama compae jajaja");
            else Console.WriteLine("edad invalida");

            Console.WriteLine("intoduce la nota del primer parcial");
            int parcial1 = int.Parse(Console.ReadLine());
            Console.WriteLine("intoduce la nota del segundo parcial");
            int parcial2 = int.Parse(Console.ReadLine());
            Console.WriteLine("intoduce la nota del tercer parcial");
            int parcial3 = int.Parse(Console.ReadLine());
            float res = (parcial1 + parcial2 + parcial3) / 3;

            if (parcial1 >= 3 && parcial2 >= 3 && parcial3 >= 3)
            {
                Console.WriteLine("Has pasado el semestre, la media es:"+res);
            }
            else
            {
                Console.WriteLine("No pasas el semestre, la media es: " +res);
            }

            Console.WriteLine("Introduce tu edad");
            int edad1 = int.Parse(Console.ReadLine());
            if (edad1 >= 18)
            {
                Console.WriteLine("¿Tienes carnet?");
                string carnet = Console.ReadLine();
                int compara = String.Compare(carnet, "si", true);

                if (compara == 0) Console.WriteLine("Puedes conducir un vehiculo");
                else Console.WriteLine("No puedes conducir un vehiculo");
            }
            else Console.WriteLine("No puedes conducir un vehiculo");
        }
    }
}
