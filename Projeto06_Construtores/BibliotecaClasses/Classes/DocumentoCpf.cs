using ClassesObjetos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassesObjetos.Classes
{
    public class DocumentoCpf : IDocumento
    {
        private string _numero;
        public string Numero 
        { 
            get => _numero; 
            set => _numero = Regex.IsMatch(value, "[0-9]{11}") ? value : 
                throw new Exception("CPF Inválido"); 
        }

        public DocumentoCpf(string numero)
        {
            this.Numero = numero;
        }

        public string GetDocumento()
        {
            return $"CPF: {Numero}";
        }
    }
}
