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

        
        var emailService = new EmailNotificationService();
        var smsService = new SMSNotificationService();

        var libraryWithEmail = new Library(emailService);
        var libraryWithSMS = new Library(smsService);

        // Adding Users
        libraryWithEmail.AddUser(user1);
        libraryWithEmail.AddUser(user2);
        libraryWithEmail.AddUser(user3);

        libraryWithSMS.AddUser(user4);
        libraryWithSMS.AddUser(user5);
        libraryWithSMS.AddUser(user6);



        // print (already exists in the Library)
        libraryWithSMS.AddUser(user4);
        // Find Users By Name
        Console.WriteLine($"{libraryWithSMS.FindUsersByName("Julia")}");


        // Adding Books
        libraryWithSMS.AddBook(book1);
        libraryWithSMS.AddBook(book2);
        libraryWithSMS.AddBook(book3);
        libraryWithSMS.AddBook(book4);
        libraryWithSMS.AddBook(book5);
        libraryWithSMS.AddBook(book6);


        // Delete Book 
        libraryWithSMS.DeleteBookById(book2.Id);

        // print Get All Books
        int page = 1;
        int pageSize = 3;
        List<Book> books = libraryWithSMS.GetAllBooks(page, pageSize);
        foreach (var book in books)
        {
            Console.WriteLine($"Book: {book.Title}, Created Date: {book.CreatedDate}");
        }

        // Find Books By Title
        Console.WriteLine($"{libraryWithSMS.FindBooksByTitle("Anna Karenina")}");


    }
}