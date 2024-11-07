
using System;

namespace CalculoAreaQuadrado
{
  
    public class Quadrado
    {
        public double Aresta { get; set; }

   
        public Quadrado(double aresta)
        {
            Aresta = aresta;
        }

        public double CalcularArea()
        {
            return Aresta * Aresta;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Entrada do usuário
            Console.Write("Digite o valor da aresta do quadrado: ");
            double aresta = Convert.ToDouble(Console.ReadLine());

            // Instância do objeto Quadrado
            Quadrado quadrado = new Quadrado(aresta);

            // Cálculo e exibição da área
            double area = quadrado.CalcularArea();
            Console.WriteLine($"A área do quadrado é: {area}");

            Console.ReadKey();
        }
    }
}