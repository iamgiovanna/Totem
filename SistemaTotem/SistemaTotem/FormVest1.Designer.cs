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
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(62)))), ((int)(((byte)(99)))));
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(40, 32);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(942, 533);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.InfoENEM);
            this.panel1.Controls.Add(this.SubTituloENEM);
            this.panel1.Controls.Add(this.TituloEnem);
            this.panel1.Controls.Add(this.SiteInfoOfficial);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 529);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // InfoENEM
            // 
            this.InfoENEM.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.InfoENEM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoENEM.ForeColor = System.Drawing.SystemColors.WindowText;
            this.InfoENEM.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.InfoENEM.Location = new System.Drawing.Point(184, 116);
            this.InfoENEM.Name = "InfoENEM";
            this.InfoENEM.Size = new System.Drawing.Size(521, 314);
            this.InfoENEM.TabIndex = 5;
            this.InfoENEM.Text = resources.GetString("InfoENEM.Text");
            this.InfoENEM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SubTituloENEM
            // 
            this.SubTituloENEM.AutoSize = true;
            this.SubTituloENEM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTituloENEM.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SubTituloENEM.Location = new System.Drawing.Point(280, 73);
            this.SubTituloENEM.Name = "SubTituloENEM";
            this.SubTituloENEM.Size = new System.Drawing.Size(317, 31);
            this.SubTituloENEM.TabIndex = 4;
            this.SubTituloENEM.Text = "Calendário ENEM 2024\r\n";
            // 
            // TituloEnem
            // 
            this.TituloEnem.AutoSize = true;
            this.TituloEnem.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloEnem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TituloEnem.Location = new System.Drawing.Point(380, 23);
            this.TituloEnem.Name = "TituloEnem";
            this.TituloEnem.Size = new System.Drawing.Size(102, 35);
            this.TituloEnem.TabIndex = 3;
            this.TituloEnem.Text = "ENEM";
            // 
            // SiteInfoOfficial
            // 
            this.SiteInfoOfficial.BackColor = System.Drawing.Color.FloralWhite;
            this.SiteInfoOfficial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SiteInfoOfficial.Location = new System.Drawing.Point(283, 450);
            this.SiteInfoOfficial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SiteInfoOfficial.Name = "SiteInfoOfficial";
            this.SiteInfoOfficial.Size = new System.Drawing.Size(354, 40);
            this.SiteInfoOfficial.TabIndex = 2;
            this.SiteInfoOfficial.Text = "Para mais informaçõoes, acesse o site oficial: www.gov.br";
            this.SiteInfoOfficial.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SiteInfoOfficial.Click += new System.EventHandler(this.SiteInfoOfficial_Click);
            // 
            // FormVest1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1017, 594);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
    }
}