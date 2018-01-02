using Microsoft.EntityFrameworkCore;
using NOD.Bubbles.Ui.Core.Domain;

namespace NOD.bubbles.ui.Infrastructure.DAL
{
    public class BubblesContext : DbContext
    {
        public BubblesContext(DbContextOptions<BubblesContext> options)
            : base(options)
        {
        }

        public DbSet<Bubble> Bubbles { get; set; }

        public DbSet<Person> Persons { get; set; }
    }
}
