using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace BookManager
{
    class BookList
    {
        private ArrayList list = new ArrayList();

        public void AddBook()
        {
            Book b = new Book();
            // nhập thông tin
            b.Input();
            //thêm vào danh sách
            list.Add(b);
        }

        ///xuất danh sách
        ///
        public void ShowList()
        {
            foreach (Book b in list)
            {
                b.show();
            }
        }

        public void InputList()
        {
            Console.WriteLine("Amount of Books");
            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                AddBook();
                n--;
            }
        }

    }
}
