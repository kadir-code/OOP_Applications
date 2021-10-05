using Library_Books_Repository.Repositories.Concretes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Books_Repository
{
    public partial class Form1 : Form
    {
        BookRepository bookRepository;
        GenreRepository genreRepository;
        public Form1()
        {
            InitializeComponent();
            bookRepository = new BookRepository();
            genreRepository = new GenreRepository();
        }

        private void btnCreateBook_Click(object sender, EventArgs e)
        {
            bookRepository.CreateBook(txtCreateBookName.Text,txtCreateBookDescription.Text);
            dataGridView1.DataSource = bookRepository.GetBook();
        }
        int id;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Static_Methods.FillBox(txtUpdateBook,txtUpdateDescription,dataGridView1);
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            bookRepository.UpdateBook(id,txtUpdateBook.Text,txtUpdateDescription.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Static_Methods.CreateGenre(txtCGName.Text);
            dataGridView2.DataSource = Static_Methods.GetGenre();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUG.Text= dataGridView2.CurrentRow.Cells["Name"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            genreRepository.UpdateGenre(id,txtUG.Text);
        }
    }
}
