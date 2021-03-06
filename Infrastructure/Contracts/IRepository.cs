using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Contracts
{
    public interface IRepository
    {
        IQueryable<T> GetItems<T>(Expression<Func<T, bool>> dataFilters);
        IQueryable<T> GetItems<T>();
        void Save<T>(T data, string collectionName = "");
        void Save<T>(List<T> datas);
        T GetItem<T>(Expression<Func<T, bool>> dataFilters);
        void Update<T>(Expression<Func<T, bool>> dataFilters, T data);
        void Delete<T>(Expression<Func<T, bool>> dataFilters);
        void Delete<T>(Expression<Func<T, bool>> dataFilters, string collectionName);
        void UpdateMany<T>(Expression<Func<T, bool>> dataFilters, object data, string collectionName = "");
    }
}
