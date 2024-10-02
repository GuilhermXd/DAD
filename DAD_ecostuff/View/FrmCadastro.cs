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
            txtData.Text = DateTime.Now.ToString();
            _plantaService = new PlantaService();
        }


        public void adicionar()
        {


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int? codigo;
            string nome= txtNome.Text;
            string observacoes =  txtObservacoes.Text;
            DateTime datadeverificacao = DateTime.Now; ;
            int ciclodeagua = 0;
            int cicloiluminacao = 0;
            string tiposolo = txtTipodeSolo.Text;

            string resultado;
            if(!string.IsNullOrEmpty(txtCicloAgua.Text))
                ciclodeagua = int.Parse(txtCicloAgua.Text);
            if (!string.IsNullOrEmpty(txtCicloIluminacao.Text))
                cicloiluminacao = int.Parse(txtCicloIluminacao.Text);

            resultado = _plantaService.Update(nome, observacoes, datadeverificacao, ciclodeagua, cicloiluminacao, tiposolo, null);
            if (resultado == "SUCESSO")
            {
                MessageBox.Show("FUNCIONOU CÃO");
            }

        }

        /* Botões */
        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
        /*-------------------------------*/

        /* Focus */
        String textoAntigo = "";
        TextBox textBox;
        bool preenchido = false;
        private void TextBox_Enter(object sender, EventArgs e)
        {
            if (!preenchido)
            {
                textBox = sender as TextBox;
                textBox.ForeColor = System.Drawing.Color.Black;
                textoAntigo = textBox.Text;
                textBox.Clear();
            }
        }

        private void Textbox_Leave(object sender, EventArgs e)
        {
            textBox = sender as TextBox;
            if(string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = textoAntigo;
                textBox.ForeColor= System.Drawing.Color.Gray;
                textoAntigo = "";
            }
            else
                preenchido=true;
        }
    }
}
