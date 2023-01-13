using System.Collections.Generic;
using System.Linq;

namespace BookStore.Models.Repositories
{
    public class AuthorRepository :IBookStoreRepository<Author>
    {
        IList<Author> authors;

        public AuthorRepository()
        {
            authors = new List<Author>()
            {
                new Author()
                {
                    Id= 1,
                    FullName="Mohamed"
                },
                new Author()
                {
                    Id= 2,
                    FullName="Mohamed ahmed"
                },
                new Author()
                {
                    Id= 3,
                    FullName="ali Mohamed"
                },

            };
        }
        public void Add(Author entity)
        {
            authors.Add(entity);
        }

        public void Delete(int id)
        {
            var author = Find(id);

            authors.Remove(author);
        }

        public Author Find(int id)
        {
            var author = authors.SingleOrDefault(e => e.Id == id);
            return author;
        }

        public IList<Author> List()
        {
            return authors;
        }

        public void Update(int id, Author newauthor)
        {
            var author = Find(id);

            author.FullName = newauthor.FullName; 
        }
    }
}
