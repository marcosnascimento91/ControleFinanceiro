using ControleFinanceiro.Common.Domain;

namespace ControleFinanceiro.Api.Domain.Entity
{
    public class Role : EntityBase
    {
        public virtual string Name { get; protected set; }
    }
}
