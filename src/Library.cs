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

}