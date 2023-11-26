using Microsoft.AspNetCore.Mvc;

namespace Revision.Controllers;
[ApiController]
[Route("api/LibraryItems")]
public class LibraryItemController:ControllerBase
{
    private readonly LibraryItemsRepository libraryItemsRepository;

    public LibraryItemController(LibraryItemsRepository libraryItemsRepository)
    {
        this.libraryItemsRepository = libraryItemsRepository;
    }
    [HttpGet]
    public IActionResult GetAllTheBook(){
        var result = libraryItemsRepository.GetAllBooks();
        return result ==null?NotFound("404"):Ok(result);
    }
    [HttpGet("{id:int}")]
    public IActionResult GetOneBook(int id){
        var result = libraryItemsRepository.GetOneBook(id);
        return result ==null?NotFound("404"):Ok(result);
    }
    [HttpPost]
    public void Add(Book book){
        libraryItemsRepository.CreateABook(book);
    }
    [HttpPut("{id:int}")]
    public void Update(int id,Book book){
        libraryItemsRepository.UpdateOneBook(id,book);
    }
    [HttpDelete]
    public void DeleteOneBook(int id){
        libraryItemsRepository.DeleteOneBook(id);
    }
}