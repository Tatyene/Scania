using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03_EstruturaFor02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Neste exercício, o usuário fornece 10 números
             * inteiros. O programa apresenta a soma dos números
             * positivos (os números negativos serão ignorados)
             * 
             * Objetivo: apresentar o comando 'continue'
             */

            int soma = 0;
            for(int i = 0; i < 10; i++)
            {
                Console.Write($"Informe o valor {i + 1}: ");
                int numero = int.Parse(Console.ReadLine());

                if(numero <= 0)
                {
                    continue; //ignora o resto do código e retorna para estrutura de repetição.
                }
                soma += numero;
            }
            Console.WriteLine($"Soma dos valores positivos: {soma}");
            Console.ReadKey();
        }
    }
}
