using BookShopAPI.Models.Entity;
using BookShopAPI.Models.EntityConfigrations;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Context
{
    public class BookShopDbContext:DbContext
    {
        public BookShopDbContext(DbContextOptions<BookShopDbContext> dbOptions):base(dbOptions) 
        {
        
        
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new BooksEntityConfiguration());
            modelBuilder.ApplyConfiguration(new PersonEntityConfiguration());
            modelBuilder.ApplyConfiguration(new PersonTypeEntityConfiguration());
        }
        public virtual DbSet<Books> Books { get; set; }
        public virtual DbSet<PersonType> PersonTypes { get; set; }
        public virtual DbSet<Person> People { get; set; }
        
    }
}
