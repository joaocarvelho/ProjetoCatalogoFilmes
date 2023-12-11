
namespace Login
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblNaoCadastrado = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.pcbLogin = new System.Windows.Forms.PictureBox();
            this.chkMostraSenha = new System.Windows.Forms.CheckBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(258, 38);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(89, 29);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "LOGIN";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(186, 103);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(100, 24);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "USUÁRIO";
            // 
            // lblNaoCadastrado
            // 
            this.lblNaoCadastrado.AutoSize = true;
            this.lblNaoCadastrado.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaoCadastrado.Location = new System.Drawing.Point(146, 364);
            this.lblNaoCadastrado.Name = "lblNaoCadastrado";
            this.lblNaoCadastrado.Size = new System.Drawing.Size(140, 18);
            this.lblNaoCadastrado.TabIndex = 2;
            this.lblNaoCadastrado.Text = "Não tem cadastro?";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(192, 184);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(77, 24);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "SENHA";
            // 
            // txbUsuario
            // 
            this.txbUsuario.Location = new System.Drawing.Point(190, 130);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(206, 22);
            this.txbUsuario.TabIndex = 4;
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(190, 211);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PasswordChar = '*';
            this.txbSenha.Size = new System.Drawing.Size(206, 22);
            this.txbSenha.TabIndex = 5;
            // 
            // pcbLogin
            // 
            this.pcbLogin.Image = ((System.Drawing.Image)(resources.GetObject("pcbLogin.Image")));
            this.pcbLogin.Location = new System.Drawing.Point(27, 103);
            this.pcbLogin.Name = "pcbLogin";
            this.pcbLogin.Size = new System.Drawing.Size(138, 116);
            this.pcbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLogin.TabIndex = 6;
            this.pcbLogin.TabStop = false;
            // 
            // chkMostraSenha
            // 
            this.chkMostraSenha.AutoSize = true;
            this.chkMostraSenha.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMostraSenha.Location = new System.Drawing.Point(263, 245);
            this.chkMostraSenha.Name = "chkMostraSenha";
            this.chkMostraSenha.Size = new System.Drawing.Size(133, 20);
            this.chkMostraSenha.TabIndex = 7;
            this.chkMostraSenha.Text = "Mostrar Senha";
            this.chkMostraSenha.UseVisualStyleBackColor = true;
            this.chkMostraSenha.CheckedChanged += new System.EventHandler(this.chkMostraSenha_CheckedChanged);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.Location = new System.Drawing.Point(165, 280);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(121, 41);
            this.btnEntrar.TabIndex = 8;
            this.btnEntrar.Text = "ENTRAR";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(317, 279);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(97, 42);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(140, 385);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(161, 41);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(457, 447);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.chkMostraSenha);
            this.Controls.Add(this.pcbLogin);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.txbUsuario);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblNaoCadastrado);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblNaoCadastrado;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.PictureBox pcbLogin;
        private System.Windows.Forms.CheckBox chkMostraSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCadastrar;
    }
}

