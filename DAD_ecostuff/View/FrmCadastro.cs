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
            string nomecientifico = txtNomeCientifico.Text;

            string resultado;
            if(!string.IsNullOrEmpty(txtCicloAgua.Text))
                ciclodeagua = int.Parse(txtCicloAgua.Text);
            if (!string.IsNullOrEmpty(txtCicloIluminacao.Text))
                cicloiluminacao = int.Parse(txtCicloIluminacao.Text);

            resultado = _plantaService.Update(nome, nomecientifico, observacoes, datadeverificacao, ciclodeagua, cicloiluminacao, tiposolo, null);
            if (resultado == "SUCESSO")
            {
                MessageBox.Show("Adicionado com Sucesso!","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }

        /* Botões */
        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
        /*-------------------------------*/

        /* Focus */
        string textoAntigo = "";
        TextBox textBox;
        
        private void TextBox_Enter(object sender, EventArgs e)
        { 
            textBox = sender as TextBox;
            textBox.ForeColor = System.Drawing.Color.Black;
            textoAntigo = textBox.Text;
            textBox.Clear();
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
            
        }

        private void txtObservacoes_TextChanged(object sender, EventArgs e)
        {




        }
    }
}
