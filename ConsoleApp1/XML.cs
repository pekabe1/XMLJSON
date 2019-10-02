using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
 internal   class XML :IBookstore
    {
       
     

        public List<Book> GetBookData()
        {
            XDocument xmlBooksDocument = XDocument.Load("Books.xml");
            return
         xmlBooksDocument.
         Element("root").
         Elements().
         Select(x => new Book
         {
             Category = x.Attribute(nameof(Book.Title)).Value,
             Id = int.Parse(x.Attribute(nameof(Book.Id)).Value),
             Status = x.Attribute(nameof(Book.Category)).Value,
             Title = x.Attribute(nameof(Book.Title)).Value
         })
           .ToList();
        }
        
        public List<BookReaders> GetReadersData()
        {
            XDocument xmlReadersDocument = XDocument.Load("BooksReader.xml");
            return
                xmlReadersDocument.
                Element("root").
                Elements().
                Select(x => new BookReaders
                {
                    Email = x.Attribute(nameof(BookReaders.Email)).Value,
                    UserName = x.Attribute(nameof(BookReaders.UserName)).Value,
                    Id = int.Parse(x.Attribute(nameof(BookReaders.Id)).Value),
                })
               .ToList();
        }
            internal List<AnimalUser> getUsers()
        {
            XDocument document = XDocument.Load("XMLFile1.xml");
            return document
                .Element("root")
                .Elements()
                .Select(e => new AnimalUser
                {
                    Id = int.Parse(e.Attribute(nameof(AnimalUser.Id)).Value),
                    Name = e.Attribute(nameof(AnimalUser.Name)).Value,
                    Role = e.Attribute(nameof(AnimalUser.Role)).Value,
                    Password = e.Attribute(nameof(AnimalUser.Password)).Value,
                })              
                .ToList();
        }
    }
}
