using Microsoft.EntityFrameworkCore;

namespace VydavatelstvoRestApi.Model
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<Autor> Autors { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>()
                .HasOne(b => b.Autor)
                .WithMany(a => a.Books);
        }
    }
}
