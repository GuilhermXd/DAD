namespace View
{
    partial class TesteIncioBonito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TesteIncioBonito));
            this.pMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pConfig = new System.Windows.Forms.Panel();
            this.pForm = new System.Windows.Forms.Panel();
            this.btnOff = new System.Windows.Forms.Button();
            this.btnFrmCliente = new System.Windows.Forms.Button();
            this.btnFrmPlanta = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pMenu.SuspendLayout();
            this.pConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pMenu
            // 
            this.pMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(94)))), ((int)(((byte)(76)))));
            this.pMenu.Controls.Add(this.panel1);
            this.pMenu.Controls.Add(this.btnFrmCliente);
            this.pMenu.Controls.Add(this.btnFrmPlanta);
            this.pMenu.Controls.Add(this.btnHome);
            this.pMenu.Controls.Add(this.pictureBox1);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenu.Location = new System.Drawing.Point(0, 0);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(200, 761);
            this.pMenu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(90)))), ((int)(((byte)(80)))));
            this.panel1.Location = new System.Drawing.Point(0, 684);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 77);
            this.panel1.TabIndex = 0;
            // 
            // pConfig
            // 
            this.pConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(94)))), ((int)(((byte)(76)))));
            this.pConfig.Controls.Add(this.btnOff);
            this.pConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.pConfig.Location = new System.Drawing.Point(200, 0);
            this.pConfig.Name = "pConfig";
            this.pConfig.Size = new System.Drawing.Size(1350, 36);
            this.pConfig.TabIndex = 1;
            // 
            // pForm
            // 
            this.pForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pForm.Location = new System.Drawing.Point(200, 36);
            this.pForm.Name = "pForm";
            this.pForm.Size = new System.Drawing.Size(1350, 725);
            this.pForm.TabIndex = 3;
            this.pForm.Paint += new System.Windows.Forms.PaintEventHandler(this.pForm_Paint);
            // 
            // btnOff
            // 
            this.btnOff.FlatAppearance.BorderSize = 0;
            this.btnOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOff.Image = global::View.Properties.Resources.icons8_desligar_32;
            this.btnOff.Location = new System.Drawing.Point(1301, 0);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(49, 40);
            this.btnOff.TabIndex = 2;
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // btnFrmCliente
            // 
            this.btnFrmCliente.FlatAppearance.BorderSize = 0;
            this.btnFrmCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrmCliente.Image = global::View.Properties.Resources.search_16dp_000000_FILL0_wght400_GRAD0_opsz20;
            this.btnFrmCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFrmCliente.Location = new System.Drawing.Point(6, 340);
            this.btnFrmCliente.Name = "btnFrmCliente";
            this.btnFrmCliente.Size = new System.Drawing.Size(194, 56);
            this.btnFrmCliente.TabIndex = 3;
            this.btnFrmCliente.Text = "CLIENTES";
            this.btnFrmCliente.UseVisualStyleBackColor = true;
            this.btnFrmCliente.Click += new System.EventHandler(this.btnFrmCliente_Click_1);
            // 
            // btnFrmPlanta
            // 
            this.btnFrmPlanta.FlatAppearance.BorderSize = 0;
            this.btnFrmPlanta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrmPlanta.Image = global::View.Properties.Resources.search_16dp_000000_FILL0_wght400_GRAD0_opsz20;
            this.btnFrmPlanta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFrmPlanta.Location = new System.Drawing.Point(3, 263);
            this.btnFrmPlanta.Name = "btnFrmPlanta";
            this.btnFrmPlanta.Size = new System.Drawing.Size(194, 56);
            this.btnFrmPlanta.TabIndex = 2;
            this.btnFrmPlanta.Text = "PLANTAS";
            this.btnFrmPlanta.UseVisualStyleBackColor = true;
            this.btnFrmPlanta.Click += new System.EventHandler(this.btnFrmPlanta_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Image = global::View.Properties.Resources.icons8_casa_60;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(3, 190);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(194, 56);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(94)))), ((int)(((byte)(76)))));
            this.pictureBox1.Image = global::View.Properties.Resources.plantasemfnd;
            this.pictureBox1.Location = new System.Drawing.Point(36, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // TesteIncioBonito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1550, 761);
            this.Controls.Add(this.pForm);
            this.Controls.Add(this.pConfig);
            this.Controls.Add(this.pMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TesteIncioBonito";
            this.Text = "teste";
            this.pMenu.ResumeLayout(false);
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
    }
}