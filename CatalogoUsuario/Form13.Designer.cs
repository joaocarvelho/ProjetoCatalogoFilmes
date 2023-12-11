
namespace CatalogoUsuario
{
    partial class Form13
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form13));
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lblSinopse = new System.Windows.Forms.Label();
            this.lblDuracao = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblDiretor = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pcbCapitain = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCapitain)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(219, 219);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(429, 175);
            this.textBox5.TabIndex = 76;
            this.textBox5.Text = resources.GetString("textBox5.Text");
            // 
            // lblSinopse
            // 
            this.lblSinopse.AutoSize = true;
            this.lblSinopse.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinopse.Location = new System.Drawing.Point(216, 191);
            this.lblSinopse.Name = "lblSinopse";
            this.lblSinopse.Size = new System.Drawing.Size(93, 22);
            this.lblSinopse.TabIndex = 75;
            this.lblSinopse.Text = "Sinopse:";
            // 
            // lblDuracao
            // 
            this.lblDuracao.AutoSize = true;
            this.lblDuracao.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuracao.Location = new System.Drawing.Point(216, 164);
            this.lblDuracao.Name = "lblDuracao";
            this.lblDuracao.Size = new System.Drawing.Size(185, 22);
            this.lblDuracao.TabIndex = 74;
            this.lblDuracao.Text = "Duração: 2h04min ";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.Location = new System.Drawing.Point(216, 132);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(390, 22);
            this.lblAno.TabIndex = 73;
            this.lblAno.Text = "Data de lançamento: 7 de março de 2019 ";
            // 
            // lblDiretor
            // 
            this.lblDiretor.AutoSize = true;
            this.lblDiretor.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiretor.Location = new System.Drawing.Point(214, 93);
            this.lblDiretor.Name = "lblDiretor";
            this.lblDiretor.Size = new System.Drawing.Size(311, 22);
            this.lblDiretor.TabIndex = 72;
            this.lblDiretor.Text = "Diretor: Anna Boden, Ryan Fleck";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(215, 56);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(202, 22);
            this.lblNome.TabIndex = 71;
            this.lblNome.Text = "Nome: Capitã Marvel";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(548, 29);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(100, 38);
            this.btnVoltar.TabIndex = 77;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // pcbCapitain
            // 
            this.pcbCapitain.Image = global::CatalogoUsuario.Properties.Resources.capitã_marvel;
            this.pcbCapitain.Location = new System.Drawing.Point(39, 94);
            this.pcbCapitain.Name = "pcbCapitain";
            this.pcbCapitain.Size = new System.Drawing.Size(157, 227);
            this.pcbCapitain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCapitain.TabIndex = 78;
            this.pcbCapitain.TabStop = false;
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(676, 427);
            this.Controls.Add(this.pcbCapitain);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.lblSinopse);
            this.Controls.Add(this.lblDuracao);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lblDiretor);
            this.Controls.Add(this.lblNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form13";
            this.Text = "Form13";
            ((System.ComponentModel.ISupportInitialize)(this.pcbCapitain)).EndInit();
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
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox pcbCapitain;
    }
}