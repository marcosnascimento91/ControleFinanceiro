using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Common.Interface
{
    public interface IApplicationServiceBase<T> where T : class
    {
        Task<T> Save(T entity);
        Task<T> SavePartial(T entity);
        Task<int> Remove(T entity);
    }
}
