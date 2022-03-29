using System;

namespace ControleFinanceiro.Common.Domain
{
    public class EntityWithUser
    {
        public virtual int Id { get; protected set; }
        public virtual int UserCreateId { get; protected set; }
        public virtual DateTime UserCreateDate { get; protected set; }
        public virtual int? UserAlterId { get; protected set; }
        public virtual DateTime? UserAlterDate { get; protected set; }
    }
}
