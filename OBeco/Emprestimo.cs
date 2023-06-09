﻿using System;
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
    public partial class Emprestimo : Form
    {
        public Emprestimo()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgLivros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                DataGridViewRow row = dtgDisponiveis.Rows[e.RowIndex];
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDb)\Bookstore;Initial Catalog=biblioteca;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("update Livros set Disponibilidade = 'emprestado' where Titulo=@Titulo", con);
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

  FROM [dbo].[Livros] WHERE Disponibilidade = 'emprestado' 
", con);
                dt2 = new DataTable();
                adpt2.Fill(dt2);
                dtgDevolver.DataSource = dt2;
            }

        }

        private void Emprestimo_Load(object sender, EventArgs e)
        {

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

  FROM [dbo].[Livros] WHERE Disponibilidade = 'emprestado' 
", con);
            dt2 = new DataTable();
            adpt2.Fill(dt2);
            dtgDevolver.DataSource = dt2;


        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Close();
            home.Show();
        }

        private void dtgDevolver_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                DataGridViewRow row = dtgDevolver.Rows[e.RowIndex];
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

  FROM [dbo].[Livros] WHERE Disponibilidade = 'emprestado' 
", con);
                dt2 = new DataTable();
                adpt2.Fill(dt2);
                dtgDevolver.DataSource = dt2;
            }
        }
    }
}
