using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos.Classes
{
    public class Curso
    {
        private string _descricao;
        public string Descricao 
        { 
            get => _descricao; 
            set => _descricao = !string.IsNullOrEmpty(value) ? value : 
                throw new Exception("Descrição inválida"); 
        }

        private int _ch;
        public int CargaHoraria 
        { 
            get => _ch; 
            set => _ch = value > 0 ? value : 
                throw new Exception("A carga horária deve ser positiva"); 
        }

        public Curso(string Descricao, int CargaHoraria)
        {
            this.Descricao = Descricao;
            this.CargaHoraria = CargaHoraria;
        }

        public string LerCurso()
        {
            return $"Descrição: {Descricao}\nCarga Horária: {CargaHoraria}";
        }

        public override string ToString()
        {
            //return $"{Descricao} - {CargaHoraria} horas";
            return this.LerCurso();
        }

    }
}
