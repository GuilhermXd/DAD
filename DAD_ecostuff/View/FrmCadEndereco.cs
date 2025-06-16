using Dados;
using FluentValidation.Results;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FrmCadEndereco : Form
        
      
    {
        private readonly Endereco_ClienteService _enderecoService;
        DataTable dtCEndereco = new DataTable();



        public FrmCadEndereco()
        {
            InitializeComponent();
            _enderecoService = new Endereco_ClienteService();
        }


        private void carregaGridView()
        {
            dtCEndereco = _enderecoService.getAll();
            dgCEndereco.DataSource = dtCEndereco;
            dgCEndereco.Refresh();
        }

        private void FrmCadEndereco_Load(object sender, EventArgs e)
        {
            carregaGridView();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int? codigo;
            int codigoCliente = int.Parse(txtCodCliente.Text);
            string bairro = txtBairro.Text;
            string rua = txtRua.Text;
            string cidade = txtCidade.Text;
            string pais = txtPais.Text;
            int cep = int.Parse(txtCep.Text);
            string numero = txtNumero.Text;
            string estado = txtEstado.Text;

            Endereco_Cliente endereco = new Endereco_Cliente();
            endereco.CEP = int.Parse(txtCep.Text);
            endereco.Pais = txtPais.Text;
            endereco.Estado = txtEstado.Text;
            endereco.Cidade = txtCidade.Text;
            endereco.Bairro = txtBairro.Text;
            endereco.Rua = txtRua.Text;
            endereco.Numero = txtNumero.Text;
            endereco.ClienteCodigo = int.Parse(txtCodCliente.Text);


            string resultado;
            resultado = _enderecoService.Update(cep, rua, numero, bairro,  cidade, pais, null, codigoCliente, estado);
            if (resultado == "SUCESSO")
            {
                MessageBox.Show("Adicionado com Sucesso!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LimpaText();
            atualiza();
        }

        public void LimpaText()
        {
            txtCep.Text = "";
            txtEstado.Text = "";
            txtCidade.Text = "";
            txtPais.Text = "";
            txtBairro.Text = "";
            txtNumero.Text = "";
            txtRua.Text = "";
            txtCodCliente.Text = "";
        }


        public void atualiza()
        {
            dgCEndereco.DataSource = _enderecoService.getAll();
        }

        int codEnd;

        private void dgCEndereco_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= 0)
            {
                return;
            }
            string id = dgCEndereco.Rows[e.RowIndex].Cells[6].Value.ToString();
            try { 
            codEnd = int.Parse(id);
            } catch(Exception err){
                MessageBox.Show("Erro ao selecionar o endereço: " + err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgCEndereco.Refresh();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string resultado;
            string msg;
            DialogResult result = MessageBox.Show("Deseja confirmar exclusão?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                resultado = _enderecoService.Remove(codEnd);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            string msg;
            msg = "A operação foi Cancelada!";
            MessageBox.Show(msg, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            atualiza();
            LimpaText();
        }

        private void dgCEndereco_SelectionChanged(object sender, EventArgs e)
        {

            DataGridView row = (DataGridView)sender;
            if (row.CurrentRow == null)
                return;
            txtCep.Text = dgCEndereco.CurrentRow.Cells[0].Value.ToString();

            txtRua.Text = dgCEndereco.CurrentRow.Cells[1].Value.ToString();

            txtNumero.Text = dgCEndereco.CurrentRow.Cells[2].Value.ToString();

            txtBairro.Text =
             dgCEndereco.CurrentRow.Cells[3].Value.ToString();

            txtCidade.Text = dgCEndereco.CurrentRow.Cells[4].Value.ToString();

            txtPais.Text = dgCEndereco.CurrentRow.Cells[5].Value.ToString();

            txtEstado.Text = dgCEndereco.CurrentRow.Cells[6].Value.ToString();
        }
    }
    }
