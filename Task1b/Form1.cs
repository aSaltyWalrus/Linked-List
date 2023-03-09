using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1b
{
    public partial class Form1 : Form
    {
        LinkedList<Book> List = new LinkedList<Book>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            long isbn = 0;
            bool isbnValid = false;
            if (titleTextbox.Text != "" && authorTextbox.Text != "" && isbnTextbox.Text != "") //if data has been added to all fields
            {
                try //check if isbn inserted is a number
                {
                    isbn = long.Parse(isbnTextbox.Text);
                    isbnValid = true;
                }
                catch
                {
                    outputLabel.Text = "Could not add book as ISBN inserted is not a number";
                }
                if (isbnValid)
                {
                    List.AddItem(new Book(titleTextbox.Text, authorTextbox.Text, isbn));
                    outputLabel.Text = "Added Book: Title : " + titleTextbox.Text + " Author : " + authorTextbox.Text + " Isbn : " + isbnTextbox.Text;
                    titleTextbox.Text = "";
                    authorTextbox.Text = "";
                    isbnTextbox.Text = "";
                }
            }
            else
                outputLabel.Text = "Could not add book as 1 or more fields are empty";
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "Current List: " + List.DisplayItems();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            long isbn = 0;
            bool isbnValid = false;
            try //check if isbn inserted is a number
            {
                isbn = long.Parse(isbnTextbox2.Text);
                isbnValid = true;
            }
            catch
            {
                outputLabel.Text = "Could not remove book as ISBN inserted is not a number";
            }
            if (isbnValid)
            {
                outputLabel.Text = List.removeItem(new Book("", "", isbn), isbn);
                isbnTextbox2.Text = "";
            }
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            if (!(List.NumberOfItems() == 0))
            {
                List = List.InOrder();
                outputLabel.Text = "List has been ordered by ascending ISBN";
            }
            else
                outputLabel.Text = "Could not sort list as there are no items in it";
        }
    }
}
