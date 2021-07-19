using Dominio.Interfaces;
using Dominio.Modelos;
using Infra.Contexto;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Infra.Repositorio
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : ObjetoBase
    {
        protected readonly BancoContext Db;
        protected readonly DbSet<TEntity> DbSet;

        public BaseRepositorio(BancoContext db)
        {
            Db = db;
            DbSet = db.Set<TEntity>();
        }

        public void Adicionar(TEntity obj)
        {
            Db.Set<TEntity>().Add(obj);
            Db.SaveChanges();
        }

        public void Atualizar(TEntity obj)
        {
            Db.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Db.SaveChanges();
        }

        public void Deletar(int id)
        {
            Db.Set<TEntity>().Remove(BuscarPorId(id));
            Db.SaveChanges();
        }

        public IList<TEntity> BuscarTodos() =>
            Db.Set<TEntity>().ToList();

        public TEntity BuscarPorId(int id) =>
            Db.Set<TEntity>().Find(id);

    }
}
