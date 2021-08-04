using Dominio.Interfaces;
using Dominio.Modelos;
using Infra.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repositorio
{
    public class ContaRepositorio : BaseRepositorio<Conta>, IRepositoryConta
    {
        private readonly BancoContext _context;

        public ContaRepositorio(BancoContext db) : base(db)
        {
            _context = db;
        }
    }
}
