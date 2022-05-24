using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Servive.Base
{
    public class BaseService<T> : ICoreService<T> where T : EntityRepository
    {
        
        public string Add(T model)
        {
            throw new NotImplementedException();
        }

        public string Add(List<T> models)
        {
            throw new NotImplementedException();
        }

        public bool Any(Expression<Func<T, bool>> exp)
        {
            throw new NotImplementedException();
        }

        public string Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public T GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<T> GetDefault(Expression<Func<T, bool>> exp)
        {
            throw new NotImplementedException();
        }

        public List<T> GetList()
        {
            throw new NotImplementedException();
        }

        public string RemoveForce(T model)
        {
            throw new NotImplementedException();
        }

        public string Update(T model)
        {
            throw new NotImplementedException();
        }
    }
}
