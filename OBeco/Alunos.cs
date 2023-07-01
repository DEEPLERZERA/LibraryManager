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

namespace OBeco
{
    public partial class Alunos : Form
    {
        public Alunos()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Alunos_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDb)\Bookstore;Initial Catalog=biblioteca;Integrated Security=True");

            SqlCommand cmd;
            SqlDataAdapter adpt;
            DataTable dt;

            adpt = new SqlDataAdapter(@"SELECT [Nome]
      ,[Matricula]
      ,[Telefone]
  FROM [dbo].[Usuarios]
", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dtgAlunos.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                    }

        private void dtgAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Close();
            home.Show();
        }
    }
}
