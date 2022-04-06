using ControleFinanceiro.Api.Domain.Entity;
using ControleFinanceiro.Common.Interface.Infrastructure;

namespace ControleFinanceiro.Api.Domain.Interface.Repository
{
    public interface IExpenseRepository : IRepository<Expense>
    {
        AccessLog GetById(int id);
    }
}
