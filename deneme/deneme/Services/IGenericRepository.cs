using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using deneme.Models;
using System.Data.Entity.Infrastructure;
using System.Linq.Expressions;

namespace deneme.Services
{
    public  interface IGenericRepsitory<T>  where T : class
    {
        void Add(T entitiy);
        void Update(T entitiy);
        void Delete(T entitiy);
        IEnumerable<T> GetList();
        IEnumerable<T> GetSourceList(Expression<Func<T,bool>> where=null);
        T GetSingle(Expression<Func<T, bool>> where=null);
    }


   
}
