using Dominio.Modelos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Interfaces
{
    public interface IBaseServico<TEntity> where TEntity :class
    {
        void Adicionar<TValidator>(TEntity obj) where TValidator : AbstractValidator<TEntity>;
        void Atualizar<TValidator>(TEntity obj) where TValidator : AbstractValidator<TEntity>;

        void Deletar(int id);

        IList<TEntity> BuscarTodos();

        TEntity BuscarPorId(int id);
    }
}
