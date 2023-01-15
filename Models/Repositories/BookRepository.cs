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
                    Id= 1,Title="C#",
                    Description="brief of c#",
                    ImageUrl="1.jpg",
                   Author = new    Author{Id=2}

                },
                new Book() {
                     Id= 2,Title="python",
                    Description="brief of python",
                    ImageUrl="2.jpg",
                    Author = new    Author{Id=3}

                },
                new Book() {
                      Id= 3,Title="Java",
                    Description="brief of ///////////",
                    ImageUrl="3.jpg",
                    Author = new    Author{Id=1}

                }
            };
        }
        public void Add(Book entity)
        {
            entity.Id = books.Max(b => b.Id) + 1;
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
            return books;
        }

        public void Update(int id, Book newBook)
        {
            var book = Find(id);

            book.Title = newBook.Title;
            book.Description = newBook.Description;
            book.Author = newBook.Author;
            book.ImageUrl = newBook.ImageUrl;
        }
    }
}
