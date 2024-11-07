using System;

namespace CalculoAreaTriangulo
{
    
    public class Triangulo
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public Triangulo(double baseTriangulo, double alturaTriangulo)
        {
            Base = baseTriangulo;
            Altura = alturaTriangulo;
        }

        public double CalcularArea()
        {
            return (Base * Altura) / 2;
        }
    }

    // Classe principal
    class Program
    {
        static void Main(string[] args)
        {
            // Entrada do usuário
            Console.Write("Digite o valor da base do triângulo: ");
            double baseTriangulo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor da altura do triângulo: ");
            double alturaTriangulo = Convert.ToDouble(Console.ReadLine());

            // Instância do objeto Triangulo
            Triangulo triangulo = new Triangulo(baseTriangulo, alturaTriangulo);

            // Cálculo e exibição da área
            double area = triangulo.CalcularArea();
            Console.WriteLine($"A área do triângulo é: {area}");

            Console.ReadKey();
        }
    }
}
