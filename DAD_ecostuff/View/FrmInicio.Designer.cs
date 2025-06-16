namespace View
{
    partial class FrmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.pMenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lkFale = new System.Windows.Forms.LinkLabel();
            this.pConfig = new System.Windows.Forms.Panel();
            this.pForm = new System.Windows.Forms.Panel();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnOff = new System.Windows.Forms.Button();
            this.btnEndereco = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnFrmCliente = new System.Windows.Forms.Button();
            this.btnFrmPlanta = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pMenu
            // 
            this.pMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(80)))), ((int)(((byte)(67)))));
            this.pMenu.Controls.Add(this.btnEndereco);
            this.pMenu.Controls.Add(this.panel2);
            this.pMenu.Controls.Add(this.panel1);
            this.pMenu.Controls.Add(this.btnFrmCliente);
            this.pMenu.Controls.Add(this.btnFrmPlanta);
            this.pMenu.Controls.Add(this.btnHome);
            this.pMenu.Controls.Add(this.pictureBox1);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenu.Location = new System.Drawing.Point(0, 0);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(200, 720);
            this.pMenu.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(12, 252);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(169, 10);
            this.panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(90)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.lkFale);
            this.panel1.Controls.Add(this.btnInfo);
            this.panel1.Location = new System.Drawing.Point(3, 643);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 77);
            this.panel1.TabIndex = 0;
            // 
            // lkFale
            // 
            this.lkFale.ActiveLinkColor = System.Drawing.Color.DarkKhaki;
            this.lkFale.AutoSize = true;
            this.lkFale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkFale.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lkFale.Location = new System.Drawing.Point(54, 27);
            this.lkFale.Name = "lkFale";
            this.lkFale.Size = new System.Drawing.Size(111, 20);
            this.lkFale.TabIndex = 5;
            this.lkFale.TabStop = true;
            this.lkFale.Text = "Fale Conosco!";
            this.lkFale.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lkFale.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkFale_LinkClicked);
            // 
            // pConfig
            // 
            this.pConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(80)))), ((int)(((byte)(67)))));
            this.pConfig.Controls.Add(this.btnMinimizar);
            this.pConfig.Controls.Add(this.btnOff);
            this.pConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.pConfig.Location = new System.Drawing.Point(200, 0);
            this.pConfig.Name = "pConfig";
            this.pConfig.Size = new System.Drawing.Size(1180, 36);
            this.pConfig.TabIndex = 1;
            // 
            // pForm
            // 
            this.pForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pForm.Location = new System.Drawing.Point(200, 36);
            this.pForm.Name = "pForm";
            this.pForm.Size = new System.Drawing.Size(1180, 684);
            this.pForm.TabIndex = 3;
            this.pForm.Paint += new System.Windows.Forms.PaintEventHandler(this.pForm_Paint);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = global::View.Properties.Resources.icons8_minimize_32;
            this.btnMinimizar.Location = new System.Drawing.Point(1086, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(49, 40);
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnOff
            // 
            this.btnOff.FlatAppearance.BorderSize = 0;
            this.btnOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOff.Image = global::View.Properties.Resources.icons8_close_32;
            this.btnOff.Location = new System.Drawing.Point(1131, 0);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(49, 40);
            this.btnOff.TabIndex = 2;
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // btnEndereco
            // 
            this.btnEndereco.FlatAppearance.BorderSize = 0;
            this.btnEndereco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndereco.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndereco.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEndereco.Image = global::View.Properties.Resources.icons8_search_302;
            this.btnEndereco.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEndereco.Location = new System.Drawing.Point(3, 454);
            this.btnEndereco.Name = "btnEndereco";
            this.btnEndereco.Size = new System.Drawing.Size(194, 56);
            this.btnEndereco.TabIndex = 4;
            this.btnEndereco.Text = "        ENDEREÇOS";
            this.btnEndereco.UseVisualStyleBackColor = true;
            this.btnEndereco.Click += new System.EventHandler(this.btnEndereco_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Image = global::View.Properties.Resources.icons8_information_30;
            this.btnInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.Location = new System.Drawing.Point(9, 12);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(39, 53);
            this.btnInfo.TabIndex = 4;
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnFrmCliente
            // 
            this.btnFrmCliente.FlatAppearance.BorderSize = 0;
            this.btnFrmCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrmCliente.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrmCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFrmCliente.Image = global::View.Properties.Resources.icons8_search_301;
            this.btnFrmCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFrmCliente.Location = new System.Drawing.Point(3, 372);
            this.btnFrmCliente.Name = "btnFrmCliente";
            this.btnFrmCliente.Size = new System.Drawing.Size(194, 56);
            this.btnFrmCliente.TabIndex = 3;
            this.btnFrmCliente.Text = "    CLIENTES";
            this.btnFrmCliente.UseVisualStyleBackColor = true;
            this.btnFrmCliente.Click += new System.EventHandler(this.btnFrmCliente_Click_1);
            // 
            // btnFrmPlanta
            // 
            this.btnFrmPlanta.FlatAppearance.BorderSize = 0;
            this.btnFrmPlanta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrmPlanta.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrmPlanta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFrmPlanta.Image = global::View.Properties.Resources.icons8_search_30;
            this.btnFrmPlanta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFrmPlanta.Location = new System.Drawing.Point(3, 287);
            this.btnFrmPlanta.Name = "btnFrmPlanta";
            this.btnFrmPlanta.Size = new System.Drawing.Size(194, 56);
            this.btnFrmPlanta.TabIndex = 2;
            this.btnFrmPlanta.Text = "     PLANTAS";
            this.btnFrmPlanta.UseVisualStyleBackColor = true;
            this.btnFrmPlanta.Click += new System.EventHandler(this.btnFrmPlanta_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHome.Image = global::View.Properties.Resources.icons8_home_30;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(3, 190);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(194, 56);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "    HOME";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(80)))), ((int)(((byte)(67)))));
            this.pictureBox1.Image = global::View.Properties.Resources.Logo__1___1_;
            this.pictureBox1.Location = new System.Drawing.Point(3, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 720);
            this.Controls.Add(this.pForm);
            this.Controls.Add(this.pConfig);
            this.Controls.Add(this.pMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmInicio";
            this.Text = "teste";
            this.pMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pConfig.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnFrmPlanta;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnFrmCliente;
        private System.Windows.Forms.Panel pConfig;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel pForm;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Panel panel2;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Button btnEndereco;
        private System.Windows.Forms.LinkLabel lkFale;
    }
}