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
    public partial class C_Login : Form
    {
        public int CN;
        public C_Login()
        {
            InitializeComponent();
        }

        private void C_Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login L = new Login();
            L.username = textBox1.Text;
            L.password = textBox2.Text;

            bool res = LoginDA.Realize(L);
            if (res)
            {
                MessageBox.Show(" You are login");
                CN = LoginDA.ID();
                BuyBook b = new BuyBook();
                b.Show();

            }
            else
            {
                MessageBox.Show(" wrong user or pass");
                textBox1.Clear();
                textBox2.Clear();

            }

        }
    }
}
