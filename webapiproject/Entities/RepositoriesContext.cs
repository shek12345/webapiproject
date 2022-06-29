using Microsoft.EntityFrameworkCore;
using webapiproject.Model;

namespace webapiproject.Entities
{
    
        public class RepositoriesContext : DbContext
        {
            public RepositoriesContext(DbContextOptions options) : base(options) { }

            public DbSet<Product> Products { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Employe> Employes { get; set; }

    }

    }
