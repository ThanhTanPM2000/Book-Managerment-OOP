using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            BookList bl = new BookList();
            bl.InputList();
            bl.ShowList();
            Console.ReadLine();
        }
    }
}
