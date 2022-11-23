using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Library
    {
        public int Id;
        public string Name;
        public Book[] Books = new Book[0];

        public void AddBook(Book book)
        {
            Array.Resize(ref Books, Books.Length + 1);
            Books[Books.Length - 1] = book;
        }
        public void AddBook(ref Book[] booksArray, Book book)
        {
            Array.Resize(ref booksArray, booksArray.Length + 1);
            booksArray[booksArray.Length - 1] = book;
        }

        public Book[] ShowAllBook()
        {
            return Books;
        }

        public Book[] FindBookById(int id)
        {
            Book[] filteredbooks = new Book[0];
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Id == id)
                {
                    AddBook(ref filteredbooks, Books[i]);
                }
            }
            return filteredbooks;
        }
        public Book[] FindBookByBookCode(string bookcode)
        {
            Book[] filteredbooks = new Book[0];
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].BookCode == bookcode)
                {
                    AddBook(ref filteredbooks, Books[i]);
                }
            }
            return filteredbooks;
        }
    }
}
