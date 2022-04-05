using ControleFinanceiro.Api.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleFinanceiro.Api.InfraStructure.Data.Maps
{
    public class UserMap
    {
        public UserMap(EntityTypeBuilder<User> typeBuilder)
        {
            typeBuilder.ToTable("User");
            typeBuilder.Property(_ => _.Id).HasColumnName("Id");
            typeBuilder.Property(_ => _.Name).HasColumnName("Name").HasColumnName("varchar(250)");
            typeBuilder.Property(_ => _.Email).HasColumnName("Email").HasColumnName("varchar(250)");
            typeBuilder.Property(_ => _.Login).HasColumnName("Login").HasColumnName("varchar(250)");
            typeBuilder.Property(_ => _.Password).HasColumnName("Password").HasColumnName("varchar(250)");
            typeBuilder.Property(_ => _.FirstAcces).HasColumnName("FirstAcces");

            typeBuilder.HasKey(_ => _.Id);
        }
    }
}
