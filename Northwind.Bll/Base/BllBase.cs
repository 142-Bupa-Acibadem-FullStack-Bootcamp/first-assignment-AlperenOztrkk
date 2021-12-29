using Northwind.Entity.Base;
using Northwind.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Northwind.Entity.IBase;

namespace Northwind.Bll.Base
{
    public class BllBase<T, TDto> : IGenericService<T, TDto> where T : EntityBase where TDto : DtoBase
    {
        #region Variable
        private readonly IUnitOfWork unitOfWork;
        private readonly  IServiceProvider service;
        private readonly IGenericRepository<T> repository;

        #endregion
        public BllBase(IServiceProvider service)
        {
            unitOfWork = service.GetService<IUnitOfWork>();
            repository = unitOfWork.GetRepository<T>();
            this.service = service;
        }
        public TDto Add(TDto item)
        {
            try
            {
                var TResult = repository.Add(Mapper.Map<T>(item));

                return new Response<TDto>()
                {
                    StatusCode =100,
                    Message="succuses",
                    Data=Mapper.Map<T,TDto>(TResult)
                };
            }
            catch (Exception ex)
            {

               return new Response<TDto>()
               {
                   StatusCode=200,
                   Message=$"Error:{ex.Message}",
                   Data=null
               };
            }
        }

        public Task<TDto> AddAsync(TDto item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(TDto item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(TDto item)
        {
            throw new NotImplementedException();
        }

        public TDto Find(int id)
        {
            throw new NotImplementedException();
        }

        public List<TDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<TDto> GetAll(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetIQueryable()
        {
            throw new NotImplementedException();
        }

        public TDto Update(TDto item)
        {
            throw new NotImplementedException();
        }

        public Task<TDto> UpdateAsync(TDto item)
        {
            throw new NotImplementedException();
        }

        IResponse<TDto> IGenericService<T, TDto>.Add(TDto item)
        {
            throw new NotImplementedException();
        }
    }

    internal interface IGenericRepository<T> where T : EntityBase
    {
        object Add(object p);
    }
}
