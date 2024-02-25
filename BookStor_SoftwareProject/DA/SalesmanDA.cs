using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BookStor_SoftwareProject.Domain;

namespace BookStor_SoftwareProject.DA
{
    class SalesmanDA
    {
        private static database DB = new database();
        public static bool Add(Salesman S)
        {
            DB.Salesmans.Add(S);
            DB.SaveChanges();
            return true;
        }
        public List<Salesman> GetallSalesman()
        {
            return DB.Salesmans.ToList();
        }
    }
}
