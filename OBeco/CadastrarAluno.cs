using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBeco
{
    public partial class CadastrarAluno : Form
    {
        public CadastrarAluno()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Close();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "")
            {
                MessageBox.Show("Campo de Nome vazio!!");

            }
            else if (txtEndereco.Text == "")
            {
                MessageBox.Show("Campo de Endereço vazio!!");

            }
            else if (txtSenha.Text == "")
            {
                MessageBox.Show("Campo de Senha vazio!!");

            }
            else if (txtTelefone.Text == "")
            {
                MessageBox.Show("Campo de Telefone vazio!!");

            }
            else if (txtMatricula.Text == "")
            {
                MessageBox.Show("Campo de Matricula vazio!!");

            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDb)\Bookstore;Initial Catalog=biblioteca;Integrated Security=True");
                SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Usuarios]
                   ([Nome]
                   ,[Senha]
                   ,[Matricula]
                   ,[Endereco]
                   ,[Telefone])
                 VALUES
                       ('" + txtLogin.Text + "','" + txtSenha.Text + "','" + txtMatricula.Text + "','" + txtEndereco.Text + "','" + txtTelefone.Text + "') ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Login login = new Login();
                MessageBox.Show("Registrado com Sucesso!");

                this.Close();
                login.Show();
            }
        }
    }
}
