using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookStor_SoftwareProject.Domain;
using BookStor_SoftwareProject.DA;


namespace BookStor_SoftwareProject.UI
{
    public partial class BrowseinBooks : Form
    {
        public BrowseinBooks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Search B = new Search();
            B.Name = textBox1.Text;
            B.Author = textBox2.Text;
            SearchDA s = new SearchDA();
            List<Book> b = new List<Book>();
            b = s.search(B);
            dataGridView1.DataSource = b;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BrowseinBooks_Load(object sender, EventArgs e)
        {

        }
    }
}
