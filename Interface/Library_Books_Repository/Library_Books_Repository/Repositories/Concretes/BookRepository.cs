using Library_Books_Repository.Entities.Concrete;
using Library_Books_Repository.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Books_Repository.Repositories.Concretes
{
    public class BookRepository : BaseBookRepository
    {
        Book book = new Book();
      
        public override void CreateBook(string name, string description)
        {
            book.Name = name;
            book.Description = description;
            SeedData.books.Add(book);
        }

        public override void DeleteBook(int id)
        {
            
            foreach (var item in SeedData.books)
            {
                if (item.Id==id)
                {
                    SeedData.books.Remove(item);
                }
            }
        }

        public override List<Book> GetBook()
        {
           return SeedData.books.ToList();
        }

        public override void UpdateBook(int id, string name, string description)
        {
            foreach (var item in SeedData.books)
            {
                if (item.Id==id)
                {
                    item.Name = name;
                    item.Description = description;
                }
            }
        }
    }
}
