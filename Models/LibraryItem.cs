using Revision.Models;

public abstract class LibraryItem : IBook
{

    public int Id { get ; set ; }
    public string? Title { get ; set ; }
    public Authors Author { get ; set ; }
    public DateTime PublishYear { get ; set ; }
    public bool IsAvaliable { get ; set ; }
    protected LibraryItem(int id, string? title, Authors author, DateTime publishYear)
    {
        Id = id;
        Title = title;
        Author = author;
        PublishYear = publishYear;
    }

    public virtual int CompareTo(LibraryItem? other)
    {
        return this.PublishYear.CompareTo(other.PublishYear);
    }

    public void SetAvaliabilty(bool value)
    {
        IsAvaliable=value;
    }
    public void Borrow(){
        if (IsAvaliable==true)
        {
            System.Console.WriteLine($"The Book: {ToString()} is Given Suceefully!!!");
            SetAvaliabilty(false);}
        
        else
        {
            System.Console.WriteLine($"The Book: {ToString()} isn't avalible at the moment!!!");
        }
    }
    public void Return(){
        System.Console.WriteLine($"The Book is Returned Suceefully!!!");
        SetAvaliabilty(true);
    }
    public override string ToString()
    {
        return $"{Id}-{Title}-{Author.ToString()}-{PublishYear}";
    }
}
