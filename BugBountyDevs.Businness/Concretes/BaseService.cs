using BugBountyDevs.Businness.Abstracts;
using BugBountyDevs.DataAccess.Abstracts;
using BugBountyDevs.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugBountyDevs.Businness.Concretes
{
    public class BaseService<T> : IBaseService<T> where T : class, IEntity, new()
    {
        private IBaseRepository<T> _baseRepository;
        public BaseService(IBaseRepository<T> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public void Delete(T Entity)
        {
            _baseRepository.Delete(Entity);
        }

        public T Get(Func<T, bool> Filter)
        {
            return _baseRepository.Get(Filter);
        }

        public List<T> GetAll()
        {
            return _baseRepository.GetAll();
        }

        public List<T> GetFilter(Func<T, bool> Filter)
        {
            return _baseRepository.GetFilter(Filter);
        }

        public void Insert(T Entity)
        {
            _baseRepository.Insert(Entity);
        }

        public void Update(T Entity)
        {
            _baseRepository.Update(Entity);
        }
    }
}
