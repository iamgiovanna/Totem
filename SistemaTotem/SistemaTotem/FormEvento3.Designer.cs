namespace SistemaTotem
{
    partial class FormEvento3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEvento3));
            this.FlowPainelEvento = new System.Windows.Forms.FlowLayoutPanel();
            this.PainelEvento = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.InfoEvento = new System.Windows.Forms.Label();
            this.TituloEvento = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.FlowPainelEvento.SuspendLayout();
            this.PainelEvento.SuspendLayout();
            this.SuspendLayout();
            // 
            // FlowPainelEvento
            // 
            this.FlowPainelEvento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(62)))), ((int)(((byte)(99)))));
            this.FlowPainelEvento.Controls.Add(this.PainelEvento);
            this.FlowPainelEvento.Location = new System.Drawing.Point(176, 43);
            this.FlowPainelEvento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FlowPainelEvento.Name = "FlowPainelEvento";
            this.FlowPainelEvento.Size = new System.Drawing.Size(969, 554);
            this.FlowPainelEvento.TabIndex = 2;
            // 
            // PainelEvento
            // 
            this.PainelEvento.Controls.Add(this.label1);
            this.PainelEvento.Controls.Add(this.InfoEvento);
            this.PainelEvento.Controls.Add(this.TituloEvento);
            this.PainelEvento.Location = new System.Drawing.Point(4, 4);
            this.PainelEvento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PainelEvento.Name = "PainelEvento";
            this.PainelEvento.Size = new System.Drawing.Size(965, 550);
            this.PainelEvento.TabIndex = 0;
            this.PainelEvento.Paint += new System.Windows.Forms.PaintEventHandler(this.PainelEvento_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Cambria", 8.25F);
            this.label1.Location = new System.Drawing.Point(349, 479);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 48);
            this.label1.TabIndex = 7;
            this.label1.Text = "Para mais informaçõoes sobre o evento, \r\nconsultar um mebro do grêmio, \r\nou o seu" +
    " líder de sala, ou a direção da escola";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // InfoEvento
            // 
            this.InfoEvento.AutoSize = true;
            this.InfoEvento.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.InfoEvento.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoEvento.ForeColor = System.Drawing.SystemColors.WindowText;
            this.InfoEvento.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.InfoEvento.Location = new System.Drawing.Point(93, 134);
            this.InfoEvento.Name = "InfoEvento";
            this.InfoEvento.Size = new System.Drawing.Size(776, 330);
            this.InfoEvento.TabIndex = 5;
            this.InfoEvento.Text = resources.GetString("InfoEvento.Text");
            this.InfoEvento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TituloEvento
            // 
            this.TituloEvento.AutoSize = true;
            this.TituloEvento.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloEvento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TituloEvento.Location = new System.Drawing.Point(303, 74);
            this.TituloEvento.Name = "TituloEvento";
            this.TituloEvento.Size = new System.Drawing.Size(372, 36);
            this.TituloEvento.TabIndex = 3;
            this.TituloEvento.Text = "FEIRA DO EMPRENDEDOR";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(49, 538);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 59);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormEvento3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1269, 644);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FlowPainelEvento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEvento3";
            this.Text = "Feira do Emprendedor";
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