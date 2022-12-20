using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02_ArrayString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Neste projeto, definiremos uma quantidade de elementos
             * para um array de nomes. A quantidade será informada pelo 
             * usuário. Em seguida, o programa: 
             * 
             * - Solicita o valor para cada um dos nomes
             * - Os nomes armazenados serão exibidos em maiúsculo
             */
            Console.Write("Informe a quantidade de nomes: ");
            int quantidade = int.Parse(Console.ReadLine());

            string[] nomes = new string[quantidade];

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write($"Informe o nome {i + 1}: ");
                nomes[i] = Console.ReadLine();
            }

            //Exibindo a lista de nomes em maiúsculo
            Console.WriteLine("Exibindo os nomes maiúsculo: ");
            foreach(string nome in nomes)
            {
                Console.WriteLine(nome.ToUpper());
            }

            // Definindo um Array de string contendo os dias da semana
            string[] diasSemana = { "Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado" };
            Console.WriteLine();
            Console.WriteLine("Dias da semana: ");
            
            foreach(string dia in diasSemana)
            {
                Console.WriteLine(dia);
            }
            Console.ReadKey();
        }
    }
}
