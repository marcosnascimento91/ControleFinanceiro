using ControleFinanceiro.Common.Domain;
using System;

namespace ControleFinanceiro.Api.Domain.Entity
{
    public class Invoice : EntityWithUser
    {
        public virtual int CardId { get; protected set; }
        public virtual DateTime ClosingDate { get; protected set; }
        public virtual DateTime DueDate { get; protected set; }
        public virtual DateTime? PaymentDate { get; protected set; }

        public virtual Card Card { get; protected set; }
    }
}
