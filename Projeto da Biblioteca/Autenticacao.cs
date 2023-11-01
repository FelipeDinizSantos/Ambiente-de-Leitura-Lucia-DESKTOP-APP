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
    public partial class Autenticacao : Form
    {
        public Autenticacao()
        {
            InitializeComponent();
        }

        private void Autenticacao_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" && txtSenha.Text == "")
            {
                MessageBox.Show("Digite o Usuário !", " Erro");

            }
            else
            {
                if (txtUsuario.Text == "Val" && txtSenha.Text == "val2023")
                {
                    MessageBox.Show("Bem Vindo " + txtUsuario.Text + "!", "Sucesso");
                    telainicial1 Telainicial1 = new telainicial1();
                    Telainicial1.Show();

                    this.Close();
                }

                else
                {
                    MessageBox.Show("Usuário ou Senha Inválidos !");
                }
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
