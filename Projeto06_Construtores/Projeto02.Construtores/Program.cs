using ClassesObjetos.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Construtores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Curso curso = new Curso("Pedagogia", 200);
            Console.WriteLine(curso.LerCurso());

            Console.ReadLine();
        }
    }
}
