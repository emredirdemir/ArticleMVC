using EmreDemir.Core.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using X.PagedList;

namespace EmreDemir.Core.Abstract
{
    public interface IEntityRepository<T> where T:class, IEntity, new()
    {
        void add(T entity);
        void update(T entity);
        void delete(T entity);
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        IPagedList<T> GetCategoryName(Expression<Func<T, bool>> filter = null);

        IPagedList<T> GetWithPage(Expression<Func<T, bool>> filter = null);

        T Get(Expression<Func<T, bool>> filter);
    }
}
