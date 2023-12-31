﻿using DaireYonetim.Context;
using DaireYonetim.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DaireYonetim.BaseServices
{
    public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private TContext _context;

        public GenericRepository(TContext context)
        {
            _context = context;
        }

        public TContext Context
        {
            get { return _context; }
            set { _context = value; }
        }

        public virtual TEntity Insert(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            return entity;
        }

        public virtual TEntity Update(TEntity entity)
        {
            _context.Entry<TEntity>(entity).State = EntityState.Modified;
            return entity;
        }

        public virtual void Delete(int Id)
        {
            var entity = Find(Id);
            if (entity != null)
            {
                _context.Set<TEntity>().Remove(entity);
            }
        }

        public virtual List<TEntity> GetList()
        {
            var query = _context.Set<TEntity>().OrderByDescending(x => x.ID).ToList();
            return query;
        }

        public virtual List<TEntity> GetList(Expression<Func<TEntity, bool>> _lambda)
        {
            var query = _context.Set<TEntity>().Where(_lambda).OrderByDescending(x => x.ID).ToList();
            return query;
        }

        public virtual IQueryable<TEntity> GetListQuerable()
        {
            return _context.Set<TEntity>().AsQueryable();
        }

        public virtual TEntity Find(int Id)
        {
            return _context.Set<TEntity>().OrderByDescending(x => x.ID).First(x => x.ID == Id);
        }

        public virtual TEntity FirstOrDefault(Expression<Func<TEntity, bool>> _lambda)
        {
            return _context.Set<TEntity>().OrderByDescending(x => x.ID).FirstOrDefault(_lambda);
        }

        public virtual TEntity First(Expression<Func<TEntity, bool>> _lambda)
        {
            return _context.Set<TEntity>().OrderByDescending(x => x.ID).First(_lambda);
        }

        public virtual bool Any(Expression<Func<TEntity, bool>> _lambda)
        {
            return _context.Set<TEntity>().Any(_lambda);
        }

        public virtual int Count(Expression<Func<TEntity, bool>> _lambda)
        {
            return _context.Set<TEntity>().Count(_lambda);
        }
    }
}
