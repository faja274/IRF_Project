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
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

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
            //kockadobás az ingyenes könyvért

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

            //fizetés és könyv kivezetése

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

            //napi bevétel kimutatása

            incomeLbl.Text = "Daily income: " + Form1.income.ToString();

            //eladási lista frissítése

            int sold = (from x in Form1.Sold
                        where x.Title == book.Title && x.Author == book.Author
                        select x).Count();
            if (sold==0)
            {
                Book newlysold = new Book();
                newlysold.Topic = book.Topic;
                newlysold.Author = book.Author;
                newlysold.Year = book.Year;
                newlysold.Title = book.Title;
                newlysold.Price = book.Price;
                newlysold.Amount = 1;
                Form1.Sold.Add(newlysold);
            }

            else
            {
                foreach (Book item in Form1.Sold)
                {
                    if (item.Title==book.Title && item.Author==book.Author)
                    {
                        item.Amount++;
                    }
                }
            }


            if (book.Amount==0)
            {
                Form1.Store.Remove(book);
                BookListing();
                MessageBox.Show("We are out of this book");
            }

            amountLbl.Text= "We have " + book.Amount.ToString() + " of this book.";
        }

        //kiírás fájlba
        private void dayCloseBtn_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("bookstore.csv");
            sw.WriteLine("TOPIC; AUTHOR; TITLE; YEAR; PRICE; AMOUNT");
            foreach (var book in Form1.Store)
            {
                sw.WriteLine(book.Topic + ';'+book.Author+';'+book.Title+';'+book.Year.ToString()+';'+book.Price.ToString()+';'+book.Amount.ToString());
            }

            sw.Close();


            StreamWriter streamw = new StreamWriter("dailysales.csv");
            streamw.WriteLine("TOPIC; AUTHOR; TITLE; YEAR; PRICE; AMOUNT");
            foreach (var book in Form1.Sold)
            {
                streamw.WriteLine(book.Topic + ';' + book.Author + ';' + book.Title + ';' + book.Year.ToString() + ';' + book.Price.ToString() + ';' + book.Amount.ToString());
            }

            
            streamw.Close();

            Application.Exit();
            
        }
    }
}
