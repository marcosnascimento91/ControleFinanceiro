using ControleFinanceiro.Common.Domain;

namespace ControleFinanceiro.Api.Domain.Entity
{
    public class Card
    {
        public virtual int UserId { get; protected set; }
        public virtual int BankId { get; protected set; }
        public virtual decimal? AmountLimit { get; protected set; }
        public virtual int? ClosingDay { get; protected set; }
        public virtual int? DueDay { get; protected set; }
        public virtual string Color { get; protected set; }

        public virtual User User { get; protected set; }
        public virtual Bank Bank { get; protected set; }

    }
}
