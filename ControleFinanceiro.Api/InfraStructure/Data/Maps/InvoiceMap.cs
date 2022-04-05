using ControleFinanceiro.Api.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleFinanceiro.Api.InfraStructure.Data.Maps
{
    public class InvoiceMap
    {
        public InvoiceMap(EntityTypeBuilder<Invoice> typeBuilder)
        {
            typeBuilder.ToTable("Invoice");
            typeBuilder.Property(_ => _.Id).HasColumnName("Id");
            typeBuilder.Property(_ => _.CardId).HasColumnName("CardId");
            typeBuilder.Property(_ => _.ClosingDate).HasColumnName("ClosingDate");
            typeBuilder.Property(_ => _.DueDate).HasColumnName("DueDate");
            typeBuilder.Property(_ => _.PaymentDate).HasColumnName("PaymentDate");
            typeBuilder.Property(_ => _.UserCreateId).HasColumnName("UserCreateId");
            typeBuilder.Property(_ => _.UserCreateDate).HasColumnName("UserCreateDate");
            typeBuilder.Property(_ => _.UserAlterId).HasColumnName("UserAlterId");
            typeBuilder.Property(_ => _.UserAlterDate).HasColumnName("UserAlterDate");

            typeBuilder.HasKey(_ => _.Id);

        }
    }
}
