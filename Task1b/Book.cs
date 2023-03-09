using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1b
{
    class Book : IComparable
    {
        string title, author;
        long isbn;
        public Book(string title, string author, long isbn)
        {
            this.title = title;
            this.author = author;
            this.isbn = isbn;
        }

        public string Title
        {
            set { this.title = value; }
            get { return this.title; }
        }

        public string Author
        {
            set { this.author = value; }
            get { return this.author; }
        }

        public long Isbn
        {
            set { this.isbn = value; }
            get { return this.isbn; }
        }

        override public string ToString()
        {
            return System.Environment.NewLine + "Title : " + title + " Author : " + author + " Isbn : " + isbn;
        }

        public int CompareTo(object obj)
        {
            Book other = (Book)obj;
            return this.isbn.CompareTo(other.isbn);
        }
    }
}
