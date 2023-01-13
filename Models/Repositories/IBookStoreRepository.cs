using System.Collections.Generic;

namespace BookStore.Models.Repositories
{
    public interface IBookStoreRepository<TEntity>
    {
        IList<TEntity> List();    
        TEntity Find(int id);

        void Add(TEntity entity);
        void Update(int id , TEntity entity);
        void Delete(int id);



    }
}
