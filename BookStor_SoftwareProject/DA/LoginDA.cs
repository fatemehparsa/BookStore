using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStor_SoftwareProject.Domain;
using System.Data.Entity;

namespace BookStor_SoftwareProject.DA
{
    class LoginDA
    {

        static int i;
       
        public static bool Realize(Login L)
        {
            List<Customer> CL = new List<Customer>();

            bool R = false;
            CustomerDA C = new CustomerDA();
            CL = C.Getallcustomers();
            String P = L.password;
            String U = L.username;
            foreach (Customer c in CL)
            {
                if (c.UserName == U && c.PassWord == P)
                {
                    R = true;
                    i = c.Id;
                }

            }
            return R;
        }

        public static int ID()
        {
            return i;
        }


    }
}
