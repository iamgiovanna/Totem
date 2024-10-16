namespace SistemaTotem
{
    partial class FormEvento4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEvento4));
            this.FlowPainelEvento = new System.Windows.Forms.FlowLayoutPanel();
            this.PainelEvento = new System.Windows.Forms.Panel();
            this.InfoEvento = new System.Windows.Forms.Label();
            this.TituloEvento = new System.Windows.Forms.Label();
            this.MaisInformacoes = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.FlowPainelEvento.SuspendLayout();
            this.PainelEvento.SuspendLayout();
            this.SuspendLayout();
            // 
            // FlowPainelEvento
            // 
            this.FlowPainelEvento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(62)))), ((int)(((byte)(99)))));
            this.FlowPainelEvento.Controls.Add(this.PainelEvento);
            this.FlowPainelEvento.Location = new System.Drawing.Point(102, 41);
            this.FlowPainelEvento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FlowPainelEvento.Name = "FlowPainelEvento";
            this.FlowPainelEvento.Size = new System.Drawing.Size(969, 554);
            this.FlowPainelEvento.TabIndex = 2;
            // 
            // PainelEvento
            // 
            this.PainelEvento.Controls.Add(this.InfoEvento);
            this.PainelEvento.Controls.Add(this.TituloEvento);
            this.PainelEvento.Controls.Add(this.MaisInformacoes);
            this.PainelEvento.Location = new System.Drawing.Point(4, 4);
            this.PainelEvento.Margin = new System.Windows.Forms.Padding(4);
            this.PainelEvento.Name = "PainelEvento";
            this.PainelEvento.Size = new System.Drawing.Size(965, 550);
            this.PainelEvento.TabIndex = 0;
            // 
            // InfoEvento
            // 
            this.InfoEvento.AutoSize = true;
            this.InfoEvento.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.InfoEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoEvento.ForeColor = System.Drawing.SystemColors.WindowText;
            this.InfoEvento.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.InfoEvento.Location = new System.Drawing.Point(35, 87);
            this.InfoEvento.Name = "InfoEvento";
            this.InfoEvento.Size = new System.Drawing.Size(847, 90);
            this.InfoEvento.TabIndex = 5;
            this.InfoEvento.Text = resources.GetString("InfoEvento.Text");
            this.InfoEvento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TituloEvento
            // 
            this.TituloEvento.AutoSize = true;
            this.TituloEvento.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloEvento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TituloEvento.Location = new System.Drawing.Point(333, 17);
            this.TituloEvento.Name = "TituloEvento";
            this.TituloEvento.Size = new System.Drawing.Size(288, 35);
            this.TituloEvento.TabIndex = 3;
            this.TituloEvento.Text = "NOME DO EVENTO";
            // 
            // MaisInformacoes
            // 
            this.MaisInformacoes.AutoSize = true;
            this.MaisInformacoes.BackColor = System.Drawing.Color.FloralWhite;
            this.MaisInformacoes.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaisInformacoes.Location = new System.Drawing.Point(34, 500);
            this.MaisInformacoes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaisInformacoes.Name = "MaisInformacoes";
            this.MaisInformacoes.Size = new System.Drawing.Size(874, 24);
            this.MaisInformacoes.TabIndex = 2;
            this.MaisInformacoes.Text = "Para mais informaçõoes sobre o evento, consultar um mebro do grêmio, ou o seu líd" +
    "er de sala, ou a direção da escola";
            this.MaisInformacoes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(14, 563);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 59);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormEvento4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1111, 644);
            this.Controls.Add(this.FlowPainelEvento);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEvento4";
            this.Text = "Evento4";
            this.FlowPainelEvento.ResumeLayout(false);
            this.PainelEvento.ResumeLayout(false);
            this.PainelEvento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlowPainelEvento;
        private System.Windows.Forms.Panel PainelEvento;
        private System.Windows.Forms.Label InfoEvento;
        private System.Windows.Forms.Label TituloEvento;
        private System.Windows.Forms.Label MaisInformacoes;
        private System.Windows.Forms.Button button1;
    }
}