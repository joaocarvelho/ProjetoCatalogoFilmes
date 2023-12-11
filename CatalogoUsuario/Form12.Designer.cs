
namespace CatalogoUsuario
{
    partial class Form12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form12));
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lblSinopse = new System.Windows.Forms.Label();
            this.lblDuracao = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblDiretor = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pcb50tons = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcb50tons)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(221, 219);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(429, 175);
            this.textBox5.TabIndex = 70;
            this.textBox5.Text = resources.GetString("textBox5.Text");
            // 
            // lblSinopse
            // 
            this.lblSinopse.AutoSize = true;
            this.lblSinopse.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinopse.Location = new System.Drawing.Point(218, 191);
            this.lblSinopse.Name = "lblSinopse";
            this.lblSinopse.Size = new System.Drawing.Size(93, 22);
            this.lblSinopse.TabIndex = 69;
            this.lblSinopse.Text = "Sinopse:";
            // 
            // lblDuracao
            // 
            this.lblDuracao.AutoSize = true;
            this.lblDuracao.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuracao.Location = new System.Drawing.Point(218, 164);
            this.lblDuracao.Name = "lblDuracao";
            this.lblDuracao.Size = new System.Drawing.Size(185, 22);
            this.lblDuracao.TabIndex = 68;
            this.lblDuracao.Text = "Duração: 2h05min ";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.Location = new System.Drawing.Point(218, 132);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(414, 22);
            this.lblAno.TabIndex = 67;
            this.lblAno.Text = "Data de lançamento: 2 de fevereiro de 2015 ";
            // 
            // lblDiretor
            // 
            this.lblDiretor.AutoSize = true;
            this.lblDiretor.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiretor.Location = new System.Drawing.Point(216, 93);
            this.lblDiretor.Name = "lblDiretor";
            this.lblDiretor.Size = new System.Drawing.Size(279, 22);
            this.lblDiretor.TabIndex = 66;
            this.lblDiretor.Text = "Diretor: Sam Taylor-Johnson";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(217, 56);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(225, 22);
            this.lblNome.TabIndex = 65;
            this.lblNome.Text = "Nome: 50 tons de cinza";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(553, 27);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(110, 40);
            this.btnVoltar.TabIndex = 72;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // pcb50tons
            // 
            this.pcb50tons.Image = global::CatalogoUsuario.Properties.Resources._50_tons;
            this.pcb50tons.Location = new System.Drawing.Point(24, 76);
            this.pcb50tons.Name = "pcb50tons";
            this.pcb50tons.Size = new System.Drawing.Size(173, 249);
            this.pcb50tons.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb50tons.TabIndex = 71;
            this.pcb50tons.TabStop = false;
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(706, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.pcb50tons);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.lblSinopse);
            this.Controls.Add(this.lblDuracao);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lblDiretor);
            this.Controls.Add(this.lblNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form12";
            this.Text = "Form12";
            
            ((System.ComponentModel.ISupportInitialize)(this.pcb50tons)).EndInit();
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
        private System.Windows.Forms.PictureBox pcb50tons;
        private System.Windows.Forms.Button btnVoltar;
    }
}