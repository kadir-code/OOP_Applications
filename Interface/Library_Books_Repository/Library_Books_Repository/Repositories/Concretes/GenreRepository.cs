using Library_Books_Repository.Entities.Concrete;
using Library_Books_Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Books_Repository.Repositories.Concretes
{
    public class GenreRepository : IBaseGenreRepository
    {
        Genre genre = new Genre();
        public void DeleteGenre(int id)
        {
            foreach (var item in SeedData.genres)
            {
                if (item.Id==id)
                {
                    SeedData.genres.Remove(item);
                }
            }
        }

        public void UpdateGenre(int id, string name)
        {
            foreach (var item in SeedData.genres)
            {
                if (item.Id==id)
                {
                    genre.Name = name;
                }
            }
        }
    }
}
