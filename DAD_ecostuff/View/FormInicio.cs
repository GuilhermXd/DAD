using System;
using System.Windows.Forms;

namespace View
{
    public partial class FormInicio : Form
    {
        public FormInicio()
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
    }
}
