using Microsoft.EntityFrameworkCore;
using CrudApp.Models;

namespace CrudApp.Data 
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

        public DbSet<UserModel> Users { get; set; }

    }
}