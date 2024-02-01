using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using BookShopAPI.Models.Entity;

namespace BookShopAPI.Models.EntityConfigrations
{
    public class BooksEntityConfiguration : IEntityTypeConfiguration<Books>
    {
        public void Configure(EntityTypeBuilder<Books> builder)
        {

        }
    }
}
