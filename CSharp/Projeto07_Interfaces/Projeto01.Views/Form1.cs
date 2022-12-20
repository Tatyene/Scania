using ClassesObjetos.Classes;
using ClassesObjetos.Data;
using ClassesObjetos.Enumeracoes;
using ClassesObjetos.Estruturas;
using ClassesObjetos.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto01.Views
{
    public partial class FormCadastro : Form
    {
        FuncionariosDao dao;
        public FormCadastro() // construtor
        {
            InitializeComponent();
            HabilitarEndereco(enderecoCheckBox.Checked);

            sexoComboBox.Items.Add(Sexos.Masculino);
            sexoComboBox.Items.Add(Sexos.Feminino);
            sexoComboBox.Items.Add(Sexos.Outros);
            dao = new FuncionariosDao();

            ListarFuncionarios();

            List<Curso> cursos = new List<Curso>()
            {
                new Curso("ADS", 3400),
                new Curso("Pedagogia", 4800),
                new Curso("JavaScript", 40)
            };

            foreach (var item in cursos)
            {
                cursoComboBox.Items.Add(item);
            }
        }

        private void HabilitarEndereco(bool opcao)
        {
            logradouroLabel.Enabled = opcao;
            logradouroTextBox.Enabled = opcao;

            numeroLabel.Enabled = opcao;
            numeroTextBox.Enabled = opcao;

            cidadeLabel.Enabled = opcao;
            cidadeTextBox.Enabled = opcao;

            cepLabel.Enabled = opcao;
            cepTextBox.Enabled = opcao;
        }

        private void LimparCampos()
        {
            nomeTextBox.Clear();
            idadeTextBox.Clear();
            sexoComboBox.SelectedIndex = -1; // volta para a posição -1 do index da lista
            cargoTextBox.Clear();
            salarioTextBox.Clear();
            documentoTextBox.Clear();

            enderecoCheckBox.Checked = false;

            logradouroTextBox.Clear();
            numeroTextBox.Clear();
            cidadeTextBox.Clear();
            cepTextBox.Clear();

            nomeTextBox.Focus(); // envia o cursor para o campo de entrada "Nome"
        }

        private int BuscarSexo(Sexos sexo)
        {
            int posicao = -1;
            switch (sexo)
            {
                case Sexos.Masculino: posicao = 0;break;
                case Sexos.Feminino: posicao = 1;break;
                default: posicao = 2;break;
            }
            return posicao;
        }

        private void ListarFuncionarios()
        {
            funcionariosListBox.Items.Clear();
            foreach (var item in dao.ListarFuncionarios())
            {
                funcionariosListBox.Items.Add(item);
            }
        }


        private void enderecoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarEndereco(enderecoCheckBox.Checked);
        }

        private void fecharButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void incluirButton_Click(object sender, EventArgs e)
        {
            try
            {
                string doc = documentoTextBox.Text;
                IDocumento documento;

                if (doc.Length == 11)
                {
                    documento = new DocumentoCpf(doc);
                }
                else if (doc.Length == 14)
                {
                    documento = new DocumentoCnpj(doc);
                }
                else
                {
                    throw new InvalidOperationException("O documento informado é inválido");
                }


                // Obtendo os dados da classe Funcionário
                Funcionario funcionario =
                    new Funcionario(
                        documento,    
                        nomeTextBox.Text,
                        cargoTextBox.Text,
                        double.Parse(salarioTextBox.Text));

                funcionario.Idade = int.Parse(idadeTextBox.Text);
                funcionario.Sexo = (Sexos)sexoComboBox.SelectedItem;

                Endereco endereco;

                if (enderecoCheckBox.Checked)
                {
                    endereco = new Endereco();
                    endereco.Logradouro = logradouroTextBox.Text;
                    endereco.Numero = int.Parse(numeroTextBox.Text);
                    endereco.Cidade = cidadeTextBox.Text;
                    endereco.Cep = cepTextBox.Text;

                    funcionario.EnderecoInfo = endereco;
                }
                
                int registros = dao.IncluirFuncionario(funcionario);
                ListarFuncionarios();
                //funcionariosListBox.Items.Add(funcionario);

                LimparCampos();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, 
                    "Erro", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void funcionariosListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimparCampos();
            if(funcionariosListBox.Items.Count > 0)
            {
                Funcionario func = (Funcionario)funcionariosListBox.SelectedItem;

                nomeTextBox.Text = func.Nome;
                idadeTextBox.Text = func.Idade.ToString();
                sexoComboBox.SelectedIndex = BuscarSexo(func.Sexo);
                cargoTextBox.Text = func.Cargo;
                salarioTextBox.Text = func.Salario.ToString();
                documentoTextBox.Text = func.Documento.Numero;

                if (!string.IsNullOrEmpty(func.EnderecoInfo.Logradouro))
                {
                    enderecoCheckBox.Checked = true;

                    Endereco end = func.EnderecoInfo;

                    logradouroTextBox.Text = end.Logradouro;
                    cidadeTextBox.Text = end.Cidade;
                    numeroTextBox.Text = end.Numero.ToString();
                    cepTextBox.Text = end.Cep;
                }
            }
        }

        private void removerButton_Click(object sender, EventArgs e)
        {
            dao.RemoverFuncionario(documentoTextBox.Text);
            LimparCampos();
            ListarFuncionarios();
        }

        private void limparButton_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}
