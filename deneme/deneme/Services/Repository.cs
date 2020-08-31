using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using deneme.Models;
using System.Data.Entity.Core.Objects;
using System.Windows;
using System.Linq.Expressions;
using Expression = System.Linq.Expressions.Expression;

namespace deneme.Services
{ 
    public class IRepository<T> : IGenericRepsitory<T> where T : class
    {
        
        IObjectContextAdapter _contex;
        IObjectSet<T> _objectSet;

        public IRepository() {
            _contex = new FBEntities();
            _objectSet = _contex.ObjectContext.CreateObjectSet<T>();
        }
        public void Add(T entitiy) {
            _objectSet.AddObject(entitiy);
            _contex.ObjectContext.SaveChanges();
        }
        public void Update(T entitiy) {
            _objectSet.Attach(entitiy);
            _contex.ObjectContext.SaveChanges();
        }
        public void Delete(T entitiy) {
            _objectSet.DeleteObject(entitiy);
            _contex.ObjectContext.SaveChanges();
        }
        public IEnumerable<T> GetList()
        {
            return _objectSet.ToList();
        }
        public IEnumerable<T> GetSourceList(Expression<Func<T,bool>> where=null) {
            if (where!=null)
            {
                return _objectSet.Where(where).ToList(); 
            }
            else
            {
                return _objectSet;
            }
        }
        public T GetSingle(Expression<Func<T,bool>> where=null) {

            //return _objectSet.Where(where).Select(where);
            if (where!=null)
            {
                return _objectSet.Single(where);/*_objectSet.Where(where) */
            }
            else
            {
                return null;
            }
        }
    }
}
