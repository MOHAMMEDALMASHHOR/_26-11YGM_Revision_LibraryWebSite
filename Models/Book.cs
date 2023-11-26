using Revision.Models;

public class Book : LibraryItem
{
    public Book(int id, string? title, Authors author, DateTime publishYear) : base(id, title, author, publishYear)
    {
    }
    public override int CompareTo(LibraryItem? other)
    {
        return this.Title.CompareTo(other.Title);
    }
}