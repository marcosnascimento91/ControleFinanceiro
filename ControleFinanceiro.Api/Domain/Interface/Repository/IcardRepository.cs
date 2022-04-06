using ControleFinanceiro.Api.Domain.Entity;
using ControleFinanceiro.Common.Interface.Infrastructure;

namespace ControleFinanceiro.Api.Domain.Interface.Repository
{
    public interface IcardRepository : IRepository<Card>
    {
        AccessLog GetById(int id);
    }
}
