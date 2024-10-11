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
using System.Configuration;
using System.Data.SqlClient;
using Org.BouncyCastle.Pqc.Crypto.Lms;
namespace View
{
    public partial class FrmCliente : Form
    {
        private readonly  ClienteService _clienteService;
        private readonly Endereco_ClienteService _enderecoService;
        DataTable dtCliente = new DataTable();
        private DataGridView dataGridView;


         private void ExibirDataGridVertical(List<Endereco_Cliente> endCliente)
         {
             // Limpar colunas e linhas anteriores
             dataGridView.Columns.Clear();
             dataGridView.Rows.Clear();

             // Verificar se a lista de clientes não está vazia
             if (endCliente == null || endCliente.Count == 0)
             {
                 MessageBox.Show("Não há Endereços para exibir.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 return;
             }

            // Criar uma coluna para cada cliente
            foreach (var endereco in endCliente)
            {
                // Usar o CEP do cliente como o título da coluna
                dataGridView.Columns.Add(endereco.CEP.ToString(), endereco.CEP.ToString());
            }

            // Adicionar as linhas representando os atributos

            dataGridView.Rows.Add("CEP");
             dataGridView.Rows.Add("Rua");
             dataGridView.Rows.Add("Numero");
             dataGridView.Rows.Add("Bairro");
             dataGridView.Rows.Add("Cidade");
             dataGridView.Rows.Add("Pais");
             dataGridView.Rows.Add("Codigo");
             dataGridView.Rows.Add("ClienteCodigo");

             // Preencher as linhas com os valores de cada cliente
             for (int i = 0; i < endCliente.Count; i++)
             {
                 dataGridView.Rows[0].Cells[i].Value = endCliente[i].Codigo;
                 dataGridView.Rows[1].Cells[i].Value = endCliente[i].ClienteCodigo;
                 dataGridView.Rows[2].Cells[i].Value = endCliente[i].Rua;
                 dataGridView.Rows[3].Cells[i].Value = endCliente[i].Numero;
                 dataGridView.Rows[4].Cells[i].Value = endCliente[i].Bairro;
                 dataGridView.Rows[5].Cells[i].Value = endCliente[i].Cidade;
                 dataGridView.Rows[6].Cells[i].Value = endCliente[i].Pais; 
            }

             // Ajustar o layout para melhor visualização
             dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
             dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
             dataGridView.RowHeadersVisible = false; // Opcional: Esconder cabeçalhos de linhas
         }

         /// <summary>
         /// Método que recupera a lista de clientes do banco de dados.
         /// </summary>
         /// <returns>Lista de objetos Cliente.</returns>
         private List<Endereco_Cliente> ObterClientesDoBanco()
         {
             List<Endereco_Cliente> endCliente = new List<Endereco_Cliente>();
             string connectionString = ConfigurationManager.ConnectionStrings["MinhaConexaoDB"].ConnectionString;

             string query = "SELECT CODIGO, CLIENTE_CODIGO, CEP, RUA, NUMERO, BAIRRO, CIDADE, PAIS";

             try
             {
                 using (SqlConnection conn = new SqlConnection(connectionString))
                 {
                     using (SqlCommand cmd = new SqlCommand(query, conn))
                     {
                         conn.Open();
                         using (SqlDataReader reader = cmd.ExecuteReader())
                         {
                             while (reader.Read())
                             {
                                Endereco_Cliente endcliente = new Endereco_Cliente
                                {
                                    Codigo = reader.GetInt32(reader.GetOrdinal("Codigo")),
                                    ClienteCodigo = reader.GetInt32(reader.GetOrdinal("ClienteCodigo")), // Adicione esta linha para ClienteCodigo
                                    CEP = reader.IsDBNull(reader.GetOrdinal("CEP")) ? 0 : reader.GetInt32(reader.GetOrdinal("CEP")), // Usando int aqui
                                    Rua = reader.IsDBNull(reader.GetOrdinal("Rua")) ? "Sem Rua" : reader.GetString(reader.GetOrdinal("Rua")),
                                    Numero = reader.IsDBNull(reader.GetOrdinal("Numero")) ? "Sem Número" : reader.GetString(reader.GetOrdinal("Numero")),
                                    Bairro = reader.IsDBNull(reader.GetOrdinal("Bairro")) ? "Sem Bairro" : reader.GetString(reader.GetOrdinal("Bairro")),
                                    Cidade = reader.IsDBNull(reader.GetOrdinal("Cidade")) ? "Sem Cidade" : reader.GetString(reader.GetOrdinal("Cidade")),
                                    Pais = reader.IsDBNull(reader.GetOrdinal("Pais")) ? "Sem País" : reader.GetString(reader.GetOrdinal("Pais"))

                                };
                                endCliente.Add(endcliente);
                             }
                         }
                     }
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show($"Erro ao obter Endereços: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }

             return endCliente;
         }



        public FrmCliente()
        {
            InitializeComponent();
            this.dataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();

            // Configurações do DataGridView
            this.dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(760, 400);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.AllowUserToAddRows = false; // Impede a adição de novas linhas pelo usuário
            this.dataGridView.AllowUserToDeleteRows = false; // Impede a exclusão de linhas pelo usuário
            this.dataGridView.ReadOnly = true;

            _enderecoService = new Endereco_ClienteService();
            _clienteService = new ClienteService();
        }

        private void carregaGridView()
        {

            
            DataGridView dgEndCliente = new DataGridView();
            DataTable dtEndCliente = _enderecoService.getAll();
            dgEndCliente.DataSource = dtEndCliente;
            dgEndCliente.Dock = DockStyle.Fill;
            pEndereco.Controls.Add(dgEndCliente);
            
            dtCliente = _clienteService.getAll();
            dgCliente.DataSource = dtCliente;
            //dgPlanta.DataSource = _plantaService.getAll();
            dgCliente.Refresh();
        }
        private void atualiza()
        {
            dgCliente.DataSource = _clienteService.getAll();
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

            resultado = _clienteService.Update(nome, email, cpf_cnpj, rg, celular, senha,null);
            if (resultado == "SUCESSO")
            {
                MessageBox.Show("Adicionado com Sucesso!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            atualiza();

        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            carregaGridView();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string resultado;
            string msg;
            DialogResult result = MessageBox.Show("Deseja confirmar exclusão?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                resultado = _clienteService.Remove(codigo);
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

        }
        
        
        int codigo;
        private void dgCliente_CellClick(object sender, DataGridViewCellEventArgs e) 
        {

            if (e.RowIndex <= 0)
            {
                return;
            }
            string id = dgCliente.Rows[e.RowIndex].Cells[0].Value.ToString();
            codigo = int.Parse(id);
            dgCliente.Refresh();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            FrmPesquisa f = new FrmPesquisa();
            string txtBusca = "";
            
            f.ShowDialog();
            txtBusca = f.Texto;
            DataTable tbClientes = _clienteService.filterByName(txtBusca);
            if (tbClientes != null)
            {
                dgCliente.DataSource = tbClientes;
                dgCliente.Refresh();
            }
        }

        public void LimparText() {
            txtNome.Text = " ";
            txtEmail.Text = " ";
            txtCpf_Cnpj.Text = " ";
            txtRg.Text = " ";
            txtCelular.Text = " ";
            txtSenha.Text = " ";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            string msg;
            msg = "A operação foi Cancelada!";
            MessageBox.Show(msg, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            atualiza();
            LimparText();
        }
    } 

}
   

