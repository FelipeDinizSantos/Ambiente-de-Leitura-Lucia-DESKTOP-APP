using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_da_Biblioteca
{
    public partial class telainicial1 : Form
    {
        public telainicial1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Telauser telauser = new Telauser();
            telauser.Show();

           
        }

        private void telainicial1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            Livros Telalivros = new Livros();
            Telalivros.Show();

            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Telauser telauser = new Telauser();
            telauser.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Livros Livros = new Livros();
            Livros.Show();

           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.Show();
        }
    }
}
