using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Common.Interface
{
    public interface IUnitOfWork
    {
        void BeginTransaction();
        int commit();
        Task<int> commitAsync();
    }
}
