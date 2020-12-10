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

namespace beadando_dwmk81
{
    public partial class UploadUserControl : UserControl
    {
        public UploadUserControl()
        {
            InitializeComponent();
            BookListing();
        }

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

        private void listedSubmitBtn_Click(object sender, EventArgs e)
        {
            Book book = (Book)searchedListBox.SelectedItem;
            book.Amount = Int32.Parse(listedAmountTxtBox.Text) + book.Amount;
            listedAmountTxtBox.Text = "";
        }
    }
}
