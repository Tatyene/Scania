using ClassesObjetos.Enumeracoes;
using ClassesObjetos.Estruturas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos.Classes
{
    public class Pessoa
    {
        // Propriedade Nome: forma completa
        private string _nome; // variável de instância / atributo. private significa que ela só existe dentro da classe

        public string Nome //nome da propriedade
        {
            get { return this._nome; }  // executado quando você lê o valor
            set 
            { 
                if(value == null || value.Length == 0)
                {
                    throw new InvalidProgramException("O nome é inválido."); // lança exceção
                }
                    
                this._nome = value; 
            } // executado na atribuição do valor
        }

        //Propriedade Idade: Forma completa
        private int _idade;  //atributo

        public int Idade // nome da propriedade
        {
            get { return this._idade; }  //lendo
            set //atribuindo
            { 
                if(value < 0)
                {
                    throw new InvalidOperationException("A idade não pode ser negativa.");
                }
                this._idade = value; 
            } 
        }

        //propriedade Sexo: forma reduzida
        public Sexos Sexo { get; set; }

        public Endereco EnderecoInfo { get; set; }

        public string LerPessoa()
        {
            string resposta = $"Nome: {this.Nome}\nIdade: {this.Idade}\nSexo: {this.Sexo}\n" +
                $"\nDados do endereço:\n{this.EnderecoInfo.LerEndereco()}";

            return resposta;
        }
        //métodos static não acessam propriedades de objeto. Usada para informações gerais.
        public static string LerInformacoes()
        {
            return "Classe desenvolvida pela turma da Scania";
        }

        public static double CalcularSoma(double x, double y)
        {
            return x + y;
        }
    }
}
