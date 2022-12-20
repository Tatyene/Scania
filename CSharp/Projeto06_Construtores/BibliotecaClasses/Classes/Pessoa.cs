using ClassesObjetos.Enumeracoes;
using ClassesObjetos.Estruturas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos.Classes
{
    public abstract class Pessoa // transformou com 'abstract' a classe em uma classe abstrata, A partir disso, a classe fica impedida de criar objetos apartir dela.
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


        //Construtores
        public Pessoa(string nome)
        {
            this.Nome = nome;
        }
        public Pessoa(string nome, int idade) 
            : this(nome)
        {
            this.Idade = idade;
        }
        public Pessoa(string nome, int idade, Sexos sexo) 
            : this(nome, idade)
        {
            this.Sexo = sexo;
        }
        public Pessoa(string nome, int idade, Sexos sexo, Endereco endereco)
            : this(nome, idade, sexo)
        {
            this.EnderecoInfo = endereco;
        }


        public virtual string LerPessoa()
        {
            return LerPessoa("DADOS DA PESSOA: ");
        }
        public virtual string LerPessoa(string cabecalho)
        {
            string resposta = $"{cabecalho}\nNome: {this.Nome}\nIdade: {this.Idade}\nSexo: {this.Sexo}\n";
            // se o endereço não tiver logradouro, assumiremos que ele não existe
            if (!string.IsNullOrEmpty(this.EnderecoInfo.Logradouro))
            {
                resposta += $"\nDados do endereço:\n{this.EnderecoInfo.LerEndereco()}";
            }

            return resposta;
        }

        //sobrescrevendo o método ToString
        public override string ToString()
        {
            return $"USANDO O MÉTODO ToString()\n\n{this.LerPessoa()}";
        }

        //public abstract string MostrarMensagem();

    }
}
