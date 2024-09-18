namespace SistemaTotem
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BoxUsu = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkConexao = new System.Windows.Forms.CheckBox();
            this.TxTSenha = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.TxTUsu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-108, -153);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(555, 668);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(62)))), ((int)(((byte)(99)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(62)))), ((int)(((byte)(99)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(145, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 39);
            this.label2.TabIndex = 6;
            this.label2.Text = "Login";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(62)))), ((int)(((byte)(99)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(155, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 40);
            this.label1.TabIndex = 7;
            this.label1.Text = "Algum texto\r\nmotivacional";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(542, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Entrar como";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // BoxUsu
            // 
            this.BoxUsu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BoxUsu.FormattingEnabled = true;
            this.BoxUsu.Location = new System.Drawing.Point(666, 180);
            this.BoxUsu.Name = "BoxUsu";
            this.BoxUsu.Size = new System.Drawing.Size(259, 21);
            this.BoxUsu.TabIndex = 24;
            this.BoxUsu.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(542, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Senha";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(542, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Usuário";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // checkConexao
            // 
            this.checkConexao.AutoSize = true;
            this.checkConexao.BackColor = System.Drawing.SystemColors.ControlLight;
            this.checkConexao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkConexao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(62)))), ((int)(((byte)(99)))));
            this.checkConexao.Location = new System.Drawing.Point(702, 338);
            this.checkConexao.Name = "checkConexao";
            this.checkConexao.Size = new System.Drawing.Size(178, 17);
            this.checkConexao.TabIndex = 21;
            this.checkConexao.Text = "Deseja permanecer conectado?";
            this.checkConexao.UseVisualStyleBackColor = false;
            this.checkConexao.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // TxTSenha
            // 
            this.TxTSenha.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TxTSenha.Location = new System.Drawing.Point(666, 282);
            this.TxTSenha.Name = "TxTSenha";
            this.TxTSenha.Size = new System.Drawing.Size(256, 20);
            this.TxTSenha.TabIndex = 20;
            this.TxTSenha.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.Location = new System.Drawing.Point(713, 395);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(150, 41);
            this.LoginBtn.TabIndex = 19;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // TxTUsu
            // 
            this.TxTUsu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TxTUsu.Location = new System.Drawing.Point(666, 231);
            this.TxTUsu.Name = "TxTUsu";
            this.TxTUsu.Size = new System.Drawing.Size(256, 20);
            this.TxTUsu.TabIndex = 18;
            this.TxTUsu.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(62)))), ((int)(((byte)(99)))));
            this.label3.Location = new System.Drawing.Point(680, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Faça seu login aqui";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1047, 512);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BoxUsu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkConexao);
            this.Controls.Add(this.TxTSenha);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.TxTUsu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox BoxUsu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkConexao;
        private System.Windows.Forms.TextBox TxTSenha;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.TextBox TxTUsu;
        private System.Windows.Forms.Label label3;
    }
}

