using ControleFinanceiro.Common.Domain;

namespace ControleFinanceiro.Api.Domain.Entity
{
    public class User : EntityBase
    {
        public virtual string Name { get; protected set; }
        public virtual string Email { get; protected set; }
        public virtual string Login { get; protected set; }
        public virtual string Password { get; protected set; }
        public virtual bool FirstAcces { get; protected set; }
    }
}
