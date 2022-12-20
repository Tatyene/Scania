using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos.Estruturas
{
    public struct Endereco
    {
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }

        //método para retornar todos os dados do endereço
        public string LerEndereco()
        {
            string resposta = $"Logradouro: {Logradouro}\nNúmero: {Numero}\n" +
                $"Cidade: {Cidade}\nCep: {Cep}";
            return resposta;
        }
    }
}
