using ClassesObjetos.Classes; // namespace onde contém a classe Pessoa. Pode ser achado com o atalho Ctrl + .
using ClassesObjetos.Enumeracoes;
using ClassesObjetos.Estruturas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instanciando a classe Pessoa, e fazendo com que a variavel
            // pessoa referencie esta instancia
            Pessoa pessoa = new Pessoa(); // new Pessoa é o objeto criado a partir da classe Pessoa. É um método pois tem () e é construtor pois cria um objeto

            pessoa.Nome = "Elaine Silva"; // Variável 'pessoa' q aponta para o objeto criado pela classe 'Pessoa' e fornece um valor para a propriedade 'Nome'
            pessoa.Idade = 30;
            pessoa.Sexo = Sexos.Feminino;

            // outra forma
            pessoa.Sexo = (Sexos)20; // typecast: atribuimos a enumeração Sexos cuja posição é 20

            // atribuindo o endereço
            Endereco endereco = new Endereco();
            endereco.Logradouro = "Av. Paulista";
            endereco.Numero = 1009;
            endereco.Cidade = "São Paulo";
            endereco.Cep = "01311-100";

            pessoa.EnderecoInfo = endereco;

            //atribuindo referencias: a variavel p2 referencia o mesmo objeto
            //referenciado por pessoa.
            Pessoa p2 = pessoa;
            p2.Idade = 31;

            //definindo uma nova pessoa ('marido da Elaine')
            //usando atribuição implicita
            Pessoa pessoa2 = new Pessoa()
            {
                Nome = "Jose Roberto",
                Idade = 35,
                Sexo = Sexos.Masculino,
                EnderecoInfo = endereco
            };

            
            Console.WriteLine(pessoa.LerPessoa()); // Estamos lendo o valor da propriedade Nome e Idade
            Console.WriteLine();
            Console.WriteLine(pessoa2.LerPessoa());

            Console.ReadKey();

        }
    }
}
