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
    public partial class Reserva : Form
    {
        public Reserva()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Reserva_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bibliotecaDataSet2.Livros'. Você pode movê-la ou removê-la conforme necessário.
            this.livrosTableAdapter1.Fill(this.bibliotecaDataSet2.Livros);
            // TODO: esta linha de código carrega dados na tabela 'bibliotecaDataSet1.Livros'. Você pode movê-la ou removê-la conforme necessário.
            this.livrosTableAdapter.Fill(this.bibliotecaDataSet1.Livros);



            SqlConnection con = new SqlConnection(@"Data Source=(LocalDb)\Bookstore;Initial Catalog=biblioteca;Integrated Security=True");

            SqlCommand cmd;
            SqlDataAdapter adpt;
            DataTable dt;

            adpt = new SqlDataAdapter(@"SELECT [Titulo]
      ,[Ano_Public]

  FROM [dbo].[Livros] WHERE Disponibilidade = 'disponivel' 
", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dtgDisponiveis.DataSource = dt;

            ///////////////////////////////////////
            ///

            SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDb)\Bookstore;Initial Catalog=biblioteca;Integrated Security=True");

            SqlCommand cmd2;
            SqlDataAdapter adpt2;
            DataTable dt2;

            adpt2 = new SqlDataAdapter(@"SELECT [Titulo]
      ,[Ano_Public]

  FROM [dbo].[Livros] WHERE Disponibilidade = 'reservado' 
", con);
            dt2 = new DataTable();
            adpt2.Fill(dt2);
            dtgReservas.DataSource = dt2;

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Close();
            home.Show();
        }

        private void dtgDisponiveis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                DataGridViewRow row = dtgDisponiveis.Rows[e.RowIndex];
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDb)\Bookstore;Initial Catalog=biblioteca;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("update Livros set Disponibilidade = 'reservado' where Titulo=@Titulo", con);
                cmd.Parameters.AddWithValue("Titulo", row.Cells["tituloDataGridViewTextBoxColumn"].Value);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                SqlDataAdapter adpt;
                DataTable dt;

                adpt = new SqlDataAdapter(@"SELECT [Titulo]
      ,[Ano_Public]

  FROM [dbo].[Livros] WHERE Disponibilidade = 'disponivel' 
", con);
                dt = new DataTable();
                adpt.Fill(dt);
                dtgDisponiveis.DataSource = dt;

                SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDb)\Bookstore;Initial Catalog=biblioteca;Integrated Security=True");

                SqlCommand cmd2;
                SqlDataAdapter adpt2;
                DataTable dt2;

                adpt2 = new SqlDataAdapter(@"SELECT [Titulo]
      ,[Ano_Public]

  FROM [dbo].[Livros] WHERE Disponibilidade = 'reservado' 
", con);
                dt2 = new DataTable();
                adpt2.Fill(dt2);
                dtgReservas.DataSource = dt2;
            }
        }

        private void dtgReservas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                DataGridViewRow row = dtgReservas.Rows[e.RowIndex];
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDb)\Bookstore;Initial Catalog=biblioteca;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("update Livros set Disponibilidade = 'disponivel' where Titulo=@Titulo", con);
                cmd.Parameters.AddWithValue("Titulo", row.Cells["titulo2dataGridViewTextBoxColumn2"].Value);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                SqlDataAdapter adpt;
                DataTable dt;

                adpt = new SqlDataAdapter(@"SELECT [Titulo]
      ,[Ano_Public]

  FROM [dbo].[Livros] WHERE Disponibilidade = 'disponivel' 
", con);
                dt = new DataTable();
                adpt.Fill(dt);
                dtgDisponiveis.DataSource = dt;

                SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDb)\Bookstore;Initial Catalog=biblioteca;Integrated Security=True");

                SqlCommand cmd2;
                SqlDataAdapter adpt2;
                DataTable dt2;

                adpt2 = new SqlDataAdapter(@"SELECT [Titulo]
      ,[Ano_Public]

  FROM [dbo].[Livros] WHERE Disponibilidade = 'reservado' 
", con);
                dt2 = new DataTable();
                adpt2.Fill(dt2);
                dtgReservas.DataSource = dt2;
            }
        }
    }
}
