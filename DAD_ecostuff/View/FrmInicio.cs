using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            FrmAb ab = new FrmAb();
            OpenFormInPanel(ab, pForm);
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            FrmAb ab = new FrmAb();
            OpenFormInPanel(ab, pForm);
        }

     

        private void pForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFrmPlanta_Click(object sender, EventArgs e)
        {
            FrmCadPlanta frmcadastro = new FrmCadPlanta();
            OpenFormInPanel(frmcadastro, pForm);
        }

      
        private void btnFrmCliente_Click_1(object sender, EventArgs e)
        {
            FrmCliente frmCadCliente = new FrmCliente();
            OpenFormInPanel(frmCadCliente, pForm);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            string caminhoArquivo = @"C:\Users\aluno\Desktop\DAD\DAD_ecostuff\fale-conosco.html";

            string conteudoHtml =
                @"<!DOCTYPE html>
        <html>
        <head>
            <title>Fale Conosco</title>
            <style>
                body { font-family: Arial, sans-serif; margin: 20px; }
                h1 { color: #0066cc; }
                .contato { margin-top: 20px; line-height: 1.6; }
            </style>
        </head>
        <body>
            <h1>Fale Conosco</h1>
            <div class='contato'>
                <strong>Empresa:</strong> Sua Empresa Ltda.<br>
                <strong>Telefone:</strong> (11) 1234-5678<br>
                <strong>E-mail:</strong> contato@empresa.com<br>
                <strong>Endereço:</strong> Rua Exemplo, 123 - São Paulo/SP<br>
                <strong>Horário:</strong> Seg-Sex, 9h às 18h
            </div>
        </body>
        </html>";

            File.WriteAllText(caminhoArquivo, conteudoHtml);
            System.Diagnostics.Process.Start(caminhoArquivo);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnEndereco_Click(object sender, EventArgs e)
        {
            FrmCadEndereco frmCadEndereco = new FrmCadEndereco();
            OpenFormInPanel(frmCadEndereco, pForm);
        }

        private void lkFale_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string caminhoArquivo = @"C:\Users\aluno\Desktop\DAD\DAD_ecostuff\fale-conosco.html";

            string conteudoHtml =
                @"<!DOCTYPE html>
        <html>
        <head>
            <title>Fale Conosco</title>
            <style>
                body { font-family: Arial, sans-serif; margin: 20px;}
                h1 { color: #628067; }
                    
                .contato { margin-top: 20px; line-height: 1.6; }
            </style>
        </head>
        <body>
            <h1>Fale Conosco</h1>
            <div class='contato'>
                <strong>Empresa:</strong> EcoStuff.<br>
                <strong>Telefone:</strong> (19) 99910-0212<br>
                <strong>E-mail:</strong> ecostuff@empresa.com<br>
                <strong>Endereço:</strong> R. Paschoal Marmo, 1888 - Jardim Nova Italia, Limeira - SP, 13484-431 /SP<br>
                <strong>Horário:</strong> Seg-Sex, 9h às 16h
            </div>
        </body>
        </html>";

            File.WriteAllText(caminhoArquivo, conteudoHtml);
            System.Diagnostics.Process.Start(caminhoArquivo);
        }
    }
}
