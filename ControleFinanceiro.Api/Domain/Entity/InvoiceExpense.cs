namespace ControleFinanceiro.Api.Domain.Entity
{
    public class InvoiceExpense
    {
        public virtual int InvoiceId { get; protected set; }
        public virtual int ExpenseId { get; protected set; }

        public virtual Invoice Invoice { get; protected set; }
        public virtual Expense Expense { get; protected set; }
    }
}
