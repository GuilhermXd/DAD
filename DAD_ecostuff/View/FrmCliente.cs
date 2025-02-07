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
using System.Configuration;
using System.Data.SqlClient;
using Org.BouncyCastle.Pqc.Crypto.Lms;
using FluentValidation.Results;
using MySqlX.XDevAPI;
using Org.BouncyCastle.Asn1.X509;
namespace View
{
    public partial class FrmCliente : Form
    {
        int codigo = -1;
        private readonly ClienteService _clienteService;
        private readonly Endereco_ClienteService _enderecoService;
        DataTable dtCliente_Endereco = new DataTable();
        DataTable dtCliente = new DataTable();





        public FrmCliente()
        {
            InitializeComponent();
            _clienteService = new ClienteService();


            _enderecoService = new Endereco_ClienteService();
        }


        private void carregaGridView()
        {

            

            dtCliente = _clienteService.getAll();
            dgCliente.DataSource = dtCliente;
            dgCliente.Refresh();
        }
        private void atualiza()
        {
            dgCliente.DataSource = _clienteService.getAll();
        }
        private void txtAdiciona_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            string cpf_cnpj = txtCpf_Cnpj.Text;
            string rg = txtRg.Text;
            string celular = txtCelular.Text;
            string senha = txtSenha.Text;

            Cliente cliente = new Cliente();
            cliente.Nome = txtNome.Text;
            cliente.Email = txtEmail.Text;
            cliente.Cpf_Cnpj = txtCpf_Cnpj.Text;
            cliente.Rg = txtRg.Text;
            cliente.Celular = txtCelular.Text;
            cliente.Senha = txtSenha.Text;

            if (cliente != null)
            {
                ClienteValidator validator = new ClienteValidator();
                ValidationResult results = validator.Validate(cliente);
                IList<ValidationFailure> failures = results.Errors;
                if (!results.IsValid)
                {
                    foreach (ValidationFailure failure in failures)
                    {
                        MessageBox.Show(failure.ErrorMessage, "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            try
            {
                _clienteService.Update(nome, email, cpf_cnpj, rg, celular, senha, null);
                MessageBox.Show("Cliente Cadastrado", "Sucesso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Campos obrigatórios não preenchidos", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                lblEmail.ForeColor = Color.Red;
                lblNome.ForeColor = Color.Red;
            }
            atualiza();

        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            carregaGridView();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (codigo == -1)
                MessageBox.Show("Selecione uma linha", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                DialogResult result = MessageBox.Show("Deseja confirmar exclusão?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    _clienteService.Remove(codigo);
                    MessageBox.Show("Cliente Removido com Sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    atualiza();
                }
            }
        }



        private void dgCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgCliente.Rows[e.RowIndex].Cells[0].Value.ToString();
            codigo = int.Parse(id);
            dgCliente.Refresh();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            FrmPesquisa f = new FrmPesquisa();
            string txtBusca = "";

            f.ShowDialog();
            txtBusca = f.Texto;
            DataTable tbClientes = _clienteService.filterByName(txtBusca);
            if (tbClientes != null)
            {
                dgCliente.DataSource = tbClientes;
                dgCliente.Refresh();
            }
        }

        public void LimparText()
        {
            txtNome.Text = " ";
            txtEmail.Text = " ";
            txtCpf_Cnpj.Text = " ";
            txtRg.Text = " ";
            txtCelular.Text = " ";
            txtSenha.Text = " ";
        }


        private void OpenFormInPanel(Form form, Panel panel)
        {
            if (panel.Controls.Count > 0)
            {
                panel.Controls[0].Dispose();
            }

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;


            panel.Controls.Add(form);
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmEndereco frmendereco = new FrmEndereco();
            OpenFormInPanel(frmendereco, pEnd);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
   

