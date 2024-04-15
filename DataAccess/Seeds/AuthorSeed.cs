using DataAccess.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Seeds
{
    public class AuthorSeed
    {
        public static List<Author> Authors= new List<Author>() 
        { 
         new Author{ID=1,Name="Author1"},
         new Author{ID=2,Name="Author2"},
         new Author{ID=3,Name="Author3"}
        };

    }
}