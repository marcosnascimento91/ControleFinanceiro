using ControleFinanceiro.Common.Domain;
using System;

namespace ControleFinanceiro.Api.Application.Dto
{
    public class InvoiceDto
    {
        public virtual int Id { get; set; }
        public virtual int CardId { get; set; }
        public virtual DateTime ClosingDate { get; set; }
        public virtual DateTime DueDate { get; set; }
        public virtual DateTime? PaymentDate { get; set; }

    }
}
