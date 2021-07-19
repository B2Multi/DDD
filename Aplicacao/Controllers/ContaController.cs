using Dominio.Interfaces;
using Dominio.Modelos;
using Microsoft.AspNetCore.Mvc;
using Servico.Validacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicacao.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContaController : ControllerBase
    {
        private IBaseServico<Conta> _baseContaServico;

        public ContaController(IBaseServico<Conta> baseContaServico)
        {
            _baseContaServico = baseContaServico;
        }

        [HttpPost]
        public IActionResult Adicionar([FromBody] Conta conta)
        {
            if (conta == null)
                return NotFound();

            return Execute(() => _baseContaServico.Adicionar<ContaValidator>(conta).Id);
        }

        [HttpPut]
        public IActionResult Atualizar([FromBody] Conta conta)
        {
            if (conta == null)
                return NotFound();

            return Execute(() => _baseContaServico.Atualizar<ContaValidator>(conta));
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            if (id == 0)
                return NotFound();

            Execute(() =>
            {
                _baseContaServico.Deletar(id);
                return true;
            });

            return new NoContentResult();
        }

        [HttpGet]
        public IActionResult BuscarTodos()
        {
            return Execute(() => _baseContaServico.BuscarTodos());
        }

        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            if (id == 0)
                return NotFound();

            return Execute(() => _baseContaServico.BuscarPorId(id));
        }

        private IActionResult Execute(Func<object> func)
        {
            try
            {
                var result = func();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
