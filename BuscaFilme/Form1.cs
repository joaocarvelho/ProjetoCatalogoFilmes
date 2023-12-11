using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BuscaFilme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }   
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit(); //fecha a tela de pesquisa dos filmes
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {                      
            string filme = txbFilme.Text;
            bool assistido = chkAssistido.Checked;
            bool favorito = chkFavorito.Checked;
            bool pretendo = chkPretendeAssistir.Checked;

            MessageBox.Show("O filme pesquisado foi: " + filme);
            MessageBox.Show("Já assistiu esse filme? " + assistido);
            MessageBox.Show("Colocou nos favoritos? " + favorito);
            MessageBox.Show("Pretende assistir? " + pretendo);
        }
    }
}
