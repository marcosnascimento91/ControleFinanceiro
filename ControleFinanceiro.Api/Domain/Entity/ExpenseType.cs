using ControleFinanceiro.Common.Domain;

namespace ControleFinanceiro.Api.Domain.Entity
{
    public class ExpenseType : EntityWithUser
    {
        public virtual string Name { get; protected set; }
        public virtual string Icon { get; protected set; }
        public virtual string Color { get; protected set; }
    }
}
