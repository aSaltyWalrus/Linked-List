using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1b
{
    class Link<T>
    {
        private T data;
        private Link<T> next;

        public Link(T item) //constructor with an item
        {
            this.data = item;
        }
        public Link(T item, Link<T> list) //constructor with item and list
        {
            this.data = item;
            this.next = list;
        }

        public T Data //property for data
        {
            set { this.data = value; }
            get { return this.data; }
        }

        public Link<T> Next //property for next
        {
            set { this.next = value; }
            get { return this.next; }
        }
    }
}
