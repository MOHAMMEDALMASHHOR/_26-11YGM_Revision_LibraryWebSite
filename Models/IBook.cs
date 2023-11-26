using Revision.Models;

public interface IBook:IComparable<LibraryItem>{
    public int Id { get; set; }
    public string? Title { get; set; }
    public Authors Author { get; set; }
    public DateTime PublishYear { get; set; }
    public bool IsAvaliable { get; set; }
    public void SetAvaliabilty(bool value);

}