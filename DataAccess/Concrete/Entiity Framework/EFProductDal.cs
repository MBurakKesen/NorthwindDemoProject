
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{

    public class EfProductDal : EFRespositoryBase<Product,NorthwindContext>,IProductDal
    {
        public void Add(Product entity)
        {
            using (NorthwindContext context =new NorthwindContext())
            {
                var added = context.Entry(entity);
                added.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext context =new NorthwindContext())
            {
                var deleted = context.Entry(entity);
                deleted.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthwindContext context =new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
                context.SaveChanges();
               
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context=new NorthwindContext())
            {
                return filter == null ? context.Set<Product>().ToList():context.Set<Product>().Where(filter).ToList();
                context.SaveChanges();
            }
        }

    

        public void Update(Product entity)
        {
            using (NorthwindContext context =new NorthwindContext())
            {
                var updated = context.Entry(entity);
                updated.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
