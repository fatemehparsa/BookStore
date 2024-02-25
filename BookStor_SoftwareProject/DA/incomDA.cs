using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStor_SoftwareProject.Domain;

namespace BookStor_SoftwareProject.DA
{
    class incomDA
    {
        private static database DB = new database();
        public void  add_incom(int n)
        {
            BookAD B = new BookAD();
            
            foreach(Book b1 in B.GetallBooks())
            {
                if ( n== b1.ID)
                {
                    DB.Incom_=b1.Price + DB.Incom_;
                }
            }
      

            
        }
        public double incom()
        {
            return DB.Incom_;
        }
    }
}
