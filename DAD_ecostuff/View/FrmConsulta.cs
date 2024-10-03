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

        private void FrmConsulta_Load(object sender, EventArgs e)
        {
            carregaGridView();
        }
    }
}
