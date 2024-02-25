using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using BookStor_SoftwareProject.Domain;
using BookStor_SoftwareProject.DA;

namespace BookStor_SoftwareProject.UI
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book B = new Book();
            B.Name = textBox1.Text;
            B.Author = textBox2.Text;
            B.ExistentNumber = textBox3.Text;
            B.Price =Convert.ToDouble( textBox4.Text);


            bool R = BookAD.Add(B);

            if (R == true)
            {
                MessageBox.Show(" Book saved successfuly ");
            }
        }

        private void AddBook_Load(object sender, EventArgs e)
        {

        }
    }
}
