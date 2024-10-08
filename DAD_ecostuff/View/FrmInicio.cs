using System;
using System.Windows.Forms;

namespace View
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
            FrmCadastro frmCadastro = new FrmCadastro();
            frmCadastro.MdiParent = this;
            frmCadastro.Size = frmCadastro.MdiParent.Size;
            frmCadastro.Show();
        }



        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastro frmCadastro = new FrmCadastro();
            frmCadastro.MdiParent = this;
            frmCadastro.Size = frmCadastro.MdiParent.Size;
            frmCadastro.Show();
        }

        private void ediçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ediçãoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmConsultaPlanta frmConsulta = new FrmConsultaPlanta();
            frmConsulta.MdiParent = this;
            
            frmConsulta.Show();
        }
    }
}
