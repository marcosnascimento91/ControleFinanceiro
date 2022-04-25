using System.Collections.Generic;
using System.Linq;

namespace ControleFinanceiro.Common.Interface.Infrastructure
{
    public interface IRepository<T>
    {
        IQueryable<T> GetAll();
    }
}
