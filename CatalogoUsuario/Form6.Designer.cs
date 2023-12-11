
namespace CatalogoUsuario
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lblSinopse = new System.Windows.Forms.Label();
            this.lblDuracao = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblDiretor = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.pcbSchindler = new System.Windows.Forms.PictureBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSchindler)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(189, 179);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(457, 238);
            this.textBox5.TabIndex = 34;
            this.textBox5.Text = resources.GetString("textBox5.Text");
            // 
            // lblSinopse
            // 
            this.lblSinopse.AutoSize = true;
            this.lblSinopse.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinopse.Location = new System.Drawing.Point(186, 151);
            this.lblSinopse.Name = "lblSinopse";
            this.lblSinopse.Size = new System.Drawing.Size(93, 22);
            this.lblSinopse.TabIndex = 33;
            this.lblSinopse.Text = "Sinopse:";
            // 
            // lblDuracao
            // 
            this.lblDuracao.AutoSize = true;
            this.lblDuracao.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuracao.Location = new System.Drawing.Point(186, 124);
            this.lblDuracao.Name = "lblDuracao";
            this.lblDuracao.Size = new System.Drawing.Size(185, 22);
            this.lblDuracao.TabIndex = 32;
            this.lblDuracao.Text = "Duração: 3h15min ";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.Location = new System.Drawing.Point(186, 92);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(430, 22);
            this.lblAno.TabIndex = 31;
            this.lblAno.Text = "Data de lançamento: 31 de dezembro de 1993";
            // 
            // lblDiretor
            // 
            this.lblDiretor.AutoSize = true;
            this.lblDiretor.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiretor.Location = new System.Drawing.Point(184, 53);
            this.lblDiretor.Name = "lblDiretor";
            this.lblDiretor.Size = new System.Drawing.Size(244, 22);
            this.lblDiretor.TabIndex = 30;
            this.lblDiretor.Text = "Diretor: Steven Spielberg";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(185, 16);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(251, 22);
            this.lblNome.TabIndex = 29;
            this.lblNome.Text = "Nome: A lista de Schindler";
            // 
            // pcbSchindler
            // 
            this.pcbSchindler.Image = global::CatalogoUsuario.Properties.Resources.Lista_de_Schindler;
            this.pcbSchindler.Location = new System.Drawing.Point(9, 72);
            this.pcbSchindler.Name = "pcbSchindler";
            this.pcbSchindler.Size = new System.Drawing.Size(166, 253);
            this.pcbSchindler.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbSchindler.TabIndex = 35;
            this.pcbSchindler.TabStop = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(524, 16);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(92, 39);
            this.btnVoltar.TabIndex = 36;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(673, 436);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.pcbSchindler);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.lblSinopse);
            this.Controls.Add(this.lblDuracao);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lblDiretor);
            this.Controls.Add(this.lblNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form6";
            this.Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)(this.pcbSchindler)).EndInit();
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
        private System.Windows.Forms.PictureBox pcbSchindler;
        private System.Windows.Forms.Button btnVoltar;
    }
}