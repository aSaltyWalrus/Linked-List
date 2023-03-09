using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1b
{
    class LinkedList<T> where T : IComparable
    {
        private Link<T> list = null; //default value – empty list

        public void AddItem(T item) //add item to front of list
        {
            list = new Link<T>(item, list);
        }

        public string removeItem(T isbn, long num)
        {
            LinkedList<T> newList = new LinkedList<T>();
            Link<T> temp = list;
            string message = "Could not remove " + num + " as it wasn't found in the list.";
            while (temp != null)
            {
                if (!(temp.Data.CompareTo(isbn) == 0))
                    newList.AddItem(temp.Data);
                else
                    message = "Successfully removed " + temp.Data.ToString();
                temp = temp.Next;
            }
            list = newList.list;
            return message;
        }

        public Link<T> Highest()
        {
            Link<T> temp = list;
            Link<T> highest = list;
            while (temp != null)
            {
                if (temp.Data.CompareTo(highest.Data) > 0)
                {
                    highest = temp;
                }
                temp = temp.Next;
            }
            return highest;

        }
        public Link<T> Lowest()
        {
            Link<T> temp = list;
            Link<T> lowest = list;
            while (temp != null)
            {
                if (temp.Data.CompareTo(lowest.Data) < 0)
                {
                    lowest = temp;
                }
                temp = temp.Next;
            }
            return lowest;

        }
        private LinkedList<T> inOrder(LinkedList<T> newList)
        {
            Link<T> temp = list;
            Link<T> currentHighest = Lowest(); //set the current highest value as the smallest value in the list
            while (temp != null)
            {
                if (!(temp.Data.CompareTo(newList.list.Data) >= 0)) //if the current link is not more than or equal to the previous item added to the new list
                {
                    if (temp.Data.CompareTo(currentHighest.Data) > 0) //if the value of the current link is more than the current lowest link
                    {
                        currentHighest = temp;
                    }
                }
                temp = temp.Next;
            }
            newList.AddItem(currentHighest.Data); //append the current highest value
            return newList;
        }

        public LinkedList<T> InOrder()
        {
            LinkedList<T> newList = new LinkedList<T>();
            Link<T> highest = Highest();//get the highest value in the link list
            newList.AddItem(highest.Data);//make the first lnik the highest value
            for (int i = 0; i < NumberOfItems() - 1; i++)//for loop to add re-run the function for every item in the list
            {
                newList = inOrder(newList);
            }
            return newList;
        }


        public string DisplayItems() //write items to string and return
        {
            Link<T> temp = list;
            string buffer = "";
            while (temp != null) //move one link and add data to the buffer
            {
                buffer += temp.Data.ToString();
                temp = temp.Next;
            }
            return buffer;
        }

        public int NumberOfItems() //returns number of items in list
        {
            Link<T> temp = list;
            int count = 0;
            while (temp != null) //move one link and add 1 to count
            {
                count++;
                temp = temp.Next;
            }
            return count;
        }

    }
}
