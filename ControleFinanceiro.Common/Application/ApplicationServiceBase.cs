using AutoMapper;
using ControleFinanceiro.Common.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Common.Application
{
    public class ApplicationServiceBase<T, TD>
        where T : class
        where TD : class
    {
        private IMapper mapper;
        private IUnitOfWork uow;
        private IServiceBase<T> service;

        public ApplicationServiceBase(IMapper mapper, IUnitOfWork uow, IServiceBase<T> service)
        {
            this.mapper = mapper;
            this.uow = uow;
            this.service = service;
        }

        public void BeginTransaction()
        {
            this.uow.BeginTransaction();
        }

        public void CommitAsync()
        {
            return this.uow.Commit();
        }

        public async Task<TD> Save(TD entity)
        {
            this.BeginTransaction();
            var model = this.MapperDtoToDomain(entity);
            var result = await this.service.Save(model);

            await this.CommitAsync();
            return this.MapperDtoToDomain(result);
        }
        public async Task<T> SavePartial(TD entity)
        {
            var model = this.MapperDtoToDomain(entity);
            this.BeginTransaction();

            //Inserir Codigo

            this.CommitAsync();
        }
        public async Task<int> Remove(TD entity)
        {
            var model = this.MapperDtoToDomain(entity);
            this.BeginTransaction();

            //Inserir Codigo

            this.CommitAsync();
        }

        private T MapperDtoToDomain(TD entity)
        {
            return this.mapper.Map<TD, T>(entity);
        }



    }
}
