using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class Endereco_Cliente
    {
        private int cep;
        private string rua;
        private string numero;
        private string bairro;
        private string cidade;
        private string pais;
        private int? codigo; // Código é a chave primária com Auto Increment
        private int? clienteCodigo; // Chave estrangeira, cliente PK
        private string estado;


        public int CEP
        {
            get { return cep; }
            set { cep = value; }
        }

        public string Rua
        {
            get { return rua; }
            set { rua = value; }
        }

        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        public string Pais
        {
            get { return pais; }
            set { pais = value; }
        }

        public int? Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public int? ClienteCodigo
        {
            get { return clienteCodigo; }
            set { clienteCodigo = value; }
        }

        public string Estado
        {

            get{ return estado; }
            set { estado = value; }
        }
    }
}
