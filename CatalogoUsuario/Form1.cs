using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogoUsuario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radAssistido.Checked == true)
            pcbFav1.Enabled = true;
            pcbFav2.Enabled = true;
            pcbFav3.Enabled = true;
            pcbFav4.Enabled = true;
            pcbFav5.Enabled = true;
            pcbPre1.Enabled = true;
            pcbPre2.Enabled = true;
            pcbPre3.Enabled = true;
        }

        private void radFavorito_CheckedChanged(object sender, EventArgs e)
        {
            if (radFavorito.Checked == true)
            pcbAss1.Enabled = true;
            pcbAss2.Enabled = true;
            pcbAss3.Enabled = true;
            pcbPre1.Enabled = true;
            pcbPre2.Enabled = true;
            pcbPre3.Enabled = true;
        }

        private void radPretende_CheckedChanged(object sender, EventArgs e)
        {
            if (radPretende.Checked == true)
            pcbFav1.Enabled = true;
            pcbFav2.Enabled = true;
            pcbFav3.Enabled = true;
            pcbFav4.Enabled = true;
            pcbFav5.Enabled = true;
            pcbAss1.Enabled = true;
            pcbAss2.Enabled = true;
            pcbAss3.Enabled = true;
            pcbAss4.Enabled = true;
            pcbAss5.Enabled = true;            
        }

        private void pcbAss1_Click(object sender, EventArgs e)
        {
            Form2 descricao = new Form2();
            descricao.ShowDialog();            
        }

        private void pcbAss2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void pcbAss3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void pcbAss4_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }

        private void pcbAss5_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.ShowDialog();
        }

        private void pcbFav1_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.ShowDialog();
        }

        private void pcbFav2_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.ShowDialog();
        }

        private void pcbFav3_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.ShowDialog();
        }

        private void pcbFav4_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.ShowDialog();
        }

        private void pcbFav5_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.ShowDialog();
        }

        private void pcbPre1_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12();
            form12.ShowDialog();
        }

        private void pcbPre2_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13();
            form13.ShowDialog();
        }

        private void pcbPre3_Click(object sender, EventArgs e)
        {
            Form14 form14 = new Form14();
            form14.ShowDialog();
        }
    }
}
