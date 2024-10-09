
namespace View
{
    partial class FrmCadastro
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
            this.label2 = new System.Windows.Forms.Label();
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
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNomeCientifico = new System.Windows.Forms.TextBox();
            this.dgPlanta = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.plantaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(108, 66);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(121, 20);
            this.txtNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Location = new System.Drawing.Point(422, 62);
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(121, 20);
            this.txtObservacoes.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(309, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Observações";
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
            this.btnSalvar.Location = new System.Drawing.Point(700, 42);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(119, 44);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
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
            this.groupBox1.Location = new System.Drawing.Point(61, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 134);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do plantio";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(700, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 44);
            this.button1.TabIndex = 16;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(58, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Nome Científico:";
            // 
            // txtNomeCientifico
            // 
            this.txtNomeCientifico.Location = new System.Drawing.Point(169, 106);
            this.txtNomeCientifico.Name = "txtNomeCientifico";
            this.txtNomeCientifico.Size = new System.Drawing.Size(121, 20);
            this.txtNomeCientifico.TabIndex = 18;
            // 
            // dgPlanta
            // 
            this.dgPlanta.AutoGenerateColumns = false;
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
            this.dgPlanta.Location = new System.Drawing.Point(61, 303);
            this.dgPlanta.Name = "dgPlanta";
            this.dgPlanta.Size = new System.Drawing.Size(844, 196);
            this.dgPlanta.TabIndex = 19;
            this.dgPlanta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPlanta_CellClick);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Location = new System.Drawing.Point(700, 163);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(119, 44);
            this.btnExcluir.TabIndex = 20;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::View.Properties.Resources.Design_sem_nome1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(924, 511);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // plantaBindingSource1
            // 
            this.plantaBindingSource1.DataSource = typeof(Dados.Planta);
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // Nome_cientifico
            // 
            this.Nome_cientifico.DataPropertyName = "Nome_cientifico";
            this.Nome_cientifico.HeaderText = "Nomecientifico";
            this.Nome_cientifico.Name = "Nome_cientifico";
            // 
            // observacoesDataGridViewTextBoxColumn
            // 
            this.observacoesDataGridViewTextBoxColumn.DataPropertyName = "Observacoes";
            this.observacoesDataGridViewTextBoxColumn.HeaderText = "Observacoes";
            this.observacoesDataGridViewTextBoxColumn.Name = "observacoesDataGridViewTextBoxColumn";
            // 
            // Ciclodeagua
            // 
            this.Ciclodeagua.DataPropertyName = "Ciclo_de_agua";
            this.Ciclodeagua.HeaderText = "Ciclodeagua";
            this.Ciclodeagua.Name = "Ciclodeagua";
            // 
            // Cicloiluminacao
            // 
            this.Cicloiluminacao.DataPropertyName = "Ciclo_de_iluminacao";
            this.Cicloiluminacao.HeaderText = "Cicloiluminacao";
            this.Cicloiluminacao.Name = "Cicloiluminacao";
            // 
            // Tiposolo
            // 
            this.Tiposolo.DataPropertyName = "Tipo_de_solo";
            this.Tiposolo.HeaderText = "Tiposolo";
            this.Tiposolo.Name = "Tiposolo";
            // 
            // Datadeverificacao
            // 
            this.Datadeverificacao.DataPropertyName = "Data_da_verificacao";
            this.Datadeverificacao.HeaderText = "Datadeverificacao";
            this.Datadeverificacao.Name = "Datadeverificacao";
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 511);
            this.ControlBox = false;
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dgPlanta);
            this.Controls.Add(this.txtNomeCientifico);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtObservacoes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmCadastro";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FrmCadastro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCadastro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlanta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.Button button1;
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