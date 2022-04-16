namespace Laboration4.Views
{
    partial class AddItem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.TypeTextBox = new System.Windows.Forms.TextBox();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.PlatformTextBox = new System.Windows.Forms.TextBox();
            this.FormatTextBox = new System.Windows.Forms.TextBox();
            this.GenreTextBox = new System.Windows.Forms.TextBox();
            this.PlaytimeTextBox = new System.Windows.Forms.TextBox();
            this.LanguageTextBox = new System.Windows.Forms.TextBox();
            this.DoneButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(31, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(309, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(558, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Coral;
            this.label4.Location = new System.Drawing.Point(31, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Coral;
            this.label5.Location = new System.Drawing.Point(309, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantity:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Coral;
            this.label6.Location = new System.Drawing.Point(558, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Author:";
            // 
            // IdTextBox
            // 
            this.IdTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.IdTextBox.ForeColor = System.Drawing.Color.Coral;
            this.IdTextBox.Location = new System.Drawing.Point(34, 60);
            this.IdTextBox.Multiline = true;
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(196, 28);
            this.IdTextBox.TabIndex = 6;
            this.IdTextBox.Leave += new System.EventHandler(this.IdTextBox_TextChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.NameTextBox.ForeColor = System.Drawing.Color.Coral;
            this.NameTextBox.Location = new System.Drawing.Point(312, 60);
            this.NameTextBox.Multiline = true;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(196, 28);
            this.NameTextBox.TabIndex = 7;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.PriceTextBox.ForeColor = System.Drawing.Color.Coral;
            this.PriceTextBox.Location = new System.Drawing.Point(561, 56);
            this.PriceTextBox.Multiline = true;
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(196, 28);
            this.PriceTextBox.TabIndex = 8;
            this.PriceTextBox.Leave += new System.EventHandler(this.Price_TextChanged);
            // 
            // TypeTextBox
            // 
            this.TypeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.TypeTextBox.ForeColor = System.Drawing.Color.Coral;
            this.TypeTextBox.Location = new System.Drawing.Point(34, 147);
            this.TypeTextBox.Multiline = true;
            this.TypeTextBox.Name = "TypeTextBox";
            this.TypeTextBox.Size = new System.Drawing.Size(196, 28);
            this.TypeTextBox.TabIndex = 9;
            this.TypeTextBox.Leave += new System.EventHandler(this.TypeTextBox_TextChanged);
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.QuantityTextBox.ForeColor = System.Drawing.Color.Coral;
            this.QuantityTextBox.Location = new System.Drawing.Point(312, 147);
            this.QuantityTextBox.Multiline = true;
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(196, 28);
            this.QuantityTextBox.TabIndex = 10;
            this.QuantityTextBox.Leave += new System.EventHandler(this.Quantity_TextChanged);
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.AuthorTextBox.ForeColor = System.Drawing.Color.Coral;
            this.AuthorTextBox.Location = new System.Drawing.Point(561, 147);
            this.AuthorTextBox.Multiline = true;
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(196, 28);
            this.AuthorTextBox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Coral;
            this.label7.Location = new System.Drawing.Point(31, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Platform:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Coral;
            this.label8.Location = new System.Drawing.Point(309, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Format:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Coral;
            this.label9.Location = new System.Drawing.Point(562, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Genre:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Coral;
            this.label10.Location = new System.Drawing.Point(33, 299);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Playtime (min):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Coral;
            this.label11.Location = new System.Drawing.Point(309, 299);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "Language:";
            // 
            // PlatformTextBox
            // 
            this.PlatformTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.PlatformTextBox.ForeColor = System.Drawing.Color.Coral;
            this.PlatformTextBox.Location = new System.Drawing.Point(34, 235);
            this.PlatformTextBox.Multiline = true;
            this.PlatformTextBox.Name = "PlatformTextBox";
            this.PlatformTextBox.Size = new System.Drawing.Size(196, 28);
            this.PlatformTextBox.TabIndex = 17;
            // 
            // FormatTextBox
            // 
            this.FormatTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.FormatTextBox.ForeColor = System.Drawing.Color.Coral;
            this.FormatTextBox.Location = new System.Drawing.Point(312, 235);
            this.FormatTextBox.Multiline = true;
            this.FormatTextBox.Name = "FormatTextBox";
            this.FormatTextBox.Size = new System.Drawing.Size(196, 28);
            this.FormatTextBox.TabIndex = 18;
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.GenreTextBox.ForeColor = System.Drawing.Color.Coral;
            this.GenreTextBox.Location = new System.Drawing.Point(565, 235);
            this.GenreTextBox.Multiline = true;
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.Size = new System.Drawing.Size(196, 28);
            this.GenreTextBox.TabIndex = 19;
            // 
            // PlaytimeTextBox
            // 
            this.PlaytimeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.PlaytimeTextBox.ForeColor = System.Drawing.Color.Coral;
            this.PlaytimeTextBox.Location = new System.Drawing.Point(34, 318);
            this.PlaytimeTextBox.Multiline = true;
            this.PlaytimeTextBox.Name = "PlaytimeTextBox";
            this.PlaytimeTextBox.Size = new System.Drawing.Size(196, 28);
            this.PlaytimeTextBox.TabIndex = 20;
            this.PlaytimeTextBox.Leave += new System.EventHandler(this.Playtime_TextChanged);
            // 
            // LanguageTextBox
            // 
            this.LanguageTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.LanguageTextBox.ForeColor = System.Drawing.Color.Coral;
            this.LanguageTextBox.Location = new System.Drawing.Point(312, 318);
            this.LanguageTextBox.Multiline = true;
            this.LanguageTextBox.Name = "LanguageTextBox";
            this.LanguageTextBox.Size = new System.Drawing.Size(196, 28);
            this.LanguageTextBox.TabIndex = 21;
            // 
            // DoneButton
            // 
            this.DoneButton.BackColor = System.Drawing.Color.Coral;
            this.DoneButton.FlatAppearance.BorderSize = 0;
            this.DoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoneButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.DoneButton.Location = new System.Drawing.Point(365, 385);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(75, 23);
            this.DoneButton.TabIndex = 22;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = false;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(236, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 32);
            this.label12.TabIndex = 23;
            this.label12.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(514, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 32);
            this.label13.TabIndex = 24;
            this.label13.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(763, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 32);
            this.label14.TabIndex = 25;
            this.label14.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(236, 147);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 32);
            this.label15.TabIndex = 26;
            this.label15.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(514, 147);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(25, 32);
            this.label16.TabIndex = 27;
            this.label16.Text = "*";
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(916, 450);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.LanguageTextBox);
            this.Controls.Add(this.PlaytimeTextBox);
            this.Controls.Add(this.GenreTextBox);
            this.Controls.Add(this.FormatTextBox);
            this.Controls.Add(this.PlatformTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AuthorTextBox);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.TypeTextBox);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddItem";
            this.Text = "Add Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox TypeTextBox;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox PlatformTextBox;
        private System.Windows.Forms.TextBox FormatTextBox;
        private System.Windows.Forms.TextBox GenreTextBox;
        private System.Windows.Forms.TextBox PlaytimeTextBox;
        private System.Windows.Forms.TextBox LanguageTextBox;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}