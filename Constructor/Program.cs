using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche coche1 = new Coche();
            Coche coche2 = new Coche(3300.5, 1500.60);

            Console.WriteLine(coche1.getInfoCoche());
            Console.WriteLine(coche2.getInfoCoche());

            //coche2.setExtras(true, "Cuero");
            Console.WriteLine(coche2.getExtras());
        }
    }
    partial class Coche
    {
        public Coche()
        {
            ruedas = 4;
            largo = 2300.5;
            tapiceria = "Tela";
            ancho = 0.800;
        }
        public Coche(double largoCoche, double anchoCoche)
        {
            ruedas = 4;
            largo = largoCoche;
            ancho = anchoCoche;
            tapiceria = "Tela";
        }
    }
    partial class Coche 
    {
        public string getInfoCoche()
        {
            return $"El coche tiene {ruedas} ruedas, con un largo de {largo} y un ancho {ancho}";
        }
        public void setExtras(bool climatizador, string tapiceria)
        {
            this.climatizador = climatizador;
            this.tapiceria = tapiceria;
        }
        public string getExtras()
        {
            return $"Extra del coche: Tapiceria {tapiceria}, Climatizador {climatizador}";
        }
        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;
        private string tapiceria;
    }
}
