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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            /*Form2 cadastro = new Form2();
            cadastro.ShowDialog();*/

            new Form2().Show(); //irá abrir a tela de Cadastro do usuário ao clicar no botão "Cadastrar"
            this.Hide();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(); //criando a conexão com banco de dados
            con.ConnectionString = @"Data Source=JOÇO\SQLSERVER;Initial Catalog=Cadastro;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";  //caminho de conexão do banco de dados criado
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open(); // Abre a conexão do banco de dados
            String login = "SELECT * FROM Login WHERE Usuario ='" + txbUsuario.Text + "' AND Senha = '" + txbSenha.Text + "' ";
            cmd = new SqlCommand(login, con);

            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read()==true)
            {
                new Form2().Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Usuário ou senha inválidos! Verifique e tente novamente!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbUsuario.Text = "";
                txbSenha.Text = "";
                txbUsuario.Focus();
            }
        }

        private void chkMostraSenha_CheckedChanged(object sender, EventArgs e)
        {
            if(chkMostraSenha.Checked) //verifica se a caixa de texto está marcada
            {
                txbSenha.PasswordChar = '\0'; //se a caixa estiver selecionada, irá mostrar a senha digitada               
            }
            else
            {
                txbSenha.PasswordChar = '*'; //se a caixa não estiver marcada, vai ocultar a senha com o símbolo ****
            }
        }
    }
}
