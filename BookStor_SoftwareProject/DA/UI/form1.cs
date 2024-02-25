using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStor_SoftwareProject.UI
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            management_log m = new management_log ();
            m.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BrowseinBooks b = new BrowseinBooks();
            b.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            C_Signin s = new C_Signin();
            s.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            C_Login l = new C_Login();
            l.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
