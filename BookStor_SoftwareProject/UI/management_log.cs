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
    public partial class management_log : Form
    {
        public int CN;
        public management_log()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Managers_log L = new Managers_log();
            L.Username = textBox1.Text;
            L.password = textBox2.Text;
            L.kind = comboBox1.SelectedIndex;

            if(comboBox1.SelectedIndex==0)
            {
                bool res = Managers_logDA.Realize(L);
                if (res)
                {
                    MessageBox.Show(" You are login");
                    CN = LoginDA.ID();
                    ManagmentPage M = new ManagmentPage();
                    M.Show();

                }
                else
                {
                    MessageBox.Show(" wrong user or pass");
                    textBox1.Clear();
                    textBox2.Clear();

                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                bool res = Managers_logDA.Realize(L);
                if (res)
                {
                    MessageBox.Show(" You are login");
                    CN = LoginDA.ID();


                }
                else
                {
                    MessageBox.Show(" wrong user or pass");
                    textBox1.Clear();
                    textBox2.Clear();

                }
            }
            
        }

        private void management_log_Load(object sender, EventArgs e)
        {

        }
    }
}
