using Library_Books_Repository.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Books_Repository
{
    static class Static_Methods
    {
        public static void CreateGenre(string name)
        {
            Genre genre = new Genre();
            genre.Name = name;
            SeedData.genres.Add(genre);
        }
        public static List<Genre> GetGenre()
        {
            return SeedData.genres.ToList();
        }

        public static int FillBox(TextBox tName,TextBox tDescription,DataGridView dataGridView)
        {
            int id = int.Parse(dataGridView.CurrentRow.Cells["Id"].Value.ToString());
            tName.Text = dataGridView.CurrentRow.Cells["Name"].Value.ToString();
            tDescription.Text = dataGridView.CurrentRow.Cells[""].Value.ToString();
            return id;
        }
    }
}
