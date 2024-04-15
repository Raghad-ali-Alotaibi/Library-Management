namespace LibraryManagement;

public class Library
{
    private List<User> users = new List<User>();
    private List<Book> books = new List<Book>();

    public List<User> GetAllUsers()
    {
        return users.OrderBy(u => u.CreatedDate).ToList();
    }

    public List<Book> GetAllBooks()
    {
        return books.OrderBy(b => b.CreatedDate).ToList();
    }


    public User FindUsersByName(string name)
    {
        User userFind = users.FirstOrDefault(user => user.Name == name)!;
        return userFind;
    }

    public Book FindBooksByTitle(string title)
    {
        Book bookFind = books.FirstOrDefault(book => book.Title == title)!;
        return bookFind;
    }
    

    public void AddUser(User user)
    {
        try
        {
            bool isIdExist = users.Any(newId => newId.Id == user.Id);
            if (isIdExist)
            {
                throw new Exception($"'{user.Name}' is already exists in the Library.");
            }
            users.Add(user);
            Console.WriteLine("User was added successfully");
        }
        catch (Exception e)
        {
            Console.WriteLine("The Exception: " + e.Message);
        }
    }

    public void AddBook(Book book)
    {
        try
        {
            bool isIdExist = books.Any(newId => newId.Id == book.Id);
            if (isIdExist)
            {
                throw new Exception($"'{book.Title}' is already exists in the Library.");
            }
            books.Add(book);
            Console.WriteLine("User was added successfully");
        }
        catch (Exception e)
        {
            Console.WriteLine("The Exception: " + e.Message);
        }
    }


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