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
        private readonly  ClienteService clienteService;
        public FrmCliente()
        {
            InitializeComponent();
            clienteService = new ClienteService();
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

            resultado = clienteService.Update(nome, email, cpf_cnpj, rg, celular, senha,null);
            if (resultado == "SUCESSO")
            {
                MessageBox.Show("Adicionado com Sucesso!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    } 

}
   

