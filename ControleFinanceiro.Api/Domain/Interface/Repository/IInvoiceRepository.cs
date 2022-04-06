using ControleFinanceiro.Api.Domain.Entity;
using ControleFinanceiro.Common.Interface.Infrastructure;

namespace ControleFinanceiro.Api.Domain.Interface.Repository
{
    public interface IInvoiceRepository : IRepository<Invoice>
    {
        AccessLog GetById(int id);
    }
}
