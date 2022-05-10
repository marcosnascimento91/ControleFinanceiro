using ControleFinanceiro.Common.Domain;

namespace ControleFinanceiro.Api.Application.Dto
{
    public class PaymentTypeDto
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
    }
}
