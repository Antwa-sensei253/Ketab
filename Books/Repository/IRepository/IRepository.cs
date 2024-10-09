using System.Linq.Expressions;

namespace WebBook.Repository.IRepository
{
    public interface IRepository
    {
        internal interface IRepository<T> where T : class
        {
             IEnumerable<T> GetAll();
            T Get(Expression<Func<T,bool>> filter);
            void Remove(T entity);
            void Add(T entity);
            void RemoveRange(IEnumerable<T> entity);
             
            
        }
    }
}
