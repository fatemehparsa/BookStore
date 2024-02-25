using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookStor_SoftwareProject.DA;
using BookStor_SoftwareProject.Domain;

namespace BookStor_SoftwareProject.UI
{
    public partial class BuyBook : Form
    {
        public BuyBook()
        {
            InitializeComponent();
        }

        private void BuyBook_Load(object sender, EventArgs e)
        {
            BookAD h = new BookAD();
            dataGridView1.DataSource = h.GetallBooks();
        }

        private void buy_Click(object sender, EventArgs e)
        {
            incomDA i = new incomDA();
            int n=Convert.ToInt32(textBox1.Text);
            i.add_incom(n);

            MessageBox.Show("Thank you :) ");

        }
    }
}
