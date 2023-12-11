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

namespace Login
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=JOÇO\SQLSERVER;Initial Catalog=Cadastro;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");  //caminho de conexão do banco de dados criado
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txbUsuario.Text == "" && txbSenha.Text == "" && txbConfirmarSenha.Text == "")
                MessageBox.Show("Usuário ou senha estão inválidos! Verifique e tente novamente", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else if (txbConfirmarSenha.Text == txbSenha.Text)
            {
                con.Open();
                string cadastro = "INSERTO INTO Login values('" + txbUsuario + "', '" + txbSenha + "')";
                cmd = new SqlCommand(cadastro, con);
                cmd.ExecuteReader();
                con.Close();

                txbUsuario.Text = ""; txbSenha.Text = ""; txbConfirmarSenha.Text = "";
                MessageBox.Show("Usuário criado com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("As senhas estão diferentes! Verifique e tente novamente", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbSenha.Text = "";
                txbConfirmarSenha.Text = "";
                txbSenha.Focus();
            }
        }
    }
}
