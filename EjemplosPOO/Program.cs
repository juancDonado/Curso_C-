using System;

namespace EjemplosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo miCirculo; ; //Creacion con el nombre de la clase
            miCirculo = new Circulo(); //Instancia
            Circulo miCirculo2 = new Circulo();

            Console.WriteLine(miCirculo2.CalculoArea(3));
            Console.WriteLine(miCirculo.CalculoArea(5));

            ConversorEuroDolar obj = new ConversorEuroDolar();
            obj.CambiarValorEuro(-1.0);
            Console.WriteLine(obj.Convierte(50));
        }
    }

    class Circulo
    {
        private const double PI = 3.1416; //Propiedad de la clase(Campo de clase)

        public double CalculoArea(int radio)
        {
            return PI * Math.Pow(radio, 2);
        }
    }

    class ConversorEuroDolar
    {
        private double euro = 1.253;

        public double Convierte(double cantidad)
        {
            return cantidad * euro;
        }
        public void CambiarValorEuro(double nuevoValor)
        {
            if (nuevoValor < 0) euro = euro;
            else euro = nuevoValor;
        }
    }
}
