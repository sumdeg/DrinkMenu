using DrinkMenu.DataAccess.Abstract;
using DrinkMenu.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DrinkMenu.DataAccess.Concrete.EntityFramework
{
    public class EfRepositoryBase<Tentity, Tcontext> : IEntityRepository<Tentity>
         where Tentity : class, IEntity, new()
         where Tcontext : DbContext, new()
    {
        public Tentity Get(int id)
        {
            using (var context = new Tcontext())
            {
                return context.Set<Tentity>().Find(id);
            }
        }
        public List<Tentity> GetAll()
        {
            using (var context = new Tcontext())
            {

              return context.Set<Tentity>().ToList();
                    
            }
        }
        public void Add(Tentity entity)
        {
            using (var context = new Tcontext())
            {
                context.Entry(entity).State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public void Delete(Tentity entity)
        {
            using (var context = new Tcontext())
            {
                context.Entry(entity).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
       
        public void Update(Tentity entity)
        {
            using (var context = new Tcontext())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();

            }
        }
    }
}
