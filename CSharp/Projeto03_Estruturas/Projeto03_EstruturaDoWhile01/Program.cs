using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03_EstruturaDoWhile01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um valor entre 0 e 10: ");
            int numero = int.Parse(Console.ReadLine());

            do // ele é executado, pelo menos, 1x, pois a condição está fora do bloco de código
            {
                Console.WriteLine($"Numero: {numero}");
                numero++;
            } while (numero < 5);

            Console.WriteLine("Fim do programa.");
            Console.ReadKey();
        }
    }
}
