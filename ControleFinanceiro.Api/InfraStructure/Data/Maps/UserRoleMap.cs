using ControleFinanceiro.Api.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleFinanceiro.Api.InfraStructure.Data.Maps
{
    public class UserRoleMap
    {
        public UserRoleMap(EntityTypeBuilder<UserRole> typeBuilder)
        {
            typeBuilder.ToTable("UserRole");
            typeBuilder.Property(_ => _.UserId).HasColumnName("Id");
            typeBuilder.Property(_ => _.RoleId).HasColumnName("Name").HasColumnName("varchar(250)");


            typeBuilder.HasKey(_ => new { _.UserId, _.RoleId });
        }
    }
}
