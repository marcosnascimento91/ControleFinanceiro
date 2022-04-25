using ControleFinanceiro.Api.Domain.Entity;
using ControleFinanceiro.Api.Domain.Interface.Repository;
using ControleFinanceiro.Api.InfraStructure.Data.Context;
using ControleFinanceiro.Common.Infrastructure;
using System.Linq;

namespace ControleFinanceiro.Api.Infrastructure.Data.Repository
{
    public class RoleRepository : RepositoryBase<Role>, IRoleRepository
    {

        public RoleRepository(ControleFinanceiroContext context) : base(context)
        {

        }

        public Role GetById(int id)
        {


            return this.GetAll().SingleOrDefault(_ => _.Id == id);
        }
    }
}
