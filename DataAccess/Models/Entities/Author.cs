using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Entities
{
    public class Author:BaseClass
    {
        public virtual List<Book> Books { get; set; }
    }
}
