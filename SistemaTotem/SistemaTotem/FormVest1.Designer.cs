namespace SistemaTotem
{
    partial class FormVest1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVest1));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.InfoENEM = new System.Windows.Forms.Label();
            this.SubTituloENEM = new System.Windows.Forms.Label();
            this.TituloEnem = new System.Windows.Forms.Label();
            this.SiteInfoOfficial = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(62)))), ((int)(((byte)(99)))));
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(370, 104);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(706, 433);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.InfoENEM);
            this.panel1.Controls.Add(this.SubTituloENEM);
            this.panel1.Controls.Add(this.TituloEnem);
            this.panel1.Controls.Add(this.SiteInfoOfficial);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 433);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // InfoENEM
            // 
            this.InfoENEM.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.InfoENEM.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoENEM.ForeColor = System.Drawing.SystemColors.WindowText;
            this.InfoENEM.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.InfoENEM.Location = new System.Drawing.Point(163, 93);
            this.InfoENEM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InfoENEM.Name = "InfoENEM";
            this.InfoENEM.Size = new System.Drawing.Size(391, 255);
            this.InfoENEM.TabIndex = 5;
            this.InfoENEM.Text = resources.GetString("InfoENEM.Text");
            this.InfoENEM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InfoENEM.Click += new System.EventHandler(this.InfoENEM_Click);
            // 
            // SubTituloENEM
            // 
            this.SubTituloENEM.AutoSize = true;
            this.SubTituloENEM.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTituloENEM.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SubTituloENEM.Location = new System.Drawing.Point(239, 56);
            this.SubTituloENEM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SubTituloENEM.Name = "SubTituloENEM";
            this.SubTituloENEM.Size = new System.Drawing.Size(232, 25);
            this.SubTituloENEM.TabIndex = 4;
            this.SubTituloENEM.Text = "Calendário ENEM 2024\r\n";
            // 
            // TituloEnem
            // 
            this.TituloEnem.AutoSize = true;
            this.TituloEnem.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloEnem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TituloEnem.Location = new System.Drawing.Point(318, 19);
            this.TituloEnem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TituloEnem.Name = "TituloEnem";
            this.TituloEnem.Size = new System.Drawing.Size(76, 28);
            this.TituloEnem.TabIndex = 3;
            this.TituloEnem.Text = "ENEM";
            // 
            // SiteInfoOfficial
            // 
            this.SiteInfoOfficial.BackColor = System.Drawing.Color.FloralWhite;
            this.SiteInfoOfficial.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SiteInfoOfficial.Location = new System.Drawing.Point(223, 371);
            this.SiteInfoOfficial.Name = "SiteInfoOfficial";
            this.SiteInfoOfficial.Size = new System.Drawing.Size(266, 32);
            this.SiteInfoOfficial.TabIndex = 2;
            this.SiteInfoOfficial.Text = "Para mais informaçõoes, acesse o site oficial: www.gov.br";
            this.SiteInfoOfficial.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SiteInfoOfficial.Click += new System.EventHandler(this.SiteInfoOfficial_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(73, 294);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 67);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(62)))), ((int)(((byte)(99)))));
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(963, 69);
            this.flowLayoutPanel2.TabIndex = 16;
            // 
            // FormVest1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(963, 570);
            this.ControlBox = false;
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormVest1";
            this.Text = "Enem";
            this.Load += new System.EventHandler(this.FormVest1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SiteInfoOfficial;
        private System.Windows.Forms.Label TituloEnem;
        private System.Windows.Forms.Label InfoENEM;
        private System.Windows.Forms.Label SubTituloENEM;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}