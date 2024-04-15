using DataAccess.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Seeds
{
    public class BookSeed
    {
        public static List<Book> Books = new List<Book>()
        {
            new Book{ID=1,Name="Book1",AuthorId=1,},
            new Book{ID=2,Name="Book2",AuthorId=2,},
            new Book{ID=3,Name="Book3",AuthorId=3,}
        };
    }
}
