﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Entities
{
    public class Genre:BaseClass
    {
        public virtual List<AuthorGenre> AuthorGenres { get; set; }
    }
}
