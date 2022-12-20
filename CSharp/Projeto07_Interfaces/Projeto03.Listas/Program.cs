using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03.Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GetListaString();
            GetListaProdutos();

            Console.ReadKey();
        }

        // Método para definir uma lista de string
        static void GetListaString()
        {
            List<string> nomes = new List<string>();

            nomes.Add("João");
            nomes.Add("Antônio");
            nomes.Add("Joaquim");
            nomes.Add("Daniela");
            nomes.Add("Abigail");

            nomes.Insert(0, "Jeferson");

            nomes.Remove("João");

            //Listando os nomes usando foreach
            foreach (var item in nomes)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new String('-', 20));

            //Listando os nomes usando for
            for (int i = 0; i < nomes.Count; i++)
            {
                Console.WriteLine(nomes[i]);
            }
            Console.WriteLine(new String('-', 20));

            //Colocar os elementos da lista em ordem
            nomes.Sort(); //ele mexe na lista, nas posições dos elementos.
            foreach (var item in nomes)
            {
                Console.WriteLine(item);
            }
        }
        static void GetListaProdutos()
        {
            List<Produto> produtos = new List<Produto>()
            {
                new Produto(1, "Mochila", 200),
                new Produto(2, "Bicicleta", 1000),
                new Produto(3, "Laptop", 4000),
                new Produto(4, "Bolo", 20)
            };

            //produtos.Add(new Produto(1, "Mochila", 200));
            foreach (var item in produtos)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new String('-', 20));

            produtos.Sort();
            foreach (var item in produtos)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new String('-', 20));

            produtos.Sort(new OrdenacaoPreco());
            foreach (var item in produtos)
            {
                Console.WriteLine(item);
            }
        }
    }
}
