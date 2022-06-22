using System;

namespace ConceptosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            realizarTarea();
            Console.WriteLine(Punto.Contador());
            
        }

        static void realizarTarea()
        {
            Punto origen = new Punto();
            Punto destino = new Punto(125, 80);

            double distancia = origen.DistanciaHasta(destino);
            Console.WriteLine($"La distancia entre dos puntos es: {distancia}");
        }
    }
}
