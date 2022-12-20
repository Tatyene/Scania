using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos.Classes
{
    public class Aluno : Pessoa
    {
        public Curso Curso { get; set; }
        public int Matricula { get; set; }

        public Aluno(string nome, int matricula) 
            : base(nome) // chamada para o construtor da super classe Pessoa
        {
            this.Matricula = matricula;
        }
        public Aluno(string nome, int matricula, Curso curso) 
            : this(nome, matricula)
        {
            this.Curso = curso;
        }

        public override string LerPessoa()
        {
            string mensagem = $"{base.LerPessoa()}\nCurso: {Curso.LerCurso()}" +
                $"\nMatrícula: {Matricula}";
            return mensagem;
        }


    }
}
