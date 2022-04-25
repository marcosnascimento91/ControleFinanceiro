using ControleFinanceiro.Api.Domain.Entity;
using ControleFinanceiro.Common.Interface.Infrastructure;

namespace ControleFinanceiro.Api.Domain.Interface.Repository
{
    public interface IInvoiceExpenseRepository : IRepository<InvoiceExpense>
    {
        InvoiceExpense GetById(int id);
    }
}
