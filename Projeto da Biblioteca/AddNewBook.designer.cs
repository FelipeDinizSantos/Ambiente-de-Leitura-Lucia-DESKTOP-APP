
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewBook));
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
            this.submitBtn.Location = new System.Drawing.Point(868, 711);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(183, 41);
            this.submitBtn.TabIndex = 10;
            this.submitBtn.Text = "Criar";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(324, 126);
            this.nameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(423, 22);
            this.nameBox.TabIndex = 2;
            // 
            // authorBox
            // 
            this.authorBox.Location = new System.Drawing.Point(324, 181);
            this.authorBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.authorBox.Name = "authorBox";
            this.authorBox.Size = new System.Drawing.Size(423, 22);
            this.authorBox.TabIndex = 3;
            // 
            // publishBox
            // 
            this.publishBox.Location = new System.Drawing.Point(324, 238);
            this.publishBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.publishBox.Name = "publishBox";
            this.publishBox.Size = new System.Drawing.Size(423, 22);
            this.publishBox.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(68, 345);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 31);
            this.label6.TabIndex = 18;
            this.label6.Text = "Faixa Etária";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 465);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 31);
            this.label5.TabIndex = 17;
            this.label5.Text = "Data de publicação";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 231);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 31);
            this.label4.TabIndex = 16;
            this.label4.Text = "Editora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 292);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 31);
            this.label3.TabIndex = 15;
            this.label3.Text = "Gênero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 175);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 31);
            this.label2.TabIndex = 14;
            this.label2.Text = "Autor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Título do Livro";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(68, 66);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(66, 31);
            this.label.TabIndex = 26;
            this.label.Text = "ISBN";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ISBNbox
            // 
            this.ISBNbox.Location = new System.Drawing.Point(324, 73);
            this.ISBNbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ISBNbox.Name = "ISBNbox";
            this.ISBNbox.Size = new System.Drawing.Size(423, 22);
            this.ISBNbox.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(680, 53);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
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
            this.genreBox.Location = new System.Drawing.Point(324, 292);
            this.genreBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.genreBox.Name = "genreBox";
            this.genreBox.Size = new System.Drawing.Size(423, 24);
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
            this.ageRangeBox.Location = new System.Drawing.Point(324, 350);
            this.ageRangeBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ageRangeBox.Name = "ageRangeBox";
            this.ageRangeBox.Size = new System.Drawing.Size(423, 24);
            this.ageRangeBox.TabIndex = 6;
            this.ageRangeBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ageRangeBox_KeyPress);
            this.ageRangeBox.Leave += new System.EventHandler(this.ageRangeBox_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(680, 218);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 31;
            this.label8.Text = "*opcional";
            // 
            // publishDateBox
            // 
            this.publishDateBox.Location = new System.Drawing.Point(324, 471);
            this.publishDateBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.publishDateBox.Name = "publishDateBox";
            this.publishDateBox.Size = new System.Drawing.Size(423, 22);
            this.publishDateBox.TabIndex = 8;
            // 
            // sinopseBox
            // 
            this.sinopseBox.Location = new System.Drawing.Point(324, 538);
            this.sinopseBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sinopseBox.Name = "sinopseBox";
            this.sinopseBox.Size = new System.Drawing.Size(423, 146);
            this.sinopseBox.TabIndex = 9;
            this.sinopseBox.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.label9.Location = new System.Drawing.Point(68, 538);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 31);
            this.label9.TabIndex = 34;
            this.label9.Text = "Sinopse";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(680, 518);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 17);
            this.label10.TabIndex = 35;
            this.label10.Text = "*opcional";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(680, 452);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 17);
            this.label11.TabIndex = 36;
            this.label11.Text = "*opcional";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.label12.Location = new System.Drawing.Point(68, 402);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(206, 31);
            this.label12.TabIndex = 37;
            this.label12.Text = "Número de Páginas";
            // 
            // numberPagesBox
            // 
            this.numberPagesBox.Location = new System.Drawing.Point(324, 409);
            this.numberPagesBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numberPagesBox.Name = "numberPagesBox";
            this.numberPagesBox.Size = new System.Drawing.Size(423, 22);
            this.numberPagesBox.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(1403, 490);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 17);
            this.label13.TabIndex = 39;
            this.label13.Text = "*opcional";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(680, 389);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 17);
            this.label14.TabIndex = 40;
            this.label14.Text = "*opcional";
            // 
            // AddNewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 767);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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