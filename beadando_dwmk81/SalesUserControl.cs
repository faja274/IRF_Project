using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using beadando_dwmk81.Entities;
using System.Globalization;

namespace beadando_dwmk81
{
    public partial class SalesUserControl : UserControl
    {
        
        
        public SalesUserControl()
        {
            InitializeComponent();
            BookListing();
            incomeLbl.Text = "Daily income: " + Form1.income.ToString();

        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BookListing();

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

        private void searchedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Book book = (Book)searchedListBox.SelectedItem;
            string number = book.Amount.ToString();
            amountLbl.Text = "We have " + number.ToString() + " of this book.";
        }

        private void salesBtn_Click(object sender, EventArgs e)
        {
            int dicecount=0;
            Random rnd = new Random();
            int nr1 = rnd.Next(1, 7);
            kocka1.Text = nr1.ToString();
            dicecount = dicecount + nr1;
            int nr2 = rnd.Next(1, 7);
            kocka2.Text = nr2.ToString();
            dicecount = dicecount + nr2;
            int nr3 = rnd.Next(1, 7);
            kocka3.Text = nr3.ToString();
            dicecount = dicecount + nr3;

            Book book = (Book)searchedListBox.SelectedItem;

            if (dicecount==18)
            {
                book.Amount = book.Amount - 1;
                MessageBox.Show("Congratulations! You don't have to pay for this book.");
            }
            else
            {
                Form1.income = Form1.income + book.Price;
                book.Amount = book.Amount - 1;

            }

            incomeLbl.Text = "Daily income: " + Form1.income.ToString();

            if (book.Amount==0)
            {
                Form1.Store.Remove(book);
                BookListing();
                MessageBox.Show("We are out of this book");
            }

            amountLbl.Text= "We have " + book.Amount.ToString() + " of this book.";
        }

        
    }
}
