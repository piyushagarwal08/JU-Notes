using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Giraffe
{
    class Book : UsefulTools
    {
        private string title;
        public string author;
        public int pages;
        public static int Counter = 0;
        // Constructor of class 
        public Book(string aTitle,string aAuthor,int aPages)
        {
            Title = aTitle;
            author = aAuthor;
            pages = aPages;
            Counter++;
            
        }

        public string Title
        {
            get { return title; }
            set
            {
                if (value == "Piyush")
                {
                    title = value;
                }
                else
                    title = "Pykid";
            }
            
        }
        public int getSongCount()
        {
            return Counter;
        }
        public void Display()
        {
            Console.WriteLine("Title: " + title + Environment.NewLine +
                "Author: "+author+Environment.NewLine+
                "Page Count: "+pages);
        }
    }
}
