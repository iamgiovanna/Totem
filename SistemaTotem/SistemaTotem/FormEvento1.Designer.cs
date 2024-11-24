namespace SistemaTotem
{
    partial class FormEvento1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEvento1));
            this.FlowPainelEvento = new System.Windows.Forms.FlowLayoutPanel();
            this.PainelEvento = new System.Windows.Forms.Panel();
            this.InfoEvento = new System.Windows.Forms.Label();
            this.TituloEvento = new System.Windows.Forms.Label();
            this.MaisInformacoes = new System.Windows.Forms.Label();
            this.BtnTelaInicial = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.FlowPainelEvento.SuspendLayout();
            this.PainelEvento.SuspendLayout();
            this.SuspendLayout();
            // 
            // FlowPainelEvento
            // 
            this.FlowPainelEvento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(62)))), ((int)(((byte)(99)))));
            this.FlowPainelEvento.Controls.Add(this.PainelEvento);
            this.FlowPainelEvento.Controls.Add(this.BtnTelaInicial);
            this.FlowPainelEvento.Location = new System.Drawing.Point(161, 44);
            this.FlowPainelEvento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FlowPainelEvento.Name = "FlowPainelEvento";
            this.FlowPainelEvento.Size = new System.Drawing.Size(969, 554);
            this.FlowPainelEvento.TabIndex = 1;
            // 
            // PainelEvento
            // 
            this.PainelEvento.Controls.Add(this.InfoEvento);
            this.PainelEvento.Controls.Add(this.TituloEvento);
            this.PainelEvento.Controls.Add(this.MaisInformacoes);
            this.PainelEvento.Location = new System.Drawing.Point(4, 4);
            this.PainelEvento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PainelEvento.Name = "PainelEvento";
            this.PainelEvento.Size = new System.Drawing.Size(964, 554);
            this.PainelEvento.TabIndex = 0;
            // 
            // InfoEvento
            // 
            this.InfoEvento.AutoSize = true;
            this.InfoEvento.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.InfoEvento.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoEvento.ForeColor = System.Drawing.SystemColors.WindowText;
            this.InfoEvento.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.InfoEvento.Location = new System.Drawing.Point(35, 149);
            this.InfoEvento.Name = "InfoEvento";
            this.InfoEvento.Size = new System.Drawing.Size(812, 276);
            this.InfoEvento.TabIndex = 5;
            this.InfoEvento.Text = resources.GetString("InfoEvento.Text");
            this.InfoEvento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InfoEvento.Click += new System.EventHandler(this.InfoEvento_Click);
            // 
            // TituloEvento
            // 
            this.TituloEvento.AutoSize = true;
            this.TituloEvento.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloEvento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TituloEvento.Location = new System.Drawing.Point(332, 66);
            this.TituloEvento.Name = "TituloEvento";
            this.TituloEvento.Size = new System.Drawing.Size(304, 36);
            this.TituloEvento.TabIndex = 3;
            this.TituloEvento.Text = "FEIRA TECNOLÓGICA";
            this.TituloEvento.Click += new System.EventHandler(this.TituloEvento_Click);
            // 
            // MaisInformacoes
            // 
            this.MaisInformacoes.AutoSize = true;
            this.MaisInformacoes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MaisInformacoes.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaisInformacoes.Location = new System.Drawing.Point(335, 473);
            this.MaisInformacoes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaisInformacoes.Name = "MaisInformacoes";
            this.MaisInformacoes.Size = new System.Drawing.Size(324, 60);
            this.MaisInformacoes.TabIndex = 2;
            this.MaisInformacoes.Text = "Para mais informaçõoes sobre o evento, \r\nconsultar um mebro do grêmio, \r\nou o seu" +
    " líder de sala, ou a direção da escola";
            this.MaisInformacoes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BtnTelaInicial
            // 
            this.BtnTelaInicial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.BtnTelaInicial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTelaInicial.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTelaInicial.ForeColor = System.Drawing.Color.White;
            this.BtnTelaInicial.Image = ((System.Drawing.Image)(resources.GetObject("BtnTelaInicial.Image")));
            this.BtnTelaInicial.Location = new System.Drawing.Point(5, 567);
            this.BtnTelaInicial.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BtnTelaInicial.Name = "BtnTelaInicial";
            this.BtnTelaInicial.Size = new System.Drawing.Size(65, 59);
            this.BtnTelaInicial.TabIndex = 8;
            this.BtnTelaInicial.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(47, 539);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 59);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormEvento1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1269, 645);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FlowPainelEvento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEvento1";
            this.Text = "Feira Tecnológica";
            this.Load += new System.EventHandler(this.FormEvento1_Load);
            this.FlowPainelEvento.ResumeLayout(false);
            this.PainelEvento.ResumeLayout(false);
            this.PainelEvento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlowPainelEvento;
        private System.Windows.Forms.Panel PainelEvento;
        private System.Windows.Forms.Label TituloEvento;
        private System.Windows.Forms.Label MaisInformacoes;
        private System.Windows.Forms.Button BtnTelaInicial;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label InfoEvento;
    }
}