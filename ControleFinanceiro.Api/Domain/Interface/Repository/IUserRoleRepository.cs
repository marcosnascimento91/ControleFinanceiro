﻿using ControleFinanceiro.Api.Domain.Entity;
using ControleFinanceiro.Common.Interface.Infrastructure;

namespace ControleFinanceiro.Api.Domain.Interface.Repository
{
    public interface IUserRoleRepository : IRepository<UserRole>
    {
        AccessLog GetById(int id);
    }
}
