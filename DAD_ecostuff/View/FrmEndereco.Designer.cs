namespace View
{
    partial class FrmEndereco
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
            this.btnCancelaConsulta = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodEnd = new System.Windows.Forms.TextBox();
            this.btnEndereco = new System.Windows.Forms.Button();
            this.pEndereco = new System.Windows.Forms.Panel();
            this.dgEndereco = new System.Windows.Forms.DataGridView();
            this.cEPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoClienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.enderecoClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pEndereco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEndereco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enderecoClienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enderecoClienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelaConsulta
            // 
            this.btnCancelaConsulta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelaConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelaConsulta.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelaConsulta.Location = new System.Drawing.Point(25, 150);
            this.btnCancelaConsulta.Name = "btnCancelaConsulta";
            this.btnCancelaConsulta.Size = new System.Drawing.Size(163, 36);
            this.btnCancelaConsulta.TabIndex = 29;
            this.btnCancelaConsulta.Text = "Cancelar";
            this.btnCancelaConsulta.UseVisualStyleBackColor = false;
            this.btnCancelaConsulta.Click += new System.EventHandler(this.btnCancelaConsulta_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(25, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 24);
            this.label7.TabIndex = 28;
            this.label7.Text = "Código do Cliente:";
            // 
            // txtCodEnd
            // 
            this.txtCodEnd.Location = new System.Drawing.Point(49, 82);
            this.txtCodEnd.Name = "txtCodEnd";
            this.txtCodEnd.Size = new System.Drawing.Size(119, 20);
            this.txtCodEnd.TabIndex = 27;
            // 
            // btnEndereco
            // 
            this.btnEndereco.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEndereco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndereco.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndereco.Location = new System.Drawing.Point(25, 108);
            this.btnEndereco.Name = "btnEndereco";
            this.btnEndereco.Size = new System.Drawing.Size(163, 36);
            this.btnEndereco.TabIndex = 26;
            this.btnEndereco.Text = "Exibir Endereço";
            this.btnEndereco.UseVisualStyleBackColor = false;
            this.btnEndereco.Click += new System.EventHandler(this.btnEndereco_Click);
            // 
            // pEndereco
            // 
            this.pEndereco.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pEndereco.Controls.Add(this.dgEndereco);
            this.pEndereco.Location = new System.Drawing.Point(14, 213);
            this.pEndereco.Name = "pEndereco";
            this.pEndereco.Size = new System.Drawing.Size(177, 203);
            this.pEndereco.TabIndex = 25;
            this.pEndereco.Paint += new System.Windows.Forms.PaintEventHandler(this.pEndereco_Paint);
            // 
            // dgEndereco
            // 
            this.dgEndereco.AllowUserToAddRows = false;
            this.dgEndereco.AllowUserToDeleteRows = false;
            this.dgEndereco.AutoGenerateColumns = false;
            this.dgEndereco.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(80)))), ((int)(((byte)(67)))));
            this.dgEndereco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEndereco.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cEPDataGridViewTextBoxColumn,
            this.Estado,
            this.ruaDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn,
            this.bairroDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn,
            this.paisDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn});
            this.dgEndereco.DataSource = this.enderecoClienteBindingSource1;
            this.dgEndereco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgEndereco.Location = new System.Drawing.Point(0, 0);
            this.dgEndereco.Name = "dgEndereco";
            this.dgEndereco.ReadOnly = true;
            this.dgEndereco.Size = new System.Drawing.Size(177, 203);
            this.dgEndereco.TabIndex = 0;
            this.dgEndereco.Visible = false;
            // 
            // cEPDataGridViewTextBoxColumn
            // 
            this.cEPDataGridViewTextBoxColumn.DataPropertyName = "CEP";
            this.cEPDataGridViewTextBoxColumn.HeaderText = "CEP";
            this.cEPDataGridViewTextBoxColumn.Name = "cEPDataGridViewTextBoxColumn";
            this.cEPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // ruaDataGridViewTextBoxColumn
            // 
            this.ruaDataGridViewTextBoxColumn.DataPropertyName = "Rua";
            this.ruaDataGridViewTextBoxColumn.HeaderText = "Rua";
            this.ruaDataGridViewTextBoxColumn.Name = "ruaDataGridViewTextBoxColumn";
            this.ruaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Numero";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            this.numeroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bairroDataGridViewTextBoxColumn
            // 
            this.bairroDataGridViewTextBoxColumn.DataPropertyName = "Bairro";
            this.bairroDataGridViewTextBoxColumn.HeaderText = "Bairro";
            this.bairroDataGridViewTextBoxColumn.Name = "bairroDataGridViewTextBoxColumn";
            this.bairroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            this.cidadeDataGridViewTextBoxColumn.DataPropertyName = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
            this.cidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paisDataGridViewTextBoxColumn
            // 
            this.paisDataGridViewTextBoxColumn.DataPropertyName = "Pais";
            this.paisDataGridViewTextBoxColumn.HeaderText = "Pais";
            this.paisDataGridViewTextBoxColumn.Name = "paisDataGridViewTextBoxColumn";
            this.paisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enderecoClienteBindingSource1
            // 
            this.enderecoClienteBindingSource1.DataSource = typeof(Dados.Endereco_Cliente);
            // 
            // enderecoClienteBindingSource
            // 
            this.enderecoClienteBindingSource.DataSource = typeof(Dados.Endereco_Cliente);
            // 
            // FrmEndereco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(80)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(215, 429);
            this.Controls.Add(this.btnCancelaConsulta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCodEnd);
            this.Controls.Add(this.btnEndereco);
            this.Controls.Add(this.pEndereco);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEndereco";
            this.Text = "FrmEndereco";
            this.Load += new System.EventHandler(this.FrmEndereco_Load);
            this.pEndereco.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgEndereco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enderecoClienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enderecoClienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelaConsulta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCodEnd;
        private System.Windows.Forms.Button btnEndereco;
        private System.Windows.Forms.Panel pEndereco;
        private System.Windows.Forms.DataGridView dgEndereco;
        private System.Windows.Forms.BindingSource enderecoClienteBindingSource;
        private System.Windows.Forms.BindingSource enderecoClienteBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
    }
}