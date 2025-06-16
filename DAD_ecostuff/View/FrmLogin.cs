using Negocio;
using System;
using Dados;
using System.Windows.Forms;
using FluentValidation.Results;
using MySqlX.XDevAPI.Common;
using System.Collections.Generic;

namespace View
{
    public partial class FrmLogin : Form
    {
        private readonly Adm _admService;
        List<Adm> users = new List<Adm> { };

        public FrmLogin()
        {
            InitializeComponent();
            txtSenha.UseSystemPasswordChar = true;
            this.AcceptButton = btnEntrar;
           
            _admService = new Adm("cecilia@gmail.com", "cecilia123");
            users.Add(_admService);
            _admService = new Adm("guilherme@gmail.com", "989808412");
            users.Add(_admService);
            _admService = new Adm("samuel@gmail.com", "sa7mu7el7");
            users.Add(_admService);


        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string email = txtUser.Text.Trim();
            string senha = txtSenha.Text;

            if (!email.Contains("@"))
            {
                MessageBox.Show("Por favor, insira um e-mail válido (deve conter '@').",
                                "E-mail inválido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtUser.Focus();
                return;
            }

            if (string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Por favor, insira a senha.",
                              "Senha obrigatória",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                txtSenha.Focus();
                return;
            }
            bool vdd = false;
            foreach (Adm a in users) {
                if (email == a.Email && senha == a.Senha) {
                    vdd = true;
                    MessageBox.Show("Credenciais Confirmadas! \n Você será redirecionado, aguarde...",
                                   "Login bem-sucedido",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
                    this.Hide();
                    using (var formInicio = new FrmInicio())
                    {
                        formInicio.ShowDialog();
                    }
                    this.Close();
                    break;
                }
              
            }
            if (!vdd)
            {
                MessageBox.Show("E-mail ou senha incorretos.",
                               "Falha no login",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                txtSenha.Clear();
                txtUser.Focus();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = !txtSenha.UseSystemPasswordChar;

        }
    }
}
