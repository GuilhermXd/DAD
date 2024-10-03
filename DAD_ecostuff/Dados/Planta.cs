using System;

namespace Dados
{
    public class Planta
    {

        private int? codigo;
        private string nome;
        private string nomecientifico;
        private string observacoes;
        private DateTime datadeverificacao;
        private int ciclodeagua;
        private int cicloiluminacao;
        private string tiposolo;
        

        public int? Codigo { get => codigo; set => codigo = value; }

        public string Nome { get => nome; set => nome = value; }

        public string Observacoes { get => observacoes; set => observacoes = value; }

        public DateTime Datadeverificacao { get => datadeverificacao; set => datadeverificacao = value; }
        public int Ciclodeagua { get => ciclodeagua; set => ciclodeagua = value; }

        public int Cicloiluminacao { get => cicloiluminacao; set => cicloiluminacao = value; }

        public string Tiposolo { get => tiposolo; set => tiposolo = value; }

        public string Nomecientifico { get => nomecientifico; set => nomecientifico = value; }


    }
}
