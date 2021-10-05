using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Books_Repository.Repositories.Interfaces
{
    public interface IBaseGenreRepository
    {
        void DeleteGenre(int id);
        void UpdateGenre(int id,string name);
    }
}
