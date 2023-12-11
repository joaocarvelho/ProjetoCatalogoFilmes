
namespace CatalogoUsuario
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lblSinopse = new System.Windows.Forms.Label();
            this.lblDuracao = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblDiretor = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pcbBorboleta = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBorboleta)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(194, 196);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(387, 191);
            this.textBox5.TabIndex = 22;
            this.textBox5.Text = resources.GetString("textBox5.Text");
            // 
            // lblSinopse
            // 
            this.lblSinopse.AutoSize = true;
            this.lblSinopse.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinopse.Location = new System.Drawing.Point(190, 164);
            this.lblSinopse.Name = "lblSinopse";
            this.lblSinopse.Size = new System.Drawing.Size(93, 22);
            this.lblSinopse.TabIndex = 21;
            this.lblSinopse.Text = "Sinopse:";
            // 
            // lblDuracao
            // 
            this.lblDuracao.AutoSize = true;
            this.lblDuracao.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuracao.Location = new System.Drawing.Point(190, 135);
            this.lblDuracao.Name = "lblDuracao";
            this.lblDuracao.Size = new System.Drawing.Size(185, 22);
            this.lblDuracao.TabIndex = 20;
            this.lblDuracao.Text = "Duração: 1h53min ";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.Location = new System.Drawing.Point(190, 103);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(383, 22);
            this.lblAno.TabIndex = 19;
            this.lblAno.Text = "Data de lançamento: 23 de julho de 2004";
            // 
            // lblDiretor
            // 
            this.lblDiretor.AutoSize = true;
            this.lblDiretor.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiretor.Location = new System.Drawing.Point(188, 64);
            this.lblDiretor.Name = "lblDiretor";
            this.lblDiretor.Size = new System.Drawing.Size(357, 22);
            this.lblDiretor.TabIndex = 18;
            this.lblDiretor.Text = "Diretor: Eric Bress, J. Mackye Gruber";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(186, 27);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(224, 22);
            this.lblNome.TabIndex = 17;
            this.lblNome.Text = "Nome: Efeito Borboleta";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(509, 13);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(98, 37);
            this.btnVoltar.TabIndex = 24;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // pcbBorboleta
            // 
            this.pcbBorboleta.Image = global::CatalogoUsuario.Properties.Resources.efeito_borboleta;
            this.pcbBorboleta.Location = new System.Drawing.Point(13, 57);
            this.pcbBorboleta.Name = "pcbBorboleta";
            this.pcbBorboleta.Size = new System.Drawing.Size(162, 267);
            this.pcbBorboleta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBorboleta.TabIndex = 23;
            this.pcbBorboleta.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(636, 399);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.pcbBorboleta);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.lblSinopse);
            this.Controls.Add(this.lblDuracao);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lblDiretor);
            this.Controls.Add(this.lblNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.pcbBorboleta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lblSinopse;
        private System.Windows.Forms.Label lblDuracao;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblDiretor;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.PictureBox pcbBorboleta;
        private System.Windows.Forms.Button btnVoltar;
    }
}