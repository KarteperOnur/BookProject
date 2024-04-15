using DataAccess.Models.Entities;
using DataAccess.Seeds;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Configurations
{
    public class AuthorGenreConfiguration : IEntityTypeConfiguration<AuthorGenre>
    {
        public void Configure(EntityTypeBuilder<AuthorGenre> builder)
        {
            builder.HasKey(x => new {x.BookId,x.GenreId});
            builder.HasOne(x=>x.Book)
                .WithMany(x=>x.AuthorGenres)
                .HasForeignKey(x=>x.BookId);
            //seed
            builder.HasData(AuthorGenreSeed.AuthorGenres);
        }
    }
}
