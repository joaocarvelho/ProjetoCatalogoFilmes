
namespace BuscaFilme
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbFilme = new System.Windows.Forms.TextBox();
            this.chkAssistido = new System.Windows.Forms.CheckBox();
            this.chkFavorito = new System.Windows.Forms.CheckBox();
            this.chkPretendeAssistir = new System.Windows.Forms.CheckBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o filme desejado";
            // 
            // txbFilme
            // 
            this.txbFilme.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFilme.Location = new System.Drawing.Point(89, 97);
            this.txbFilme.Name = "txbFilme";
            this.txbFilme.Size = new System.Drawing.Size(366, 28);
            this.txbFilme.TabIndex = 1;
            // 
            // chkAssistido
            // 
            this.chkAssistido.AutoSize = true;
            this.chkAssistido.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAssistido.Location = new System.Drawing.Point(52, 153);
            this.chkAssistido.Name = "chkAssistido";
            this.chkAssistido.Size = new System.Drawing.Size(118, 23);
            this.chkAssistido.TabIndex = 2;
            this.chkAssistido.Text = "ASSISTIDO";
            this.chkAssistido.UseVisualStyleBackColor = true;
            // 
            // chkFavorito
            // 
            this.chkFavorito.AutoSize = true;
            this.chkFavorito.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFavorito.Location = new System.Drawing.Point(185, 153);
            this.chkFavorito.Name = "chkFavorito";
            this.chkFavorito.Size = new System.Drawing.Size(113, 23);
            this.chkFavorito.TabIndex = 3;
            this.chkFavorito.Text = "FAVORITO";
            this.chkFavorito.UseVisualStyleBackColor = true;
            // 
            // chkPretendeAssistir
            // 
            this.chkPretendeAssistir.AutoSize = true;
            this.chkPretendeAssistir.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPretendeAssistir.Location = new System.Drawing.Point(316, 151);
            this.chkPretendeAssistir.Name = "chkPretendeAssistir";
            this.chkPretendeAssistir.Size = new System.Drawing.Size(199, 23);
            this.chkPretendeAssistir.TabIndex = 4;
            this.chkPretendeAssistir.Text = "PRETENDE ASSISTIR";
            this.chkPretendeAssistir.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(104, 240);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(164, 41);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.Text = "PESQUISAR";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(342, 240);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(97, 41);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(552, 340);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.chkPretendeAssistir);
            this.Controls.Add(this.chkFavorito);
            this.Controls.Add(this.chkAssistido);
            this.Controls.Add(this.txbFilme);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Busca de Filmes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbFilme;
        private System.Windows.Forms.CheckBox chkAssistido;
        private System.Windows.Forms.CheckBox chkFavorito;
        private System.Windows.Forms.CheckBox chkPretendeAssistir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnSair;
    }
}

