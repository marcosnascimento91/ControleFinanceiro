using ControleFinanceiro.Api.Domain.Entity;
using ControleFinanceiro.Api.Domain.Interface.Repository;
using ControleFinanceiro.Api.InfraStructure.Data.Context;
using ControleFinanceiro.Common.Infrastructure;
using System.Linq;

namespace ControleFinanceiro.Api.Infrastructure.Data.Repository
{
    public class InvoiceExpenseRepository : RepositoryBase<InvoiceExpense>, IInvoiceExpenseRepository
    {

        public InvoiceExpenseRepository(ControleFinanceiroContext context) : base(context)
        {

        }

        public InvoiceExpense GetById(int id)
        {


            return this.GetAll().SingleOrDefault(_ => _.InvoiceId == id);
        }
    }
}
