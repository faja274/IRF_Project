﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using beadando_dwmk81.Entities;

namespace beadando_dwmk81
{
    public partial class StatsUserControl : UserControl
    {
        public StatsUserControl()
        {
            InitializeComponent();

            var bookTopics = from x in Form1.Store
                             group x by new { x.Topic} into g
                             select new Book()
                             {
                                 Topic=g.Key.Topic,
                                 Amount=(from x in g select x.Amount).Sum()

                             };
            bookBindingSource.DataSource = bookTopics.ToList();
            chart1.DataSource = bookBindingSource;
            chart1.DataBind();
        }

       
    }
}
