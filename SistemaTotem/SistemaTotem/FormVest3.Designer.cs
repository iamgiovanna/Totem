﻿namespace SistemaTotem
{
    partial class FormVest3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVest3));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SiteInfoOfficial = new System.Windows.Forms.Label();
            this.SubTituloListas = new System.Windows.Forms.Label();
            this.SubTituloDatasProvas = new System.Windows.Forms.Label();
            this.InfoProvasEmais = new System.Windows.Forms.Label();
            this.InfoListas = new System.Windows.Forms.Label();
            this.TituloProvaoPaulista = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(27, 23);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1049, 553);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SiteInfoOfficial);
            this.panel1.Controls.Add(this.SubTituloListas);
            this.panel1.Controls.Add(this.SubTituloDatasProvas);
            this.panel1.Controls.Add(this.InfoProvasEmais);
            this.panel1.Controls.Add(this.InfoListas);
            this.panel1.Controls.Add(this.TituloProvaoPaulista);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1046, 551);
            this.panel1.TabIndex = 0;
            // 
            // SiteInfoOfficial
            // 
            this.SiteInfoOfficial.BackColor = System.Drawing.Color.FloralWhite;
            this.SiteInfoOfficial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SiteInfoOfficial.Location = new System.Drawing.Point(225, 481);
            this.SiteInfoOfficial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SiteInfoOfficial.Name = "SiteInfoOfficial";
            this.SiteInfoOfficial.Size = new System.Drawing.Size(463, 39);
            this.SiteInfoOfficial.TabIndex = 5;
            this.SiteInfoOfficial.Text = "Para mais informaçõoes, acesse o site oficial: www.provaopaulistaseriado.vunesp.c" +
    "om.br\r\n";
            this.SiteInfoOfficial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SubTituloListas
            // 
            this.SubTituloListas.AutoSize = true;
            this.SubTituloListas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTituloListas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SubTituloListas.Location = new System.Drawing.Point(69, 115);
            this.SubTituloListas.Name = "SubTituloListas";
            this.SubTituloListas.Size = new System.Drawing.Size(248, 36);
            this.SubTituloListas.TabIndex = 4;
            this.SubTituloListas.Text = "Datas das listas:";
            this.SubTituloListas.Click += new System.EventHandler(this.label4_Click);
            // 
            // SubTituloDatasProvas
            // 
            this.SubTituloDatasProvas.AutoSize = true;
            this.SubTituloDatasProvas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTituloDatasProvas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SubTituloDatasProvas.Location = new System.Drawing.Point(545, 106);
            this.SubTituloDatasProvas.Name = "SubTituloDatasProvas";
            this.SubTituloDatasProvas.Size = new System.Drawing.Size(373, 36);
            this.SubTituloDatasProvas.TabIndex = 3;
            this.SubTituloDatasProvas.Text = "Datas das Provas e mais:";
            this.SubTituloDatasProvas.Click += new System.EventHandler(this.label3_Click);
            // 
            // InfoProvasEmais
            // 
            this.InfoProvasEmais.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.InfoProvasEmais.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoProvasEmais.ForeColor = System.Drawing.SystemColors.Desktop;
            this.InfoProvasEmais.Location = new System.Drawing.Point(511, 148);
            this.InfoProvasEmais.Name = "InfoProvasEmais";
            this.InfoProvasEmais.Size = new System.Drawing.Size(511, 303);
            this.InfoProvasEmais.TabIndex = 2;
            this.InfoProvasEmais.Text = resources.GetString("InfoProvasEmais.Text");
            this.InfoProvasEmais.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InfoProvasEmais.Click += new System.EventHandler(this.label1_Click);
            // 
            // InfoListas
            // 
            this.InfoListas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.InfoListas.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoListas.ForeColor = System.Drawing.SystemColors.WindowText;
            this.InfoListas.Location = new System.Drawing.Point(39, 157);
            this.InfoListas.Name = "InfoListas";
            this.InfoListas.Size = new System.Drawing.Size(384, 284);
            this.InfoListas.TabIndex = 1;
            this.InfoListas.Text = resources.GetString("InfoListas.Text");
            this.InfoListas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InfoListas.Click += new System.EventHandler(this.label2_Click);
            // 
            // TituloProvaoPaulista
            // 
            this.TituloProvaoPaulista.AutoSize = true;
            this.TituloProvaoPaulista.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloProvaoPaulista.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TituloProvaoPaulista.Location = new System.Drawing.Point(368, 35);
            this.TituloProvaoPaulista.Name = "TituloProvaoPaulista";
            this.TituloProvaoPaulista.Size = new System.Drawing.Size(240, 35);
            this.TituloProvaoPaulista.TabIndex = 0;
            this.TituloProvaoPaulista.Text = "Provão Paulista";
            this.TituloProvaoPaulista.Click += new System.EventHandler(this.TituloProvaoPaulista_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(14, 585);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 59);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormVest3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1096, 705);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormVest3";
            this.Text = "Provão Paulista";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TituloProvaoPaulista;
        private System.Windows.Forms.Label InfoListas;
        private System.Windows.Forms.Label InfoProvasEmais;
        private System.Windows.Forms.Label SubTituloListas;
        private System.Windows.Forms.Label SubTituloDatasProvas;
        private System.Windows.Forms.Label SiteInfoOfficial;
        private System.Windows.Forms.Button button1;
    }
}