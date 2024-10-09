using Negocio;
using System;
using System.Data;
using System.Windows.Forms;
namespace View
{
    public partial class FrmCadastro : Form
    {
        private readonly PlantaService _plantaService;
        DataTable dtPlanta = new DataTable();

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

            atualiza();

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


        public void carregaGridView() 
        {
            dtPlanta = _plantaService.getAll();
            dgPlanta.DataSource = dtPlanta;
            dgPlanta.Refresh();
        }
        private void atualiza()
        {
            dgPlanta.DataSource = _plantaService.getAll();
        }

        int codigoplanta;
        private void dgPlanta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= 0)
            {
                return;
            }
            string id = dgPlanta.Rows[e.RowIndex].Cells[0].Value.ToString();
            codigoplanta  = int.Parse(id);
            dgPlanta.Refresh();
        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {
            carregaGridView();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string resultado;
            string msg;
            DialogResult result = MessageBox.Show("Deseja confirmar exclusão?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                resultado = _plantaService.Remove(codigoplanta);
                atualiza();
                if (resultado != "SUCESSO")
                {
                    msg = "A Operação Falhou";
                }
                else
                {
                    msg = "A operação foi um Sucesso!";
                }
                MessageBox.Show(msg, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (result == DialogResult.No)
            {
                msg = "A operação foi Cancelada!";
                MessageBox.Show(msg, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            atualiza();

        }
    }
}
