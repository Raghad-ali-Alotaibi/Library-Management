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
        var user5 = new User("Fiona", new DateTime(2024, 6, 1));
        var user6 = new User("George", new DateTime(2024, 7, 1));

        // Creating Books
        var book1 = new Book("The Great Gatsby", new DateTime(2023, 1, 1));
        var book2 = new Book("1984", new DateTime(2023, 2, 1));
        var book3 = new Book("The Iliad");
        var book4 = new Book("Anna Karenina");
        var book5 = new Book("The Brothers Karamazov", new DateTime(2024, 5, 1));
        var book6 = new Book("Don Quixote", new DateTime(2024, 6, 1));

        var library = new Library();

        // Adding Users
        library.AddUser(user1);
        library.AddUser(user2);
        library.AddUser(user3);
        library.AddUser(user4);
        library.AddUser(user5);
        library.AddUser(user6);



        // print (already exists in the Library)
        library.AddUser(user4);
        // Delete User
        library.DeleteUserById(user1.Id);
        // Find Users By Name
        Console.WriteLine($"{library.FindUsersByName("Julia")}");


        // Adding Books
        library.AddBook(book1);
        library.AddBook(book2);
        library.AddBook(book3);
        library.AddBook(book4);
        library.AddBook(book5);
        library.AddBook(book6);


        // Delete Book 
        library.DeleteBookById(book2.Id);

        // print Get All Books
        int page = 1;
        int pageSize = 3;
        List<Book> books = library.GetAllBooks(page, pageSize);
        foreach (var book in books)
        {
            Console.WriteLine($"Book: {book.Title}, Created Date: {book.CreatedDate}");
        }

        // Find Books By Title
        Console.WriteLine($"{library.FindBooksByTitle("Anna Karenina")}");
    }
}

