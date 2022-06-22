using System;

namespace Checked
{
    class Program
    {
        static void Main(string[] args)
        {
            //Checked y unchecked : checked(expresion) - unchecked(expresion) 
            int numero = int.MaxValue;
            int res = unchecked(numero + 20);

            Console.WriteLine(res);

            Console.WriteLine("Intoduce el n° del mes");
            int numeroMes = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine($"El mes es: {nombreDelMes(numeroMes)}");
            }catch(Exception e)
            {
                Console.WriteLine("Mensaje de la excepcion "+e.Message);
            }
            
            Console.WriteLine("Aqui continuaria la ejecucion del resto del programa");
        }
        public static string nombreDelMes(int mes)
        {
            switch (mes)
            {
                case 1:
                    return "Enero";
                    break;
                case 2:
                    return "Febrero";
                    break;
                case 3:
                    return "Marzo";
                    break;
                case 4:
                    return "Abril";
                    break;
                case 5:
                    return "Mayo";
                    break;
                case 6:
                    return "Junio";
                    break;
                case 7:
                    return "Julio";
                    break;
                case 8:
                    return "Agosto";
                    break;
                case 9:
                    return "Septiembre";
                    break;
                case 10:
                    return "Octubre";
                    break;
                case 11:
                    return "Noviembre";
                    break;
                case 12:
                    return "Diciembre";
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
                    break;
            }
        }
    }
}
