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
    }
}
