using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_task2_day3
{
    class book
    {
        private int bookid;
        private string bookname;
        private string author;
        private int price;
        private int noofpages;
        private static int count = 1000;
        public book(string bookname, string author, int price, int noofpages)
        {
            book.count++;
            this.bookid = book.count;
            this.bookname = bookname;
            this.author = author;
            this.price = price;
            this.noofpages = noofpages;
        }
        public int pbookid
        {
            get
            {
                return this.bookid;
            }
        }
        public string pbookname
        {
            get
            {
                return this.bookname;
            }
        }
        public string pauthor
        {
            get
            {
                return this.author;
            }
        }
        public int pprice
        {
            get
            {
                return this.price;
            }
        }
        public int pnoofpages
        {
            get
            {
                return this.noofpages;
            }
        }
    }
}
