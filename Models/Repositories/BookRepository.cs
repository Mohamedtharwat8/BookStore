using System.Collections.Generic;
using System.Linq;

namespace BookStore.Models.Repositories
{
    public class BookRepository : IBookStoreRepository<Book>
    {

        IList<Book> books;

        public BookRepository()
        {
            books = new List<Book>()
            {
                new Book()
                {
                    Id= 1,Title="C#",Description="brief of c#"

                },
                new Book() {
                                        Id= 2,Title="python",Description="brief of python"

                },
                new Book() {
                                        Id= 3,Title="Java",Description="brief of ///////////"

                }
            };
        }
        public void Add(Book entity)
        {
            books.Add(entity);
        }

        public void Delete(int id)
        {
            var book = Find(id);
            books.Remove(book);
                
                }

        public Book Find(int id)
        {
            var book = books.SingleOrDefault(e => e.Id == id);
            return book;
        }

        public IList<Book> List()
        {
            return books;        }

        public void Update(int id, Book newBook)
        {
            var book = Find(id);
            
            book.Title = newBook.Title;
            book.Description = newBook.Description;
            book.Author = newBook.Author;   
        }
    }
}
