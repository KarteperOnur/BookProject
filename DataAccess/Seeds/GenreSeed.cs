using DataAccess.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Seeds
{
    public class GenreSeed
    {
        public static List<Genre> Genres=new List<Genre>() 
        { 
         new Genre{ID=1,Name="Genre1"},
         new Genre{ID=2,Name="Genre2"},
         new Genre{ID=3,Name="Genre3"}
        };
    }
}
