
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
            this.plantaBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.plantaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.plantaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.plantaRepositoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.plantaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.plantaBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.plantaBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nomecientifico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacoesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciclodeaguaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cicloiluminacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiposoloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datadeverificacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlanta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantaBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantaRepositoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantaBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantaBindingSource5)).BeginInit();
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
            this.Nomecientifico,
            this.observacoesDataGridViewTextBoxColumn,
            this.ciclodeaguaDataGridViewTextBoxColumn,
            this.cicloiluminacaoDataGridViewTextBoxColumn,
            this.tiposoloDataGridViewTextBoxColumn,
            this.datadeverificacaoDataGridViewTextBoxColumn});
            this.dgPlanta.DataSource = this.plantaBindingSource5;
            this.dgPlanta.Location = new System.Drawing.Point(77, 254);
            this.dgPlanta.Name = "dgPlanta";
            this.dgPlanta.ReadOnly = true;
            this.dgPlanta.Size = new System.Drawing.Size(864, 150);
            this.dgPlanta.TabIndex = 0;
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
            // plantaBindingSource5
            // 
            this.plantaBindingSource5.DataSource = typeof(Dados.Planta);
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoDataGridViewTextBoxColumn.Width = 50;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Nomecientifico
            // 
            this.Nomecientifico.DataPropertyName = "NOME_CIENTIFICO";
            this.Nomecientifico.HeaderText = "Nome Científico";
            this.Nomecientifico.Name = "Nomecientifico";
            this.Nomecientifico.ReadOnly = true;
            this.Nomecientifico.Width = 120;
            // 
            // observacoesDataGridViewTextBoxColumn
            // 
            this.observacoesDataGridViewTextBoxColumn.DataPropertyName = "OBSERVACOES";
            this.observacoesDataGridViewTextBoxColumn.HeaderText = "Observações";
            this.observacoesDataGridViewTextBoxColumn.Name = "observacoesDataGridViewTextBoxColumn";
            this.observacoesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ciclodeaguaDataGridViewTextBoxColumn
            // 
            this.ciclodeaguaDataGridViewTextBoxColumn.DataPropertyName = "ciclo_DE_AGUA";
            this.ciclodeaguaDataGridViewTextBoxColumn.HeaderText = "Ciclo de água";
            this.ciclodeaguaDataGridViewTextBoxColumn.Name = "ciclodeaguaDataGridViewTextBoxColumn";
            this.ciclodeaguaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cicloiluminacaoDataGridViewTextBoxColumn
            // 
            this.cicloiluminacaoDataGridViewTextBoxColumn.DataPropertyName = "CICLO_DE_ILUMINACAO";
            this.cicloiluminacaoDataGridViewTextBoxColumn.HeaderText = "Ciclo de Iluminacao";
            this.cicloiluminacaoDataGridViewTextBoxColumn.Name = "cicloiluminacaoDataGridViewTextBoxColumn";
            this.cicloiluminacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.cicloiluminacaoDataGridViewTextBoxColumn.Width = 130;
            // 
            // tiposoloDataGridViewTextBoxColumn
            // 
            this.tiposoloDataGridViewTextBoxColumn.DataPropertyName = "TIPO_DE_SOLO";
            this.tiposoloDataGridViewTextBoxColumn.HeaderText = "Tipo de Solo";
            this.tiposoloDataGridViewTextBoxColumn.Name = "tiposoloDataGridViewTextBoxColumn";
            this.tiposoloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datadeverificacaoDataGridViewTextBoxColumn
            // 
            this.datadeverificacaoDataGridViewTextBoxColumn.DataPropertyName = "DATA_DA_VERIFICACAO";
            this.datadeverificacaoDataGridViewTextBoxColumn.HeaderText = "Data de Consulta";
            this.datadeverificacaoDataGridViewTextBoxColumn.Name = "datadeverificacaoDataGridViewTextBoxColumn";
            this.datadeverificacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.datadeverificacaoDataGridViewTextBoxColumn.Width = 120;
            // 
            // FrmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 450);
            this.ControlBox = false;
            this.Controls.Add(this.dgPlanta);
            this.Name = "FrmConsulta";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPlanta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantaBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantaRepositoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantaBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantaBindingSource5)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nomecientifico;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacoesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciclodeaguaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cicloiluminacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiposoloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datadeverificacaoDataGridViewTextBoxColumn;
    }
}