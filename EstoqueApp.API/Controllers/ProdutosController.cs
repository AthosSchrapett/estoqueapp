using EstoqueApp.Application.Models.Commands;
using EstoqueApp.Application.Models.Queries;
using Microsoft.AspNetCore.Mvc;

namespace EstoqueApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ProdutoQuery), 201)]
        public IActionResult Post(ProdutoCreateCommand command)
        {
            return Ok();
        }

        [HttpPut]
        [ProducesResponseType(typeof(ProdutoQuery), 200)]
        public IActionResult Put(ProdutoUpdateCommand command)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(ProdutoQuery), 200)]
        public IActionResult Delete(Guid? id)
        {
            var command = new ProdutoDeleteCommand { Id = id };
            return Ok();
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<ProdutoQuery>), 200)]
        public IActionResult GetAll()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ProdutoQuery), 200)]
        public IActionResult GetById(Guid? id)
        {
            return Ok();
        }
    }
}