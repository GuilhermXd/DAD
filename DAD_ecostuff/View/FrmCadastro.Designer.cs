
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
            this.btnEditar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Location = new System.Drawing.Point(360, 67);
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(121, 20);
            this.txtObservacoes.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(265, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Observações";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data de Verificação";
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
            this.label5.Location = new System.Drawing.Point(42, 77);
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
            this.btnSalvar.Location = new System.Drawing.Point(584, 252);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(87, 31);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCicloAgua);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTipodeSolo);
            this.groupBox1.Controls.Add(this.txtCicloIluminacao);
            this.groupBox1.Controls.Add(this.txtData);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(61, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 127);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do plantio";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(476, 252);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(91, 31);
            this.btnEditar.TabIndex = 15;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(360, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 31);
            this.button1.TabIndex = 16;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 364);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtObservacoes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Name = "FrmCadastro";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FrmCadastro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button button1;
    }
}