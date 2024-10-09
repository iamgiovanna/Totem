namespace SistemaTotem
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
            this.InfoListas = new System.Windows.Forms.Label();
            this.TituloProvaoPaulista = new System.Windows.Forms.Label();
            this.InfoProvasEmais = new System.Windows.Forms.Label();
            this.SubTituloDatasProvas = new System.Windows.Forms.Label();
            this.SubTituloListas = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 19);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(725, 449);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SubTituloListas);
            this.panel1.Controls.Add(this.SubTituloDatasProvas);
            this.panel1.Controls.Add(this.InfoProvasEmais);
            this.panel1.Controls.Add(this.InfoListas);
            this.panel1.Controls.Add(this.TituloProvaoPaulista);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 448);
            this.panel1.TabIndex = 0;
            // 
            // InfoListas
            // 
            this.InfoListas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.InfoListas.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoListas.ForeColor = System.Drawing.SystemColors.WindowText;
            this.InfoListas.Location = new System.Drawing.Point(24, 187);
            this.InfoListas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InfoListas.Name = "InfoListas";
            this.InfoListas.Size = new System.Drawing.Size(288, 231);
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
            this.TituloProvaoPaulista.Location = new System.Drawing.Point(256, 39);
            this.TituloProvaoPaulista.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TituloProvaoPaulista.Name = "TituloProvaoPaulista";
            this.TituloProvaoPaulista.Size = new System.Drawing.Size(193, 29);
            this.TituloProvaoPaulista.TabIndex = 0;
            this.TituloProvaoPaulista.Text = "Provão Paulista";
            this.TituloProvaoPaulista.Click += new System.EventHandler(this.TituloProvaoPaulista_Click);
            // 
            // InfoProvasEmais
            // 
            this.InfoProvasEmais.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.InfoProvasEmais.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoProvasEmais.ForeColor = System.Drawing.SystemColors.Desktop;
            this.InfoProvasEmais.Location = new System.Drawing.Point(327, 133);
            this.InfoProvasEmais.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InfoProvasEmais.Name = "InfoProvasEmais";
            this.InfoProvasEmais.Size = new System.Drawing.Size(383, 285);
            this.InfoProvasEmais.TabIndex = 2;
            this.InfoProvasEmais.Text = resources.GetString("InfoProvasEmais.Text");
            this.InfoProvasEmais.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InfoProvasEmais.Click += new System.EventHandler(this.label1_Click);
            // 
            // SubTituloDatasProvas
            // 
            this.SubTituloDatasProvas.AutoSize = true;
            this.SubTituloDatasProvas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTituloDatasProvas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SubTituloDatasProvas.Location = new System.Drawing.Point(351, 86);
            this.SubTituloDatasProvas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SubTituloDatasProvas.Name = "SubTituloDatasProvas";
            this.SubTituloDatasProvas.Size = new System.Drawing.Size(306, 29);
            this.SubTituloDatasProvas.TabIndex = 3;
            this.SubTituloDatasProvas.Text = "Datas das Provas e mais:";
            this.SubTituloDatasProvas.Click += new System.EventHandler(this.label3_Click);
            // 
            // SubTituloListas
            // 
            this.SubTituloListas.AutoSize = true;
            this.SubTituloListas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTituloListas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SubTituloListas.Location = new System.Drawing.Point(62, 147);
            this.SubTituloListas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SubTituloListas.Name = "SubTituloListas";
            this.SubTituloListas.Size = new System.Drawing.Size(203, 29);
            this.SubTituloListas.TabIndex = 4;
            this.SubTituloListas.Text = "Datas das listas:";
            this.SubTituloListas.Click += new System.EventHandler(this.label4_Click);
            // 
            // FormVest3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(763, 483);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
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
    }
}