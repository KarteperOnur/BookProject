using DataAccess.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Seeds
{
    public class AuthorGenreSeed
    {
        public static List<AuthorGenre> AuthorGenres = new List<AuthorGenre>() 
        { 
        new AuthorGenre{BookId=1,GenreId=1},
        new AuthorGenre{BookId=2,GenreId=2},
        new AuthorGenre{BookId=1,GenreId=2},

        };
    }
}
