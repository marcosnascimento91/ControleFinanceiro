using ControleFinanceiro.Common.Domain;

namespace ControleFinanceiro.Api.Domain.Entity
{
    public class PaymentType : EntityWithUser
    {
        public virtual string Name { get; protected set; }
    }
}
