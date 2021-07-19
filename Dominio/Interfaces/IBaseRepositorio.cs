using Dominio.Modelos;
using System.Collections.Generic;

namespace Dominio.Interfaces
{
    public interface IBaseRepositorio<TEntidade> where TEntidade : ObjetoBase
    {
        void Adicionar(TEntidade obj);

        void Atualizar(TEntidade obj);

        void Deletar(int id);

        IList<TEntidade> BuscarTodos();

        TEntidade BuscarPorId(int id);
    }
}
