using Negocio;
using System;
using System.Windows.Forms;
namespace View
{
    public partial class FrmCadastro : Form
    {
        private readonly PlantaService _plantaService;

        public FrmCadastro()
        {
            InitializeComponent();
            _plantaService = new PlantaService();
        }


        public void adicionar()
        {


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int? codigo;
            string nome;
            string observacoes;
            DateTime datadeverificacao;
            string ciclodeagua;
            string cicloiluminacao;
            string tiposolo;
            string fertilizante;
            string resultado;

            nome = txtNome.Text;
            observacoes = txtObservacoes.Text;
            datadeverificacao = DateTime.Now;
            ciclodeagua = txtCicloAgua.Text;
            cicloiluminacao = txtCicloIluminacao.Text;
            tiposolo = txtTipodeSolo.Text;
            fertilizante = txtFertilizante.Text;


            resultado = _plantaService.Update(nome, observacoes, datadeverificacao, ciclodeagua, cicloiluminacao, tiposolo, fertilizante, null);
            if (resultado == "SUCESSO")
            {
                MessageBox.Show("FUNCIONOU CÃO");
            }

        }
    }
}
