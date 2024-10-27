namespace SistemaTotem
{
    partial class FormMapaEtec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMapaEtec));
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.PainelMapaEtecZL = new System.Windows.Forms.Panel();
            this.TituloMapaEtecZL = new System.Windows.Forms.Label();
            this.PainelControleSecretaria = new System.Windows.Forms.FlowLayoutPanel();
            this.PictureMapaEtecZL = new System.Windows.Forms.PictureBox();
            this.PainelMapa = new System.Windows.Forms.Panel();
            this.PainelMapaEtecZL.SuspendLayout();
            this.PainelControleSecretaria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureMapaEtecZL)).BeginInit();
            this.PainelMapa.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.BtnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVoltar.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltar.ForeColor = System.Drawing.Color.White;
            this.BtnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("BtnVoltar.Image")));
            this.BtnVoltar.Location = new System.Drawing.Point(103, 619);
            this.BtnVoltar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(62, 53);
            this.BtnVoltar.TabIndex = 4;
            this.BtnVoltar.UseVisualStyleBackColor = false;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1514, 66);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(62)))), ((int)(((byte)(99)))));
            this.flowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(607, 113);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(368, 68);
            this.flowLayoutPanel3.TabIndex = 13;
            this.flowLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel3_Paint_1);
            // 
            // PainelMapaEtecZL
            // 
            this.PainelMapaEtecZL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.PainelMapaEtecZL.Controls.Add(this.TituloMapaEtecZL);
            this.PainelMapaEtecZL.Location = new System.Drawing.Point(607, 113);
            this.PainelMapaEtecZL.Margin = new System.Windows.Forms.Padding(4);
            this.PainelMapaEtecZL.Name = "PainelMapaEtecZL";
            this.PainelMapaEtecZL.Size = new System.Drawing.Size(368, 68);
            this.PainelMapaEtecZL.TabIndex = 0;
            // 
            // TituloMapaEtecZL
            // 
            this.TituloMapaEtecZL.AutoSize = true;
            this.TituloMapaEtecZL.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloMapaEtecZL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TituloMapaEtecZL.Location = new System.Drawing.Point(75, 18);
            this.TituloMapaEtecZL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TituloMapaEtecZL.Name = "TituloMapaEtecZL";
            this.TituloMapaEtecZL.Size = new System.Drawing.Size(252, 37);
            this.TituloMapaEtecZL.TabIndex = 0;
            this.TituloMapaEtecZL.Text = "Mapa da Etec ZL";
            this.TituloMapaEtecZL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TituloMapaEtecZL.Click += new System.EventHandler(this.label2_Click);
            // 
            // PainelControleSecretaria
            // 
            this.PainelControleSecretaria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(62)))), ((int)(((byte)(99)))));
            this.PainelControleSecretaria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PainelControleSecretaria.Controls.Add(this.PainelMapa);
            this.PainelControleSecretaria.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PainelControleSecretaria.Location = new System.Drawing.Point(227, 208);
            this.PainelControleSecretaria.Margin = new System.Windows.Forms.Padding(4);
            this.PainelControleSecretaria.Name = "PainelControleSecretaria";
            this.PainelControleSecretaria.Size = new System.Drawing.Size(1125, 464);
            this.PainelControleSecretaria.TabIndex = 12;
            // 
            // PictureMapaEtecZL
            // 
            this.PictureMapaEtecZL.Image = ((System.Drawing.Image)(resources.GetObject("PictureMapaEtecZL.Image")));
            this.PictureMapaEtecZL.Location = new System.Drawing.Point(-16, -3);
            this.PictureMapaEtecZL.Name = "PictureMapaEtecZL";
            this.PictureMapaEtecZL.Size = new System.Drawing.Size(1135, 470);
            this.PictureMapaEtecZL.TabIndex = 2;
            this.PictureMapaEtecZL.TabStop = false;
            this.PictureMapaEtecZL.Click += new System.EventHandler(this.PictureMapaEtecZL_Click);
            // 
            // PainelMapa
            // 
            this.PainelMapa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PainelMapa.Controls.Add(this.PictureMapaEtecZL);
            this.PainelMapa.Location = new System.Drawing.Point(4, 4);
            this.PainelMapa.Margin = new System.Windows.Forms.Padding(4);
            this.PainelMapa.Name = "PainelMapa";
            this.PainelMapa.Size = new System.Drawing.Size(1122, 470);
            this.PainelMapa.TabIndex = 0;
            // 
            // FormMapaEtec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1514, 735);
            this.Controls.Add(this.PainelMapaEtecZL);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.PainelControleSecretaria);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMapaEtec";
            this.Text = "FormMapaEtec";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(62)))), ((int)(((byte)(99)))));
            this.PainelMapaEtecZL.ResumeLayout(false);
            this.PainelMapaEtecZL.PerformLayout();
            this.PainelControleSecretaria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureMapaEtecZL)).EndInit();
            this.PainelMapa.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Panel PainelMapaEtecZL;
        private System.Windows.Forms.Label TituloMapaEtecZL;
        private System.Windows.Forms.FlowLayoutPanel PainelControleSecretaria;
        private System.Windows.Forms.Panel PainelMapa;
        private System.Windows.Forms.PictureBox PictureMapaEtecZL;
    }
}