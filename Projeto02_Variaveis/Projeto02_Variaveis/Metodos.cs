using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02_Variaveis
{
    internal class Metodos
    {
        public static void ApresentarVariaveis()
        {
            //Declaração de variáveis
            int idade;
            idade = 20;
            string nome = "José Antônio";
            double peso = 75.3;

            Console.WriteLine($"{nome} possui {idade} anos e pesa {peso} kg");
        }
        public static void LerVariaveis()
        {
            Console.Write("Qual o seu nome? ");
            string nome = Console.ReadLine();

            Console.Write("Qual a sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Qual é o seu peso? ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Qual é a sua altura? ");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine($"{nome} possui {idade} anos e pesa {peso:0.00} kg e mede {altura} cm");
        }

        public static double CalcularImc(double peso, double altura)
        {
            double imc = peso / Math.Pow(altura, 2);
            return imc;
        }

        public static double CalcularValorAleatorio()
        {
            Random rand = new Random();
            return rand.Next();
        }
    }
}
