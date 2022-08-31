using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    //Çalışacağımız tablonun verilmesi için 1. param , Northwind ilişkileri için 2.param.
    public class EfEntityRepositoryBase<TEntity,TContext> : IEntityRepository<TEntity>
        where TEntity : class,IEntity,new()
        where TContext:DbContext,new()
    {
        public void Add(TEntity entity)
        {
            //IDispossabe pattern implementation of C# 
            using (TContext context = new TContext())
            {
                //context.Products.Add(entity);   

                var addedEntity = context.Entry(entity); //Kaydedilecek referansa git 
                addedEntity.State = EntityState.Added;  // EKleme işlemi
                context.SaveChanges();                  //Değişiklikleri Kaydetme
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                // context.Products.Remove(context.Products.SingleOrDefault(p=>p.ProductId==entity.ProductId));    
                var deletedEntity = context.Entry(entity); //Kaydedilecek referansa git 
                deletedEntity.State = EntityState.Deleted;  // Silme işlemi
                context.SaveChanges();                  //Değişiklikleri Kaydetme
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();

            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity); //Kaydedilecek referansa git 
                updatedEntity.State = EntityState.Modified;  // Güncelleme işlemi
                context.SaveChanges();                  //Değişiklikleri Kaydetme
            }
        }
    }
}
