using System;

namespace Sentencia_SWITCH
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduce el N° de mes para el calculo de comision");
            int nMes = int.Parse(Console.ReadLine());

            switch (nMes)
            {
                case 1:
                    Console.WriteLine("Mes escogido: Enero");s
                    break;
                case 2:
                    Console.WriteLine("Mes escogido: Febrero");
                    break;
                case 3:
                    Console.WriteLine("Mes escogido: Marzo");
                    break;
                case 4:
                    Console.WriteLine("Mes escogido: Abril");
                    break;
                case 5:
                    Console.WriteLine("Mes escogido: Mayo");
                    break;
                default:
                    Console.WriteLine("Mes escogido: Invalido");
                    break;
            }

            Console.WriteLine("Elije un metodo de transporte (coche, tren, avion)");
            string medioTransporte = Console.ReadLine();

            switch (medioTransporte)
            {
                case "coche":
                    Console.WriteLine("Velocidad medio 100 Km/h");
                    break;
                case "tren":
                    Console.WriteLine("Velocidad medio 250 Km/h");
                    break;
                case "avion":
                    Console.WriteLine("Velocidad medio 100 Km/h");
                    break;
                default:
                    Console.WriteLine("El vehiculo escrito no esta disponible");
                    break;
            }
        }
    }
}
