using ControleFinanceiro.Common.Domain;

namespace ControleFinanceiro.Api.Application.Dto
{
    public class RoleDto
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; protected set; }
    }
}
