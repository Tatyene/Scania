using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02_Variaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Metodos.ApresentarVariaveis();
            //MostrarCurso();
            //Metodos.LerVariaveis();

            Console.WriteLine("Informe o peso:");
            double peso = double.Parse(Console.ReadLine());
            
            Console.Write("Informe a altura: ");
            
            string valor = Console.ReadLine();
            double altura = double.Parse(valor);
             
            //double altura = double.Parse(Console.ReadLine());

            //double imc = Metodos.CalcularImc(peso, altura);
            Console.WriteLine($"Peso: {peso}kg, Altura: {altura}cm, IMC: {Metodos.CalcularImc(peso, altura):0.00}");

            double numero = Metodos.CalcularValorAleatorio();
            Console.WriteLine($"Numero gerado: {numero}");
            Console.WriteLine($"Numero gerado: {numero}");
            Console.WriteLine($"Numero gerado: {Metodos.CalcularValorAleatorio()}");
            Console.ReadKey();

        }

        static void MostrarCurso()
        {
            Console.WriteLine("Cursos da semana:");
            Console.WriteLine("Linguagem C#");
            Console.WriteLine("Python");
        }
    }
}
