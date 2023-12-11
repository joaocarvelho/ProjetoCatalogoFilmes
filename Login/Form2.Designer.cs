
namespace Login
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.chkMostraSenha = new System.Windows.Forms.CheckBox();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblConfirmarSenha = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.pcbCadastro = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.txbConfirmarSenha = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCadastro)).BeginInit();
            this.SuspendLayout();
            // 
            // chkMostraSenha
            // 
            this.chkMostraSenha.AutoSize = true;
            this.chkMostraSenha.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMostraSenha.Location = new System.Drawing.Point(231, 297);
            this.chkMostraSenha.Name = "chkMostraSenha";
            this.chkMostraSenha.Size = new System.Drawing.Size(133, 20);
            this.chkMostraSenha.TabIndex = 12;
            this.chkMostraSenha.Text = "Mostrar Senha";
            this.chkMostraSenha.UseVisualStyleBackColor = true;
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(160, 180);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PasswordChar = '*';
            this.txbSenha.Size = new System.Drawing.Size(206, 22);
            this.txbSenha.TabIndex = 11;
            // 
            // txbUsuario
            // 
            this.txbUsuario.Location = new System.Drawing.Point(160, 99);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(206, 22);
            this.txbUsuario.TabIndex = 10;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(162, 153);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(77, 24);
            this.lblSenha.TabIndex = 9;
            this.lblSenha.Text = "SENHA";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(156, 72);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(100, 24);
            this.lblUsuario.TabIndex = 8;
            this.lblUsuario.Text = "USUÁRIO";
            // 
            // lblConfirmarSenha
            // 
            this.lblConfirmarSenha.AutoSize = true;
            this.lblConfirmarSenha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarSenha.Location = new System.Drawing.Point(159, 232);
            this.lblConfirmarSenha.Name = "lblConfirmarSenha";
            this.lblConfirmarSenha.Size = new System.Drawing.Size(202, 24);
            this.lblConfirmarSenha.TabIndex = 13;
            this.lblConfirmarSenha.Text = "CONFIRMAR SENHA";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(78, 358);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(161, 41);
            this.btnCadastrar.TabIndex = 15;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // pcbCadastro
            // 
            this.pcbCadastro.Image = ((System.Drawing.Image)(resources.GetObject("pcbCadastro.Image")));
            this.pcbCadastro.Location = new System.Drawing.Point(17, 85);
            this.pcbCadastro.Name = "pcbCadastro";
            this.pcbCadastro.Size = new System.Drawing.Size(123, 171);
            this.pcbCadastro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCadastro.TabIndex = 16;
            this.pcbCadastro.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(284, 358);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(97, 42);
            this.btnSair.TabIndex = 17;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // txbConfirmarSenha
            // 
            this.txbConfirmarSenha.Location = new System.Drawing.Point(163, 259);
            this.txbConfirmarSenha.Name = "txbConfirmarSenha";
            this.txbConfirmarSenha.Size = new System.Drawing.Size(203, 22);
            this.txbConfirmarSenha.TabIndex = 18;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(407, 450);
            this.Controls.Add(this.txbConfirmarSenha);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.pcbCadastro);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblConfirmarSenha);
            this.Controls.Add(this.chkMostraSenha);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.txbUsuario);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.Text = "Cadastro";
            ((System.ComponentModel.ISupportInitialize)(this.pcbCadastro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkMostraSenha;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblConfirmarSenha;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.PictureBox pcbCadastro;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txbConfirmarSenha;
    }
}