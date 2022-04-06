using ControleFinanceiro.Common.Interface.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Common.Infrastructure
{
    public class RepositoryBase<T> : IRepository<T> where T : class
    {

        protected DbContext context;
        protected DbSet<T> dbset;

        public RepositoryBase(DbContext context)
        {
            this.context = context;
            this.dbset = this.context.Set<T>();
        }

        public IQueryable<T> GetAll()
        {
            return this.dbset;
        }

        public T GetById(int id)
        {
            return this.dbset.AsNoTracking();
        }
    }
}
