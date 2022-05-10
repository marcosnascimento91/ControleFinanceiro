using ControleFinanceiro.Common.Domain;
using System;

namespace ControleFinanceiro.Api.Application.Dto
{
    public class AccessLogDto

    {
        public virtual int Id { get; set; }
        public virtual int UserId { get; set; }
        public virtual string Action { get; set; }
        public DateTime ActionDate { get; set; }
    }
}
