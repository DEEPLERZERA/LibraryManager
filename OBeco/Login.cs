using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OBeco
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtLogin.Text == "")
            {
                MessageBox.Show("Campo de Login vazio!!");
            }else if(txtSenha.Text == "")
            {
                MessageBox.Show("Campo de Senha vazio!!");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDb)\Bookstore;Initial Catalog=biblioteca;Integrated Security=True");


                    SqlCommand cmd = new SqlCommand("select * from Usuarios where Nome = @Nome and Senha = @Senha ", con);
                    cmd.Parameters.AddWithValue("@Nome", txtLogin.Text);
                    cmd.Parameters.AddWithValue("@Senha", txtSenha.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    SqlCommand cmd2 = new SqlCommand("select * from Funcionario where Nome = @NomeFunc and Senha = @SenhaFunc ", con);
                    cmd2.Parameters.AddWithValue("@NomeFunc", txtLogin.Text);
                    cmd2.Parameters.AddWithValue("@SenhaFunc", txtSenha.Text);
                    SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                    DataTable dt2 = new DataTable();
                    da2.Fill(dt2);

                    if (dt.Rows.Count > 0)
                    {
                        globals.nome_login = dt.Rows[0]["Nome"].ToString();
                        globals.matricula_login = dt.Rows[0]["Matricula"].ToString();
                        globals.endereco_login = dt.Rows[0]["Endereco"].ToString();
                        globals.telefone_login = dt.Rows[0]["Telefone"].ToString();
                        globals.funcionario = false;
                        Home home = new Home();
                        this.Hide();
                        home.Show();

                    }
                    else if(dt2.Rows.Count > 0)
                    {
                        globals.nome_login = dt2.Rows[0]["Nome"].ToString();
                        globals.numeroID_login = dt2.Rows[0]["Numero_ID"].ToString();
                        globals.endereco_login = dt2.Rows[0]["Endereco"].ToString();
                        globals.telefone_login = dt2.Rows[0]["Telefone"].ToString();
                        globals.funcionario = true;
                        Home home = new Home();
                        this.Hide();
                        home.Show();
                    }
                    else
                    {
                        MessageBox.Show("Login ou Senha inválidos!");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CadastrarFunc cadastrar = new CadastrarFunc();
            this.Hide();
            cadastrar.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastrarAluno cadastrar = new CadastrarAluno();
            this.Hide();
            cadastrar.Show();
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
