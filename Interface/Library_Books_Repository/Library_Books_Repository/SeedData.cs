using Library_Books_Repository.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Books_Repository
{
    static class SeedData
    {
        public static List<Genre> genres = new List<Genre>()
        {
            new Genre{Id=1,Name="best seller"},
            new Genre{Id=2,Name="It"},
            new Genre{Id=3,Name="Classic"},
        };
        public static List<Book> books = new List<Book>()
        {
            new Book{Id=1,Name="oliver twist",Description="dont reat this"},
            new Book{Id=2,Name="Faust",Description="good book"},
            new Book{Id=3,Name="madame bovary",Description="its a book" },
            new Book{Id=4,Name="incognito",Description="has shifts"},
        };
        
    }
}
