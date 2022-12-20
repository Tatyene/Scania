using System.Collections;
using System.Collections.Generic;

namespace Projeto01.ConceitosMVC.Models
{
    public class Utils
    {
        public static IEnumerable<Pessoa> ListarPessoas()
        {
            return new List<Pessoa>()
            {
                new Fornecedor()
                {
                    Cpf = "22991312807",
                    Nome = "Ananias Silva",
                    Email = "ananais@gmail.com",
                    Telefone = "3258-2200"
                },
                new Cliente()
                {
                    Cpf = "2586994565",
                    Nome = "Sebastião Golveia",
                    Email = "sebastiao@gmail.com",
                    Telefone = "2563-7854"
                }
            };
        }
    }
}
