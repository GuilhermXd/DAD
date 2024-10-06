
namespace View
{
    partial class FrmConsulta
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
            this.dgPlanta = new System.Windows.Forms.DataGridView();
            this.plantaBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.plantaBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.plantaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.plantaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.plantaRepositoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.plantaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.plantaBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.plantaBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomecientificoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlanta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantaBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantaBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantaRepositoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantaBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantaBindingSource6)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPlanta
            // 
            this.dgPlanta.AllowUserToAddRows = false;
            this.dgPlanta.AutoGenerateColumns = false;
            this.dgPlanta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPlanta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.nomecientificoDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgPlanta.DataSource = this.plantaBindingSource6;
            this.dgPlanta.Location = new System.Drawing.Point(12, 40);
            this.dgPlanta.Name = "dgPlanta";
            this.dgPlanta.ReadOnly = true;
            this.dgPlanta.Size = new System.Drawing.Size(845, 150);
            this.dgPlanta.TabIndex = 0;
            this.dgPlanta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPlanta_CellClick);
            // 
            // plantaBindingSource5
            // 
            this.plantaBindingSource5.DataSource = typeof(Dados.Planta);
            // 
            // plantaBindingSource4
            // 
            this.plantaBindingSource4.DataSource = typeof(Dados.Planta);
            // 
            // plantaBindingSource
            // 
            this.plantaBindingSource.DataSource = typeof(Dados.Planta);
            // 
            // plantaBindingSource1
            // 
            this.plantaBindingSource1.DataSource = typeof(Dados.Planta);
            // 
            // plantaRepositoryBindingSource
            // 
            this.plantaRepositoryBindingSource.DataSource = typeof(Dados.PlantaRepository);
            // 
            // plantaBindingSource2
            // 
            this.plantaBindingSource2.DataSource = typeof(Dados.Planta);
            // 
            // plantaBindingSource3
            // 
            this.plantaBindingSource3.DataSource = typeof(Dados.Planta);
            // 
            // plantaBindingSource6
            // 
            this.plantaBindingSource6.DataSource = typeof(Dados.Planta);
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomecientificoDataGridViewTextBoxColumn
            // 
            this.nomecientificoDataGridViewTextBoxColumn.DataPropertyName = "Nome_cientifico";
            this.nomecientificoDataGridViewTextBoxColumn.HeaderText = "Nomecientifico";
            this.nomecientificoDataGridViewTextBoxColumn.Name = "nomecientificoDataGridViewTextBoxColumn";
            this.nomecientificoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Observacoes";
            this.dataGridViewTextBoxColumn1.HeaderText = "Observacoes";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Data_da_verificacao";
            this.dataGridViewTextBoxColumn2.HeaderText = "Datadeverificacao";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Ciclo_de_agua";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ciclodeagua";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Ciclo_de_iluminacao";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cicloiluminacao";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Tipo_de_solo";
            this.dataGridViewTextBoxColumn5.HeaderText = "Tiposolo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(12, 219);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(108, 47);
            this.btnExcluir.TabIndex = 1;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(478, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 51);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FrmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 450);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dgPlanta);
            this.Name = "FrmConsulta";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPlanta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantaBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantaBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantaRepositoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantaBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantaBindingSource6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource plantaBindingSource1;
        private System.Windows.Forms.BindingSource plantaBindingSource;
        private System.Windows.Forms.BindingSource plantaRepositoryBindingSource;
        private System.Windows.Forms.BindingSource plantaBindingSource2;
        private System.Windows.Forms.BindingSource plantaBindingSource3;
        private System.Windows.Forms.DataGridView dgPlanta;
        private System.Windows.Forms.BindingSource plantaBindingSource4;
        private System.Windows.Forms.BindingSource plantaBindingSource5;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacoesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciclodeaguaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cicloiluminacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiposoloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datadeverificacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource plantaBindingSource6;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomecientificoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button button2;
    }
}