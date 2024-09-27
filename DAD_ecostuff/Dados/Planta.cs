using System;

namespace Dados
{
    public class Planta
    {

        private int? codigo;
        private string nome;
        private string observacoes;
        private DateTime datadeverificacao;
        private string ciclodeagua;
        private string cicloiluminacao;
        private string tiposolo;
        private string fertilizante;



        public int? Codigo { get => codigo; set => codigo = value; }

        public string Nome { get => nome; set => nome = value; }

        public string Observacoes { get => observacoes; set => observacoes = value; }

        public DateTime Datadeverificacao { get => datadeverificacao; set => datadeverificacao = value; }
        public string Ciclodeagua { get => ciclodeagua; set => ciclodeagua = value; }

        public string Cicloiluminacao { get => cicloiluminacao; set => cicloiluminacao = value; }

        public string Tiposolo { get => tiposolo; set => tiposolo = value; }

        public string Fertilizante { get => fertilizante; set => fertilizante = value; }
    }
}
