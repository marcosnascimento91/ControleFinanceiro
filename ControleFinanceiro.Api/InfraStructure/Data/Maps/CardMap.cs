using ControleFinanceiro.Api.Domain.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace ControleFinanceiro.Api.InfraStructure.Data.Maps
{
    public class CardMap
    {
        public CardMap(EntityTypeBuilder<Card> typeBuilder)
        {
            typeBuilder.ToTable("Card");
            typeBuilder.Property(_ => _.Id).HasColumnName("Id");
            typeBuilder.Property(_ => _.UserId).HasColumnName("UserId");
            typeBuilder.Property(_ => _.BankId).HasColumnName("BankId");
            typeBuilder.Property(_ => _.AmountLimit).HasColumnName("AmountLimit");
            typeBuilder.Property(_ => _.ClosingDay).HasColumnName("ClosingDay");
            typeBuilder.Property(_ => _.DueDay).HasColumnName("DueDay");
            typeBuilder.Property(_ => _.Color).HasColumnName("Color");
            typeBuilder.Property(_ => _.UserCreateId).HasColumnName("UserCreateId");
            typeBuilder.Property(_ => _.UserCreateDate).HasColumnName("UserCreateDate");
            typeBuilder.Property(_ => _.UserAlterId).HasColumnName("UserAlterId");
            typeBuilder.Property(_ => _.UserAlterDate).HasColumnName("UserAlterDate");

            typeBuilder.HasKey(_ => _.Id);

        }
    }
}
