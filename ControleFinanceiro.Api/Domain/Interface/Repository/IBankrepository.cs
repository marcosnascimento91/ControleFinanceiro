using ControleFinanceiro.Api.Domain.Entity;
using ControleFinanceiro.Common.Interface.Infrastructure;

namespace ControleFinanceiro.Api.Domain.Interface.Repository
{
    public interface IBankRepository : IRepository<Bank>
    {
        AccessLog GetById(int id);
    }
}
