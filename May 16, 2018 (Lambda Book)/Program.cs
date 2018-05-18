using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace May_16__2018__Lambda_Book_
{
    class Program
    {
        public static void Main(string[] args)
        {
            //use var here because this list has string and int
            var books = new BookRep().GetBook();

            //lambda
            var cheapbooks = books.FindAll(book => book.Price < 10);

            //2 line is method long way
            //var cheapbooks = books.FindAll(cheapbook);

            foreach (var book in cheapbooks)
            {
                Console.WriteLine(book.Title);
            }
            Console.ReadLine();
        }
        //public static bool cheapbook(Book book)
        //{
        //    return book.Price < 10;
        //}
    }
}

