using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Servive
{
    public interface ICoreService<T> where T : EntityRepository
    {
        string Add(T model);

        string Add(List<T> models);

        T GetById(Guid id);

       List<T> GetList();

       string Delete(Guid id);

        string Update(T model);

        bool Any(Expression<Func<T,bool>>exp);

        List<T> GetDefault(Expression<Func<T,bool>>exp);

        string RemoveForce(T model);



    }
}
