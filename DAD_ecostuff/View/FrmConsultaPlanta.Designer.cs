
namespace View
{
    partial class FrmConsultaPlanta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dgPlanta = new System.Windows.Forms.DataGridView();
            this.plantaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nomecientifico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datadeverificacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciclodeagua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cicloiluminacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tiposolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlanta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(12, 219);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(209, 87);
            this.btnExcluir.TabIndex = 1;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // dgPlanta
            // 
            this.dgPlanta.AllowUserToAddRows = false;
            this.dgPlanta.AllowUserToDeleteRows = false;
            this.dgPlanta.AutoGenerateColumns = false;
            this.dgPlanta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPlanta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.Nomecientifico,
            this.dataGridViewTextBoxColumn8,
            this.Datadeverificacao,
            this.Ciclodeagua,
            this.Cicloiluminacao,
            this.Tiposolo});
            this.dgPlanta.DataSource = this.plantaBindingSource;
            this.dgPlanta.Location = new System.Drawing.Point(23, 23);
            this.dgPlanta.Name = "dgPlanta";
            this.dgPlanta.ReadOnly = true;
            this.dgPlanta.Size = new System.Drawing.Size(844, 150);
            this.dgPlanta.TabIndex = 2;
            this.dgPlanta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPlanta_CellClick_1);
            this.dgPlanta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPlanta_CellContentClick);
            // 
            // plantaBindingSource
            // 
            this.plantaBindingSource.DataSource = typeof(Dados.Planta);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn6.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn7.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // Nomecientifico
            // 
            this.Nomecientifico.DataPropertyName = "nome_cientifico";
            this.Nomecientifico.HeaderText = "Nomecientifico";
            this.Nomecientifico.Name = "Nomecientifico";
            this.Nomecientifico.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Observacoes";
            this.dataGridViewTextBoxColumn8.HeaderText = "Observacoes";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // Datadeverificacao
            // 
            this.Datadeverificacao.DataPropertyName = "Data_da_verificacao";
            this.Datadeverificacao.HeaderText = "Datadeverificacao";
            this.Datadeverificacao.Name = "Datadeverificacao";
            this.Datadeverificacao.ReadOnly = true;
            // 
            // Ciclodeagua
            // 
            this.Ciclodeagua.DataPropertyName = "Ciclo_de_agua";
            this.Ciclodeagua.HeaderText = "Ciclodeagua";
            this.Ciclodeagua.Name = "Ciclodeagua";
            this.Ciclodeagua.ReadOnly = true;
            // 
            // Cicloiluminacao
            // 
            this.Cicloiluminacao.DataPropertyName = "Ciclo_de_iluminacao";
            this.Cicloiluminacao.HeaderText = "Cicloiluminacao";
            this.Cicloiluminacao.Name = "Cicloiluminacao";
            this.Cicloiluminacao.ReadOnly = true;
            // 
            // Tiposolo
            // 
            this.Tiposolo.DataPropertyName = "Tipo_de_solo";
            this.Tiposolo.HeaderText = "Tiposolo";
            this.Tiposolo.Name = "Tiposolo";
            this.Tiposolo.ReadOnly = true;
            // 
            // FrmConsultaPlanta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 450);
            this.ControlBox = false;
            this.Controls.Add(this.dgPlanta);
            this.Controls.Add(this.btnExcluir);
            this.Name = "FrmConsultaPlanta";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPlanta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn observacoesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciclodeaguaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cicloiluminacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiposoloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datadeverificacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomecientificoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dgPlanta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.BindingSource plantaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nomecientifico;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datadeverificacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciclodeagua;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cicloiluminacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tiposolo;
    }
}