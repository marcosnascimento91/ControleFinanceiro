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

        public T Add(T entity)
        {
            var result = this.dbSet.Add(entity).Entity;
            this.context.SaveChanges(); // salva o digitado

            return result; // retorna o resultado (Return é sempre a última linha)
        }

        public void Remove(T entity)
        {
            this.context.Remove(entity);
            this.context.SaveChanges();
        }

        public IQueryable<T> GetAll()
        {
            return this.dbSet.AsNoTracking();
        }

        public T Update(T entity)
        {
            var entry = this.context.Update(entity); // Aqui é feito o update
            this.dbSet.Attach(entity); // Localiza a entidade na tabela e faz a alteração correta
            entry.State = EntityState.Modified; // Informa ao contexto da alteração

            this.context.SaveChanges();

            return entity;
        }
    }
}