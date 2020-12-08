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
    }
}
