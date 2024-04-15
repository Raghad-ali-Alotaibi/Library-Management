namespace LibraryManagement;
public class User : LibraryItem
{
    public User(string name, DateTime? createdDate = null) : base(name, createdDate)
    {
    }
}