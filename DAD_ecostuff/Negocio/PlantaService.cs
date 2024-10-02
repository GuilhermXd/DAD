using Dados;
using System;
using System.Data;

namespace Negocio
{
    public class PlantaService
    {
        private PlantaRepository _repository;

        public PlantaService()
        {
            _repository = new PlantaRepository();
        }

        private string nome;
        private string observacoes;
        private DateTime datadaverificacao;
        private int ciclodeAgua;
        private int cicloiluminista;
        private string tipodeSolo;
  
        private int? codigo;

        public string Update(string nome, string observacoes, DateTime datadeverificacao, int ciclodeagua, int cicloiluminista, string tipodesolo, int? codigo)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            var planta = new Planta
            {
                Codigo = codigo,
                Nome = nome,
                Observacoes = observacoes,
                Datadeverificacao = datadeverificacao,
                Ciclodeagua = ciclodeagua,
                Cicloiluminacao = cicloiluminista,
                Tiposolo = tipodesolo,
                //mano to com medo
            };

            if (codigo == null)
                return _repository.Inserir(planta);
            else
                return _repository.Update(planta);

        }

        public string Inserir(Planta planta)
        {
            return _repository.Inserir(planta);
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
