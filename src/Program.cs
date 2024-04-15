namespace LibraryManagement;
internal class Program
{
    private static void Main()
    {
        // Creating Users
        var user1 = new User("Alice", new DateTime(2023, 1, 1));
        var user2 = new User("Bob", new DateTime(2023, 2, 1));
        var user3 = new User("Ian");
        var user4 = new User("Julia");

        // Creating Books
        var book1 = new Book("The Great Gatsby", new DateTime(2023, 1, 1));
        var book2 = new Book("1984", new DateTime(2023, 2, 1));
        var book3 = new Book("The Iliad");
        var book4 = new Book("Anna Karenina");

        var library = new Library();

        // Adding Users
        library.AddUser(user1);
        library.AddUser(user2);
        library.AddUser(user3);
        library.AddUser(user4);

        // print (already exists in the Library)
        library.AddUser(user4);
        // Delete User
        library.DeleteUserById(user1.Id);
        // Print Get All Users
        foreach (var user in library.GetAllUsers())
        {
            Console.WriteLine($"User: {user.Name}, Created Date: {user.CreatedDate}");
        }
        // Find Users By Name
        Console.WriteLine($"{library.FindUsersByName("Julia")}");


        // Adding Books
        library.AddBook(book1);
        library.AddBook(book2);
        library.AddBook(book3);
        library.AddBook(book4);

        // Delete Book 
        library.DeleteBookById(book2.Id);
        // Print Get All Books
        foreach (var book in library.GetAllBooks())
        {
            Console.WriteLine($"Book: {book.Title}, Created Date: {book.CreatedDate}");
        }
        // Find Books By Title
        Console.WriteLine($"{library.FindBooksByTitle("Anna Karenina")}");
    }
}

