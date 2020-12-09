using beadando_dwmk81.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace beadando_dwmk81
{
    public partial class Form1 : Form
    {
        public static List<Book> Store = new List<Book>();
        public static double income = 0;
        public Form1()
        {
            InitializeComponent();
            
            LoadStore();
            SalesUserControl salesUserControl = new SalesUserControl();
            panel1.Controls.Add(salesUserControl);
            salesUserControl.Dock = DockStyle.Fill;
        }

        private void saleBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            SalesUserControl salesUserControl = new SalesUserControl();
            panel1.Controls.Add(salesUserControl);
            salesUserControl.Dock = DockStyle.Fill;

        }

        private void statsBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            StatsUserControl statsUserControl = new StatsUserControl();
            panel1.Controls.Add(statsUserControl);
            statsUserControl.Dock = DockStyle.Fill;
        }

        private void LoadStore()
        {
           
            Store.Clear();
            using (StreamReader sr = new StreamReader("eladasok.csv", Encoding.UTF8))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(';');
                    Book b = new Book();
                    b.Topic = line[0];
                    b.Author = line[1];
                    b.Title = line[2];
                    b.Year = Int32.Parse(line[3]);
                    b.Price = Double.Parse(line[4]);
                    b.Amount = Int32.Parse(line[5]);
                    Store.Add(b);
                }
            }

        }

        public List<Book> GetBooks()
        {
            List<Book> books = new List<Book>();

            using (StreamReader sr = new StreamReader("eladasok.csv", Encoding.UTF8))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(';');
                    Book b = new Book();
                    b.Topic = line[0];
                    b.Author = line[1];
                    b.Title = line[2];
                    b.Year = Int32.Parse(line[3]);
                    b.Price = Double.Parse(line[4]);
                    b.Amount = Int32.Parse(line[5]);
                    books.Add(b);
                }
            }

            return books;
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UploadUserControl uploadUserControl = new UploadUserControl();
            panel1.Controls.Add(uploadUserControl);
            uploadUserControl.Dock = DockStyle.Fill;
        }
    }
}
