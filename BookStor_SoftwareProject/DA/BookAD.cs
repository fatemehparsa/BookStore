using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BookStor_SoftwareProject.Domain;

namespace BookStor_SoftwareProject.DA
{
    class BookAD
    {
        private static database DB = new database();
        public static bool Add(Book B)
        {
            DB.Books.Add(B);
            DB.SaveChanges();
            return true;
        }
        public List<Book> GetallBooks()
        {
            return DB.Books.ToList();
        }


    }
}
