using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Common.Interface
{
    public interface IServiceBase<T>
    {
        Task<T> Save(T entity);
        Task<T> SavePartial(T entity);
        Task<T> Remove(T entity);
    }
}
