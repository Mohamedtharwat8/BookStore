﻿using System.Collections.Generic;
using System.Linq;

namespace BookStore.Models.Repositories
{
    public class BookDbRepository : IBookStoreRepository<Book>
    {

        BookStoreDbContext db;

        public BookDbRepository(BookStoreDbContext _db)
        {
            db = _db;
        }
        public void Add(Book entity)
        {

            db.Books.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var book = Find(id);
            db.Books.Remove(book);
            db.SaveChanges();

        }

        public Book Find(int id)
        {
            var book = db.Books.SingleOrDefault(e => e.Id == id);
            return book;
        }

        public IList<Book> List()
        {
            return db.Books.ToList();
        }

        public void Update(int id, Book newBook)
        {
            db.Update(newBook);
            db.SaveChanges();
        }
    }
}
