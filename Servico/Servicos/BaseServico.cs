using Dominio.Interfaces;
using Dominio.Modelos;
using FluentValidation;
using System;
using System.Collections.Generic;

namespace Servico.Servicos
{
   public class BaseServico<TEntity> : IBaseServico<TEntity> where TEntity : ObjetoBase
   {
       private readonly IBaseRepositorio<TEntity> _baseRepositorio;

       public BaseServico(IBaseRepositorio<TEntity> baseRepositorio)
       {
            _baseRepositorio = baseRepositorio;
       }

       public TEntity Adicionar<TValidator>(TEntity obj) where TValidator : AbstractValidator<TEntity>
       {
           Validate(obj, Activator.CreateInstance<TValidator>());
            _baseRepositorio.Adicionar(obj);
           return obj;
       }

       public void Deletar(int id) => _baseRepositorio.Deletar(id);

       public IList<TEntity> BuscarTodos() => _baseRepositorio.BuscarTodos();

       public TEntity BuscarPorId(int id) => _baseRepositorio.BuscarPorId(id);

       public TEntity Atualizar<TValidator>(TEntity obj) where TValidator : AbstractValidator<TEntity>
       {
           Validate(obj, Activator.CreateInstance<TValidator>());
            _baseRepositorio.Atualizar(obj);
           return obj;
       }

       private void Validate(TEntity obj, AbstractValidator<TEntity> validator)
       {
           if (obj == null)
               throw new Exception("Registros não encontrados!");

           validator.ValidateAndThrow(obj);
       }
   }
}
