using ClassesObjetos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos.Classes
{
    public class Funcionario : Pessoa
    {
        public IDocumento Documento { get; set; }
        public string Cargo { get; set; }

        //3º tipo de propriedade: property expression (novo no C# 7.0)
        private double _salario;
        public double Salario 
        {
            get => _salario;
            set => _salario = (value > 0) ? _salario = value : throw new ArgumentException("Salário invalido");
        }

        // Suponha que o imposto de renda seja equivalente a 10% do que exeder o salário
        // de R$ 1500,00. Escreveremos uma propriedade somente-leitura
        //public double Irpf
        //{
        //  get {return this.Salario >1500 ? (this.Salario - 1500) * 0.1 : 0; }
        //}

        public double Irpf => this.Salario > 1500 ? (this.Salario - 1500) * 0.1 : 0;

        // analogamente, definiremos a propiedade SalarioLiquido como sendo somente-leitura
        public double SalarioLiquido => this.Salario - this.Irpf;

        public Funcionario(IDocumento documento, string nome, string cargo) : base(nome)
        {
            this.Documento = documento;
            this.Cargo = cargo;
        }
        public Funcionario(IDocumento documento, string nome, string cargo, double salario) 
            : this(documento, nome, cargo)
        {
            this.Salario = salario;
        }

        public override string LerPessoa()
        {
            string resposta = $"{base.LerPessoa()}\nCargo: {Cargo}\n" +
                $"Salario Bruto: {Salario:c}\nIRPF: {Irpf:c}\n" +
                $"Salário Líquido: {SalarioLiquido:c}\nDocumento: {Documento.GetDocumento()}";
            return resposta;
        }

        public override string ToString()
        {
            return $"{Documento.Numero} - {Nome}";
        }

    }
}
