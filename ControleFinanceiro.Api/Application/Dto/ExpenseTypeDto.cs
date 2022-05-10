using ControleFinanceiro.Common.Domain;

namespace ControleFinanceiro.Api.Application.Dto
{
    public class ExpenseTypeDto
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Icon { get; set; }
        public virtual string Color { get; set; }
    }
}
