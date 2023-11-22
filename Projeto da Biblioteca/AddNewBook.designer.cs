
namespace Projeto_da_Biblioteca
{
    partial class AddNewBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.submitBtn = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.authorBox = new System.Windows.Forms.TextBox();
            this.publishBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.ISBNbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.genreBox = new System.Windows.Forms.ComboBox();
            this.ageRangeBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.publishDateBox = new System.Windows.Forms.DateTimePicker();
            this.sinopseBox = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.numberPagesBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(651, 578);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(137, 33);
            this.submitBtn.TabIndex = 10;
            this.submitBtn.Text = "Criar";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(243, 102);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(318, 20);
            this.nameBox.TabIndex = 2;
            // 
            // authorBox
            // 
            this.authorBox.Location = new System.Drawing.Point(243, 147);
            this.authorBox.Name = "authorBox";
            this.authorBox.Size = new System.Drawing.Size(318, 20);
            this.authorBox.TabIndex = 3;
            // 
            // publishBox
            // 
            this.publishBox.Location = new System.Drawing.Point(243, 193);
            this.publishBox.Name = "publishBox";
            this.publishBox.Size = new System.Drawing.Size(318, 20);
            this.publishBox.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Faixa Etária";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Data de publicação";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Editora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Gênero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Autor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Título do Livro";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(51, 54);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(50, 25);
            this.label.TabIndex = 26;
            this.label.Text = "ISBN";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ISBNbox
            // 
            this.ISBNbox.Location = new System.Drawing.Point(243, 59);
            this.ISBNbox.Name = "ISBNbox";
            this.ISBNbox.Size = new System.Drawing.Size(318, 20);
            this.ISBNbox.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(510, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "*opcional";
            // 
            // genreBox
            // 
            this.genreBox.FormattingEnabled = true;
            this.genreBox.Items.AddRange(new object[] {
            "Poesia",
            "Romance",
            "Mistério",
            "Ficção Científica",
            "Fantasia",
            "Horror",
            "Aventura",
            "Drama",
            "Comédia",
            "Ficção Histórica",
            "Não Ficção"});
            this.genreBox.Location = new System.Drawing.Point(243, 237);
            this.genreBox.Name = "genreBox";
            this.genreBox.Size = new System.Drawing.Size(318, 21);
            this.genreBox.TabIndex = 5;
            this.genreBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.genreBox_KeyPress);
            this.genreBox.Leave += new System.EventHandler(this.genreBox_Leave);
            // 
            // ageRangeBox
            // 
            this.ageRangeBox.FormattingEnabled = true;
            this.ageRangeBox.Items.AddRange(new object[] {
            "Livre",
            "10+ ",
            "12+ ",
            "14+ ",
            "16+ ",
            "18+ "});
            this.ageRangeBox.Location = new System.Drawing.Point(243, 284);
            this.ageRangeBox.Name = "ageRangeBox";
            this.ageRangeBox.Size = new System.Drawing.Size(318, 21);
            this.ageRangeBox.TabIndex = 6;
            this.ageRangeBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ageRangeBox_KeyPress);
            this.ageRangeBox.Leave += new System.EventHandler(this.ageRangeBox_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(510, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "*opcional";
            // 
            // publishDateBox
            // 
            this.publishDateBox.Location = new System.Drawing.Point(243, 383);
            this.publishDateBox.Name = "publishDateBox";
            this.publishDateBox.Size = new System.Drawing.Size(318, 20);
            this.publishDateBox.TabIndex = 8;
            // 
            // sinopseBox
            // 
            this.sinopseBox.Location = new System.Drawing.Point(243, 437);
            this.sinopseBox.Name = "sinopseBox";
            this.sinopseBox.Size = new System.Drawing.Size(318, 119);
            this.sinopseBox.TabIndex = 9;
            this.sinopseBox.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.label9.Location = new System.Drawing.Point(51, 437);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 25);
            this.label9.TabIndex = 34;
            this.label9.Text = "Sinopse";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(510, 421);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "*opcional";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(510, 367);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "*opcional";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.label12.Location = new System.Drawing.Point(51, 327);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(168, 25);
            this.label12.TabIndex = 37;
            this.label12.Text = "Número de Páginas";
            // 
            // numberPagesBox
            // 
            this.numberPagesBox.Location = new System.Drawing.Point(243, 332);
            this.numberPagesBox.Name = "numberPagesBox";
            this.numberPagesBox.Size = new System.Drawing.Size(318, 20);
            this.numberPagesBox.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(1052, 398);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 39;
            this.label13.Text = "*opcional";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(510, 316);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 40;
            this.label14.Text = "*opcional";
            // 
            // AddNewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 623);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.numberPagesBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.sinopseBox);
            this.Controls.Add(this.publishDateBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ageRangeBox);
            this.Controls.Add(this.genreBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ISBNbox);
            this.Controls.Add(this.label);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.authorBox);
            this.Controls.Add(this.publishBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddNewBook";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.AddNewBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox authorBox;
        private System.Windows.Forms.TextBox publishBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox ISBNbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox genreBox;
        private System.Windows.Forms.ComboBox ageRangeBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker publishDateBox;
        private System.Windows.Forms.RichTextBox sinopseBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox numberPagesBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}