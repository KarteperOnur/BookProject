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
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.Property(x=>x.ID).IsRequired(true);
            builder.Property(x=>x.Name).IsRequired(true);
            builder.Property(x=>x.Name).HasMaxLength(255);

            //seed
            builder.HasData(BookSeed.Books);

        }
    }
}
