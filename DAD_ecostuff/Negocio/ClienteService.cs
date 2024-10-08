using Dados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ClienteService
    {
        private  ClienteRepository _repository;

        public   ClienteService()
        {
            _repository = new ClienteRepository();
        }

        private string nome;
        private string email;
        private string cpf_cnpj;
        private string rg;
        private string celular;
        private string senha;

        private int? codigo;

        public string Update(string nome, string email, string cpf_cnpj, string rg, string celular,string senha, int? codigo)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado
            
            var cliente = new Cliente
            {
                Codigo = codigo,
                Nome = nome,
                Email = email,
                Cpf_Cnpj = cpf_cnpj,
                Rg = rg,
                Celular = celular,
                Senha = senha,
            };

            if (codigo == null)
                return _repository.Inserir(cliente);
            else
                return _repository.Update(cliente);

        }

        public string Inserir(Cliente cliente)
        {
            return _repository.Inserir(cliente);
        }

        public string Remove(int codigo)
        {

            return _repository.Remove(codigo);
        }
        public DataTable getAll()
        {
            return _repository.getAll();
        }

        public DataTable filterByName(string nome)
        {
            return _repository.filterByName(nome);
        }
    }
}

