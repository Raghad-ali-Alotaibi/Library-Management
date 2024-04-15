namespace LibraryManagement;

// Base class for User and Book
public class LibraryItem
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public DateTime CreatedDate { get; set; }

    // Constructor
    public LibraryItem(string name, DateTime? createdDate = null)
    {
        Id = Guid.NewGuid();
        Name = name;
        CreatedDate = createdDate ?? DateTime.Now;
    }
}

// class Library
public class Library
{
    private List<Book> books = new List<Book>();
    private List<User> users = new List<User>();

    public void DeleteUserById(Guid id)
    {
        try
        {
            var userToDelete = users.FirstOrDefault(user => user.Id == id);
            if (userToDelete != null)
            {
                users.Remove(userToDelete);
                Console.WriteLine("User was Deleted");
            }
            else
            {
                Console.WriteLine("User not found in the Library.");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("The Exception: " + e.Message);
        }
    }

    public void DeleteBookById(Guid id)
    {
        try
        {
            var bookToDelete = books.FirstOrDefault(book => book.Id == id);
            if (bookToDelete != null)
            {
                books.Remove(bookToDelete);
                Console.WriteLine("Book was Deleted");
            }
            else
            {
                Console.WriteLine("Book not found in the Library.");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("The Exception: " + e.Message);
        }
    }
}