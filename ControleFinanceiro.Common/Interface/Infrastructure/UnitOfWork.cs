using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Common.Interface.Infrastructure
{
    public class UnitOfWork<T> : IUnitOfWork
    {
        private DbContext context;
        private IDbContextTransaction transaction;
        private bool dispoded;

        public UnitOfWork(T context)
        {
            this.context = context as DbContext;
        }

        public void BeginTransaction()
        {
            this.transaction = this.context.Database.BeginTransaction();
            this.dispoded = false;
        }

        public int commit()
        {
            var result = this.context.SaveChanges();
            this.transaction.Commit();
            return result;
        }

        public Task<int> commitAsync()
        {
            var result = this.context.SaveChangesAsync();
            this.transaction.Commit();
            return result;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.context.Dispose();
            }
        }
    }
}
