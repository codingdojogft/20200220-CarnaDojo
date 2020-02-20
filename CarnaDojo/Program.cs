using CarnaDojo.Classes;
using System;

namespace CarnaDojo
{
    class Program
    {
        static void Main(string[] args)
        {
            var calorias = 2503;
            var carboidratosGramas = 180;
            var proteinasGramas = 250;
            var gordurasGramas = 87;

            CalculadoraAlimentos calc = new CalculadoraAlimentos(calorias, carboidratosGramas, proteinasGramas, gordurasGramas);
            Console.WriteLine("***Calculadora de Alimentos***\n");

            while (true)
            {
                Console.Write("Digite o nome do alimento ou 0 para sair: ");
                var nomeAlimento = Console.ReadLine();

                if (nomeAlimento == "0") break;

                Console.Write("Gramas de Carboidrato: ");
                var carbG = Console.ReadLine();
                Console.Write("Gramas de Proteína: ");
                var protG = Console.ReadLine();
                Console.Write("Gramas de Gordura: ");
                var gordG = Console.ReadLine();
                Console.WriteLine(" ");

                calc.calculaAlimento(nomeAlimento, carbG, protG, gordG);
            }
        }
    }
}
