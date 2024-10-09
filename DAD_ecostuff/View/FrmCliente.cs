using Dados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
namespace View
{
    public partial class FrmCliente : Form
    {
        private readonly  ClienteService _clienteService;
        DataTable dtCliente = new DataTable();
        public FrmCliente()
        {
            InitializeComponent();
            _clienteService = new ClienteService();
        }

        private void carregaGridView()
        {
            dtCliente = _clienteService.getAll();
            dgCliente.DataSource = dtCliente;
            //dgPlanta.DataSource = _plantaService.getAll();
            dgCliente.Refresh();
        }
        private void atualiza()
        {
            dgCliente.DataSource = _clienteService.getAll();
        }
        private void txtAdiciona_Click(object sender, EventArgs e)
        {
            int? codigo;
            string nome = txtNome.Text;
         string email = txtEmail.Text;
         string cpf_cnpj = txtCpf_Cnpj.Text;
         string rg = txtRg.Text;
         string celular = txtCelular.Text;
         string senha = txtSenha.Text;

            string resultado;

            resultado = _clienteService.Update(nome, email, cpf_cnpj, rg, celular, senha,null);
            if (resultado == "SUCESSO")
            {
                MessageBox.Show("Adicionado com Sucesso!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void FrmCliente_Load(object sender, EventArgs e)
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
                resultado = _clienteService.Remove(codigo);
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

        }
        
        
        int codigo;
        private void dgCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex <= 0)
            {
                return;
            }
            string id = dgCliente.Rows[e.RowIndex].Cells[0].Value.ToString();
            codigo = int.Parse(id);
            dgCliente.Refresh();
        }
    } 

}
   

