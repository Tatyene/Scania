using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03_EstruturaWhile01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Informe um valor entre 0 e 10: ");
            //int numero = int.Parse(Console.ReadLine());
            Random random = new Random();
            int numero = random.Next(0, 10);
            
            while(numero < 5)
            {
                Console.WriteLine($"Numero: {numero}");
                numero++;
            }
            Console.WriteLine("Fim do programa.");
            Console.ReadKey();
        }
    }
}
