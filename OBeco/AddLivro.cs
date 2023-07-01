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
    public partial class AddLivro : Form
    {
        public AddLivro()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {   
            this.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtTitulo.Text == "")
            {
                MessageBox.Show("Campo de Titulo vazio!!");

            }
            else if (txtAutor.Text == "")
            {
                MessageBox.Show("Campo de Autor vazio!!");

            }
            else if (txtEditora.Text == "")
            {
                MessageBox.Show("Campo de Editora vazio!!");

            }
            else if (txtCategoria.Text == "")
            {
                MessageBox.Show("Campo de Categoria vazio!!");

            }
            else if (txtAno.Text == "")
            {
                MessageBox.Show("Campo de Ano de Publicação vazio!!");

            }
            else
            {   
                int AnoConvertido = int.Parse(txtAno.Text);
                string disponivel = "disponivel";
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDb)\Bookstore;Initial Catalog=biblioteca;Integrated Security=True");
                SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Livros]
                   ([Autor]
                   ,[Titulo]
                   ,[Editora]
                   ,[Ano_Public]
                   ,[Categoria]
                   ,[Disponibilidade])
                 VALUES
                       ('" + txtAutor.Text + "','" + txtTitulo.Text + "','" + txtEditora.Text + "','" + AnoConvertido + "','" + txtCategoria.Text + "','" + disponivel + "') ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Adicionado com Sucesso!");
                Acervo acervo = new Acervo();
                this.Hide();
                acervo.Refresh();

            }




            
        }
    }
}
