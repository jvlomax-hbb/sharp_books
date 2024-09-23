using Microsoft.EntityFrameworkCore;
using sharp_books.Models;

namespace sharp_books.Data;

public class BookContext : DbContext
{
    public BookContext(DbContextOptions<BookContext>  options) : base(options)
    {

    }

    public DbSet<Book> Book => Set<Book>();

}