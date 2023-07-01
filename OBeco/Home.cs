using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBeco
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            if (!globals.funcionario)
            {
                button1.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            Alunos alunos = new Alunos();
            this.Close(); 
            alunos.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Perfil perfil = new Perfil();
            perfil.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Acervo acervo = new Acervo();
            this.Hide();
            acervo.Show();  
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Close();
            login.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reserva reserva = new Reserva();
            this.Close();  
            reserva.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Emprestimo emprestimo = new Emprestimo();
            this.Close();
            emprestimo.Show();
        }
    }
}
