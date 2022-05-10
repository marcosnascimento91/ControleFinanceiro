using ControleFinanceiro.Common.Domain;

namespace ControleFinanceiro.Api.Application.Dto
{
    public class UserDto
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Email { get; set; }
        public virtual string Login { get; set; }
        public virtual string Password { get; set; }
        public virtual bool FirstAcces { get; set; }
    }
}
