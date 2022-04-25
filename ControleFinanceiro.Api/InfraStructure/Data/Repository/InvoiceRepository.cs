using ControleFinanceiro.Api.Domain.Entity;
using ControleFinanceiro.Api.Domain.Interface.Repository;
using ControleFinanceiro.Api.InfraStructure.Data.Context;
using ControleFinanceiro.Common.Infrastructure;
using System.Linq;

namespace ControleFinanceiro.Api.Infrastructure.Data.Repository
{
    public class InvoiceRepository : RepositoryBase<Invoice>, IInvoiceRepository
    {

        public InvoiceRepository(ControleFinanceiroContext context) : base(context)
        {

        }

        public Invoice GetById(int id)
        {


            return this.GetAll().SingleOrDefault(_ => _.Id == id);
        }
    }
}
