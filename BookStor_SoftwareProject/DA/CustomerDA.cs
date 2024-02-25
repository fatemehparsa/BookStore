using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BookStor_SoftwareProject.Domain;

namespace BookStor_SoftwareProject.DA
{
    class CustomerDA
    {
        private static database DB = new database();
        public static bool Add(Customer C)
        {
            DB.Customers.Add(C);
            DB.SaveChanges();
            return true;
        }
        public List<Customer> Getallcustomers()
        {
            return DB.Customers.ToList();
        }
    }
}
