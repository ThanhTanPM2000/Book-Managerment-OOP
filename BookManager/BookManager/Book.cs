using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace BookManager
{
    class Book
    {
        #region định nghĩa dữ liệu
        private string isbn;

        public string Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private string author;

        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        private string publisher;

        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }
        private int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        private ArrayList array = new ArrayList();
        #endregion
        //public string this[int index]
        //{
        //    get
        //    {
        //        if (index >= 0 && index < array.Count)
        //            return (string)array[index];
        //        else
        //            throw new IndexOutOfRangeException();
        //    }
        //    set
        //    {
        //        if (index >= 0 && index < array.Count)
        //            array[index] = value;
        //        else if (index == array.Count)
        //            array.Add(value);
        //        else
        //            throw new IndexOutOfRangeException();
        //    }
        //}

        public void show()
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Publisher: " + Publisher);
            Console.WriteLine("Year: " + Year);
            Console.WriteLine("ISBN: " + Isbn);
            Console.WriteLine("chapter: ");
            for (int i = 0; i < array.Count; i++)
            {
                Console.WriteLine("\t{0} : {1}", i + 1, array[i]);
            }
            Console.WriteLine("----------------------------------------------");
        }

        public void Input()
        {
            Console.Write("Title: ");
            Title = Console.ReadLine();
            Console.Write("Author: ");
            Author = Console.ReadLine();
            Console.Write("Publisher: ");
            Publisher = Console.ReadLine();
            Console.Write("ISBN: ");
            Isbn = Console.ReadLine();
            Console.Write("Year: ");
            Year = int.Parse(Console.ReadLine());
            Console.WriteLine("Input chapter (finished with empty string)");
            string str;
            do
            {
                str = Console.ReadLine();
                if (str.Length > 0)
                    array.Add(str);
            }
            while (str.Length > 0);
        }
    }
}
