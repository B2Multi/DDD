using Dominio.Modelos;
using System.Collections.Generic;

namespace Dominio.Interfaces
{
    public interface IBaseRepositorio<TEntity> where TEntity : class
    {
        void Adicionar(TEntity obj);

        void Atualizar(TEntity obj);

        void Deletar(int id);

        IList<TEntity> BuscarTodos();

        TEntity BuscarPorId(int id);
        void Dispose();
    }
}
