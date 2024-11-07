using System;

namespace ConversaoMilhasMaritimas
{
  
    public class Conversor
    {
      
        public double ConverterMilhasParaQuilometros(double milhasMaritimas)
        {
            double metros = milhasMaritimas * 1852;    
            double quilometros = metros / 1000;        
            return quilometros;
        }
    }

   
    class Program
    {
        static void Main(string[] args)
        {
            // Entrada do usuário
            Console.Write("Digite o valor em milhas marítimas: ");
            double milhasMaritimas = Convert.ToDouble(Console.ReadLine());

            // Instância do objeto Conversor
            Conversor conversor = new Conversor();

            // Conversão e exibição do resultado
            double quilometros = conversor.ConverterMilhasParaQuilometros(milhasMaritimas);
            Console.WriteLine($"{milhasMaritimas} milhas marítimas equivalem a {quilometros} quilômetros.");

            Console.ReadKey();
        }
    }
}
   
