using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStor_SoftwareProject.Domain;
using System.Data.Entity;

namespace BookStor_SoftwareProject.DA
{
    class database:DbContext
    {
        public  database()
            {

            this.Configuration.ProxyCreationEnabled = true;
            this.Configuration.LazyLoadingEnabled = true;
            }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Administer> Administers { get; set; }
        public DbSet<Salesman> Salesmans { get; set; }
        public DbSet<Book> Books { get; set; }
        public double Incom_ { get; set; }

    }
}
