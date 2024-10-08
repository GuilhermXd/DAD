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
    public partial class FrmConsulta : Form
    {
        private readonly PlantaService _plantaService;
        private DataTable tblPlanta = new DataTable();
        public FrmConsulta()
        {
            InitializeComponent();
            _plantaService = new PlantaService();

          
        }
        
        private void carregaGridView()
        {
            tblPlanta = _plantaService.getAll();
            dgPlanta.DataSource = tblPlanta;
            //dgPlanta.DataSource = _plantaService.getAll();
            dgPlanta.Refresh();
        }
        private void atualiza() {
            dgPlanta.DataSource = _plantaService.getAll();
        }

        private void FrmConsulta_Load(object sender, EventArgs e)
        {
            carregaGridView();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string resultado;
            string msg;
            DialogResult result= MessageBox.Show("Deseja confirmar exclusão?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                resultado = _plantaService.Remove(codigo);
                atualiza();
                if (resultado != "SUCESSO") {
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
       

        private void dgPlanta_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex <= 0)
            {
                return;
            }
            string id = dgPlanta.Rows[e.RowIndex].Cells[0].Value.ToString();
            codigo = int.Parse(id);
            dgPlanta.Refresh();
        }
    }
}
