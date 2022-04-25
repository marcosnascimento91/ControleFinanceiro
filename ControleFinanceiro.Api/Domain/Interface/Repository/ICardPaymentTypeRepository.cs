using ControleFinanceiro.Api.Domain.Entity;
using ControleFinanceiro.Common.Interface.Infrastructure;

namespace ControleFinanceiro.Api.Domain.Interface.Repository
{
    public interface ICardPaymentTypeRepository : IRepository<CardPaymentType>
    {
        CardPaymentType GetById(int id);
    }
}