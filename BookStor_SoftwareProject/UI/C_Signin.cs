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
    public partial class C_Signin : Form
    {
        public C_Signin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex==0)
            {
                Customer C = new Customer();
                C.FirstName = textBox1.Text;
                C.LastName= textBox2.Text;
                C.UserName = textBox3.Text;
                C.PassWord = textBox4.Text;


                bool R = CustomerDA.Add(C);

                if (R == true)
                {
                    MessageBox.Show(" Customer's informations saved successfuly ");
                }
            }
            else if (comboBox1.SelectedIndex==1)
            {
                Administer A = new Administer();
                A.FirstName = textBox1.Text;
                A.LastName = textBox2.Text;
                A.UserName = textBox3.Text;
                A.PassWord = textBox4.Text;


                bool R = AdministerDA.Add(A);

                if (R == true)
                {
                    MessageBox.Show(" Administer's informations saved successfuly ");
                }
            }
            else if (comboBox1.SelectedIndex==2)
            {
                Salesman S = new Salesman();
                S.FirstName = textBox1.Text;
                S.LastName = textBox2.Text;
                S.UserName = textBox3.Text;
                S.PassWord = textBox4.Text;


                bool R = SalesmanDA.Add(S);

                if (R == true)
                {
                    MessageBox.Show(" Salesman's informations saved successfuly ");
                }
            }
            
        }

        private void C_Signin_Load(object sender, EventArgs e)
        {

        }
    }
}
