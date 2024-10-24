﻿namespace View
{
    partial class FrmCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCpf_Cnpj = new System.Windows.Forms.TextBox();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtAdiciona = new System.Windows.Forms.Button();
            this.dgCliente = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pEndereco = new System.Windows.Forms.Panel();
            this.dgEndereco = new System.Windows.Forms.DataGridView();
            this.btnEndereco = new System.Windows.Forms.Button();
            this.tabCliente = new System.Windows.Forms.TabControl();
            this.tabAdiciona = new System.Windows.Forms.TabPage();
            this.tabConsulta = new System.Windows.Forms.TabPage();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfCnpjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cEPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtCodEnd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgCliente)).BeginInit();
            this.pEndereco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEndereco)).BeginInit();
            this.tabCliente.SuspendLayout();
            this.tabAdiciona.SuspendLayout();
            this.tabConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enderecoClienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(372, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "CPF/CNPJ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(419, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rg:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Celular:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(200, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Senha:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(83, 24);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(250, 24);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // txtCpf_Cnpj
            // 
            this.txtCpf_Cnpj.Location = new System.Drawing.Point(453, 24);
            this.txtCpf_Cnpj.Name = "txtCpf_Cnpj";
            this.txtCpf_Cnpj.Size = new System.Drawing.Size(100, 20);
            this.txtCpf_Cnpj.TabIndex = 8;
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(453, 76);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(100, 20);
            this.txtRg.TabIndex = 9;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(88, 76);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(100, 20);
            this.txtCelular.TabIndex = 10;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(255, 76);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 11;
            // 
            // txtAdiciona
            // 
            this.txtAdiciona.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtAdiciona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtAdiciona.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdiciona.Location = new System.Drawing.Point(28, 133);
            this.txtAdiciona.Name = "txtAdiciona";
            this.txtAdiciona.Size = new System.Drawing.Size(191, 48);
            this.txtAdiciona.TabIndex = 12;
            this.txtAdiciona.Text = "Adicionar";
            this.txtAdiciona.UseVisualStyleBackColor = false;
            this.txtAdiciona.Click += new System.EventHandler(this.txtAdiciona_Click);
            // 
            // dgCliente
            // 
            this.dgCliente.AllowUserToAddRows = false;
            this.dgCliente.AllowUserToDeleteRows = false;
            this.dgCliente.AutoGenerateColumns = false;
            this.dgCliente.BackgroundColor = System.Drawing.Color.MediumAquamarine;
            this.dgCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgCliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.cpfCnpjDataGridViewTextBoxColumn,
            this.rgDataGridViewTextBoxColumn,
            this.celularDataGridViewTextBoxColumn,
            this.senhaDataGridViewTextBoxColumn});
            this.dgCliente.DataSource = this.clienteBindingSource;
            this.dgCliente.Location = new System.Drawing.Point(28, 220);
            this.dgCliente.Name = "dgCliente";
            this.dgCliente.ReadOnly = true;
            this.dgCliente.Size = new System.Drawing.Size(853, 359);
            this.dgCliente.TabIndex = 13;
            this.dgCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCliente_CellClick);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(422, 133);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(191, 48);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(225, 133);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(191, 48);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pEndereco
            // 
            this.pEndereco.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pEndereco.Controls.Add(this.dgEndereco);
            this.pEndereco.Location = new System.Drawing.Point(12, 9);
            this.pEndereco.Name = "pEndereco";
            this.pEndereco.Size = new System.Drawing.Size(402, 579);
            this.pEndereco.TabIndex = 18;
            // 
            // dgEndereco
            // 
            this.dgEndereco.AllowUserToAddRows = false;
            this.dgEndereco.AllowUserToDeleteRows = false;
            this.dgEndereco.AutoGenerateColumns = false;
            this.dgEndereco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEndereco.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cEPDataGridViewTextBoxColumn,
            this.ruaDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn,
            this.bairroDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn,
            this.paisDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn1});
            this.dgEndereco.DataSource = this.enderecoClienteBindingSource;
            this.dgEndereco.Location = new System.Drawing.Point(45, 27);
            this.dgEndereco.Name = "dgEndereco";
            this.dgEndereco.ReadOnly = true;
            this.dgEndereco.Size = new System.Drawing.Size(307, 170);
            this.dgEndereco.TabIndex = 0;
            this.dgEndereco.Visible = false;
            // 
            // btnEndereco
            // 
            this.btnEndereco.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEndereco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndereco.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndereco.Location = new System.Drawing.Point(463, 36);
            this.btnEndereco.Name = "btnEndereco";
            this.btnEndereco.Size = new System.Drawing.Size(191, 48);
            this.btnEndereco.TabIndex = 19;
            this.btnEndereco.Text = "Exibir Endereço";
            this.btnEndereco.UseVisualStyleBackColor = false;
            this.btnEndereco.Click += new System.EventHandler(this.btnEndereco_Click);
            // 
            // tabCliente
            // 
            this.tabCliente.Controls.Add(this.tabAdiciona);
            this.tabCliente.Controls.Add(this.tabConsulta);
            this.tabCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCliente.Location = new System.Drawing.Point(0, 0);
            this.tabCliente.Name = "tabCliente";
            this.tabCliente.SelectedIndex = 0;
            this.tabCliente.Size = new System.Drawing.Size(1619, 933);
            this.tabCliente.TabIndex = 20;
            // 
            // tabAdiciona
            // 
            this.tabAdiciona.Controls.Add(this.label1);
            this.tabAdiciona.Controls.Add(this.label2);
            this.tabAdiciona.Controls.Add(this.label3);
            this.tabAdiciona.Controls.Add(this.dgCliente);
            this.tabAdiciona.Controls.Add(this.btnPesquisa);
            this.tabAdiciona.Controls.Add(this.btnCancelar);
            this.tabAdiciona.Controls.Add(this.label4);
            this.tabAdiciona.Controls.Add(this.label5);
            this.tabAdiciona.Controls.Add(this.btnExcluir);
            this.tabAdiciona.Controls.Add(this.label6);
            this.tabAdiciona.Controls.Add(this.txtAdiciona);
            this.tabAdiciona.Controls.Add(this.txtNome);
            this.tabAdiciona.Controls.Add(this.txtEmail);
            this.tabAdiciona.Controls.Add(this.txtSenha);
            this.tabAdiciona.Controls.Add(this.txtCpf_Cnpj);
            this.tabAdiciona.Controls.Add(this.txtCelular);
            this.tabAdiciona.Controls.Add(this.txtRg);
            this.tabAdiciona.Controls.Add(this.pictureBox1);
            this.tabAdiciona.Location = new System.Drawing.Point(4, 22);
            this.tabAdiciona.Name = "tabAdiciona";
            this.tabAdiciona.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdiciona.Size = new System.Drawing.Size(1611, 907);
            this.tabAdiciona.TabIndex = 0;
            this.tabAdiciona.Text = "Adicionar Cliente";
            this.tabAdiciona.UseVisualStyleBackColor = true;
            // 
            // tabConsulta
            // 
            this.tabConsulta.Controls.Add(this.txtCodEnd);
            this.tabConsulta.Controls.Add(this.btnEndereco);
            this.tabConsulta.Controls.Add(this.pEndereco);
            this.tabConsulta.Location = new System.Drawing.Point(4, 22);
            this.tabConsulta.Name = "tabConsulta";
            this.tabConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsulta.Size = new System.Drawing.Size(1611, 907);
            this.tabConsulta.TabIndex = 1;
            this.tabConsulta.Text = "Consulta de Clientes";
            this.tabConsulta.UseVisualStyleBackColor = true;
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
            this.nomeDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 130;
            // 
            // cpfCnpjDataGridViewTextBoxColumn
            // 
            this.cpfCnpjDataGridViewTextBoxColumn.DataPropertyName = "Cpf_Cnpj";
            this.cpfCnpjDataGridViewTextBoxColumn.HeaderText = "Cpf_Cnpj";
            this.cpfCnpjDataGridViewTextBoxColumn.Name = "cpfCnpjDataGridViewTextBoxColumn";
            this.cpfCnpjDataGridViewTextBoxColumn.ReadOnly = true;
            this.cpfCnpjDataGridViewTextBoxColumn.Width = 130;
            // 
            // rgDataGridViewTextBoxColumn
            // 
            this.rgDataGridViewTextBoxColumn.DataPropertyName = "Rg";
            this.rgDataGridViewTextBoxColumn.HeaderText = "Rg";
            this.rgDataGridViewTextBoxColumn.Name = "rgDataGridViewTextBoxColumn";
            this.rgDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // celularDataGridViewTextBoxColumn
            // 
            this.celularDataGridViewTextBoxColumn.DataPropertyName = "Celular";
            this.celularDataGridViewTextBoxColumn.HeaderText = "Celular";
            this.celularDataGridViewTextBoxColumn.Name = "celularDataGridViewTextBoxColumn";
            this.celularDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // senhaDataGridViewTextBoxColumn
            // 
            this.senhaDataGridViewTextBoxColumn.DataPropertyName = "Senha";
            this.senhaDataGridViewTextBoxColumn.HeaderText = "Senha";
            this.senhaDataGridViewTextBoxColumn.Name = "senhaDataGridViewTextBoxColumn";
            this.senhaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(Dados.Cliente);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisa.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisa.Image = global::View.Properties.Resources.icons8_pesquisar_501;
            this.btnPesquisa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisa.Location = new System.Drawing.Point(619, 133);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(191, 59);
            this.btnPesquisa.TabIndex = 15;
            this.btnPesquisa.Text = "  Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = false;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::View.Properties.Resources.tab;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1605, 901);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // cEPDataGridViewTextBoxColumn
            // 
            this.cEPDataGridViewTextBoxColumn.DataPropertyName = "CEP";
            this.cEPDataGridViewTextBoxColumn.HeaderText = "CEP";
            this.cEPDataGridViewTextBoxColumn.Name = "cEPDataGridViewTextBoxColumn";
            this.cEPDataGridViewTextBoxColumn.ReadOnly = true;
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
            // codigoDataGridViewTextBoxColumn1
            // 
            this.codigoDataGridViewTextBoxColumn1.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn1.Name = "codigoDataGridViewTextBoxColumn1";
            this.codigoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // enderecoClienteBindingSource
            // 
            this.enderecoClienteBindingSource.DataSource = typeof(Dados.Endereco_Cliente);
            // 
            // txtCodEnd
            // 
            this.txtCodEnd.Location = new System.Drawing.Point(513, 119);
            this.txtCodEnd.Name = "txtCodEnd";
            this.txtCodEnd.Size = new System.Drawing.Size(100, 20);
            this.txtCodEnd.TabIndex = 20;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1619, 933);
            this.Controls.Add(this.tabCliente);
            this.Name = "FrmCliente";
            this.Text = "FrmCliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCliente)).EndInit();
            this.pEndereco.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgEndereco)).EndInit();
            this.tabCliente.ResumeLayout(false);
            this.tabAdiciona.ResumeLayout(false);
            this.tabAdiciona.PerformLayout();
            this.tabConsulta.ResumeLayout(false);
            this.tabConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enderecoClienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCpf_Cnpj;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button txtAdiciona;
        private System.Windows.Forms.DataGridView dgCliente;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel pEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfCnpjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senhaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgEndereco;
        private System.Windows.Forms.BindingSource enderecoClienteBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteCodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnEndereco;
        private System.Windows.Forms.TabControl tabCliente;
        private System.Windows.Forms.TabPage tabAdiciona;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabConsulta;
        private System.Windows.Forms.TextBox txtCodEnd;
    }
}