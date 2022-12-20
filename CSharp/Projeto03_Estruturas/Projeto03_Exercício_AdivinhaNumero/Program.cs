using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03_Exercício_AdivinhaNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Neste exercício o programa gera um número aleatório entre 1 e 100.
             * 
             * Iterativamente, o programa pede o usuário fornecer um valor
             * O programa ajusta os limites mínimo e máximo até que o 
             * usuário acerte o número. Quando ele acertar, o programa apresenta 
             * a mensagem:
             * 
             * "Você acertou em n tentativas"
             */
            Random random = new Random();
            int minimo = 1, maximo = 100;
            int numero = random.Next(minimo, maximo);
            int tentativas = 0;
            while (true)
            {
                tentativas++;

                //operador ternário para evitar a mensagem de minimo e maximo iguais
                string mensagem = minimo == maximo ? 
                    $"Informe o valor {minimo}: " :
                    $"Informe um valor entre {minimo} e {maximo}: "; 

                Console.WriteLine(mensagem);
                int palpite = int.Parse(Console.ReadLine());

                // Se o usuário informar algum valor fora da faixa solicitada:
                if(palpite < minimo || palpite > maximo)
                {
                    continue;
                }

                if(palpite > numero)
                {
                    maximo = palpite - 1;
                }
                else if(palpite < numero)
                {
                    minimo = palpite + 1;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine($"Você acertou o numero em {tentativas} tentativas.");
            Console.ReadLine();
        }
    }
}
