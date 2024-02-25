using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BookStor_SoftwareProject.Domain;

namespace BookStor_SoftwareProject.DA
{
    class AdministerDA
    {
        private static database DB = new database();
        public static bool Add(Administer A)
        {
            DB.Administers.Add(A);
            DB.SaveChanges();
            return true;
        }
        public List<Administer> GetallAdministers()
        {
            return DB.Administers.ToList();
        }
    }
}
