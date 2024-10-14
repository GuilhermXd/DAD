namespace View
{
    partial class FrmPesquisa
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
            this.btnEnvia = new System.Windows.Forms.Button();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnvia
            // 
            this.btnEnvia.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEnvia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnvia.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnvia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEnvia.Location = new System.Drawing.Point(611, 104);
            this.btnEnvia.Name = "btnEnvia";
            this.btnEnvia.Size = new System.Drawing.Size(133, 39);
            this.btnEnvia.TabIndex = 0;
            this.btnEnvia.Text = "Pesquisar";
            this.btnEnvia.UseVisualStyleBackColor = true;
            this.btnEnvia.Click += new System.EventHandler(this.btnEnvia_Click);
            // 
            // txtTexto
            // 
            this.txtTexto.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtTexto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTexto.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtTexto.Location = new System.Drawing.Point(37, 51);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(707, 36);
            this.txtTexto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "INSIRA O NOME A SER PESQUISADO:";
            // 
            // btnOff
            // 
            this.btnOff.FlatAppearance.BorderSize = 0;
            this.btnOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOff.Image = global::View.Properties.Resources.icons8_desligar_32;
            this.btnOff.Location = new System.Drawing.Point(695, 5);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(49, 40);
            this.btnOff.TabIndex = 3;
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // FrmPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(80)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(774, 155);
            this.ControlBox = false;
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.btnEnvia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPesquisa";
            this.Text = "FrmPesquisa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnvia;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOff;
    }
}