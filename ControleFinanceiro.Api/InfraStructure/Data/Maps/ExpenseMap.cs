using ControleFinanceiro.Api.Domain.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace ControleFinanceiro.Api.InfraStructure.Data.Maps
{
    public class ExpenseMap
    {
        public ExpenseMap(EntityTypeBuilder<Expense> typeBuilder)
        {
            
            typeBuilder.ToTable("Expense");
            typeBuilder.Property(_ => _.Id).HasColumnName("Id");
            typeBuilder.Property(_ => _.ExpenseTypeId).HasColumnName("ExpenseTypeId");
            typeBuilder.Property(_ => _.PaymentTypeId).HasColumnName("PaymentTypeId");
            typeBuilder.Property(_ => _.Description).HasColumnName("Description").HasColumnType("varchar(250)");
            typeBuilder.Property(_ => _.InstallmentNrCurrent).HasColumnName("InstallmentNrCurrent");
            typeBuilder.Property(_ => _.InstallmentNrFinal).HasColumnName("InstallmentNrFinal");
            typeBuilder.Property(_ => _.Value).HasColumnName("Value");
            typeBuilder.Property(_ => _.PurchaseDate).HasColumnName("PurchaseDate");
            typeBuilder.Property(_ => _.UserCreateId).HasColumnName("UserCreateId");
            typeBuilder.Property(_ => _.UserCreateDate).HasColumnName("UserCreateDate");
            typeBuilder.Property(_ => _.UserAlterId).HasColumnName("UserAlterId");
            typeBuilder.Property(_ => _.UserAlterDate).HasColumnName("UserAlterDate");

            typeBuilder.HasKey(x => x.Id);

        }

    }
}
