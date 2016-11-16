using System.Data.Entity;

namespace WebApi.Models
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
}