﻿namespace SistemaTotem
{
    partial class FrmMapaEtec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMapaEtec));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PainelMapaEtecZL = new System.Windows.Forms.Panel();
            this.TituloMapaEtecZL = new System.Windows.Forms.Label();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PainelMapaEtecZL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(62)))), ((int)(((byte)(99)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(110, 92);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(730, 437);
            this.panel2.TabIndex = 75;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(62)))), ((int)(((byte)(99)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.PainelMapaEtecZL);
            this.panel1.Controls.Add(this.BtnVoltar);
            this.panel1.Location = new System.Drawing.Point(-10, -11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(966, 84);
            this.panel1.TabIndex = 76;
            // 
            // PainelMapaEtecZL
            // 
            this.PainelMapaEtecZL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.PainelMapaEtecZL.Controls.Add(this.TituloMapaEtecZL);
            this.PainelMapaEtecZL.Location = new System.Drawing.Point(359, 20);
            this.PainelMapaEtecZL.Name = "PainelMapaEtecZL";
            this.PainelMapaEtecZL.Size = new System.Drawing.Size(258, 50);
            this.PainelMapaEtecZL.TabIndex = 0;
            // 
            // TituloMapaEtecZL
            // 
            this.TituloMapaEtecZL.AutoSize = true;
            this.TituloMapaEtecZL.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloMapaEtecZL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TituloMapaEtecZL.Location = new System.Drawing.Point(10, 3);
            this.TituloMapaEtecZL.Name = "TituloMapaEtecZL";
            this.TituloMapaEtecZL.Size = new System.Drawing.Size(252, 37);
            this.TituloMapaEtecZL.TabIndex = 0;
            this.TituloMapaEtecZL.Text = "Mapa da Etec ZL";
            this.TituloMapaEtecZL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TituloMapaEtecZL.Click += new System.EventHandler(this.TituloMapaEtecZL_Click);
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.BtnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVoltar.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltar.ForeColor = System.Drawing.Color.White;
            this.BtnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("BtnVoltar.Image")));
            this.BtnVoltar.Location = new System.Drawing.Point(143, 26);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(57, 49);
            this.BtnVoltar.TabIndex = 4;
            this.BtnVoltar.UseVisualStyleBackColor = false;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(14, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(696, 412);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // FrmMapaEtec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(946, 547);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmMapaEtec";
            this.Text = "FrmMapaEtec";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.PainelMapaEtecZL.ResumeLayout(false);
            this.PainelMapaEtecZL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PainelMapaEtecZL;
        private System.Windows.Forms.Label TituloMapaEtecZL;
        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}