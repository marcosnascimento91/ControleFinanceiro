using ControleFinanceiro.Common.Domain;

namespace ControleFinanceiro.Api.Domain.Entity
{
    public class Bank : EntityWithUser
    {
        public virtual string Name { get; protected set; }
        public object UserAterId { get; internal set; }
    }
}
