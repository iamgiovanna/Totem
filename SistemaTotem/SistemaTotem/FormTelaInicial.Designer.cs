namespace SistemaTotem
{
    partial class FormTelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTelaInicial));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCasa = new System.Windows.Forms.Button();
            this.BtnHome = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(62)))), ((int)(((byte)(99)))));
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-3, -1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1547, 46);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 43);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BtnCasa
            // 
            this.BtnCasa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCasa.BackgroundImage")));
            this.BtnCasa.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.BtnCasa.Location = new System.Drawing.Point(38, 166);
            this.BtnCasa.Name = "BtnCasa";
            this.BtnCasa.Size = new System.Drawing.Size(194, 43);
            this.BtnCasa.TabIndex = 0;
            this.BtnCasa.UseVisualStyleBackColor = true;
            // 
            // BtnHome
            // 
            this.BtnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.BtnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHome.ForeColor = System.Drawing.Color.White;
            this.BtnHome.Image = ((System.Drawing.Image)(resources.GetObject("BtnHome.Image")));
            this.BtnHome.Location = new System.Drawing.Point(298, 242);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(198, 46);
            this.BtnHome.TabIndex = 1;
            this.BtnHome.UseVisualStyleBackColor = false;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // FormTelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1544, 784);
            this.Controls.Add(this.BtnHome);
            this.Controls.Add(this.BtnCasa);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTelaInicial";
            this.Text = "FormTelaInicial";
            this.Load += new System.EventHandler(this.FormTelaInicial_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnCasa;
        private System.Windows.Forms.Button BtnHome;
    }
}