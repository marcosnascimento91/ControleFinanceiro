using ControleFinanceiro.Api.Domain.Interface.Repository;
using ControleFinanceiro.Api.Infrastructure.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace ControleFinanceiro.Api.Config
{
    public static class ControleFinanceiroContainer
    {
        public static void Config(IServiceCollection services)
        {
            services.AddScoped<IAccessLogRepository, AccessLogRepository>();
            services.AddScoped<IBankRepository, BankRepository>();
            services.AddScoped<ICardPaymentTypeRepository, CardPaymentTypeRepository>();
            services.AddScoped<ICardRepository, CardRepository>();
            services.AddScoped<IExpenseRepository, ExpenseRepository>();
            services.AddScoped<IExpenseTypeRepository, ExpenseTypeRepository>();
            services.AddScoped<IInvoiceExpenseRepository, InvoiceExpenseRepository>();
            services.AddScoped<IInvoiceRepository, InvoiceRepository>();
            services.AddScoped<IPaymentTypeRepository, PaymentTypeRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserRoleRepository, UserRoleRepository>();
        }
    }
}