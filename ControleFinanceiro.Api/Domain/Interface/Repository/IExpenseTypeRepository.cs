using ControleFinanceiro.Api.Domain.Entity;
using ControleFinanceiro.Common.Interface.Infrastructure;

namespace ControleFinanceiro.Api.Domain.Interface.Repository
{
    public interface IExpenseTypeRepository : IRepository<ExpenseType>
    {
        AccessLog GetById(int id);
    }
}