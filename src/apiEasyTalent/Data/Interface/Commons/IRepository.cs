using System.Collections.Generic;

namespace apiEasyTalent.Data.Interface.Commons
{
    public interface IRepository<T> where T : class
    {
         
        void Insert(T obj);

        void Edit(T obj);

        void Delete(T obj);

        IEnumerable<T> GetAll();

        T GetById(int id);

    }
}