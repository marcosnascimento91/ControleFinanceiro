using AutoMapper;
using ControleFinanceiro.Api.Application.Dto;
using ControleFinanceiro.Api.Domain.Entity;

namespace ControleFinanceiro.Api.Config
{
    public class ControleFinanceiroProfile : AutoMapper.Profile
    {
        public ControleFinanceiroProfile()
        {
            CreateMap<AccessLogDto, AccessLog>().ReverseMap();
            CreateMap<BankDto, Bank>().ReverseMap();
            CreateMap<CardDto, Card>().ReverseMap();
            CreateMap<CardPaymentTypeDto, CardPaymentType>().ReverseMap();
            CreateMap<ExpenseDto, Expense>().ReverseMap();
            CreateMap<ExpenseTypeDto, ExpenseType>().ReverseMap();
            CreateMap<InvoiceDto, Invoice>().ReverseMap();
            CreateMap<InvoiceExpenseDto, InvoiceExpense>().ReverseMap();
            CreateMap<PaymentTypeDto, PaymentType>().ReverseMap();
            CreateMap<Role, Role>().ReverseMap();
            CreateMap<UserDto, User>().ReverseMap();
            CreateMap<UserRoleDto, UserRole>().ReverseMap();
        }
    }
}
