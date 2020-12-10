using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using beadando_dwmk81.Entities;
using System.Text.RegularExpressions;

namespace beadando_dwmk81
{
    public partial class UploadUserControl : UserControl
    {
        public UploadUserControl()
        {
            InitializeComponent();
            BookListing();
        }

        //új könyv felvitele

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string author = authorTextBox.Text;
            string title = titleTextBox.Text;
            string topic = topicTextBox.Text;
            int year =Int32.Parse(yearTextBox.Text);
            int amount = Int32.Parse(amountTextBox.Text);
            double price = double.Parse(priceTextBox.Text);
            int same = (from x in Form1.Store
                        where author == x.Author && title == x.Title
                        select x.ID).Count();


            if (same==0)
            {
                
                var b = new Book()
                {
                    Author = author,
                    Title=title,
                    Topic=topic,
                    Year=year,
                    Amount=amount,
                    Price=price
                };
                Form1.Store.Add(b);

                authorTextBox.Text = "";
                titleTextBox.Text = "";
                topicTextBox.Text = "";
                yearTextBox.Text = "";
                amountTextBox.Text = "";
                priceTextBox.Text = "";
            }
            else
            {

                MessageBox.Show("We already have this kind of book, please load it from the list.");
            }
        }


        //lista feltöltése
        private void BookListing()
        {
            var titles = from b in Form1.Store
                         where b.Title.ToLower().Contains(textBox1.Text.ToLower())
                         select b;

            searchedListBox.DataSource = titles.ToList();
            searchedListBox.DisplayMember = "Title";
            searchedListBox.ValueMember = "ID";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BookListing();
        }

        //már raktáron tartott könyvek utánpótlása

        private void listedSubmitBtn_Click(object sender, EventArgs e)
        {
            Book book = (Book)searchedListBox.SelectedItem;
            book.Amount = Int32.Parse(listedAmountTxtBox.Text) + book.Amount;
            listedAmountTxtBox.Text = "";
        }

        //Validálások

        private void yearTextBox_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("^[1-2][09][0-9][0-9]$");
            if (regex.IsMatch(yearTextBox.Text))
            {
                e.Cancel = false;
                if (!String.IsNullOrWhiteSpace(yearTextBox.Text))
                    yearTextBox.BackColor = Color.LightGreen;
                else
                    yearTextBox.BackColor = Color.White;
            }
            else
            {
                e.Cancel = true;
                yearTextBox.BackColor = Color.MediumVioletRed;
            }
        }

        private void amountTextBox_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("^[1-9]+[0-9]*$");
            if (regex.IsMatch(amountTextBox.Text))
            {
                e.Cancel = false;
                if (!String.IsNullOrWhiteSpace(amountTextBox.Text))
                    amountTextBox.BackColor = Color.LightGreen;
                else
                    amountTextBox.BackColor = Color.White;
            }
            else
            {
                e.Cancel = true;
                amountTextBox.BackColor = Color.MediumVioletRed;
            }
        }

        private void priceTextBox_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("^[1-9]+[,]?[0-9]*$");
            if (regex.IsMatch(priceTextBox.Text))
            {
                e.Cancel = false;
                if (!String.IsNullOrWhiteSpace(priceTextBox.Text))
                    priceTextBox.BackColor = Color.LightGreen;
                else
                    priceTextBox.BackColor = Color.White;
            }
            else
            {
                e.Cancel = true;
                priceTextBox.BackColor = Color.MediumVioletRed;
            }
        }

        private void authorTextBox_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("^[a-zA-Z.]*$");
            if (regex.IsMatch(authorTextBox.Text))
            {
                e.Cancel = false;
                if (!String.IsNullOrWhiteSpace(authorTextBox.Text))
                    authorTextBox.BackColor = Color.LightGreen;
                else
                    authorTextBox.BackColor = Color.White;
            }
            else
            {
                e.Cancel = true;
                authorTextBox.BackColor = Color.MediumVioletRed;
            }
        }

        private void titleTextBox_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("^[a-zA-Z0-9,?!]*$");
            if (regex.IsMatch(titleTextBox.Text))
            {
                e.Cancel = false;
                if (!String.IsNullOrWhiteSpace(titleTextBox.Text))
                    titleTextBox.BackColor = Color.LightGreen;
                else
                    titleTextBox.BackColor = Color.White;
            }
            else
            {
                e.Cancel = true;
                titleTextBox.BackColor = Color.MediumVioletRed;
            }
        }

        private void topicTextBox_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("^[A-Z][a-z]*$");
            if (regex.IsMatch(topicTextBox.Text))
            {
                e.Cancel = false;
                if (!String.IsNullOrWhiteSpace(topicTextBox.Text))
                    topicTextBox.BackColor = Color.LightGreen;
                else
                    topicTextBox.BackColor = Color.White;
            }
            else
            {
                e.Cancel = true;
                topicTextBox.BackColor = Color.MediumVioletRed;
            }
        }

        private void listedAmountTxtBox_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("^[1-9]+[0-9]*$");
            if (regex.IsMatch(listedAmountTxtBox.Text))
            {
                e.Cancel = false;
                if (!String.IsNullOrWhiteSpace(listedAmountTxtBox.Text))
                    listedAmountTxtBox.BackColor = Color.LightGreen;
                else
                    listedAmountTxtBox.BackColor = Color.White;
            }
            else
            {
                e.Cancel = true;
                listedAmountTxtBox.BackColor = Color.MediumVioletRed;
            }
        }

        private void listedAmountTxtBox_TextChanged(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void authorTextBox_TextChanged(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void topicTextBox_TextChanged(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void yearTextBox_TextChanged(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void amountTextBox_TextChanged(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {
            this.Validate();
        }
    }
}
