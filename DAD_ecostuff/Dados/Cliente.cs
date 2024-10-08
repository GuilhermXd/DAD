using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class Cliente
    {
        private int? codigo;
        private string nome;
        private string email;
        private string cpf_cnpj;
        private string rg;
        private string celular;
        private string senha;

        public int? Codigo { get => codigo; set => codigo = value; }

        public string Nome { get => nome; set => nome = value; }

        public string Email { get => email; set => email = value; }

       
        public string  Cpf_Cnpj { get => cpf_cnpj; set => cpf_cnpj = value; }

        public string Rg { get => rg; set => rg = value; }

        public string Celular { get => celular; set => celular = value; }

        public string Senha { get => senha; set => senha = value; }
    }
}
