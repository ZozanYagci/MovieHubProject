using Microsoft.EntityFrameworkCore;
using MovieHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieHub.Persistence.Context
{
    public class MovieContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\MSSQLSERVER1;Initial Catalog=MovieHub;Integrated Security=true;TrustServerCertificate=True");
        }

        public DbSet<Cast> Casts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Tag> Tags { get; set; }

    }
}
