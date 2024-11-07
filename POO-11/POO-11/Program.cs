using System;

namespace Calcularpesoideal
{
    // Classe Retangulo com propriedades e método para calcular a área
    public class Pesoideal
    {
        // Propriedades da base e da altura do retângulo
        public double peso { get; set; }
        public double Altura { get; set; }

        // Construtor para inicializar base e altura
        public Pesoideal(double peso1, double alturaPessoa)
        {
            peso = peso1;
            Altura = alturaPessoa;
        }

        // Método para calcular a área e retornar o tipo de terreno
        public string AvaliarPesoIdeal()
        {
            double resultado = peso / (Altura * Altura);

            if (resultado < 20)
            {
                return $"Você pesa {peso}. e comparado com a sua altura você está abaixo do peso ideal."; 
            }
            else if (resultado >= 20 || resultado < 25)
            {
                return $"Você pesa {peso}. e comparado com a sua altura você está no peso ideal";
            }
            else
            {
                return $"Você pesa {peso}. e comparado com a sua altura você está acima do peso";
            }
        }
    }

    // Classe principal
    class Program
    {
        static void Main(string[] args)
        {
            // Entrada do usuário para base e altura
            Console.Write("Digite seu peso: ");
            double peso1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a sua altura: ");
            double alturapessoa = Convert.ToDouble(Console.ReadLine());

            // Instância do objeto Retangulo
           Pesoideal pesoideal = new Pesoideal (peso1, alturapessoa);

            // Avaliação do terreno e exibição do resultado
            string resultado = pesoideal.AvaliarPesoIdeal();
            Console.WriteLine(resultado);

            Console.ReadKey();
        }
    }
}