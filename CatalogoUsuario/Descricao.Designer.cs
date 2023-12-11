
namespace CatalogoUsuario
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
            this.pcbMaravilha = new System.Windows.Forms.PictureBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblDiretor = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblDuracao = new System.Windows.Forms.Label();
            this.lblSinopse = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMaravilha)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbMaravilha
            // 
            this.pcbMaravilha.Image = global::CatalogoUsuario.Properties.Resources.mulher_maravilha;
            this.pcbMaravilha.Location = new System.Drawing.Point(33, 46);
            this.pcbMaravilha.Name = "pcbMaravilha";
            this.pcbMaravilha.Size = new System.Drawing.Size(300, 363);
            this.pcbMaravilha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbMaravilha.TabIndex = 0;
            this.pcbMaravilha.TabStop = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(357, 41);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(236, 22);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome: Mulher Maravilha";
            this.lblNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDiretor
            // 
            this.lblDiretor.AutoSize = true;
            this.lblDiretor.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiretor.Location = new System.Drawing.Point(359, 78);
            this.lblDiretor.Name = "lblDiretor";
            this.lblDiretor.Size = new System.Drawing.Size(211, 22);
            this.lblDiretor.TabIndex = 2;
            this.lblDiretor.Text = "Diretor: Patty Jenkins";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.Location = new System.Drawing.Point(361, 117);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(379, 22);
            this.lblAno.TabIndex = 3;
            this.lblAno.Text = "Data de lançamento: 1 de junho de 2017";
            // 
            // lblDuracao
            // 
            this.lblDuracao.AutoSize = true;
            this.lblDuracao.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuracao.Location = new System.Drawing.Point(363, 151);
            this.lblDuracao.Name = "lblDuracao";
            this.lblDuracao.Size = new System.Drawing.Size(185, 22);
            this.lblDuracao.TabIndex = 4;
            this.lblDuracao.Text = "Duração: 2h21min ";
            // 
            // lblSinopse
            // 
            this.lblSinopse.AutoSize = true;
            this.lblSinopse.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinopse.Location = new System.Drawing.Point(363, 185);
            this.lblSinopse.Name = "lblSinopse";
            this.lblSinopse.Size = new System.Drawing.Size(93, 22);
            this.lblSinopse.TabIndex = 9;
            this.lblSinopse.Text = "Sinopse:";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(359, 213);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(429, 227);
            this.textBox5.TabIndex = 10;
            this.textBox5.Text = resources.GetString("textBox5.Text");
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(670, 19);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(89, 44);
            this.btnVoltar.TabIndex = 11;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.lblSinopse);
            this.Controls.Add(this.lblDuracao);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lblDiretor);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.pcbMaravilha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.Text = "Form2";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            ((System.ComponentModel.ISupportInitialize)(this.pcbMaravilha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbMaravilha;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblDiretor;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblDuracao;
        private System.Windows.Forms.Label lblSinopse;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnVoltar;
    }
}