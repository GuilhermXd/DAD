using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dados;
using Negocio;

namespace View
{
    public partial class FrmEndereco : Form
    {
        private readonly Endereco_ClienteService _enderecoService;
        DataTable dtCliente_Endereco = new DataTable();

        public FrmEndereco()
        {
            InitializeComponent();
            _enderecoService = new Endereco_ClienteService();
        }

        private void HabilitaGridEndereco()
        {
            dgEndereco.Visible = true;
            dgEndereco.Dock = DockStyle.Fill;
        }

        private void carregagri() 
        {
            dtCliente_Endereco = _enderecoService.getAll();
            dgEndereco.DataSource = dtCliente_Endereco;
            dgEndereco.Refresh();

        }
        private void btnEndereco_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = int.Parse(txtCodEnd.Text);
                DataTable dtEndereco = _enderecoService.filterByClienteCodigo(codigo);
                if (dtEndereco != null)
                {
                    dgEndereco.DataSource = dtEndereco;
                    dgEndereco.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            HabilitaGridEndereco();
        }

        private void LimparText(){
            txtCodEnd.Text = " ";
        }

        private void btnCancelaConsulta_Click(object sender, EventArgs e)
        {
            LimparText();
            dgEndereco.Visible = false;
        }

        private void FrmEndereco_Load(object sender, EventArgs e)
        {
            carregagri();
        }

        private void pEndereco_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
