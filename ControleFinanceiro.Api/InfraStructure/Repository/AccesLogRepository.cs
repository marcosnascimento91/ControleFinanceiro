using ControleFinanceiro.Api.Domain.Entity;
using ControleFinanceiro.Api.Domain.Interface.Repository;
using ControleFinanceiro.Api.InfraStructure.Data.Context;
using ControleFinanceiro.Common.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ControleFinanceiro.Api.InfraStructure.Repository
{
    public class AccessLogRepository : RepositoryBase<AccessLog>, IAccessLogrepository
    {
        public AccessLogRepository(ControleFinanceiroContext context) : base(context)
        {
        }

        public AccessLog GetById(int id)
        {
            var accesLog = this.GetAll().SingleOrDefault(_ => _.Id == id);

            return accesLog;
        }
    }
}

