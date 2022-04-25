using ControleFinanceiro.Api.Domain.Entity;
using ControleFinanceiro.Api.Domain.Interface.Repository;
using ControleFinanceiro.Api.InfraStructure.Data.Context;
using ControleFinanceiro.Common.Infrastructure;
using System.Linq;

namespace ControleFinanceiro.Api.Infrastructure.Data.Repository
{
    public class PaymentTypeRepository : RepositoryBase<PaymentType>, IPaymentTypeRepository
    {

        public PaymentTypeRepository(ControleFinanceiroContext context) : base(context)
        {

        }

        public PaymentType GetById(int id)
        {


            return this.GetAll().SingleOrDefault(_ => _.Id == id);
        }
    }
}
