using BugBountyDevs.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugBountyDevs.DataAccess.Abstracts
{
    public interface IBaseRepository<T> where T : class, IEntity, new()  //class => referans tipli değişkenlerin en komplike hali class'tır,  new() => Somut bir class gelicek, nesne alınabilecek.
    {

        List<T> GetAll();

        List<T> GetFilter(Func<T, bool> Filter);

        T Get(Func<T, bool> Filter);   // İlk bulduğunu getirecek

        void Insert(T Entity);

        void Update(T Entity);

        void Delete(T Entity);
        
    }
}



