using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStor_SoftwareProject.Domain
{
    class Book
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string ExistentNumber { get; set; }
        public double Price { get; set; }
    }
}
