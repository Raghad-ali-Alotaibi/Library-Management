namespace LibraryManagement;

public class Library
{
    private List<User> users = new List<User>();
    private List<Book> books = new List<Book>();
    public INotificationService Notification { get; }

    // Constructor
    public Library(INotificationService notification)
    {
        Notification = notification;
    }

    public List<User> GetAllUsers(int page, int pageSize)
    {
        return users.OrderBy(user => user.CreatedDate).Skip((page - 1) * pageSize).Take(pageSize).ToList();
    }

    public List<Book> GetAllBooks(int page, int pageSize)
    {
        return books.OrderBy(book => book.CreatedDate).Skip((page - 1) * pageSize).Take(pageSize).ToList();
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
                Notification.SendNotificationOnFailure($"'{user.Name}' is already exists");
            }
            users.Add(user);
            Notification.SendNotificationOnSuccess($"User '{user.Name}' was added ");
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
                Notification.SendNotificationOnFailure($"{book.Title}' is already exists");
            }
            books.Add(book);
            Notification.SendNotificationOnSuccess($"book '{book.Title}' was added ");
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