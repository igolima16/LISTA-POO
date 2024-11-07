using System;

namespace CalculoAreaQuadrado
{
    public class Quadrado
    {
        public double Diagonal { get; set; }

        public Quadrado(double diagonal)
        {
            Diagonal = diagonal;
        }

        public double CalcularArea()
        {
            return (Diagonal * Diagonal) / 2;
        }
    }

    // Classe principal
    class Program
    {
        static void Main(string[] args)
        {
            // Entrada do usuário
            Console.Write("Digite o valor da diagonal do quadrado: ");
            double diagonal = Convert.ToDouble(Console.ReadLine());

            // Instância do objeto Quadrado
            Quadrado quadrado = new Quadrado(diagonal);

            // Cálculo e exibição da área
            double area = quadrado.CalcularArea();
            Console.WriteLine($"A área do quadrado é: {area}");

            Console.ReadKey();
        }
    }
}