using ClaimsIdentity_zad_6.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ClaimsIdentity_zad_6.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public class PeopleContext : DbContext
        {
            public PeopleContext(DbContextOptions options) : base(options) { }

            public DbSet<Person> Person { get; set; }
        }
        public DbSet<ClaimsIdentity_zad_6.Models.Person> Person { get; set; }

    }
}