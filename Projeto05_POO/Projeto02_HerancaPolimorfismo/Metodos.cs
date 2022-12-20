using ClassesObjetos.Classes;
using ClassesObjetos.Enumeracoes;
using ClassesObjetos.Estruturas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Projeto02_HerancaPolimorfismo
{
    public class Metodos
    {
        public static void LerDadosPessoa()
        {
            //obtendo o endereço como dados de entrada
            Console.Write("Informe o logradoro: ");
            string logradouro = Console.ReadLine();

            Console.Write("Informe o número: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Informe a cidade: ");
            string cidade = Console.ReadLine();

            Console.Write("Informe o Cep: ");
            string cep = Console.ReadLine();

            //definindo um endereço
            Endereco endereco = new Endereco()
            {
                Logradouro = logradouro,
                Numero = numero,
                Cidade = cidade,
                Cep = cep
            };

            Console.WriteLine();

            //obtendo os dados da pessoa
            Pessoa pessoa = new Pessoa();

            Console.Write("Informe o nome: ");
            pessoa.Nome = Console.ReadLine();

            Console.Write("Informe a idade: ");
            pessoa.Idade = int.Parse(Console.ReadLine());

            Console.Write("Informe o sexo (10-Masc., 20-Fem., 30-outros): ");
            int sexo = int.Parse(Console.ReadLine());
            pessoa.Sexo = (Sexos)sexo;

            pessoa.EnderecoInfo = endereco;

            MessageBox.Show(pessoa.LerPessoa());
        }

        // método usado para obter os dados do funcionário
        public static void LerDadosFuncionario()
        {
            Funcionario funcionario = new Funcionario();

            Console.Write("Informe o nome: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Informe a idade: ");
            funcionario.Idade = int.Parse(Console.ReadLine());

            Console.Write("Informe o sexo (10-Masc., 20-Fem., 30-outros): ");
            int sexo = int.Parse(Console.ReadLine());
            funcionario.Sexo = (Sexos)sexo;

            Console.Write("Informe o cargo: ");
            funcionario.Cargo = Console.ReadLine();

            Console.Write("Informe o salário: ");
            funcionario.Salario = double.Parse(Console.ReadLine());

            MessageBox.Show(funcionario.LerPessoa());
        }
        public static void LerDadosPessoaFuncionario()
        {
            Pessoa pessoa = new Funcionario() //Polimorfismo = variável 'pessoa' da super classe que faz referência a um objeto da 'Funcionário' da subclasse
            {                                  //O método assumi a forma ao qual o objeto se referencia. Assume a forma do objeto referenciado
                Nome = "Tatyene Alves",
                Idade = 35,
                Sexo = Sexos.Feminino,
                Cargo = "Gerente",
                Salario = 2000
            };

            //Após o objeto ter sido criado, como podemos fazer para alterar
            //(acessar) as propriedades específicas do objeto? (Cargo/Salario)
            
            if(pessoa is Funcionario)
            {
                Funcionario func = (Funcionario)pessoa;
                func.Cargo = "Gestor";
                func.Salario = 10000;
            }
            

            
            /*
             * O método executado é o método polimórfico (sobrescrito) referencia ao objeto.
             * Em outras palavras, quem executa o método é o objeto.
             */
            MessageBox.Show(pessoa.LerPessoa());

            pessoa = new Pessoa()
            {
                Nome = "Tatyene Alves",
                Idade = 35,
                Sexo = Sexos.Feminino,
            };
            MessageBox.Show(pessoa.LerPessoa());

            pessoa = new Aluno()
            {
                Nome = "Tatyene Alves",
                Idade = 35,
                Sexo = Sexos.Feminino,
                Curso = "ADS",
                Matricula = 1256369
            };


            if (pessoa is Aluno)
            {
                Aluno aluno = pessoa as Aluno;
                aluno.Curso = "Direito"; 
            }
            
            MessageBox.Show(pessoa.LerPessoa());

            object obj = pessoa;

            MessageBox.Show(
                obj.ToString(), 
                "Objeto Pessoa", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }
    }
}
