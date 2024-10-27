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
            this.DesingTelaInicial = new System.Windows.Forms.PictureBox();
            this.LogoCPS = new System.Windows.Forms.PictureBox();
            this.LabelTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelEntrarComo = new System.Windows.Forms.Label();
            this.BoxUsu = new System.Windows.Forms.ComboBox();
            this.LabelSenha = new System.Windows.Forms.Label();
            this.LabelUsuario = new System.Windows.Forms.Label();
            this.CheckManterConectado = new System.Windows.Forms.CheckBox();
            this.TxTSenha = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.TxTUsu = new System.Windows.Forms.TextBox();
            this.LabelFazerLogin = new System.Windows.Forms.Label();
            this.LabelSubTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DesingTelaInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoCPS)).BeginInit();
            this.SuspendLayout();
            // 
            // DesingTelaInicial
            // 
            this.DesingTelaInicial.Image = ((System.Drawing.Image)(resources.GetObject("DesingTelaInicial.Image")));
            this.DesingTelaInicial.Location = new System.Drawing.Point(-110, -126);
            this.DesingTelaInicial.Name = "DesingTelaInicial";
            this.DesingTelaInicial.Size = new System.Drawing.Size(600, 668);
            this.DesingTelaInicial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DesingTelaInicial.TabIndex = 3;
            this.DesingTelaInicial.TabStop = false;
            // 
            // LogoCPS
            // 
            this.LogoCPS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(62)))), ((int)(((byte)(99)))));
            this.LogoCPS.Image = ((System.Drawing.Image)(resources.GetObject("LogoCPS.Image")));
            this.LogoCPS.Location = new System.Drawing.Point(12, 12);
            this.LogoCPS.Name = "LogoCPS";
            this.LogoCPS.Size = new System.Drawing.Size(100, 80);
            this.LogoCPS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoCPS.TabIndex = 5;
            this.LogoCPS.TabStop = false;
            // 
            // LabelTitulo
            // 
            this.LabelTitulo.AutoSize = true;
            this.LabelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(62)))), ((int)(((byte)(99)))));
            this.LabelTitulo.Font = new System.Drawing.Font("Cambria", 29.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelTitulo.Location = new System.Drawing.Point(139, 193);
            this.LabelTitulo.Name = "LabelTitulo";
            this.LabelTitulo.Size = new System.Drawing.Size(119, 46);
            this.LabelTitulo.TabIndex = 6;
            this.LabelTitulo.Text = "Login";
            this.LabelTitulo.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(62)))), ((int)(((byte)(99)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(155, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 7;
            // 
            // LabelEntrarComo
            // 
            this.LabelEntrarComo.AutoSize = true;
            this.LabelEntrarComo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEntrarComo.Location = new System.Drawing.Point(525, 287);
            this.LabelEntrarComo.Name = "LabelEntrarComo";
            this.LabelEntrarComo.Size = new System.Drawing.Size(96, 20);
            this.LabelEntrarComo.TabIndex = 25;
            this.LabelEntrarComo.Text = "Entrar como";
            this.LabelEntrarComo.Click += new System.EventHandler(this.label4_Click);
            // 
            // BoxUsu
            // 
            this.BoxUsu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BoxUsu.FormattingEnabled = true;
            this.BoxUsu.Items.AddRange(new object[] {
            "Membro Grêmio",
            "Funcionário Secretária"});
            this.BoxUsu.Location = new System.Drawing.Point(649, 286);
            this.BoxUsu.Name = "BoxUsu";
            this.BoxUsu.Size = new System.Drawing.Size(259, 21);
            this.BoxUsu.TabIndex = 24;
            this.BoxUsu.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // LabelSenha
            // 
            this.LabelSenha.AutoSize = true;
            this.LabelSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSenha.Location = new System.Drawing.Point(525, 236);
            this.LabelSenha.Name = "LabelSenha";
            this.LabelSenha.Size = new System.Drawing.Size(56, 20);
            this.LabelSenha.TabIndex = 23;
            this.LabelSenha.Text = "Senha";
            this.LabelSenha.Click += new System.EventHandler(this.label6_Click);
            // 
            // LabelUsuario
            // 
            this.LabelUsuario.AutoSize = true;
            this.LabelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsuario.Location = new System.Drawing.Point(525, 189);
            this.LabelUsuario.Name = "LabelUsuario";
            this.LabelUsuario.Size = new System.Drawing.Size(64, 20);
            this.LabelUsuario.TabIndex = 22;
            this.LabelUsuario.Text = "Usuário";
            this.LabelUsuario.Click += new System.EventHandler(this.label5_Click);
            // 
            // CheckManterConectado
            // 
            this.CheckManterConectado.AutoSize = true;
            this.CheckManterConectado.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CheckManterConectado.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckManterConectado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(62)))), ((int)(((byte)(99)))));
            this.CheckManterConectado.Location = new System.Drawing.Point(702, 338);
            this.CheckManterConectado.Name = "CheckManterConectado";
            this.CheckManterConectado.Size = new System.Drawing.Size(178, 17);
            this.CheckManterConectado.TabIndex = 21;
            this.CheckManterConectado.Text = "Deseja permanecer conectado?";
            this.CheckManterConectado.UseVisualStyleBackColor = false;
            this.CheckManterConectado.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // TxTSenha
            // 
            this.TxTSenha.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TxTSenha.Location = new System.Drawing.Point(649, 236);
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
            this.TxTUsu.Location = new System.Drawing.Point(649, 189);
            this.TxTUsu.Name = "TxTUsu";
            this.TxTUsu.Size = new System.Drawing.Size(256, 20);
            this.TxTUsu.TabIndex = 18;
            this.TxTUsu.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LabelFazerLogin
            // 
            this.LabelFazerLogin.AutoSize = true;
            this.LabelFazerLogin.BackColor = System.Drawing.Color.White;
            this.LabelFazerLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFazerLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(62)))), ((int)(((byte)(99)))));
            this.LabelFazerLogin.Location = new System.Drawing.Point(680, 123);
            this.LabelFazerLogin.Name = "LabelFazerLogin";
            this.LabelFazerLogin.Size = new System.Drawing.Size(200, 25);
            this.LabelFazerLogin.TabIndex = 17;
            this.LabelFazerLogin.Text = "Faça seu login aqui";
            this.LabelFazerLogin.Click += new System.EventHandler(this.label3_Click);
            // 
            // LabelSubTitulo
            // 
            this.LabelSubTitulo.AutoSize = true;
            this.LabelSubTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(62)))), ((int)(((byte)(99)))));
            this.LabelSubTitulo.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSubTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelSubTitulo.Location = new System.Drawing.Point(83, 267);
            this.LabelSubTitulo.Name = "LabelSubTitulo";
            this.LabelSubTitulo.Size = new System.Drawing.Size(249, 32);
            this.LabelSubTitulo.TabIndex = 26;
            this.LabelSubTitulo.Text = "Seja Bem Vindo(a)!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1047, 512);
            this.Controls.Add(this.LabelSubTitulo);
            this.Controls.Add(this.LabelEntrarComo);
            this.Controls.Add(this.BoxUsu);
            this.Controls.Add(this.LabelSenha);
            this.Controls.Add(this.LabelUsuario);
            this.Controls.Add(this.CheckManterConectado);
            this.Controls.Add(this.TxTSenha);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.TxTUsu);
            this.Controls.Add(this.LabelFazerLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelTitulo);
            this.Controls.Add(this.LogoCPS);
            this.Controls.Add(this.DesingTelaInicial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DesingTelaInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoCPS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox DesingTelaInicial;
        private System.Windows.Forms.PictureBox LogoCPS;
        private System.Windows.Forms.Label LabelTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelEntrarComo;
        private System.Windows.Forms.ComboBox BoxUsu;
        private System.Windows.Forms.Label LabelSenha;
        private System.Windows.Forms.Label LabelUsuario;
        private System.Windows.Forms.CheckBox CheckManterConectado;
        private System.Windows.Forms.TextBox TxTSenha;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.TextBox TxTUsu;
        private System.Windows.Forms.Label LabelFazerLogin;
        private System.Windows.Forms.Label LabelSubTitulo;
    }
}

