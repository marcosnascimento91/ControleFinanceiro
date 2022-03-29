namespace ControleFinanceiro.Api.Domain.Entity
{
    public class UserRole
    {
        public virtual int UserId { get; protected set; }
        public virtual int RoleId { get; protected set; }

        public virtual User User { get; protected set; }
        public virtual Role Role { get; protected set; }
    }
}
