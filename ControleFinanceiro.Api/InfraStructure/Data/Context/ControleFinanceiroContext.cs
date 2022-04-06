using ControleFinanceiro.Api.Domain.Entity;
using ControleFinanceiro.Api.InfraStructure.Data.Maps;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ControleFinanceiro.Api.InfraStructure.Data.Context
{
    public class ControleFinanceiroContext : DbContext
    {
        protected ControleFinanceiroContext(DbContextOptions<ControleFinanceiroContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
         
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new AccessLogMap(modelBuilder.Entity<Maps.AccessLog>());
            new BankMap(modelBuilder.Entity<Bank>());
            new CardMap(modelBuilder.Entity<Card>());
            new CardPaymentTypeMap(modelBuilder.Entity<CardPaymentType>());
            new ExpenseMap(modelBuilder.Entity<Expense>());
            new ExpenseTypeMap(modelBuilder.Entity<ExpenseType>());
            new InvoiceExpenseMap(modelBuilder.Entity<InvoiceExpense>());
            new InvoiceMap(modelBuilder.Entity<Invoice>());
            new RoleMap(modelBuilder.Entity<Role>());
            new UserMap(modelBuilder.Entity<User>());
            new UserRoleMap(modelBuilder.Entity<UserRole>());

            base.OnModelCreating(modelBuilder);

        }

    }
}
