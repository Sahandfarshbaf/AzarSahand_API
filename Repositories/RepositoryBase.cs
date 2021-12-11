using Contracts;
using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected shahghassemi_SahandAzarContext RepositoryContext { get; set; }

        public RepositoryBase(shahghassemi_SahandAzarContext repositoryContext)
        {
            this.RepositoryContext = repositoryContext;
        }

        public IQueryable<T> FindAll()
        {
            return this.RepositoryContext.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this.RepositoryContext.Set<T>().Where(expression).AsNoTracking();
        }

        public IQueryable<T> FindByConditionWithPaging(Expression<Func<T, bool>> expression, int pageNumber, int pageSize, out int totalCount)
        {
            totalCount = this.RepositoryContext.Set<T>().Where(expression).AsNoTracking().Count();
            return this.RepositoryContext.Set<T>().Where(expression).Skip((pageNumber - 1) * pageSize).Take(pageSize).AsNoTracking();
        }

        public void Create(T entity)
        {
            this.RepositoryContext.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {

            this.RepositoryContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            this.RepositoryContext.Set<T>().Remove(entity);
        }

        public void DeleteRange(List<T> entity)
        {
            this.RepositoryContext.Set<T>().RemoveRange(entity);
        }

        public virtual void AddRange(List<T> entities)
        {
            this.RepositoryContext.Set<T>().AddRange(entities);
        }

        public virtual void UpdateRange(List<T> entities)
        {
            this.RepositoryContext.Set<T>().UpdateRange(entities);
        }


    }
}