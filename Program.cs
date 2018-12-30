using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_task2_day3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" enter Book Title");
            string bookname = Console.ReadLine();

            Console.WriteLine("enter author");
            string author = Console.ReadLine();

            Console.WriteLine("enter price");
            int price = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter noofpages");
            int noofpages = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("order type:");
            string ordertype = Console.ReadLine();
            if (ordertype == "offline")
            {
                book obj = new book(bookname, author, price, noofpages);
                Console.WriteLine(obj.pbookid);
                Console.WriteLine(obj.pbookname);
                Console.WriteLine(obj.pauthor);
                Console.WriteLine(obj.pprice);
                Console.WriteLine(obj.pnoofpages);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("enter size:");
                int size = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter format:");
                string format = Console.ReadLine();
                ebook obj = new ebook(bookname, author, price, noofpages, size, format);
                Console.WriteLine(obj.pbookid);
                Console.WriteLine(obj.pbookname);
                Console.WriteLine(obj.pauthor);
                Console.WriteLine(obj.pprice);
                Console.WriteLine(obj.pnoofpages);
                Console.WriteLine(obj.psize);
                Console.WriteLine(obj.pformat);

            }
            Console.ReadLine();
        }
    }
}
