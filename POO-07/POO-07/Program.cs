using System;

namespace ConversaoDolarParaReal
{
  
    public class ConversorMoeda
    {
        public double CotacaoDolar { get; set; }
        public double QuantidadeDolares { get; set; }

     
        public ConversorMoeda(double cotacaoDolar, double quantidadeDolares)
        {
            CotacaoDolar = cotacaoDolar;
            QuantidadeDolares = quantidadeDolares;
        }

        public double ConverterParaReais()
        {
            return CotacaoDolar * QuantidadeDolares;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Entrada do usuário para a cotação do dólar
            Console.Write("Digite o valor da cotação do dólar: ");
            double cotacaoDolar = Convert.ToDouble(Console.ReadLine());

            // Entrada do usuário para a quantidade de dólares
            Console.Write("Digite a quantidade de dólares: ");
            double quantidadeDolares = Convert.ToDouble(Console.ReadLine());

            // Instância do objeto ConversorMoeda
            ConversorMoeda conversor = new ConversorMoeda(cotacaoDolar, quantidadeDolares);

            // Conversão e exibição do valor em reais
            double valorEmReais = conversor.ConverterParaReais();
            Console.WriteLine($"O valor correspondente em reais é: R$ {valorEmReais:F2}");

            Console.ReadKey();
        }
    }
}