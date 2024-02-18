using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using H_BakhshayeshModels.Context;
using H_BakhshayeshModels.Models;

namespace H_BakhshayeshRepository.GenericRepository
{
    public class GenericRepository<T> : IGenericRepository<T> where T:BaseEntity
    {
        HbakhshayeshContext db;
        DbSet<T> dbSet;

        public GenericRepository(HbakhshayeshContext context)
        {
            db = context;
            dbSet = db.Set<T>();

        }

        public List<T> GetAll()
        {
            return dbSet.ToList();
        }

        public T GetEntity(Guid id)
        {
            return dbSet.Find(id);
        }

        public bool Add(T entity)
        {
            try
            {
                dbSet.Add(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(T entity)
        {
            try
            {
                dbSet.Entry(entity).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(T entity)
        {
            try
            {
                dbSet.Entry(entity).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(Guid id)
        {
            try
            {
                T entity = GetEntity(id);
                dbSet.Entry(entity).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }

    }
}
