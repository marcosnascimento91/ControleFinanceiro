using ControleFinanceiro.Common.Domain;

namespace ControleFinanceiro.Api.Application.Dto
{
    public class CardDto 
    {
        public virtual int Id { get; set; }
        public virtual int UserId { get; set; }
        public virtual int BankId { get; set; }
        public virtual decimal? AmountLimit { get; set; }
        public virtual int? ClosingDay { get; set; }
        public virtual int? DueDay { get; set; }
        public virtual string Color { get; set; }

    }
}
