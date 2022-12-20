using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01_ArraysNumericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Definindo arrays de números inteiros:
            // Forma 1: criar o array e definir uma quantidade
            // variável que armazena conjunto de inteiros
            // usado quando ainda não se sabe os valores - recebe os valores na ordem em que vc determina, não necessitando de ser em sequência
            int[] numeros = new int[5];

            numeros[0] = 220;
            numeros[1] = 14;
            numeros[2] = 36;
            numeros[3] = 100;
            numeros[4] = 78;

            // Apresentando os valor usando a estrutura for
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"números[{i}] = {numeros[i]}");
            }
            Console.WriteLine();

            // Apresentando os valores usando a estrutura foreach
            // item = elemento da coleção
            // numeros = uma coleção
            // in = cada elemento EM UMA coleção
            // Essa estrutura não trabalha com o INDICE, você não tem acesso a posição.
            // Se ela for necessária para o código, o indicado é utilizar a estrutura anterior.
            foreach (int item in numeros)
            {
                Console.WriteLine($"número : {item}");
            }

            Console.WriteLine();
            //Forma 2: na declaração da array, atribuir seus valores
            //{} quando colocado, imediatamente após uma declaração de array, se refere aos valores do array
            //usando quando já se conhece os valores, e dificilmente eles irão mudar. Recebem os valores exatamente na ordem em que são declarados
            //seus valores podem ser alterados acessando o índice
            /*
             * nesse caso não funciona pois ele não reconhece as{} como array e sim como bloco de código.
             * int[] val;
             * val = { 2, 3, 5 , 98};
             */
                        
            int[] valores = { 15, 10, 12, 20, 45 };
            // instrução acima é uma forma abreviada de 
            //int[] valores = new int[]{ 15, 10, 12, 20, 45 };
            
            // essa é a forma correta de declarar variáveis array e atribuir valor após
            int[] val;
            val = new int[]{2, 3, 5, 98};


            valores[2] = 100; // alterando o valor do 3º elemento
            foreach(int elemento in valores)
            {
                Console.WriteLine($"elemento: {elemento}");
            }

            Console.ReadKey();
        }
    }
}