using System;
using System.Collections.Generic;
using System.Text;
using Dominio.Interfaces;
using Dominio.Modelos;
using FluentValidation;

namespace Servico.Servicos
{
    public class contaServico : IContaServico
    {
        private readonly IRepositoryConta _repositoryConta;

        public contaServico(IRepositoryConta repositoryConta)
        {
            _repositoryConta = repositoryConta;
        }

        public void Adicionar<TValidator>(Conta obj) where TValidator : AbstractValidator<Conta>
        {
              _repositoryConta.Adicionar(obj);
        }

        public void Atualizar<TValidator>(Conta obj) where TValidator : AbstractValidator<Conta>
        {
            _repositoryConta.Atualizar(obj);
        }

        public Conta BuscarPorId(int id)
        {
          return  _repositoryConta.BuscarPorId(id);
        }

        public IList<Conta> BuscarTodos()
        {
            return _repositoryConta.BuscarTodos();
        }

        public void Deletar(int id)
        {
            _repositoryConta.Deletar(id);
        }
    }
}
