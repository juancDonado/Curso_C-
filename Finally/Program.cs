using System;

namespace Finally
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string linea;
                int contador = 0;
                string path = @"C:\Users\Semillero\Documents";

                System.IO.StreamReader archivo = new System.IO.StreamReader(path);

                while ((linea = archivo.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                    contador++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error con la lectura del archivo");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.ToString());
            }
        }
    }
}
