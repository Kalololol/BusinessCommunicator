﻿using BusinessCommunicator.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace BusinessCommunicator.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : EntityBase
    {
        private readonly ApplicationDbContext _context;
        private DbSet<TEntity> entities;

        public Repository(ApplicationDbContext context)
        {
            this._context = context;
            this.entities = context.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            entities.Add(entity);
        }
        public void Delete(TEntity entity)
        {
            entities.Remove(entity);
        }
        public IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        { 
            return entities.Where(predicate); 
        }
        public IQueryable<TEntity> GetAll() 
        { 
            return entities.Where(x => !x.Active); 
        }
        public TEntity GetById(int id) 
        { 
            return entities.SingleOrDefault(e => e.Id == id); 
        }
        public void Update(TEntity entity)
        {
            entities.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }

    }
}
