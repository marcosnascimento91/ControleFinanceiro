using ControleFinanceiro.Api.Domain.Entity;
using ControleFinanceiro.Api.Domain.Interface.Repository;
using ControleFinanceiro.Api.InfraStructure.Data.Context;
using ControleFinanceiro.Common.Infrastructure;
using System.Linq;

namespace ControleFinanceiro.Api.Infrastructure.Data.Repository
{
    public class CardPaymentTypeRepository : RepositoryBase<CardPaymentType>, ICardPaymentTypeRepository
    {
        public CardPaymentTypeRepository(ControleFinanceiroContext context) : base(context)
        {
        }

        public CardPaymentType GetById(int id)
        {
            return this.GetAll().SingleOrDefault(_ => _.CardId == id);
        }
    }
}