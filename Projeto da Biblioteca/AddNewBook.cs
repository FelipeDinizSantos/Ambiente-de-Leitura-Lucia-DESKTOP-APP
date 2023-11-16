using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projeto_da_Biblioteca
{
    public partial class AddNewBook : Form
    {
        public AddNewBook()
        {
            InitializeComponent();
        }
        private void clearTextBoxes(TextBox[] textBoxes)
        {
            foreach(TextBox textBox in textBoxes)
            {
                textBox.Text = String.Empty;
            };
        }

        private void clearComboBoxes(ComboBox[] comboBoxes)
        {
            foreach (ComboBox comboBox in comboBoxes)
            {
                comboBox.Text = String.Empty;
            };
        }

        private int getIdAgeRange(string ageRange)
        {
            switch (ageRange) 
            {
                case "Livre":
                    return 1;
                case "10+":
                    return 2;
                case "12+":
                    return 3;
                case "14+":
                    return 4;
                case "16+":
                    return 5;
                case "18+":
                    return 6;
                default: 
                    return 0;
            }
        }
        private int getIdGenre(string genrer)
        {
            switch (genrer) 
            {
                case "Poesia":
                    return 1;
                case "Romance":
                    return 2;
                case "Mistério":
                    return 3;
                case "Ficção Científica":
                    return 4;
                case "Fantasia":
                    return 5;
                case "Horror":
                    return 6;
                case "Aventura":
                    return 7;
                case "Drama":
                    return 8;
                case "Comédia":
                    return 9;
                case "Ficção Histórica":
                    return 10;
                case "Não Ficção":
                    return 11;
                default:
                    return 0;
            }
        }

        private string isProvided(string text)
        {

            if (string.IsNullOrEmpty(text))
            {
                return "Não fornecido";
            }
            return text;
        }

        private string treatISBN(string ISBN) 
        { 
            string treatIsbn = ISBN.Replace("-", "");
            return treatIsbn;
        }

        private string formatDate(DateTime date)
        {
            string mySqlDate = date.ToString("yyyy-MM-dd");
            publishDateBox.Value = DateTime.Now.Date;
            return mySqlDate;
        }

        private void checkRequiredFieldsTextBox(TextBox[] textBoxes)
        {
            foreach (TextBox textBox in textBoxes)
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    throw new ArgumentException("Preencha todos os campos obrigatórios");
                }
            };
        }

        private void checkRequiredFieldsComboBox(ComboBox[] comboBoxes)
        {
            foreach (ComboBox comboBox in comboBoxes)
            {
                if (string.IsNullOrEmpty(comboBox.Text))
                {
                    throw new ArgumentException("Preencha todos os campos obrigatórios");
                }
            };
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost; database=db_biblioteca; uid=root; pwd=c662943d78";
            MySqlConnection mySqlConnection = new MySqlConnection(connection);

            try
            {
                TextBox[] textBoxes = { nameBox, authorBox };
                ComboBox[] comboBoxes = { genreBox, ageRangeBox };
                checkRequiredFieldsTextBox(textBoxes);
                checkRequiredFieldsComboBox(comboBoxes);

                if (publishDateBox.Value.Date == DateTime.Now.Date)
                {
                    mySqlConnection.Open();

                    string sqlString = "insert into tb_livro (titulo, autor, ISBN, editora, id_faixaEtaria, sinopse, numeroPaginas) values (@nome, @autor, @ISBN, @editora, @faixaEtaria, @sinopse, @numeroPaginas)";
                    MySqlCommand tbLivroCommand = new MySqlCommand(sqlString, mySqlConnection);

                    tbLivroCommand.Parameters.AddWithValue("@nome", nameBox.Text);
                    tbLivroCommand.Parameters.AddWithValue("@autor", authorBox.Text);
                    tbLivroCommand.Parameters.AddWithValue("@ISBN", treatISBN(isProvided(ISBNbox.Text)));
                    tbLivroCommand.Parameters.AddWithValue("@editora", isProvided(publishBox.Text));
                    tbLivroCommand.Parameters.AddWithValue("@faixaEtaria", getIdAgeRange(ageRangeBox.SelectedItem.ToString().Trim()));
                    tbLivroCommand.Parameters.AddWithValue("@sinopse", isProvided(sinopseBox.Text));
                    tbLivroCommand.Parameters.AddWithValue("@numeroPaginas", isProvided(numberPagesBox.Text.ToString()));

                    int affectedLinesLivro = tbLivroCommand.ExecuteNonQuery();

                    if (affectedLinesLivro > 0)
                    {
                        long livroId = tbLivroCommand.LastInsertedId;

                        string tbLivroCategoriaSqlString = "insert into tb_livroCategoria(id_livro, id_categoria) values(@livroId, @categoriaId)";
                        MySqlCommand tbLivroCategoriaCommand = new MySqlCommand(tbLivroCategoriaSqlString, mySqlConnection);

                        tbLivroCategoriaCommand.Parameters.AddWithValue("@livroId", livroId);
                        tbLivroCategoriaCommand.Parameters.AddWithValue("@categoriaId", getIdGenre(genreBox.SelectedItem.ToString()));

                        int affectedLinesLivroCategoria = tbLivroCategoriaCommand.ExecuteNonQuery();

                        if (affectedLinesLivroCategoria > 0)
                        {
                            MessageBox.Show("Cadastro realizado com sucesso!", "SUCESSO");
                        }
                        else
                        {
                            MessageBox.Show("Falha ao realizar o cadastro!", "ERRO");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Falha ao realizar o cadastro!", "ERRO");
                    }
                }
                else
                {
                    mySqlConnection.Open();

                    string sqlString = "insert into tb_livro (titulo, autor, ISBN, editora, dataPublicacao, id_faixaEtaria, sinopse, numeroPaginas) values (@nome, @autor, @ISBN, @editora, @dataPublicacao, @faixaEtaria, @sinopse, @numeroPaginas)";
                    MySqlCommand tbLivroCommand = new MySqlCommand(sqlString, mySqlConnection);

                    tbLivroCommand.Parameters.AddWithValue("@nome", nameBox.Text);
                    tbLivroCommand.Parameters.AddWithValue("@autor", authorBox.Text);
                    tbLivroCommand.Parameters.AddWithValue("@ISBN", treatISBN(isProvided(ISBNbox.Text)));
                    tbLivroCommand.Parameters.AddWithValue("@editora", isProvided(publishBox.Text));
                    tbLivroCommand.Parameters.AddWithValue("@dataPublicacao", formatDate(publishDateBox.Value));
                    tbLivroCommand.Parameters.AddWithValue("@faixaEtaria", getIdAgeRange(ageRangeBox.SelectedItem.ToString().Trim()));
                    tbLivroCommand.Parameters.AddWithValue("@sinopse", isProvided(sinopseBox.Text));
                    tbLivroCommand.Parameters.AddWithValue("@numeroPaginas", isProvided(numberPagesBox.Text.ToString()));

                    int affectedLinesLivro = tbLivroCommand.ExecuteNonQuery();

                    if (affectedLinesLivro > 0)
                    {
                        long livroId = tbLivroCommand.LastInsertedId;

                        string tbLivroCategoriaSqlString = "insert into tb_livroCategoria(id_livro, id_categoria) values(@livroId, @categoriaId)";
                        MySqlCommand tbLivroCategoriaCommand = new MySqlCommand(tbLivroCategoriaSqlString, mySqlConnection);

                        tbLivroCategoriaCommand.Parameters.AddWithValue("@livroId", livroId);
                        tbLivroCategoriaCommand.Parameters.AddWithValue("@categoriaId", getIdGenre(genreBox.SelectedItem.ToString()));

                        int affectedLinesLivroCategoria = tbLivroCategoriaCommand.ExecuteNonQuery();

                        if (affectedLinesLivroCategoria > 0)
                        {
                            MessageBox.Show("Cadastro realizado com sucesso!", "SUCESSO");
                        }
                        else
                        {
                            MessageBox.Show("Falha ao realizar o cadastro!", "ERRO");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Falha ao realizar o cadastro!", "ERRO");
                    }
                }

                TextBox[] textBoxesArray = { nameBox, authorBox, publishBox, ISBNbox, numberPagesBox };
                ComboBox[] comboBoxesArray = { ageRangeBox, genreBox };
                sinopseBox.Text = String.Empty;
                clearTextBoxes(textBoxesArray);
                clearComboBoxes(comboBoxesArray);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "ERRO");
            }
            finally
            {
                mySqlConnection.Close();
            }
        }

        private void genreBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            genreBox.Text = String.Empty;
        }

        private void ageRangeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ageRangeBox.Text = String.Empty;
        }

        private void genreBox_Leave(object sender, EventArgs e)
        {
            if(genreBox.Text.Length < 1)
            {
                genreBox.Text = String.Empty;
            }
        }

        private void ageRangeBox_Leave(object sender, EventArgs e)
        {
            if (ageRangeBox.Text.Length < 1)
            {
                ageRangeBox.Text = String.Empty;
            }
        }
    }
}
