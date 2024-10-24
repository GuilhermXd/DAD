using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class TesteIncioBonito : Form
    {
        public TesteIncioBonito()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OpenFormInPanel(Form form, Panel panel)
        {
            // Verifica se já existe um controle dentro do painel e o remove
            if (panel.Controls.Count > 0)
            {
                panel.Controls[0].Dispose(); // Remove o controle existente no painel
            }

            // Configura o Form para ser exibido dentro do painel
            form.TopLevel = false; // Define que o Form não é de nível superior
            form.FormBorderStyle = FormBorderStyle.None; // Remove bordas do Form
            form.Dock = DockStyle.Fill; // O Form vai ocupar todo o espaço do Panel

            // Adiciona o Form ao Panel
            panel.Controls.Add(form);
            form.Show(); // Exibe o Form
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            
        }

        /*
          FrmCliente frmCadCliente = new FrmCliente();
            OpenFormInPanel(frmCadCliente,pForm);


         FrmCadPlanta frmcadastro = new FrmCadPlanta();
            OpenFormInPanel(frmcadastro, pForm);
         */

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
    }
}
