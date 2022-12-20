using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03_ComandoDecisao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Neste exercício, o usuário fornece um valor para saque.
             * (simulação de um caixa eletrônico).
             * As cédulas disponívies são:
             * R$: 50,00
             * R$: 20,00
             * R$: 10,00
             * R$: 5,00
             * 
             * Com base nestas informações, o programa deve apresentar 
             * a quantidade de cédulas de acordo com o valor do saque.
             */
            Console.WriteLine("Insira um valor para saque:");
            double valor = double.Parse(Console.ReadLine());
            
            // Obtendo a parte inteira da variável 'valor': typecast ou coerção
            int valorSaque = (int)valor;

            int q50, q20, q10, q5;
            q50 = q20 = q10 = q5 = 0; //atribuição simultânea

            if (valorSaque % 5 != 0)
            {
                Console.WriteLine("Valor inválido para saque");
                //Console.ReadKey();
                //return;
            }
            else
            {
                q50 = valorSaque / 50;
                valorSaque = valorSaque % 50;

                q20 = valorSaque / 20;
                valorSaque = valorSaque % 20;

                q10 = valorSaque / 10;
                valorSaque = valorSaque % 10;

                q5 = valorSaque / 5;

                string resposta = $"Valor do saque: {valor:c}\nNotas de 50: {q50}\n" +
                    $"Notas de 20: {q20}\nNotas de 10: {q10}\nNotas de 5: {q5}";

                Console.WriteLine(resposta);
            }
            Console.ReadKey();
        }
    }
}
