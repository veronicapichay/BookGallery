using System.Collections.Generic;
using BookGallery.Models;


namespace BookGallery.Services
{
    public interface IData
    {
        List<Book> Books { get; set; }
        List<Book> ReadAll();
        Book GetBook(int? id);


        //CRUD
        void AddBook(Book book);
        void UpdateBook(Book book);
        void DeleteBook(int? id);





    }
}
