using Dados;
using Org.BouncyCastle.Security;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Endereco_ClienteService
    {
        private Endereco_ClienteRepository _repository;
        public Endereco_ClienteService() {
            _repository = new Endereco_ClienteRepository();
        }

        private int cep;
        private string rua;
        private string numero;
        private string bairro;
        private string cidade;
        private string pais;
        private int? codigo; // Código é a chave primária com Auto Increment
        private int? clienteCodigo;

        public string Update(int cep, string rua, string numero, string bairro, string cidade, string pais, int? codigo, int? clienteCodigo)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            var endereco_Cliente = new Endereco_Cliente
            {
                Codigo = codigo,
                ClienteCodigo = clienteCodigo,
                CEP = cep,
                Rua = rua,
                Numero = numero,
                Bairro = bairro,
                Cidade = cidade,
                Pais = pais
            };

            if (codigo == null)
                return _repository.Inserir(endereco_Cliente);
            else
                return _repository.Update(endereco_Cliente);

        }
        public string Inserir(Endereco_Cliente endereco_Cliente)
        {
            return _repository.Inserir(endereco_Cliente);
        }

        public string Remove(int codigo)
        {

            return _repository.Remove(codigo);
        }
        public DataTable getAll()
        {
            return _repository.getAll();
        }

        public DataTable filterByClienteCodigo(int clienteCodigo)
        {
            return _repository.filterByClientCodigo(clienteCodigo);
        }
    


    }
}
