using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BookStor_SoftwareProject.Domain;

namespace BookStor_SoftwareProject.DA
{
    class SearchDA
    {
        public List<Book> search(Search S)
        {
            BookAD BDA = new BookAD();
            List<Book> showB = new List<Book>();

            foreach (Book b in BDA.GetallBooks())
            {
                if (S.Name== b.Author && S.Author== b.Name)
                {
                    showB.Add(b);
                }
            }
            return showB;

        }
    }
}
