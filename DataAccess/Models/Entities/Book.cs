using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Entities
{
    public class Book:BaseClass
    {
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public virtual List<AuthorGenre> AuthorGenres { get; set; }
    }
}
