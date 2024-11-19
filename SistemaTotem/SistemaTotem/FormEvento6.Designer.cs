namespace SistemaTotem
{
    partial class FormEvento6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEvento6));
            this.button1 = new System.Windows.Forms.Button();
            this.PainelEvento = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.InfoEvento6 = new System.Windows.Forms.Label();
            this.TituloEvento6 = new System.Windows.Forms.Label();
            this.PainelEvento.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(42, 433);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 48);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PainelEvento
            // 
            this.PainelEvento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.PainelEvento.Controls.Add(this.label1);
            this.PainelEvento.Controls.Add(this.InfoEvento6);
            this.PainelEvento.Controls.Add(this.TituloEvento6);
            this.PainelEvento.Location = new System.Drawing.Point(133, 34);
            this.PainelEvento.Name = "PainelEvento";
            this.PainelEvento.Size = new System.Drawing.Size(724, 447);
            this.PainelEvento.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Cambria", 8.25F);
            this.label1.Location = new System.Drawing.Point(256, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "Para mais informaçõoes sobre o evento, \r\nconsultar um mebro do grêmio, \r\nou o seu" +
    " líder de sala, ou a direção da escola";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // InfoEvento6
            // 
            this.InfoEvento6.AutoSize = true;
            this.InfoEvento6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.InfoEvento6.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoEvento6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.InfoEvento6.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.InfoEvento6.Location = new System.Drawing.Point(24, 165);
            this.InfoEvento6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InfoEvento6.Name = "InfoEvento6";
            this.InfoEvento6.Size = new System.Drawing.Size(686, 70);
            this.InfoEvento6.TabIndex = 5;
            this.InfoEvento6.Text = resources.GetString("InfoEvento6.Text");
            this.InfoEvento6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TituloEvento6
            // 
            this.TituloEvento6.AutoSize = true;
            this.TituloEvento6.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloEvento6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TituloEvento6.Location = new System.Drawing.Point(270, 70);
            this.TituloEvento6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TituloEvento6.Name = "TituloEvento6";
            this.TituloEvento6.Size = new System.Drawing.Size(213, 28);
            this.TituloEvento6.TabIndex = 3;
            this.TituloEvento6.Text = "NOME DO EVENTO";
            this.TituloEvento6.Click += new System.EventHandler(this.TituloEvento6_Click);
            // 
            // FormEvento6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(952, 524);
            this.Controls.Add(this.PainelEvento);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEvento6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Evento6";
            this.Load += new System.EventHandler(this.FormEvento6_Load);
            this.PainelEvento.ResumeLayout(false);
            this.PainelEvento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel PainelEvento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label InfoEvento6;
        private System.Windows.Forms.Label TituloEvento6;
    }
}