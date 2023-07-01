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
using System.Data;

namespace OBeco
{
    public partial class CadastrarFunc : Form
    {
        public CadastrarFunc()
        {
            InitializeComponent();
        }

        private void Cadastrar_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtLogin.Text == "")
            {
                MessageBox.Show("Campo de Nome vazio!!");

            }
            else if (txtEndereco.Text == "")
            {
                MessageBox.Show("Campo de Endereço vazio!!");

            }
            else if(txtSenha.Text == "")
            {
                MessageBox.Show("Campo de Senha vazio!!");

            }
            else if(txtTelefone.Text == "")
            {
                MessageBox.Show("Campo de Telefone vazio!!");

            }
            else if(txtID.Text == "")
            {
                MessageBox.Show("Campo de ID vazio!!");

            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDb)\Bookstore;Initial Catalog=biblioteca;Integrated Security=True");
                SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Funcionario]
                       ([Nome]
                       ,[Senha]
                       ,[Endereco]
                       ,[Telefone]
                       ,[Numero_ID])
                 VALUES
                       ('"+ txtLogin.Text + "','"+ txtSenha.Text +"','"+ txtEndereco.Text +"','"+ txtTelefone.Text + "','"+ txtID.Text +"') ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Login login = new Login();
                MessageBox.Show("Registrado com Sucesso!");

                this.Hide();
                login.Show();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Close();
            login.Show();
        }
    }
}
