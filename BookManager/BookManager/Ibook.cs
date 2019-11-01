using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager
{
    interface IBook
    {
        //string this[int index]
        //{
        //    get;
        //    set;
        //}

        string Title
        {
            get;
            set;
        }

        string Author
        {
            get;
            set;
        }

        string Publisher
        {
            get;
            set;
        }

        string Isbn
        {
            get;
            set;
        }

        int Year
        {
            get;
            set;
        }

        void show();
    }
}
