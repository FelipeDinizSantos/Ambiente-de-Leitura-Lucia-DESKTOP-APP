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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Telauser telauser = new Telauser();
            telauser.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Livros Livros = new Livros();
            Livros.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
