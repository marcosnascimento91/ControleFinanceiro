using ControleFinanceiro.Common.Domain;
using System;

namespace ControleFinanceiro.Api.Application.Dto
{
    public class ExpenseDto
    {
        public virtual int Id { get; set; }
        public virtual int ExpenseTypeId { get; set; }
        public virtual int PaymentTypeId { get; set; }
        public virtual string Description { get; set; }
        public virtual int InstallmentNrCurrent { get; set; }
        public virtual int InstallmentNrFinal { get; set; }
        public virtual decimal Value { get; set; }
        public virtual DateTime PurchaseDate { get; set; }

    }
}
