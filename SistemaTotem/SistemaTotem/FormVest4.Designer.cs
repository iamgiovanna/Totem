namespace SistemaTotem
{
    partial class FormVest4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVest4));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SubTituloFuvest = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.InfoCalendarioFuvest = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(62)))), ((int)(((byte)(99)))));
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(30, 26);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(707, 415);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.InfoCalendarioFuvest);
            this.panel1.Controls.Add(this.SubTituloFuvest);
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(705, 413);
            this.panel1.TabIndex = 0;
            // 
            // SubTituloFuvest
            // 
            this.SubTituloFuvest.AutoSize = true;
            this.SubTituloFuvest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTituloFuvest.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SubTituloFuvest.Location = new System.Drawing.Point(157, 79);
            this.SubTituloFuvest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SubTituloFuvest.Name = "SubTituloFuvest";
            this.SubTituloFuvest.Size = new System.Drawing.Size(373, 25);
            this.SubTituloFuvest.TabIndex = 1;
            this.SubTituloFuvest.Text = "Calendário vestibular Fuvest 2025";
            this.SubTituloFuvest.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTitle.Location = new System.Drawing.Point(292, 27);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(108, 29);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "FUVEST";
            // 
            // InfoCalendarioFuvest
            // 
            this.InfoCalendarioFuvest.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.InfoCalendarioFuvest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoCalendarioFuvest.ForeColor = System.Drawing.SystemColors.WindowText;
            this.InfoCalendarioFuvest.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.InfoCalendarioFuvest.Location = new System.Drawing.Point(132, 127);
            this.InfoCalendarioFuvest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InfoCalendarioFuvest.Name = "InfoCalendarioFuvest";
            this.InfoCalendarioFuvest.Size = new System.Drawing.Size(421, 256);
            this.InfoCalendarioFuvest.TabIndex = 2;
            this.InfoCalendarioFuvest.Text = resources.GetString("InfoCalendarioFuvest.Text");
            this.InfoCalendarioFuvest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InfoCalendarioFuvest.Click += new System.EventHandler(this.label3_Click);
            // 
            // FormVest4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(763, 483);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormVest4";
            this.Text = "Fuvest";
            this.Load += new System.EventHandler(this.FormVest4_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label SubTituloFuvest;
        private System.Windows.Forms.Label InfoCalendarioFuvest;
    }
}