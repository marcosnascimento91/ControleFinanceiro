using ControleFinanceiro.Common.Interface.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Common.Infrastructure
{
    public abstract class RepositoryBase<T> : IRepository<T> where T : class
    {
        protected DbContext context;
        protected DbSet<T> dbSet;

        public RepositoryBase(DbContext context)
        {
            this.context = context;
            this.dbSet = this.context.Set<T>();
        }

        public IQueryable<T> GetAll()
        {
            return this.dbSet.AsNoTracking();
        }
    }
}