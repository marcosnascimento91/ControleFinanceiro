using ControleFinanceiro.Api.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleFinanceiro.Api.InfraStructure.Data.Maps
{
    public class PaymentTypeMap
    {
        public PaymentTypeMap(EntityTypeBuilder<PaymentType> typeBuilder)
        {
            typeBuilder.ToTable("Invoice");
            typeBuilder.Property(_ => _.Id).HasColumnName("Id");
            typeBuilder.Property(_ => _.Name).HasColumnName("Name").HasColumnName("varchar(250)");
            typeBuilder.Property(_ => _.UserCreateId).HasColumnName("UserCreateId");
            typeBuilder.Property(_ => _.UserCreateDate).HasColumnName("UserCreateDate");
            typeBuilder.Property(_ => _.UserAlterId).HasColumnName("UserAlterId");
            typeBuilder.Property(_ => _.UserAlterDate).HasColumnName("UserAlterDate");
            typeBuilder.Property(_ => _.UserCreateDate).HasColumnName("UserCreateDate");

            typeBuilder.HasKey(_ => _.Id);
        }
    }
}
