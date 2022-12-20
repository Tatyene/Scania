using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03_EstruturaFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Neste exercício, o usuário fornecerá uma quantidade 
             * de números. Em seguida, ele digitará alguns números
             * inteiros (a quantidade de números digitados é a 
             * quantidade informada).
             * 
             * Ao final, o programa apresenta a soma destes números.
             */

            Console.Write("Informe uma quantidade de números (1 a 10): ");
            int quantidade = int.Parse(Console.ReadLine());

            if(quantidade < 1 || quantidade > 10)
            {
                Console.WriteLine("A quantidade deve ser entre 1 e 10!");
            }
            else
            {
                int soma = 0;
                for (int i = 0; i < quantidade; i++)
                {
                    Console.Write($"Informe o número {i + 1} de {quantidade}: ");
                    int numero = int.Parse(Console.ReadLine());
                    soma += numero;
                }
                Console.WriteLine($"A soma dos números é: {soma}");
            }
            Console.ReadKey();
        }
    }
}
