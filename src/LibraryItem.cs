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

public class Book : LibraryItem
{
    public string Title { get; set; }

    public Book(string title, DateTime? createdDate = null) : base(title, createdDate)
    {
        Title = title;
    }
}

public class User : LibraryItem
{
    public User(string name, DateTime? createdDate = null) : base(name, createdDate)
    {
    }
}