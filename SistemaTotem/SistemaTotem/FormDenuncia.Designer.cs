namespace SistemaTotem
{
    partial class FormDenuncia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDenuncia));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.PainelDenuncia = new System.Windows.Forms.Panel();
            this.LabelDenuncia3 = new System.Windows.Forms.Label();
            this.LabelDenuncia2 = new System.Windows.Forms.Label();
            this.LabelDenuncia1 = new System.Windows.Forms.Label();
            this.BtnTelaInicial = new System.Windows.Forms.Button();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.PainelDenuncia.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(62)))), ((int)(((byte)(99)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1483, 64);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.BtnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVoltar.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltar.ForeColor = System.Drawing.Color.White;
            this.BtnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("BtnVoltar.Image")));
            this.BtnVoltar.Location = new System.Drawing.Point(13, 708);
            this.BtnVoltar.Margin = new System.Windows.Forms.Padding(5);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(77, 64);
            this.BtnVoltar.TabIndex = 6;
            this.BtnVoltar.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(62)))), ((int)(((byte)(99)))));
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel2.Controls.Add(this.panel1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(335, 85);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(872, 80);
            this.flowLayoutPanel2.TabIndex = 1;
            this.flowLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 69);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(236, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Como fazer uma denúncia\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(62)))), ((int)(((byte)(99)))));
            this.flowLayoutPanel3.Controls.Add(this.PainelDenuncia);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(222, 197);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1088, 449);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // PainelDenuncia
            // 
            this.PainelDenuncia.Controls.Add(this.LabelDenuncia3);
            this.PainelDenuncia.Controls.Add(this.LabelDenuncia2);
            this.PainelDenuncia.Controls.Add(this.LabelDenuncia1);
            this.PainelDenuncia.Location = new System.Drawing.Point(4, 4);
            this.PainelDenuncia.Margin = new System.Windows.Forms.Padding(4);
            this.PainelDenuncia.Name = "PainelDenuncia";
            this.PainelDenuncia.Size = new System.Drawing.Size(1084, 433);
            this.PainelDenuncia.TabIndex = 0;
            // 
            // LabelDenuncia3
            // 
            this.LabelDenuncia3.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDenuncia3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelDenuncia3.Location = new System.Drawing.Point(15, 285);
            this.LabelDenuncia3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelDenuncia3.Name = "LabelDenuncia3";
            this.LabelDenuncia3.Size = new System.Drawing.Size(1051, 138);
            this.LabelDenuncia3.TabIndex = 5;
            this.LabelDenuncia3.Text = resources.GetString("LabelDenuncia3.Text");
            this.LabelDenuncia3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LabelDenuncia2
            // 
            this.LabelDenuncia2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDenuncia2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelDenuncia2.Location = new System.Drawing.Point(15, 144);
            this.LabelDenuncia2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelDenuncia2.Name = "LabelDenuncia2";
            this.LabelDenuncia2.Size = new System.Drawing.Size(1061, 109);
            this.LabelDenuncia2.TabIndex = 4;
            this.LabelDenuncia2.Text = resources.GetString("LabelDenuncia2.Text");
            this.LabelDenuncia2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LabelDenuncia1
            // 
            this.LabelDenuncia1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDenuncia1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelDenuncia1.Location = new System.Drawing.Point(4, 28);
            this.LabelDenuncia1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelDenuncia1.Name = "LabelDenuncia1";
            this.LabelDenuncia1.Size = new System.Drawing.Size(1062, 79);
            this.LabelDenuncia1.TabIndex = 3;
            this.LabelDenuncia1.Text = resources.GetString("LabelDenuncia1.Text");
            this.LabelDenuncia1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LabelDenuncia1.Click += new System.EventHandler(this.label2_Click);
            // 
            // BtnTelaInicial
            // 
            this.BtnTelaInicial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.BtnTelaInicial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTelaInicial.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTelaInicial.ForeColor = System.Drawing.Color.White;
            this.BtnTelaInicial.Image = ((System.Drawing.Image)(resources.GetObject("BtnTelaInicial.Image")));
            this.BtnTelaInicial.Location = new System.Drawing.Point(57, 607);
            this.BtnTelaInicial.Margin = new System.Windows.Forms.Padding(5);
            this.BtnTelaInicial.Name = "BtnTelaInicial";
            this.BtnTelaInicial.Size = new System.Drawing.Size(65, 59);
            this.BtnTelaInicial.TabIndex = 7;
            this.BtnTelaInicial.UseVisualStyleBackColor = false;
            this.BtnTelaInicial.Click += new System.EventHandler(this.btntelainical_Click);
            // 
            // FormDenuncia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1483, 706);
            this.Controls.Add(this.BtnTelaInicial);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDenuncia";
            this.Text = "Denúncia";
            this.Load += new System.EventHandler(this.FormDenuncia_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.PainelDenuncia.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Panel PainelDenuncia;
        private System.Windows.Forms.Label LabelDenuncia1;
        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.Button BtnTelaInicial;
        private System.Windows.Forms.Label LabelDenuncia2;
        private System.Windows.Forms.Label LabelDenuncia3;
    }
}