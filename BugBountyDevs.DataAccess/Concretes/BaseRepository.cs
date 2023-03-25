using BugBountyDevs.DataAccess.Abstracts;
using BugBountyDevs.DataAccess.Concretes.EF.Contexts;
using BugBountyDevs.Entity.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugBountyDevs.DataAccess.Concretes
{
    public class BaseRepository<T, TContext> : IBaseRepository<T> where T : class, IEntity, new()
        where TContext : BugBountyContext, new()
       
    {
        public void Delete(T Entity)
        {
            using (var context = new TContext())
            {
                var entity = context.Entry(Entity);

                entity.State = EntityState.Deleted;

                context.SaveChanges(); // UnitOfWork Repository Yapısı
            }
        }

        public T Get(Func<T, bool> Filter)
        {
            using (var context = new TContext()) 
            {
                return context.Set<T>().SingleOrDefault(Filter);
            }
        }

        public List<T> GetAll()
        {
            using (var context = new TContext())
            {
                return context.Set<T>().ToList();
            }
        }

        public List<T> GetFilter(Func<T, bool> Filter)
        {
            using (var context = new TContext())
            {
                return context.Set<T>().Where(Filter).ToList();
            }
        }

        public void Insert(T Entity)
        {
            using (var context = new TContext())
            {
                var entity = context.Entry(Entity);

                entity.State = EntityState.Added;

                context.SaveChanges(); // UnitOfWork 
            }

        }

        public void Update(T Entity)
        {
            using (var context = new TContext())
            {
                var entity = context.Entry(Entity);

                entity.State = EntityState.Modified;

                context.SaveChanges(); // UnitOfWork 
            }
        }
    }
}
