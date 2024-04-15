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
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.Property(x=>x.ID).IsRequired(true);
            builder.Property(x=>x.Name).IsRequired(true);


            //seed Data
            builder.HasData(AuthorSeed.Authors);

        }
    }
}
