using ControleFinanceiro.Common.Domain;
using System;

namespace ControleFinanceiro.Api.Domain.Entity
{
    public class Expense : EntityWithUser
    {
        public virtual int ExpenseTypeId { get; protected set; }
        public virtual int PaymentTypeId { get; protected set; }
        public virtual string Description { get; protected set; }
        public virtual int InstallmentNrCurrent { get; protected set; }
        public virtual int InstallmentNrFinal { get; protected set; }
        public virtual decimal Value { get; protected set; }
        public virtual DateTime PurchaseDate { get; protected set; }

        public virtual ExpenseType ExpenseType { get; protected set; }
        public virtual PaymentType PaymentType { get; protected set; }
    }
}
