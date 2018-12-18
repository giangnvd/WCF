using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        static IBookRepository repository = new BookRepository();

        public string AddBook(Book book)
        {
            Book newBook = repository.AddNewBook(book);
            return "id=" + newBook.BookId;
           // throw new NotImplementedException();
        }

        public string DeleteBook(string id)
        {
            bool deleted = repository.DeleteBook(int.Parse("1"));
            if (deleted)

                return "Delete success";
            else
                return "Delete False";
            //throw new NotImplementedException();
        }

        public Book GetBookById(string id)
        {
            return repository.GetBookById(int.Parse(id));
           // throw new NotImplementedException();
        }

        public List<Book> GetBookList()
        {
            return repository.GetAllBooks();
            //throw new NotImplementedException();
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        

        public string UpdateBook(Book book)
        {
            bool deleted = repository.updateBook(book);
            if (deleted)
                return "Book with id=" + book.BookId + "Update successFully";
            else
                return "Unable to update book with id=" + book.BookId;
            throw new NotImplementedException();
        }
    }
}
