using System;
using System.Collections.Generic;
using System.Text;

namespace Disaheim
{
    public class BookRepository
    {
        private List<Book> books = new List<Book>();
        private Utility utility = new Utility();
      
        public void AddBook (Book book)
        {
            books.Add(book);
        }

        public Book? GetBook (string itemId)
        {
            foreach (Book book in books)
            {
                if (book.ItemId == itemId)
                {  return book; }
            }
            return null;
        }

        public double GetTotalValue ()
        { 
            double total = 0;
            foreach (Book book in books)
            {
                total += utility.GetValueOfBook(book);
            }
            return total;
        }
    }
}

