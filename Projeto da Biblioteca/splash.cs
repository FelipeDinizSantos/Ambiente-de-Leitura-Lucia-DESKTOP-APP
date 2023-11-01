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
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

        private void splash_Load(object sender, EventArgs e)
        {

        }

        private int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label1.Text == "Carregando...")
            {
                label1.Text = "Carregando.";
                count++;
            }
            else if (label1.Text == "Carregando.")
            {
                label1.Text = "Carregando..";
                count++;
            }
            else
            {
                label1.Text = "Carregando...";
                count++;
            }
            if (count >= 6)
            {
                timer1.Enabled = false;
                Form1 form1 = new Form1();
                form1.Show();
                this.Visible = false;

            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
    }

