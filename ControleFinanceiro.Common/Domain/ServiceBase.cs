using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Common.Domain
{
    public class ServiceBase<T>
    {
        public ServiceBase()
        {

        }
    public async Task<T> Save(T entity)
        {
            throw new NotImplementedException();
        }
     public async Task<T> SavePartial(T entity)
        {
            throw new NotImplementedException();
        }
     public async Task<T> Remove(T entity)
        {
            throw new NotImplementedException();
        }
}
}
