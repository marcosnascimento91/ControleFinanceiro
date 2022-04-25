using ControleFinanceiro.Api.Domain.Entity;
using ControleFinanceiro.Api.Domain.Interface.Repository;
using ControleFinanceiro.Api.InfraStructure.Data.Context;
using ControleFinanceiro.Common.Infrastructure;
using System.Linq;

namespace ControleFinanceiro.Api.Infrastructure.Data.Repository
{
    public class BankRepository : RepositoryBase<Bank>, IBankRepository
    {
        public BankRepository(ControleFinanceiroContext context) : base(context)
        {
        }

        public Bank GetById(int id)
        {
            return this.GetAll().SingleOrDefault(_ => _.Id == id);
        }
    }
}