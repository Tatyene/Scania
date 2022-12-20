using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos.Classes
{
    public class Aluno : Pessoa
    {
        public string Curso { get; set; }
        public int Matricula { get; set; }

        public override string LerPessoa()
        {
            string mensagem = $"{base.LerPessoa()}\nCurso: {Curso}\nMatrícula: {Matricula}";
            return mensagem;
        }


    }
}
