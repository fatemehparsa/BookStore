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
    public partial class ManagmentPage : Form
    {
        public ManagmentPage()
        {
            InitializeComponent();
        }

        private void ManagmentPage_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddBook a = new AddBook();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            incomDA i = new incomDA();
            label1.Text = Convert.ToString(i.incom());
        }
    }
}
