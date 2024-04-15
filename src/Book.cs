namespace LibraryManagement;
public class Book : LibraryItem
{
    public string Title { get; set; }

    public Book(string title, DateTime? createdDate = null) : base(title, createdDate)
    {
        Title = title;
    }
}