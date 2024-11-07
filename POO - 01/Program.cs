using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO___01
{
    public class Retangulo
    { 
        public double Base { get; set; }
        public double Altura { get; set; }

        public Retangulo(double baseRetangulo, double alturaRetangulo)
        {
            Base = baseRetangulo;
            Altura = alturaRetangulo;
        }

        public double CalcularArea()
        {
            return Base * Altura;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a base do retângulo: ");
            double baseRetangulo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a altura do retângulo: ");
            double alturaRetangulo = Convert.ToDouble(Console.ReadLine());

            
            Retangulo retangulo = new Retangulo(baseRetangulo, alturaRetangulo);

     
            double area = retangulo.CalcularArea();
            Console.WriteLine($"A área do retângulo é: {area}");

            Console.ReadKey();
        }
    }
}
