using ControleFinanceiro.Api.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleFinanceiro.Api.InfraStructure.Data.Maps
{
    public class InvoiceExpenseMap
    {
        public InvoiceExpenseMap(EntityTypeBuilder<InvoiceExpense> typeBuilder)
        {
            typeBuilder.ToTable("Invoice");
            typeBuilder.Property(_ => _.InvoiceId).HasColumnName("InvoiceId");
            typeBuilder.Property(_ => _.ExpenseId).HasColumnName("ExpenseId");
          
            typeBuilder.HasKey(_ => new { _.InvoiceId, _.ExpenseId });
        }
    }
}
