using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beadando_dwmk81.Entities
{
    public class Book
    {
        public Guid ID { get; set; }
        public string Topic { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        public DateTime SellDate { get; set; }
    }
}
