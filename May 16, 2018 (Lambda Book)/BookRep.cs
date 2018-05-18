using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace May_16__2018__Lambda_Book_
{
    class BookRep
    {
        public List<Book> GetBook()
        {
            return new List<Book>
            {
            new Book() { Title = "Title 1", Price = 5 },
            new Book() { Title = "Title 2", Price = 7 },
            new Book() { Title = "Title 3", Price = 14 },
            new Book() { Title = "Title 4", Price = 23 },
            new Book() { Title = "Title 5", Price = 100 },
            };

        }
    }

        class Book
        {
            public string Title { get; set; }
            public int Price { get; set; }
        }
    
}
