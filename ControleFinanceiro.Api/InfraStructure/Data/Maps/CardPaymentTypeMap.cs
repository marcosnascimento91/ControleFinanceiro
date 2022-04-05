using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ControleFinanceiro.Api.Domain.Entity;

namespace ControleFinanceiro.Api.InfraStructure.Data.Maps
{
    public class CardPaymentTypeMap
    {
        public CardPaymentTypeMap(EntityTypeBuilder<CardPaymentType> typeBuilder)
        {
            typeBuilder.ToTable("CardPayment");
            typeBuilder.Property(_ => _.CardId).HasColumnName("CardId");
            typeBuilder.Property(_ => _.PaymentTypeId).HasColumnName("PaymentTypeId");

            typeBuilder.HasKey(_ => new { _.CardId, _.PaymentTypeId});

        }

    }
}
