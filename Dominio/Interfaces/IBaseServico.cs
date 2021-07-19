using Dominio.Modelos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Interfaces
{
    public interface IBaseServico<TEntidade> where TEntidade : ObjetoBase
    {
        TEntidade Adicionar<TValidator>(TEntidade obj) where TValidator : AbstractValidator<TEntidade>;
        TEntidade Atualizar<TValidator>(TEntidade obj) where TValidator : AbstractValidator<TEntidade>;

        void Deletar(int id);

        IList<TEntidade> BuscarTodos();

        TEntidade BuscarPorId(int id);
    }
}
