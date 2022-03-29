namespace ControleFinanceiro.Api.Domain.Entity
{
    public class CardPaymentType
    {
        public int CardId { get; protected set; }
        public int PaymentTypeId { get; protected set; }

        public virtual Card Card { get; protected set; }
        public virtual PaymentType PaymentType { get; protected set; }
    }
}
