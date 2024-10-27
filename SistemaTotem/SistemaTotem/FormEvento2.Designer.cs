namespace SistemaTotem
{
    partial class FormEvento2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEvento2));
            this.FlowPainelEvento = new System.Windows.Forms.FlowLayoutPanel();
            this.PainelEvento = new System.Windows.Forms.Panel();
            this.InfoEvento = new System.Windows.Forms.Label();
            this.TituloEvento = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FlowPainelEvento.SuspendLayout();
            this.PainelEvento.SuspendLayout();
            this.SuspendLayout();
            // 
            // FlowPainelEvento
            // 
            this.FlowPainelEvento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(62)))), ((int)(((byte)(99)))));
            this.FlowPainelEvento.Controls.Add(this.PainelEvento);
            this.FlowPainelEvento.Location = new System.Drawing.Point(138, 40);
            this.FlowPainelEvento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FlowPainelEvento.Name = "FlowPainelEvento";
            this.FlowPainelEvento.Size = new System.Drawing.Size(727, 450);
            this.FlowPainelEvento.TabIndex = 2;
            // 
            // PainelEvento
            // 
            this.PainelEvento.Controls.Add(this.label1);
            this.PainelEvento.Controls.Add(this.InfoEvento);
            this.PainelEvento.Controls.Add(this.TituloEvento);
            this.PainelEvento.Location = new System.Drawing.Point(3, 3);
            this.PainelEvento.Name = "PainelEvento";
            this.PainelEvento.Size = new System.Drawing.Size(724, 447);
            this.PainelEvento.TabIndex = 0;
            this.PainelEvento.Paint += new System.Windows.Forms.PaintEventHandler(this.PainelEvento_Paint);
            // 
            // InfoEvento
            // 
            this.InfoEvento.AutoSize = true;
            this.InfoEvento.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.InfoEvento.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoEvento.ForeColor = System.Drawing.SystemColors.WindowText;
            this.InfoEvento.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.InfoEvento.Location = new System.Drawing.Point(24, 127);
            this.InfoEvento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InfoEvento.Name = "InfoEvento";
            this.InfoEvento.Size = new System.Drawing.Size(686, 70);
            this.InfoEvento.TabIndex = 5;
            this.InfoEvento.Text = resources.GetString("InfoEvento.Text");
            this.InfoEvento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TituloEvento
            // 
            this.TituloEvento.AutoSize = true;
            this.TituloEvento.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloEvento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TituloEvento.Location = new System.Drawing.Point(269, 51);
            this.TituloEvento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TituloEvento.Name = "TituloEvento";
            this.TituloEvento.Size = new System.Drawing.Size(213, 28);
            this.TituloEvento.TabIndex = 3;
            this.TituloEvento.Text = "NOME DO EVENTO";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(42, 442);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 48);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Cambria", 8.25F);
            this.label1.Location = new System.Drawing.Point(272, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "Para mais informaçõoes sobre o evento, \r\nconsultar um mebro do grêmio, \r\nou o seu" +
    " líder de sala, ou a direção da escola";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormEvento2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(952, 523);
            this.Controls.Add(this.FlowPainelEvento);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEvento2";
            this.Text = "Evento2";
            this.Load += new System.EventHandler(this.FormEvento2_Load);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}