using Core;
using Core.Service;
using DAL.Context;
using DAL.Tools;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service.Base
{
    public class BaseService<T> : ICoreService<T> where T : EntityRepository
    {
        EcommerceContext context = DbTools.Context;

        public string Add(T model)
        {

            try
            {
                model.ID = Guid.NewGuid();
                context.Set<T>().Add(model);
                context.SaveChanges();
                return "veri eklendi!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Add(List<T> models)
        {
            context.Set<T>().AddRange(models);
            return "Eklenen modeller listelendi";
        }

        public bool Any(Expression<Func<T, bool>> exp)
        {
            return context.Set<T>().Any(exp);
        }

        public string Delete(Guid id)
        {
            try
            {
                T deleted = GetById(id);
                deleted.Status = Core.Enum.Status.Deleted;
                Update(deleted);
                return "veri silindi";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }

        }

        public T GetById(Guid id)
        {
            return context.Set<T>().Find(id);
        }

        public List<T> GetDefault(Expression<Func<T, bool>> exp)
        {
            return context.Set<T>().Where(exp).ToList();
        }

        public List<T> GetList()
        {
            return context.Set<T>().ToList();
        }

        public string RemoveForce(T model)
        {
            try
            {
                context.Set<T>().Remove(model);
                return "veri kalıcı olarak silindi!";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string Update(T model)
        {

            try
            {
                T updated = GetById(model.ID);
                //context.Entry(model).State = System.Data.Entity.EntityState.Modified;

                DbEntityEntry entity = context.Entry(updated);
                entity.CurrentValues.SetValues(model);

                context.SaveChanges();
                return $"{model.ID} nolu veri güncellendi";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public T Find(int id)
        {
            return context .Set<T>().Find(id);
        }
    }
       
    
}
