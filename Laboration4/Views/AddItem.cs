using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Laboration4.Views
{
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
        }

        List<String> Ids = new List<String>();
        public Boolean flag = false;
        public string Id
        {
            get { return IdTextBox.Text; }
        }

        public string NameofProduct
        {
            get { return NameTextBox.Text; }
        }

        public string Price
        {
            get { return PriceTextBox.Text; }
        }

        public string Type
        {
            get { return TypeTextBox.Text; }
        }

        public string Quantity
        {
            get { return QuantityTextBox.Text; }
        }

        public string Author
        {
            get { return AuthorTextBox.Text; }
        }

        public string Platform
        {
            get { return PlatformTextBox.Text; }
        }

        public string Format
        {
            get { return FormatTextBox.Text; }
        }

        public string Genre
        {
            get { return GenreTextBox.Text; }
        }

        public string Playtime
        {
            get { return PlaytimeTextBox.Text; }
        }

        public string Language
        {
            get { return LanguageTextBox.Text; }
        }

        public void GetIdList(List<String> Id)
        {
            Ids = Id;

        }

        private void IdTextBox_TextChanged(object sender, EventArgs e)
        {
            if ((System.Text.RegularExpressions.Regex.IsMatch(IdTextBox.Text, "[^0-9]")))
            {
                MessageBox.Show("Please enter only positive numbers.");
                IdTextBox.Text = IdTextBox.Text.Remove(IdTextBox.Text.Length - IdTextBox.Text.Length);
            }

            foreach (String Id in Ids)
            {
                if (Id == IdTextBox.Text)
                {
                    MessageBox.Show("Please enter new Id, this one is already taken.");
                    IdTextBox.Text = IdTextBox.Text.Remove(IdTextBox.Text.Length - IdTextBox.Text.Length);
                }
            }
        }

        private void Price_TextChanged(object sender, EventArgs e)
        {
            if ((System.Text.RegularExpressions.Regex.IsMatch(PriceTextBox.Text, "[^0-9]")))
            {
                MessageBox.Show("Please enter only positive numbers.");
                PriceTextBox.Text = PriceTextBox.Text.Remove(PriceTextBox.Text.Length - PriceTextBox.Text.Length);
            }
        }

        private void Quantity_TextChanged(object sender, EventArgs e)
        {
            if ((System.Text.RegularExpressions.Regex.IsMatch(QuantityTextBox.Text, "[^0-9]")))
            {
                MessageBox.Show("Please enter only positive numbers.");
                QuantityTextBox.Text = QuantityTextBox.Text.Remove(QuantityTextBox.Text.Length - QuantityTextBox.Text.Length);
            }
        }

        private void Playtime_TextChanged(object sender, EventArgs e)
        {
            if ((System.Text.RegularExpressions.Regex.IsMatch(PlaytimeTextBox.Text, "[^0-9]")))
            {
                MessageBox.Show("Please enter only positive numbers.");
                PlaytimeTextBox.Text = PlaytimeTextBox.Text.Remove(PlaytimeTextBox.Text.Length - PlaytimeTextBox.Text.Length);
            }
        }

        private void TypeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (TypeTextBox.Text != "Book" && TypeTextBox.Text != "Game" && TypeTextBox.Text != "Film")
            {
                MessageBox.Show("Wrong type, please try again.");
                if (TypeTextBox.Text.Length > 0)
                    TypeTextBox.Text = TypeTextBox.Text.Remove(TypeTextBox.Text.Length - TypeTextBox.Text.Length);
            }
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(NameTextBox.Text) || String.IsNullOrEmpty(PriceTextBox.Text) || String.IsNullOrEmpty(IdTextBox.Text) || String.IsNullOrEmpty(TypeTextBox.Text)
                || String.IsNullOrEmpty(QuantityTextBox.Text))
            {
                MessageBox.Show("Please Finish the obligatory fields");
            }
            else
            {
                flag = true;
                Close();
            }
        }
    }
}
