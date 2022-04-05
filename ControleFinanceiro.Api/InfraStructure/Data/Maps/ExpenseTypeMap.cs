using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ControleFinanceiro.Api.Domain.Entity;

namespace ControleFinanceiro.Api.InfraStructure.Data.Maps
{
    public class ExpenseTypeMap
    {
        public ExpenseTypeMap(EntityTypeBuilder<ExpenseType> typeBuilder)
        {
            typeBuilder.ToTable("ExpenseType");
            typeBuilder.Property(_=>_.Id).HasColumnName("Id");
            typeBuilder.Property(_=>_.Name).HasColumnName("Name").HasColumnType("varchar(250)");
            typeBuilder.Property(_=>_.Icon).HasColumnName("IdIcon").HasColumnType("varchar(250)");
            typeBuilder.Property(_=>_.Color).HasColumnName("Color").HasColumnType("varchar(250)");
            typeBuilder.Property(_=>_.UserCreateId).HasColumnName("UserCreateId");
            typeBuilder.Property(_=>_.UserCreateDate).HasColumnName("UserCreateDate");
            typeBuilder.Property(_=>_.UserAlterId).HasColumnName("UserAlterId");
            typeBuilder.Property(_=>_.UserAlterDate).HasColumnName("UserAlterDate");

            typeBuilder.HasKey(_ => _.Id);

        }
    }
}
