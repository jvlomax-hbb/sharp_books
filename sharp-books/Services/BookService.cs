using sharp_books.Models;
namespace sharp_books.Services;

public static class BookService {

    static List<Book> Books {get;}
    static BookService()
    {
        Books = new List<Book>
        {
            new Book{Title = "green eggs and ham", Isbn = 1234, Author = "Dr. Seuss"}
            
        }; 
    }

    
    public static List<Book> GetAll() => Books;
    public static Book? Get(int id) => Books.FirstOrDefault(p => p.Id == id);
    public static void Add(Book book){
        // Add book to db
    }

    
}