using ControleFinanceiro.Common.Domain;

namespace ControleFinanceiro.Api.Application.Dto
{
    public class BankDto
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public object UserAterId { get; set; }
    }
}
