using ControleFinanceiro.Api.Domain.Entity;
using ControleFinanceiro.Common.Interface.Infrastructure;

namespace ControleFinanceiro.Api.Domain.Interface.Repository
{
    public interface IPaymentTypeRepository : IRepository<PaymentType>
    {
        PaymentType GetById(int id);
    }
}
