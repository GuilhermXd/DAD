
namespace View
{
    partial class FrmCadPlanta
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtCicloAgua = new System.Windows.Forms.TextBox();
            this.txtCicloIluminacao = new System.Windows.Forms.TextBox();
            this.txtTipodeSolo = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNomeCientifico = new System.Windows.Forms.TextBox();
            this.dgPlanta = new System.Windows.Forms.DataGridView();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.plantaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.plantaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_cientifico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacoesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciclodeagua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cicloiluminacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tiposolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datadeverificacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlanta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(256, 137);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(121, 20);
            this.txtNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Location = new System.Drawing.Point(523, 99);
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(183, 58);
            this.txtObservacoes.TabIndex = 2;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObs.Location = new System.Drawing.Point(405, 103);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(89, 16);
            this.lblObs.TabIndex = 3;
            this.lblObs.Text = "Observações";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data de Cadastro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(333, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ciclo de Água";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ciclo de Iluminação";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(339, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tipo de Solo";
            // 
            // txtData
            // 
            this.txtData.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtData.Location = new System.Drawing.Point(172, 27);
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.Size = new System.Drawing.Size(121, 20);
            this.txtData.TabIndex = 9;
            this.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCicloAgua
            // 
            this.txtCicloAgua.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtCicloAgua.Location = new System.Drawing.Point(439, 77);
            this.txtCicloAgua.Name = "txtCicloAgua";
            this.txtCicloAgua.Size = new System.Drawing.Size(121, 20);
            this.txtCicloAgua.TabIndex = 10;
            this.txtCicloAgua.Text = "Em Horas";
            this.txtCicloAgua.Enter += new System.EventHandler(this.TextBox_Enter);
            this.txtCicloAgua.Leave += new System.EventHandler(this.Textbox_Leave);
            // 
            // txtCicloIluminacao
            // 
            this.txtCicloIluminacao.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtCicloIluminacao.Location = new System.Drawing.Point(172, 77);
            this.txtCicloIluminacao.Name = "txtCicloIluminacao";
            this.txtCicloIluminacao.Size = new System.Drawing.Size(121, 20);
            this.txtCicloIluminacao.TabIndex = 11;
            this.txtCicloIluminacao.Text = "Em Horas";
            this.txtCicloIluminacao.Enter += new System.EventHandler(this.TextBox_Enter);
            this.txtCicloIluminacao.Leave += new System.EventHandler(this.Textbox_Leave);
            // 
            // txtTipodeSolo
            // 
            this.txtTipodeSolo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtTipodeSolo.Location = new System.Drawing.Point(439, 27);
            this.txtTipodeSolo.Name = "txtTipodeSolo";
            this.txtTipodeSolo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTipodeSolo.Size = new System.Drawing.Size(121, 20);
            this.txtTipodeSolo.TabIndex = 12;
            this.txtTipodeSolo.Text = "Seco, Molhado...";
            this.txtTipodeSolo.Enter += new System.EventHandler(this.TextBox_Enter);
            this.txtTipodeSolo.Leave += new System.EventHandler(this.Textbox_Leave);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(754, 99);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(191, 48);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.txtCicloAgua);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTipodeSolo);
            this.groupBox1.Controls.Add(this.txtCicloIluminacao);
            this.groupBox1.Controls.Add(this.txtData);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(84, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 134);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do plantio";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(754, 159);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(191, 48);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancela_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(127, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Nome Científico:";
            // 
            // txtNomeCientifico
            // 
            this.txtNomeCientifico.Location = new System.Drawing.Point(256, 99);
            this.txtNomeCientifico.Name = "txtNomeCientifico";
            this.txtNomeCientifico.Size = new System.Drawing.Size(121, 20);
            this.txtNomeCientifico.TabIndex = 18;
            // 
            // dgPlanta
            // 
            this.dgPlanta.AllowUserToAddRows = false;
            this.dgPlanta.AllowUserToDeleteRows = false;
            this.dgPlanta.AutoGenerateColumns = false;
            this.dgPlanta.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgPlanta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgPlanta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPlanta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.Nome_cientifico,
            this.observacoesDataGridViewTextBoxColumn,
            this.Ciclodeagua,
            this.Cicloiluminacao,
            this.Tiposolo,
            this.Datadeverificacao});
            this.dgPlanta.DataSource = this.plantaBindingSource1;
            this.dgPlanta.Location = new System.Drawing.Point(84, 363);
            this.dgPlanta.Name = "dgPlanta";
            this.dgPlanta.ReadOnly = true;
            this.dgPlanta.Size = new System.Drawing.Size(868, 248);
            this.dgPlanta.TabIndex = 19;
            this.dgPlanta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPlanta_CellClick);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisa.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisa.Image = global::View.Properties.Resources.icons8_pesquisar_50;
            this.btnPesquisa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisa.Location = new System.Drawing.Point(754, 284);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(191, 56);
            this.btnPesquisa.TabIndex = 22;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = false;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(754, 219);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(191, 48);
            this.btnExcluir.TabIndex = 20;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // plantaBindingSource1
            // 
            this.plantaBindingSource1.DataSource = typeof(Dados.Planta);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::View.Properties.Resources.Design_sem_nome__1_3;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1103, 646);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
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
            // Nome_cientifico
            // 
            this.Nome_cientifico.DataPropertyName = "Nome_cientifico";
            this.Nome_cientifico.HeaderText = "Nomecientifico";
            this.Nome_cientifico.Name = "Nome_cientifico";
            this.Nome_cientifico.ReadOnly = true;
            this.Nome_cientifico.Width = 125;
            // 
            // observacoesDataGridViewTextBoxColumn
            // 
            this.observacoesDataGridViewTextBoxColumn.DataPropertyName = "Observacoes";
            this.observacoesDataGridViewTextBoxColumn.HeaderText = "Observacoes";
            this.observacoesDataGridViewTextBoxColumn.Name = "observacoesDataGridViewTextBoxColumn";
            this.observacoesDataGridViewTextBoxColumn.ReadOnly = true;
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
            // Datadeverificacao
            // 
            this.Datadeverificacao.DataPropertyName = "Data_da_verificacao";
            this.Datadeverificacao.HeaderText = "Datadeverificacao";
            this.Datadeverificacao.Name = "Datadeverificacao";
            this.Datadeverificacao.ReadOnly = true;
            // 
            // FrmCadPlanta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 646);
            this.ControlBox = false;
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dgPlanta);
            this.Controls.Add(this.txtNomeCientifico);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.txtObservacoes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmCadPlanta";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FrmCadastro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCadastro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlanta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtCicloAgua;
        private System.Windows.Forms.TextBox txtCicloIluminacao;
        private System.Windows.Forms.TextBox txtTipodeSolo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.BindingSource plantaBindingSource;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNomeCientifico;
        private System.Windows.Forms.DataGridView dgPlanta;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomecientificoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datadeverificacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciclodeaguaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cicloiluminacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiposoloDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource plantaBindingSource1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_cientifico;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacoesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciclodeagua;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cicloiluminacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tiposolo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datadeverificacao;
    }
}