using Revision.Models;

public class LibraryItemsRepository
{
    public List<Book> LibraryItems { get; set; }
    public LibraryItemsRepository()
    {
        LibraryItems = new List<Book>(){
            new Book(1,"Suc ve Ceza",new Authors(){Id =1,FirstName = "Mohammed",LastName="Almashhor"},DateTime.Now),
            new Book(2,"Su Guzel",new Authors(){Id =2,FirstName = "Mohammed",LastName="Almashhor"},DateTime.Now),
            new Book(3,"Ceza Onemli",new Authors(){Id =3,FirstName = "Mohammed",LastName="Almashhor"},DateTime.Now)
        };
    }
    public void CreateABook(Book book){
        book.SetAvaliabilty(true);
        LibraryItems.Add(book);
    }
    public List<Book> GetAllBooks(){
        return LibraryItems;
    }
    public List<Book> GetAvaliableBooks(){
       return LibraryItems.Where(book=>book.IsAvaliable==true).ToList();
    }
    public Book GetOneBook(int id){
        for (int i = 0; i < LibraryItems.Count; i++)
        {
            if (LibraryItems[i].Id==id)
            {
                return LibraryItems[i];
                break;
            }
        }
        throw new Exception($"The Book With The Id: {id} is 404");
    }
    public void DeleteOneBook(int id){
        for (int i = 0; i < LibraryItems.Count; i++)
        {
            if (LibraryItems[i].Id==id)
            {
                 LibraryItems.Remove(LibraryItems[i]);
                
            }
        }
        throw new Exception($"The Book With The Id: {id} is 404");
    }
    public void UpdateOneBook(int id,Book book){
        for (int i = 0; i < LibraryItems.Count; i++)
        {
            if (LibraryItems[i].Id==id)
            {
                 LibraryItems[i]=book;
                
            }
        }
        throw new Exception($"The Book With The Id: {id} is 404");
    }
    public void GiveABook(int id){
        //LibraryItems.Where(book=>book.Id==id)
        for (int i = 0; i < LibraryItems.Count; i++)
        {
            if (LibraryItems[i].Id==id)
            {
                 LibraryItems[i].Borrow();
                
            }
        }
        throw new Exception($"The Book With The Id: {id} is 404");
        
    }
    public void TakeABook(int id){
        //LibraryItems.Where(book=>book.Id==id)
        for (int i = 0; i < LibraryItems.Count; i++)
        {
            if (LibraryItems[i].Id==id)
            {
                 LibraryItems[i].Return();
                
            }
        }
        throw new Exception($"The Book With The Id: {id} is 404");
        
    }

}