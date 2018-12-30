using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_task2_day3
{
    class ebook:book
    {
        private int size;
        private string format;
        public ebook(string bookname, string author, int price, int noofpages, int size, string format) : base(bookname, author, price, noofpages)
        {
            this.size = size;
            this.format = format;
            Console.WriteLine("customer online object constructor");
        }
        public int psize
        {
            get
            {
                return this.size;
            }
        }
        public string pformat
        {
            get
            {
                return this.format;
            }
        }
    }
}
