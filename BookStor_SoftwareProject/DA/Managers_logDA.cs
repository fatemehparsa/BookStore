using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BookStor_SoftwareProject.Domain;

namespace BookStor_SoftwareProject.DA
{
    class Managers_logDA
    {
        static int i;
        public static bool Realize(Managers_log L)
        {
            if (L.kind == 0)
            {
                bool R = false;
                AdministerDA A = new AdministerDA();
 
                String P = L.password;
                String U = L.Username;

                foreach (Administer c in A.GetallAdministers())
                {
                    if (c.UserName == U && c.PassWord == P)
                    {
                        R = true;
                        i = c.Id;
                    }

                }
                return R;
            }
            else
            {

                bool R = false;
                SalesmanDA S = new SalesmanDA();
                
                String P = L.password;
                String U = L.Username;
                foreach (Salesman c in S.GetallSalesman())
                {
                    if (c.UserName == U && c.PassWord == P)
                    {
                        R = true;
                        i = c.Id;
                    }

                }
                return R;
            }
            
        }

        public static int ID()
        {
            return i;
        }

    }
}
