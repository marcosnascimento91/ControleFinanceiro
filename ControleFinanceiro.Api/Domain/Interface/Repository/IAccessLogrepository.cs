using ControleFinanceiro.Api.Domain.Entity;
using ControleFinanceiro.Common.Interface.Infrastructure;

namespace ControleFinanceiro.Api.Domain.Interface.Repository
{
    public interface IAccessLogrepository : IRepository<AccessLog>
    {
        AccessLog GetById(int id);
    }
}
