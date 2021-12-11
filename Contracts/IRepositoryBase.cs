using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Contracts
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> FindAll();
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
        IQueryable<T> FindByConditionWithPaging(Expression<Func<T, bool>> expression, int pageNumber, int pageSize, out int totalCount);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        void DeleteRange(List<T> entity);
        void AddRange(List<T> entities);
        void UpdateRange(List<T> entities);



    }
}
