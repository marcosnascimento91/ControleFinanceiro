using ControleFinanceiro.Api.Domain.Entity;
using ControleFinanceiro.Api.Domain.Interface.Repository;
using ControleFinanceiro.Api.InfraStructure.Data.Context;
using ControleFinanceiro.Common.Infrastructure;
using System.Linq;

namespace ControleFinanceiro.Api.Infrastructure.Data.Repository
{
    public class UserRoleRepository : RepositoryBase<UserRole>, IUserRoleRepository
    {

        public UserRoleRepository(ControleFinanceiroContext context) : base(context)
        {

        }

        public UserRole GetById(int id)
        {


            return this.GetAll().SingleOrDefault(_ => _.RoleId == id);
        }
    }
}
