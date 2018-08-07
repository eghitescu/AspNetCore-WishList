using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace WishList.Data
{
    using Models;

    public class ApplicationDbContext : DbContext
    {

        public DbSet<Item> Items { get; set; }
        public ApplicationDbContext( DbContextOptions options) : base(options)
        {
        }
    }
}
