using ClassesObjetos.Classes;
using ClassesObjetos.Enumeracoes;
using ClassesObjetos.Estruturas;
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
        public FormCadastro() // construtor
        {
            InitializeComponent();
            HabilitarEndereco(enderecoCheckBox.Checked);

            sexoComboBox.Items.Add(Sexos.Masculino);
            sexoComboBox.Items.Add(Sexos.Feminino);
            sexoComboBox.Items.Add(Sexos.Outros);

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
            // Obtendo os dados da classe Funcionário
            Funcionario funcionario = 
                new Funcionario(   
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
            }
            
            MessageBox.Show(funcionario.LerPessoa());
        }
    }
}
