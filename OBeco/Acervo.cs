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
    public partial class Acervo : Form
    {
        public Acervo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddLivro addLivro = new AddLivro();
            addLivro.Show();
        }

        private void Acervo_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDb)\Bookstore;Initial Catalog=biblioteca;Integrated Security=True");

            SqlCommand cmd;
            SqlDataAdapter adpt;
            DataTable dt;

            adpt = new SqlDataAdapter(@"SELECT [Titulo]
      ,[Autor]
      ,[Editora]
      ,[Ano_Public]
      ,[Categoria]
  FROM [dbo].[Livros]
", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dtgLivros.DataSource = dt;


        }

        private void dtgLivros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           if(e.ColumnIndex == 5)
            {
                DataGridViewRow row = dtgLivros.Rows[e.RowIndex];
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDb)\Bookstore;Initial Catalog=biblioteca;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("Delete from Livros where Titulo=@Titulo", con);
                cmd.Parameters.AddWithValue("Titulo", row.Cells["tituloDataGridViewTextBoxColumn"].Value);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                SqlDataAdapter adpt;
                DataTable dt;

                adpt = new SqlDataAdapter(@"SELECT [Titulo]
      ,[Autor]
      ,[Editora]
      ,[Ano_Public]
      ,[Categoria]
  FROM [dbo].[Livros]
", con);
                dt = new DataTable();
                adpt.Fill(dt);
                dtgLivros.DataSource = dt;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Close();
            home.Show();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDb)\Bookstore;Initial Catalog=biblioteca;Integrated Security=True");

            SqlCommand cmd;
            SqlDataAdapter adpt;
            DataTable dt;

            adpt = new SqlDataAdapter(@"SELECT [Titulo]
      ,[Autor]
      ,[Editora]
      ,[Ano_Public]
      ,[Categoria]
  FROM [dbo].[Livros]
", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dtgLivros.DataSource = dt;
        }
    }
}
