using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03_ArrayObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var não é um tipo de dado, object é.
            // Trabalhando com diferentes tipos
            string nome;
            nome = "Gerson";
            object obj;
            obj = nome;

            var v1 = 12.2;
            v1 = 10.9;

            var v2 = "123";
            var v3 = int.Parse(v2);
            // O especificador 'var' é usado para determinar o tipo da
            // variável de acordo com o valor atribuido a ela.

            object[] elementos = { "Futebol", 100, 100.1, true };
            foreach(var item in elementos)
            {
                Console.WriteLine($"{item} - {item.GetType().Name}");
            }

            Console.ReadKey();
        }
    }
}
