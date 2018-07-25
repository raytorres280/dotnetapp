using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace dotnetapp.ServiceInterface
{
    public interface IRepository<TEntitiy> where TEntitiy : class
    {
        TEntitiy Get()
        IEnumerable<TEntitiy> GetAll();
        IEnumerable<TEntitiy> Find(Expression<Func<TEntitiy, bool>> predicate)

        void Add(TEntitiy entity);
        void AddRange(IEnumerable<TEntitiy> entities);

        void Remove(TEntitiy entity);
        void RemoveRange(IEnumerable<TEntitiy> entities);
    }

    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected IDbConnection db;

        public Repository(IDbConnection db)
        {
            this.db = db;
        }

        public IEnumerable<TEntity> GetAll()
        { 
            return db.Select<TEntity>();
        }

        public IEnumerable<TEntity> Find(Expression<Func<T, bool>> exp)
        {
            return db.Select<TEntity>(exp);
        }

        public TEntity GetById(string id)
        {
            var o = db.SingleById<TEntity>(id);
            return o;
        }

        //public virtual T GetById(string id)
        //{
        //    var o = db.SingleById<TEntity>(id);
        //    return o;
        //}

        //public bool Save(T o)
        //{
        //    db.Save<T>(o);
        //    return true;
        //}

        //public void Delete(int id)
        //{
        //    db.DeleteById<T>(id);
        //}

        //public void Delete(Expression<Func<T, bool>> exp)
        //{
        //    db.Delete<T>(exp);
        //}
    }
}
