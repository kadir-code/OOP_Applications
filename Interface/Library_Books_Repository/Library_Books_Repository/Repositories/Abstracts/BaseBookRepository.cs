using Library_Books_Repository.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Books_Repository.Repositories.Abstracts
{
    public abstract class BaseBookRepository
    {
        public abstract void CreateBook(string name,string description);
        public abstract List<Book> GetBook();
        public abstract void UpdateBook(int id,string name, string description);
        public abstract void DeleteBook(int id);
    }
}
